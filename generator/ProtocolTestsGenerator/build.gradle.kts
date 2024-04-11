plugins {
    id("java-library")
}

repositories {
    mavenCentral()
    mavenLocal()
}

dependencies {
    testImplementation(platform(test.junit.bom))
    testImplementation(test.junit.jupiter)
}

tasks.test {
    useJUnitPlatform()
}
