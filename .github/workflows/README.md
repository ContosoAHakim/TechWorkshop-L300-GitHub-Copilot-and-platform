# GitHub Actions Deployment Setup

This workflow uses **OIDC (OpenID Connect)** for secure, secretless authentication to Azure.

## Step 1: Create Federated Credential

### Create App Registration (if not exists)

```bash
az ad app create --display-name "github-actions-oidc"
```

Note the `appId` from the output.

### Create Service Principal

```bash
az ad sp create --id {app-id}
```

### Add Federated Credential

```bash
az ad app federated-credential create --id {app-id} --parameters '{
  "name": "github-actions-dev",
  "issuer": "https://token.actions.githubusercontent.com",
  "subject": "repo:ContosoAHakim/TechWorkshop-L300-GitHub-Copilot-and-platform:ref:refs/heads/dev",
  "audiences": ["api://AzureADTokenExchange"]
}'
```

### Assign Roles

```bash
# Contributor on resource group
az role assignment create --assignee {app-id} --role Contributor --scope /subscriptions/f146eaa1-f5cb-45fe-9fb3-98e79595aecb/resourceGroups/rg-dev

# AcrPush for container registry
az role assignment create --assignee {app-id} --role AcrPush --scope /subscriptions/f146eaa1-f5cb-45fe-9fb3-98e79595aecb/resourceGroups/rg-dev/providers/Microsoft.ContainerRegistry/registries/crxbpvytnzezeiq
```

## Step 2: Configure GitHub Variables

Configure these in **Settings > Secrets and variables > Actions > Variables**:

| Variable | Value |
|----------|-------|
| `AZURE_CLIENT_ID` | App registration client ID |
| `AZURE_TENANT_ID` | `b05ecba5-4093-4f8e-991c-3596a0ba03a3` |
| `AZURE_SUBSCRIPTION_ID` | `f146eaa1-f5cb-45fe-9fb3-98e79595aecb` |
| `AZURE_WEBAPP_NAME` | `app-xbpvytnzezeiq` |
| `ACR_LOGIN_SERVER` | `crxbpvytnzezeiq.azurecr.io` |
| `ACR_NAME` | `crxbpvytnzezeiq` |

### Get Values

```bash
azd env get-values
```

**No secrets required!** OIDC uses short-lived tokens issued by GitHub.
