# FunctionApp44
Test app for dotnet isolated placeholder/specialization usecases with our new native component.

### To build/publish locally.

The worker packages needed for this app is published to our [internal staging feed](https://azfunc.visualstudio.com/Azure%20Functions/_artifacts/feed/AzureFunctionsTempStaging).

1. If not alreadyt present, [add a new nuget package source which points to our internal staging feed](https://azfunc.visualstudio.com/Azure%20Functions/_artifacts/feed/AzureFunctionsTempStaging/connect/visual%20studio).
2. Open this function app in Visual studio. Go to "Manage nuget packages" and restore packages from the "AzureFunctionsTempStaging" package source. (Make sure you have enabled "include prerelease" checkbox.
3. Once you update the packages, open a cmd prompt in the function app root (where you see the .csproj file) and run `dotnet publish -c release -r win-x64 --no-self-contained`

![image](https://user-images.githubusercontent.com/144469/225951033-4a2948c1-ae4e-4949-9d37-36dc9a68e01f.png)


You can go to the publish directory (`\FunctionApp44\bin\release\net6.0\win-x64\publish`) and use that payload.
