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
dependencyResolutionManagement {
    versionCatalogs {
        create("codegen") {
            version("smithy", "1.60.3")
            library("protocol-tests", "software.amazon.smithy", "smithy-protocol-tests").versionRef("smithy")
            library("protocol-aws-tests", "software.amazon.smithy", "smithy-aws-protocol-tests").versionRef("smithy")
            library("codegen-core", "software.amazon.smithy", "smithy-codegen-core").versionRef("smithy")
            library("protocol-tests-traits", "software.amazon.smithy", "smithy-protocol-test-traits").versionRef("smithy")
            library("aws-traits", "software.amazon.smithy", "smithy-aws-traits").versionRef("smithy")
            library("model", "software.amazon.smithy", "smithy-model").versionRef("smithy")
        }
        create("test") {
            library("junit-bom", "org.junit:junit-bom:5.9.1")
            library("junit-jupiter", "org.junit.jupiter:junit-jupiter:5.9.1")
        }
    }
}
