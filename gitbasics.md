# To add a Repository to a Git Repo and Push it to Github

## Add a Git Ignore File

Since we are using .net, I added it using:

(A git ignore file tells git not to track certain files, usually stuff we don't own.)

```shell
dotnet new gitignore
```

Create a `.git` folder in the directory that has the change history.

```shell
git init
```

Add all the current files to the list of "tracked" files by version control.

```shell
git add .
```

Commit the files you've added. 

```shell
git commit -m "Commit Message Here"
```

Use the Github CLI to create a repository on github with your code.

```shell
gh repo create
```