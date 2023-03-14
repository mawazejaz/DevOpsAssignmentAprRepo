# devops-aspnet-core-github-workflow-v2a
Repository for Dev Ops Class 

# About the class 
MS DevOPS RIU @ 14.Mar.2023

# Prerequisits
Create an account on GItHub
Create a Repository (Public with Readme File)
Edit the redme file and commit the code via click action

Install VS Code   (https://code.visualstudio.com/docs/?dv=win)
Install Git (https://git-scm.com/)
Install .NET 6.0 (https://dotnet.microsoft.com/en-us/download)

# Topics to Cover

Git Pull / Push

VS Code

Branching

I am chinging this manuscript V2.0


# Commands to Execute

mkdir MyFirstAzureWebApp

code MyFirstAzureWebApp

dotnet new webapp -f net6.0

dotnet run --urls=https://localhost:5001/

git commit -am "Version 1.0 aspnet core web app added"

git push

git pull

# Branching
Create a branch
=====================
git branch <new-branch> 
git branch feature01_inprogress_branch 

git branch <new-branch> <base-branch>
git branch feature01_1_inprogress_branch  feature01_inprogress_branch 

Switch to another branch
======================
git checkout feature01_inprogress_branch


# Gitflow Workflow Demonstration
Link 1: https://www.atlassian.com/git/tutorials/using-branches/git-checkout#:~:text=New%20Branches&text=The%20git%20branch%20command%20can,to%20switch%20to%20that%20branch.

link2: https://endjin.com/blog/2013/04/a-step-by-step-guide-to-using-gitflow-with-teamcity-part-3-gitflow-commands 

link3: http://danielkummer.github.io/git-flow-cheatsheet/

git flow init
>> Branch name for production releases: [main] main
>> Branch name for "next release" develop

git flow feature start f001 
git flow feature start f002


git flow feature finish f001
git flow feature publish f002