# fullstack-mission

### Setup devcontainers
    1. สร้างโปรเจค/Repository ใน Github
    2. กด + Dev containers
    3. Clone repository in container volume...
    4. C# (.NET)
    5. 7.0
    6. Node.js (via, nvm) yarn and pnpm
    7. dotnet --version
    8. node --version

### Setup front/back project
#### Backend
    1. Create folder API
    2. dotnet new webapi -o chat-sv เพื่อสร้างโปรเจคชื่อ chat-sv 
    3. cd chat-sv
    4. dotnet run
    5. open in browser + /<route>
    6. dotnet new gitignore
#### Fontend
    1. npx create-next-app@latest

### Chat Api using in-memory
### Chat UI
### Real-time using SignalR
### Store data in mongo
### Separate Chat Api to member and message
### Share/Publish data between services using RabbitMQ

# Guideline
### @Don will guide each one first
### Ask ChatGPT
### Modify the answer to your needs
### Repeat 1-3

# Requisition
### Need to use Docker
### Need to use Devcontainer
### Need to use K8s and helm
### Need to use Skaffold

# Folder Structure
    - api
        - chat-sv
        - message-sv
    - app
        - chat-app

# Commands
```C#
dotnet new webapi -o chat-sv
dotnet run
http://localhost:5044/weatherforecast
dotnet new gitignore
frontend
npx create-next-app@latest
```