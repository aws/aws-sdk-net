using Amazon.S3.Transfer.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class AtomicFileHandlerTests
    {
        private string _testDirectory;

        [TestInitialize]
        public void Setup()
        {
            _testDirectory = MultipartDownloadTestHelpers.CreateTempDirectory();
        }

        [TestCleanup]
        public void Cleanup()
        {
            MultipartDownloadTestHelpers.CleanupTempDirectory(_testDirectory);
        }

        #region Constructor Tests

        [TestMethod]
        public void Constructor_CreatesHandler()
        {
            // Act
            var handler = new AtomicFileHandler();

            // Assert
            Assert.IsNotNull(handler);
        }

        #endregion

        #region CreateTemporaryFile Tests

        [TestMethod]
        public void CreateTemporaryFile_CreatesFileWithS3TmpPattern()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var destinationPath = Path.Combine(_testDirectory, "test.dat");

            // Act
            var tempPath = handler.CreateTemporaryFile(destinationPath);

            // Assert
            Assert.IsTrue(tempPath.Contains(".s3tmp."));
            Assert.IsTrue(File.Exists(tempPath));
        }

        [TestMethod]
        public void CreateTemporaryFile_Generates8CharacterUniqueId()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var destinationPath = Path.Combine(_testDirectory, "test.dat");

            // Act
            var tempPath = handler.CreateTemporaryFile(destinationPath);

            // Assert - Extract unique ID from pattern: {dest}.s3tmp.{8-char-id}
            var match = Regex.Match(tempPath, @"\.s3tmp\.([A-Z2-7]{8})$");
            Assert.IsTrue(match.Success, $"Temp file path '{tempPath}' doesn't match expected pattern");
            Assert.AreEqual(8, match.Groups[1].Value.Length);
        }

        [TestMethod]
        public void CreateTemporaryFile_CreatesDirectoryIfDoesntExist()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var nestedDir = Path.Combine(_testDirectory, "level1", "level2", "level3");
            var destinationPath = Path.Combine(nestedDir, "test.dat");

            // Act
            var tempPath = handler.CreateTemporaryFile(destinationPath);

            // Assert
            Assert.IsTrue(Directory.Exists(nestedDir));
            Assert.IsTrue(File.Exists(tempPath));
        }

        [TestMethod]
        public void CreateTemporaryFile_GeneratesUniqueNamesOnCollision()
        {
            // Arrange
            var handler1 = new AtomicFileHandler();
            var handler2 = new AtomicFileHandler();
            var destinationPath = Path.Combine(_testDirectory, "test.dat");

            // Act
            var tempPath1 = handler1.CreateTemporaryFile(destinationPath);
            var tempPath2 = handler2.CreateTemporaryFile(destinationPath);

            // Assert
            Assert.AreNotEqual(tempPath1, tempPath2);
            Assert.IsTrue(File.Exists(tempPath1));
            Assert.IsTrue(File.Exists(tempPath2));
        }

        [TestMethod]
        public void CreateTemporaryFile_CreatesEmptyFile()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var destinationPath = Path.Combine(_testDirectory, "test.dat");

            // Act
            var tempPath = handler.CreateTemporaryFile(destinationPath);

            // Assert
            var fileInfo = new FileInfo(tempPath);
            Assert.AreEqual(0, fileInfo.Length);
        }

        [TestMethod]
        public void CreateTemporaryFile_ReturnsCorrectTempFilePath()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var destinationPath = Path.Combine(_testDirectory, "test.dat");

            // Act
            var tempPath = handler.CreateTemporaryFile(destinationPath);

            // Assert
            Assert.IsTrue(tempPath.StartsWith(destinationPath));
            Assert.IsTrue(tempPath.Contains(".s3tmp."));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateTemporaryFile_WithNullDestinationPath_ThrowsArgumentException()
        {
            // Arrange
            var handler = new AtomicFileHandler();

            // Act
            handler.CreateTemporaryFile(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateTemporaryFile_WithEmptyDestinationPath_ThrowsArgumentException()
        {
            // Arrange
            var handler = new AtomicFileHandler();

            // Act
            handler.CreateTemporaryFile("");
        }

        #endregion

        #region CreateTemporaryFile Tests - Path Handling

        [TestMethod]
        public void CreateTemporaryFile_WithAbsolutePath_CreatesFile()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var absolutePath = Path.Combine(_testDirectory, "absolute.dat");

            // Act
            var tempPath = handler.CreateTemporaryFile(absolutePath);

            // Assert
            Assert.IsTrue(Path.IsPathRooted(tempPath));
            Assert.IsTrue(File.Exists(tempPath));
        }

        [TestMethod]
        public void CreateTemporaryFile_WithRelativePath_CreatesFile()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var relativePath = "relative.dat";

            // Act
            var tempPath = handler.CreateTemporaryFile(relativePath);

            // Assert
            Assert.IsTrue(File.Exists(tempPath));
        }

        [TestMethod]
        public void CreateTemporaryFile_WithSpecialCharactersInPath_CreatesFile()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var specialPath = Path.Combine(_testDirectory, "test[1]@2024.dat");

            // Act
            var tempPath = handler.CreateTemporaryFile(specialPath);

            // Assert
            Assert.IsTrue(File.Exists(tempPath));
        }

        [TestMethod]
        public void CreateTemporaryFile_WithDeepDirectoryStructure_CreatesAllNestedDirectories()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var deepPath = Path.Combine(_testDirectory, "a", "b", "c", "d", "e", "test.dat");

            // Act
            var tempPath = handler.CreateTemporaryFile(deepPath);

            // Assert
            Assert.IsTrue(Directory.Exists(Path.GetDirectoryName(deepPath)));
            Assert.IsTrue(File.Exists(tempPath));
        }

        #endregion

        #region CommitFile Tests

        [TestMethod]
        public void CommitFile_MovesTempFileToDestination()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var destinationPath = Path.Combine(_testDirectory, "final.dat");
            var tempPath = handler.CreateTemporaryFile(destinationPath);
            
            // Write some data to temp file
            File.WriteAllText(tempPath, "test content");

            // Act
            handler.CommitFile(tempPath, destinationPath);

            // Assert
            Assert.IsTrue(File.Exists(destinationPath));
            Assert.IsFalse(File.Exists(tempPath));
            Assert.AreEqual("test content", File.ReadAllText(destinationPath));
        }

        [TestMethod]
        public void CommitFile_OverwritesExistingDestination()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var destinationPath = Path.Combine(_testDirectory, "existing.dat");
            
            // Create existing file
            File.WriteAllText(destinationPath, "old content");
            
            var tempPath = handler.CreateTemporaryFile(destinationPath);
            File.WriteAllText(tempPath, "new content");

            // Act
            handler.CommitFile(tempPath, destinationPath);

            // Assert
            Assert.IsTrue(File.Exists(destinationPath));
            Assert.AreEqual("new content", File.ReadAllText(destinationPath));
        }

        [TestMethod]
        public void CommitFile_ClearsInternalTempFilePath()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var tempPath = handler.CreateTemporaryFile(destinationPath);
            File.WriteAllText(tempPath, "content");

            // Act
            handler.CommitFile(tempPath, destinationPath);
            handler.Dispose(); // Should not try to cleanup already-committed file

            // Assert
            Assert.IsTrue(File.Exists(destinationPath));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CommitFile_WithNullTempPath_ThrowsArgumentException()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var destinationPath = Path.Combine(_testDirectory, "test.dat");

            // Act
            handler.CommitFile(null, destinationPath);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CommitFile_WithNullDestinationPath_ThrowsArgumentException()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var tempPath = Path.Combine(_testDirectory, "temp.dat");
            File.Create(tempPath).Dispose();

            // Act
            handler.CommitFile(tempPath, null);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void CommitFile_WithMissingTempFile_ThrowsFileNotFoundException()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var tempPath = Path.Combine(_testDirectory, "nonexistent.s3tmp.ABCD1234");
            var destinationPath = Path.Combine(_testDirectory, "test.dat");

            // Act
            handler.CommitFile(tempPath, destinationPath);
        }

        [TestMethod]
        public void CommitFile_ToSameDirectory_Succeeds()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var destinationPath = Path.Combine(_testDirectory, "file.dat");
            var tempPath = handler.CreateTemporaryFile(destinationPath);
            File.WriteAllText(tempPath, "content");

            // Act
            handler.CommitFile(tempPath, destinationPath);

            // Assert
            Assert.IsTrue(File.Exists(destinationPath));
            Assert.IsFalse(File.Exists(tempPath));
        }

        [TestMethod]
        public void CommitFile_ToDifferentDirectory_Succeeds()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var tempDir = Path.Combine(_testDirectory, "temp");
            var finalDir = Path.Combine(_testDirectory, "final");
            Directory.CreateDirectory(tempDir);
            Directory.CreateDirectory(finalDir);
            
            var tempPath = Path.Combine(tempDir, "file.s3tmp.ABCD1234");
            var destinationPath = Path.Combine(finalDir, "file.dat");
            File.WriteAllText(tempPath, "content");

            // Act
            handler.CommitFile(tempPath, destinationPath);

            // Assert
            Assert.IsTrue(File.Exists(destinationPath));
            Assert.IsFalse(File.Exists(tempPath));
        }

        #endregion

        #region CleanupOnFailure Tests

        [TestMethod]
        public void CleanupOnFailure_DeletesTempFile()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var tempPath = handler.CreateTemporaryFile(destinationPath);

            // Act
            handler.CleanupOnFailure();

            // Assert
            Assert.IsFalse(File.Exists(tempPath));
        }

        [TestMethod]
        public void CleanupOnFailure_WithExplicitPath_DeletesSpecifiedFile()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var tempPath = Path.Combine(_testDirectory, "explicit.s3tmp.ABCD1234");
            File.Create(tempPath).Dispose();

            // Act
            handler.CleanupOnFailure(tempPath);

            // Assert
            Assert.IsFalse(File.Exists(tempPath));
        }

        [TestMethod]
        public void CleanupOnFailure_WithMissingFile_DoesNotThrow()
        {
            // Arrange
            var handler = new AtomicFileHandler();

            // Act & Assert - Should not throw
            handler.CleanupOnFailure();
        }

        [TestMethod]
        public void CleanupOnFailure_ClearsInternalTempFilePath()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            handler.CreateTemporaryFile(destinationPath);

            // Act
            handler.CleanupOnFailure();
            handler.CleanupOnFailure(); // Second call should be safe

            // Assert - No exception thrown
        }

        [TestMethod]
        public void CleanupOnFailure_CanBeCalledMultipleTimes()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            handler.CreateTemporaryFile(destinationPath);

            // Act & Assert - Should not throw
            handler.CleanupOnFailure();
            handler.CleanupOnFailure();
            handler.CleanupOnFailure();
        }

        [TestMethod]
        public void CleanupOnFailure_WithNullPath_UsesInternalPath()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var tempPath = handler.CreateTemporaryFile(destinationPath);

            // Act
            handler.CleanupOnFailure(null);

            // Assert
            Assert.IsFalse(File.Exists(tempPath));
        }

        [TestMethod]
        public void CleanupOnFailure_WithEmptyPath_UsesInternalPath()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var tempPath = handler.CreateTemporaryFile(destinationPath);

            // Act
            handler.CleanupOnFailure("");

            // Assert
            Assert.IsFalse(File.Exists(tempPath));
        }

        #endregion

        #region GenerateUniqueId Tests

        [TestMethod]
        public void GenerateUniqueId_GeneratesDifferentIdsOnSuccessiveCalls()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var destinationPath = Path.Combine(_testDirectory, "test.dat");

            // Act - Create multiple temp files to generate multiple IDs
            var tempPath1 = handler.CreateTemporaryFile(destinationPath);
            var handler2 = new AtomicFileHandler();
            var tempPath2 = handler2.CreateTemporaryFile(destinationPath);
            var handler3 = new AtomicFileHandler();
            var tempPath3 = handler3.CreateTemporaryFile(destinationPath);

            // Extract IDs
            var id1 = Regex.Match(tempPath1, @"\.s3tmp\.([A-Z2-7]{8})$").Groups[1].Value;
            var id2 = Regex.Match(tempPath2, @"\.s3tmp\.([A-Z2-7]{8})$").Groups[1].Value;
            var id3 = Regex.Match(tempPath3, @"\.s3tmp\.([A-Z2-7]{8})$").Groups[1].Value;

            // Assert - IDs should be different (statistically)
            Assert.IsFalse(id1 == id2 && id2 == id3, "All three IDs are identical - very unlikely with proper random generation");
        }

        [TestMethod]
        public void GenerateUniqueId_UsesBase32CharacterSet()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var destinationPath = Path.Combine(_testDirectory, "test.dat");

            // Act
            var tempPath = handler.CreateTemporaryFile(destinationPath);
            var match = Regex.Match(tempPath, @"\.s3tmp\.([A-Z2-7]{8})$");
            var id = match.Groups[1].Value;

            // Assert - Should only contain A-Z and 2-7 (RFC 4648 base32)
            Assert.IsTrue(Regex.IsMatch(id, "^[A-Z2-7]+$"), $"ID '{id}' contains invalid base32 characters");
        }

        [TestMethod]
        public void GenerateUniqueId_IdsAreFilesystemSafe()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var destinationPath = Path.Combine(_testDirectory, "test.dat");

            // Act
            var tempPath = handler.CreateTemporaryFile(destinationPath);
            var match = Regex.Match(tempPath, @"\.s3tmp\.([A-Z2-7]{8})$");
            var id = match.Groups[1].Value;

            // Assert - No problematic characters (/, \, :, *, ?, ", <, >, |)
            var problematicChars = new[] { '/', '\\', ':', '*', '?', '"', '<', '>', '|' };
            Assert.IsFalse(id.Any(c => problematicChars.Contains(c)));
        }

        #endregion

        #region Dispose Tests

        [TestMethod]
        public void Dispose_CallsCleanupOnUncommittedFile()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var tempPath = handler.CreateTemporaryFile(destinationPath);

            // Act
            handler.Dispose();

            // Assert
            Assert.IsFalse(File.Exists(tempPath));
        }

        [TestMethod]
        public void Dispose_CanBeCalledMultipleTimes()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            handler.CreateTemporaryFile(destinationPath);

            // Act & Assert - Should not throw
            handler.Dispose();
            handler.Dispose();
            handler.Dispose();
        }

        [TestMethod]
        public void Dispose_DoesNotCleanupCommittedFiles()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var tempPath = handler.CreateTemporaryFile(destinationPath);
            File.WriteAllText(tempPath, "content");
            handler.CommitFile(tempPath, destinationPath);

            // Act
            handler.Dispose();

            // Assert
            Assert.IsTrue(File.Exists(destinationPath));
            Assert.AreEqual("content", File.ReadAllText(destinationPath));
        }

        [TestMethod]
        public void Dispose_SafeAfterManualCleanup()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            handler.CreateTemporaryFile(destinationPath);
            handler.CleanupOnFailure();

            // Act & Assert - Should not throw
            handler.Dispose();
        }

        #endregion

        #region Integration Tests

        [TestMethod]
        public void Integration_CreateWriteCommit_Success()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var destinationPath = Path.Combine(_testDirectory, "final.dat");
            var testData = "Integration test content";

            // Act
            var tempPath = handler.CreateTemporaryFile(destinationPath);
            File.WriteAllText(tempPath, testData);
            handler.CommitFile(tempPath, destinationPath);

            // Assert
            Assert.IsTrue(File.Exists(destinationPath));
            Assert.IsFalse(File.Exists(tempPath));
            Assert.AreEqual(testData, File.ReadAllText(destinationPath));
        }

        [TestMethod]
        public void Integration_CreateWriteCleanup_Success()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var destinationPath = Path.Combine(_testDirectory, "temp.dat");

            // Act
            var tempPath = handler.CreateTemporaryFile(destinationPath);
            File.WriteAllText(tempPath, "temporary content");
            handler.CleanupOnFailure();

            // Assert
            Assert.IsFalse(File.Exists(tempPath));
            Assert.IsFalse(File.Exists(destinationPath));
        }

        [TestMethod]
        public void Integration_ConcurrentTempFileCreation_AllFilesUnique()
        {
            // Arrange
            var handlers = Enumerable.Range(0, 10).Select(_ => new AtomicFileHandler()).ToArray();
            var destinationPath = Path.Combine(_testDirectory, "concurrent.dat");

            // Act
            var tempPaths = handlers.Select(h => h.CreateTemporaryFile(destinationPath)).ToArray();

            // Assert - All paths should be unique
            Assert.AreEqual(10, tempPaths.Distinct().Count());
            Assert.IsTrue(tempPaths.All(File.Exists));

            // Cleanup
            foreach (var handler in handlers)
            {
                handler.Dispose();
            }
        }

        [TestMethod]
        public void Integration_VerifyFileAtomicity_NoPartialWrites()
        {
            // Arrange
            var handler = new AtomicFileHandler();
            var destinationPath = Path.Combine(_testDirectory, "atomic.dat");
            var largeData = new string('A', 1024 * 1024); // 1MB of data

            // Act
            var tempPath = handler.CreateTemporaryFile(destinationPath);
            File.WriteAllText(tempPath, largeData);
            handler.CommitFile(tempPath, destinationPath);

            // Assert
            var finalContent = File.ReadAllText(destinationPath);
            Assert.AreEqual(largeData.Length, finalContent.Length);
            Assert.IsTrue(finalContent.All(c => c == 'A'));
        }

        #endregion
    }
}
