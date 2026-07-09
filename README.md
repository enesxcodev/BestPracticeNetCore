# 🚀 BestPractice

A collection of **ASP.NET Core**, **Entity Framework Core**, and **.NET** best practices built with production-ready examples.

The purpose of this repository is not to provide a complete application, but to serve as a reference project that demonstrates clean, maintainable, and scalable approaches used in real-world software development.

Every implementation in this repository aims to answer two questions:

- **What is the best practice?**
- **Why is it considered the best practice?**

---

# 📂 Current Project Structure

```text
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
```

---

# 🎯 Roadmap

This repository is being developed incrementally.

Each topic will become a self-contained learning module with:

- ✅ Production-ready implementation
- ✅ Detailed documentation
- ✅ Best practice explanation
- ✅ Common mistakes
- ✅ Alternative approaches
- ✅ Pros & Cons
- ✅ References

The goal is to transform the repository into a practical .NET knowledge base.

---

# 📚 Planned Modules

```text
01-Solution Structure
02-Domain
03-DbContext
04-Configurations
05-Generic Repository
06-Unit Of Work
07-Result Pattern
08-Middleware
09-Validation
10-Identity
11-JWT
12-Refresh Token
13-Logging
14-Caching
15-Background Jobs
16-Docker
17-Testing
18-CI/CD
19-Performance
20-Production Checklist
```

Each module will eventually contain its own documentation.

Example:

```text
05-Generic Repository
│
├── README.md
├── IRepository.cs
├── Repository.cs
├── Examples
└── Tests
```

The README of every module will explain:

- Why this approach?
- When should it be used?
- When should it NOT be used?
- Advantages
- Disadvantages
- Common mistakes
- Best practices
- Alternative implementations
- References

---

# 🎓 Who is this repository for?

This repository is intended for developers who want to learn:

- ASP.NET Core
- Entity Framework Core
- Clean Code
- Design Patterns
- Software Architecture
- Best Practices
- Performance
- Production-ready development

---

# ⭐ Repository Goal

The ultimate goal is to create a reference repository that can be used as a practical handbook for modern .NET development.