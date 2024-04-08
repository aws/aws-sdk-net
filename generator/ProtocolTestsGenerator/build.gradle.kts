plugins {
    id("java-library")
}

version = "1.0-SNAPSHOT"

repositories {
    mavenCentral()
}

dependencies {
    testImplementation(platform(test.junit.bom))
    testImplementation(test.junit.jupiter)
}

tasks.test {
    useJUnitPlatform()
}
