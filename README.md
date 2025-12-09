# TechWorkshop L300: GitHub - Innovate with GitHub

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![GitHub Pages](https://img.shields.io/badge/docs-GitHub%20Pages-blue)](https://microsoft.github.io/TechWorkshop-L300-GitHub-Copilot-and-platform/)

This comprehensive hands-on workshop guides you through a series of practical exercises for modernizing business applications using GitHub Enterprise, GitHub Advanced Security, and GitHub Copilot features. Based on a real-world scenario of Zava's storefront application development, you'll gain practical experience in governance, automation, security, AI integration, and observability while migrating to Azure.

## 📚 Table of Contents

- [Overview](#overview)
- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
- [Workshop Exercises](#workshop-exercises)
- [Technology Stack](#technology-stack)
- [Repository Structure](#repository-structure)
- [Documentation](#documentation)
- [Contributing](#contributing)
- [Support](#support)
- [License](#license)
- [Trademarks](#trademarks)

## Overview

Learn to leverage GitHub's powerful platform and AI-driven development practices through a customer proof of concept. Zava, a retail chain specializing in "do-it-yourself" home improvement solutions, needs to establish best practices for DevOps setup and AI-assisted development and delivery.

**What You'll Learn:**
- Setting up and configuring GitHub Enterprise for your organization
- Implementing infrastructure as code with Azure MCP and Bicep using Copilot
- Building automated CI/CD pipelines with GitHub Actions
- Securing development with GitHub Advanced Security (Dependabot, Secret Protection, Code Security)
- Boosting developer productivity with GitHub Copilot for code refactoring and AI chatbot development
- Monitoring and governing AI model usage with Azure services
- Deploying applications to Azure

**Estimated Duration:** 4-6 hours for complete workshop

## Prerequisites

To participate in this workshop, you'll need:

- **Azure Account**: An Azure subscription with access to Microsoft Foundry
- **GitHub Account**: A GitHub account with the ability to enable GitHub Enterprise
- **Development Environment**: 
  - Desktop, laptop, or virtual machine
  - Administrative privileges to install software
  - Internet connection

**Required Software** (detailed setup instructions in Exercise 01):
- Visual Studio Code
- Docker Desktop
- .NET 6 SDK
- Git

**Required VS Code Extensions:**
- GitHub Copilot
- GitHub Copilot Chat
- GitHub Copilot for Azure
- GitHub MCP Server
- Azure MCP Server
- Bicep
- Docker

## Getting Started

### Quick Start

1. **Fork this repository** to your GitHub account
2. **Clone your fork** locally:
   ```bash
   git clone https://github.com/YOUR-USERNAME/TechWorkshop-L300-GitHub-Copilot-and-platform.git
   cd TechWorkshop-L300-GitHub-Copilot-and-platform
   ```
3. **Follow the workshop documentation** at [GitHub Pages](https://microsoft.github.io/TechWorkshop-L300-GitHub-Copilot-and-platform/)
4. **Start with Exercise 01** to set up your development environment

### Running the Sample Application

The repository includes a sample ASP.NET Core MVC storefront application (Zava Storefront):

```bash
cd src
dotnet run
```

Then navigate to `https://localhost:5001` in your browser.

See [src/README.md](src/README.md) for detailed application documentation.

## Workshop Exercises

This workshop consists of 7 comprehensive exercises:

| Exercise | Title | Duration | Key Topics |
|----------|-------|----------|------------|
| 01 | [Development Environment Setup](docs/01_development_environment_setup/01_development_environment_setup.md) | 45 min | GitHub Enterprise, VS Code Extensions, Docker |
| 02 | [Implement Infrastructure with Copilot](docs/02_implement_infrastructure_with_copilot/02_implement_infrastructure_with_copilot.md) | 60 min | Azure MCP Server, Bicep, Infrastructure as Code |
| 03 | [GitHub Actions Pipeline](docs/03_github_actions_pipeline/) | 60 min | CI/CD, Automated Deployment, GitHub Actions |
| 04 | [GitHub Advanced Security](docs/04_github_advanced_security/) | 45 min | Dependabot, Secret Scanning, Code Security |
| 05 | [GitHub Copilot for Productivity](docs/05_integrate_github_copilot_for_developer_productivity/) | 60 min | Code Refactoring, AI Chatbot Development |
| 06 | [AI Governance and Observability](docs/06_ai_governance_and_model_observability/) | 45 min | Azure Monitor, Application Insights |
| 07 | [Resource Cleanup](docs/07_resource_cleanup/) | 15 min | Azure Resource Management |

**Total Estimated Time:** 4-6 hours

## Technology Stack

This workshop leverages the following technologies:

**Development & Version Control:**
- GitHub Enterprise
- GitHub Copilot
- GitHub Advanced Security
- GitHub Actions
- Git

**Cloud Platform:**
- Microsoft Azure
- Azure App Service
- Azure Container Registry
- Microsoft Foundry

**Application Stack:**
- .NET 6
- ASP.NET Core MVC
- Bootstrap 5

**DevOps & Tools:**
- Docker
- Bicep (Infrastructure as Code)
- Azure MCP Server
- GitHub MCP Server
- Visual Studio Code

## Repository Structure

```
TechWorkshop-L300-GitHub-Copilot-and-platform/
├── docs/                          # Workshop documentation and exercises
│   ├── 01_development_environment_setup/
│   ├── 02_implement_infrastructure_with_copilot/
│   ├── 03_github_actions_pipeline/
│   ├── 04_github_advanced_security/
│   ├── 05_integrate_github_copilot_for_developer_productivity/
│   ├── 06_ai_governance_and_model_observability/
│   └── 07_resource_cleanup/
├── src/                           # Sample ASP.NET Core MVC application
│   ├── Controllers/
│   ├── Models/
│   ├── Services/
│   ├── Views/
│   └── README.md                  # Application documentation
├── media/                         # Images and screenshots for documentation
├── index.md                       # GitHub Pages home page
├── _config.yml                    # Jekyll configuration
├── LICENSE                        # MIT License
├── SECURITY.md                    # Security policy and reporting
├── SUPPORT.md                     # Support information
└── README.md                      # This file
```

## Documentation

Comprehensive workshop documentation is available as GitHub Pages:

🔗 **[View Full Workshop Documentation](https://microsoft.github.io/TechWorkshop-L300-GitHub-Copilot-and-platform/)**

The documentation includes:
- Step-by-step exercise instructions
- Screenshots and visual guides
- Code samples and examples
- Troubleshooting tips
- Additional resources and references

## Contributing

This project welcomes contributions and suggestions.  Most contributions require you to agree to a
Contributor License Agreement (CLA) declaring that you have the right to, and actually do, grant us
the rights to use your contribution. For details, visit https://cla.opensource.microsoft.com.

When you submit a pull request, a CLA bot will automatically determine whether you need to provide
a CLA and decorate the PR appropriately (e.g., status check, comment). Simply follow the instructions
provided by the bot. You will only need to do this once across all repos using our CLA.

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or
contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.

## Support

For help and questions about using this workshop, please refer to the [SUPPORT.md](SUPPORT.md) file or create a GitHub Issue.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Trademarks

This project may contain trademarks or logos for projects, products, or services. Authorized use of Microsoft 
trademarks or logos is subject to and must follow 
[Microsoft's Trademark & Brand Guidelines](https://www.microsoft.com/legal/intellectualproperty/trademarks/usage/general).
Use of Microsoft trademarks or logos in modified versions of this project must not cause confusion or imply Microsoft sponsorship.
Any use of third-party trademarks or logos are subject to those third-party's policies.
