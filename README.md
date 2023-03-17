# FunctionApp44
Test app for dotnet isolated placeholder/specialization usecases with our new native component.

### To build/publish locally.

We need to use the worker packages from this PR build artifacts: https://github.com/Azure/azure-functions-dotnet-worker/pull/1309

Here is the latest build: https://azfunc.visualstudio.com/Azure%20Functions/_build/results?buildId=120577&view=results

1. Download artifacts from the above build.
2. Setup a local nuget package source. Copy the packages from above step to the local nuget source directory.
3. Open this function app in VS. Go to "Manage nuget packages" and select the local nuget source and upgrade the packages to the one we dropped in previous step. (Make sure you have enabled "include prerelease" checkbox.
4. Once you update the packages, open a cmd prompt in the function app root (where you see the .csproj file) and run `dotnet publish -c release -r win-x64 --no-self-contained`

![image](https://user-images.githubusercontent.com/144469/225951033-4a2948c1-ae4e-4949-9d37-36dc9a68e01f.png)


You can go to the publish directory (`\FunctionApp44\bin\release\net6.0\win-x64\publish`) and use that payload.
