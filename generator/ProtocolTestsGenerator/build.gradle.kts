plugins {
    id("java-library")
}

allprojects {
    group = "software.amazon.smithy.dotnet"
    version = "0.1.0"
}

repositories {
    mavenLocal()
    mavenCentral()
}

dependencies {
    testImplementation(platform(test.junit.bom))
    testImplementation(test.junit.jupiter)
}

tasks.test {
    useJUnitPlatform()
}
