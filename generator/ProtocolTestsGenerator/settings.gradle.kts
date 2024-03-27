rootProject.name = "ProtocolTestsGenerator"
include ("smithy-dotnet-codegen")
include("smithy-dotnet-codegen-test")
include("smithy-dotnet-protocol-test")

pluginManagement {
    repositories {
        mavenLocal()
        gradlePluginPortal()
    }
}