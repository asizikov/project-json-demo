# project-json-demo
This repository contains a demo .NET 4.5.2  application with `project.json` 

[![Build status](https://ci.appveyor.com/api/projects/status/gmhseph9h0kcgyma?svg=true)](https://ci.appveyor.com/project/asizikov/project-json-demo)

The solution is simple enough. Just two projects: `Demo` and `Demo.Tests`. 

Both have a NuGet dependency (`Rx-Main` for `Demo`, and `NUnit` for `Demo.Tests`)

The interesting part is a way NuGet packages are restored and referenced. Instead of `package.config` I'm using `project.json` file here.

NuGet 3 has a [new way of working with packages](http://blog.nuget.org/20151008/NuGet-3-What-and-Why.html).

The benefits are: 
* `.csproj` files are no longer modified to contain the library location.
* Packages are now stored in a per-user cache instead of `packages` folder alongside the solution.
* References are transitive. Now only the top-level packages you require are listed.

How to install and build
===

To get source code just run regular 
```
git clone https://github.com/asizikov/project-json-demo.git
```
You will need
* Visual Studio 2015 Update 1 (Community edition is enough)
* NuGet 3.4


Links:
===
* [Project.json all the things](https://oren.codes/2016/02/08/project-json-all-the-things/)
* [NuGet 3.0, .NET and project.json](http://docs.nuget.org/consume/ProjectJson-Intro)



