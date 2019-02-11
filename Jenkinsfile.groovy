node
{
    stage 'Checkout code'
        git 'https://github.com/almeidainm/TesteJenkins.git'
    stage 'Restore Nuget'
        bat '"C:/Program Files (x86)/NuGet/nuget.exe" restore "C:/Users/Inmetrics/source/repos/TesteGoogleJenkins/TesteGoogleJenkins.sln'
    stage 'Build'
        bat "\"${tool 'Framework4.0'}\" TesteGoogleJenkins.sln /p:Configuration=Debug /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"
    stage 'Test'
        bat '"C:/Program Files (x86)/NUnit.Console-3.9.0/nunit3-console.exe" "TesteGoogleJenkins/bin/Debug/TesteGoogleJenkins.dll"'
}