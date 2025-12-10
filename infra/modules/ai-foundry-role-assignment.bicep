@description('Name of the AI Foundry account')
param aiFoundryAccountName string

@description('Principal ID to assign the Cognitive Services OpenAI User role')
param principalId string

// Cognitive Services OpenAI User role definition ID
var cognitiveServicesOpenAIUserRoleDefinitionId = subscriptionResourceId('Microsoft.Authorization/roleDefinitions', '5e0bd9bd-7b93-4f28-af87-19fc36ad61bd')

resource aiFoundryAccount 'Microsoft.CognitiveServices/accounts@2024-04-01-preview' existing = {
  name: aiFoundryAccountName
}

resource aiFoundryRoleAssignment 'Microsoft.Authorization/roleAssignments@2022-04-01' = {
  name: guid(aiFoundryAccount.id, principalId, cognitiveServicesOpenAIUserRoleDefinitionId)
  scope: aiFoundryAccount
  properties: {
    principalId: principalId
    roleDefinitionId: cognitiveServicesOpenAIUserRoleDefinitionId
    principalType: 'ServicePrincipal'
  }
}
