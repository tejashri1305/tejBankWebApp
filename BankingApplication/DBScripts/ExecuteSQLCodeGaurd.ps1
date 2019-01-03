#param([String] $MSBuildExePath,[String] $SqlCodeGuardProjPath)
clear
$LASTEXITCODE = 0;
try
{
#Write-Host ("SQL cmd path - " + $SQLCMDFolderPath);
#Write-Host ("MS Build exe path - " + $MSBuildExePath);
#Write-Host ("SQL code gaurd sample project file path - " + $SqlCodeGuardProjPath);
c:
cd "C:\Windows\Microsoft.NET\Framework\v2.0.50727";
&  MSBuild.exe "C:\Program Files (x86)\SqlCodeGuard\SampleProject.msbuild";

#cd $MSBuildExePath
#& .\MSBuild.exe $SqlCodeGuardProjPath

#START "" $MSBuildExePath $SqlCodeGuardProjPath
}
catch
{
    $lastexitcode=-1;
    Write-Host("Failed and exit with lastexitcode: "+$lastexitcode);
}
exit $lastexitcode;