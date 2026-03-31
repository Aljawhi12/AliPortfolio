# Ali Aljawhi – Portfolio

A personal portfolio website built with **ASP.NET Core MVC** and **Tailwind CSS**.

## 🚀 Tech Stack
- ASP.NET Core 8 MVC
- Tailwind CSS (CDN)
- JetBrains Mono + Space Grotesk + DM Sans fonts

## 📁 Project Structure
```
AliPortfolio/
├── Controllers/
│   └── HomeController.cs
├── Models/
│   └── PortfolioViewModel.cs   ← Edit your info here
├── Views/
│   ├── Home/Index.cshtml
│   └── Shared/_Layout.cshtml
├── wwwroot/
│   ├── css/site.css
│   └── js/site.js
├── Program.cs
└── AliPortfolio.csproj
```

## ✏️ How to Update Your Info

Open `Models/PortfolioViewModel.cs` and edit the `PortfolioData.GetData()` method:
- **PersonalInfo** – name, title, email, phone, LinkedIn, GitHub
- **Skills** – add/remove skill categories and items
- **Projects** – add new projects with highlights and technologies
- **Experiences** – add new jobs
- **Education** – update university details

## 🛠️ Run Locally
```bash
dotnet run
```
Then open https://localhost:5001

## 🌐 Publish to GitHub Pages / Azure
```bash
dotnet publish -c Release -o ./publish
```
Deploy the `./publish` folder to Azure App Service or any hosting provider.

## 📌 GitHub Setup
```bash
git init
git add .
git commit -m "Initial portfolio"
git remote add origin https://github.com/YOUR_USERNAME/portfolio.git
git push -u origin main
```
