# FunctionApp44
Test app for dotnet isolated placeholder/specialization usecases with our new native component.

### To build/publish locally.

_
~~The worker packages needed for this app is published to our [internal staging feed](https://azfunc.visualstudio.com/Azure%20Functions/_artifacts/feed/AzureFunctionsTempStaging).~~ We published the latest worker & sdk packages to public nuget gallery on 3/27. So we do not rely on the internal staging feed anymore.

1. Open a cmd prompt in the function app root (where you see the .csproj file) and run `dotnet publish -c release -r win-x64 --no-self-contained`

![image](https://user-images.githubusercontent.com/144469/225951033-4a2948c1-ae4e-4949-9d37-36dc9a68e01f.png)


You can go to the publish directory (`\FunctionApp44\bin\release\net6.0\win-x64\publish`) and use that payload.
