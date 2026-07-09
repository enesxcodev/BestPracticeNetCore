BestPractice
│
├── src
│   │
│   ├── BestPractice.API
│   │   ├── Controllers
│   │   ├── Middlewares
│   │   ├── Extensions
│   │   ├── Filters
│   │   ├── Program.cs
│   │   └── appsettings.json
│   │
│   ├── BestPractice.Application
│   │   ├── Common
│   │   │   ├── Result
│   │   │   ├── Interfaces
│   │   │   ├── Exceptions
│   │   │   ├── Behaviors
│   │   │   └── Mapping
│   │   │
│   │   └── Features
│   │
│   ├── BestPractice.Domain
│   │   ├── Common
│   │   ├── Entities
│   │   ├── ValueObjects
│   │   └── Events
│   │
│   ├── BestPractice.Persistence
│   │   ├── Context
│   │   ├── Repositories
│   │   ├── Configurations
│   │   ├── Migrations
│   │   └── DependencyInjection.cs
│   │
│   └── BestPractice.Infrastructure
│       ├── Authentication
│       ├── Email
│       ├── Cache
│       └── DependencyInjection.cs
│
└── tests