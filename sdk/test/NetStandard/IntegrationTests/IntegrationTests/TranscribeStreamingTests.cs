using Amazon.TranscribeStreaming;
using Amazon.TranscribeStreaming.Model;
using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace Amazon.DNXCore.IntegrationTests
{
    public class TranscribeStreaming : TestBase<AmazonTranscribeStreamingClient>
    {
#if NET8_0_OR_GREATER
        [Fact]
        [Trait(CategoryAttribute, "TranscribeStreaming")]
        public async Task TranscribeFlacFile()
        {
            var startRequest = new StartStreamTranscriptionRequest
            {
                LanguageCode = LanguageCode.EnUS,
                MediaEncoding = MediaEncoding.Flac,
                MediaSampleRateHertz = 44100
            };

            // Audio file saying "this is a test" 3 times.
            var audioFilePath = FindFilePath("this-is-a-test.flac");
            Stream fileStream = File.OpenRead(audioFilePath);
            var buffer = new byte[1024 * 10];
            var bytesRead = -1;
            startRequest.AudioStreamPublisher += async () =>
            {
                // If the previous read was 0 bytes then return null to stop publishing
                if (bytesRead == 0)
                    return null;

                bytesRead = await fileStream.ReadAsync(buffer, 0, buffer.Length);

                // Return an audio event even if bytesRead is 0 to send an ending audio event.
                // The next call to publishe will return null triggering an end to publishing.
                var audioEvent = new AudioEvent
                {
                    AudioChunk = new MemoryStream(buffer, 0, bytesRead)
                };

                return audioEvent;
            };

            using var response = await Client.StartStreamTranscriptionAsync(startRequest);

            bool foundThisIsATest = false;
            var timeoutTime = DateTime.UtcNow.AddSeconds(30);
            await foreach (var evnt in response.TranscriptResultStream)
            {
                if (evnt is TranscriptEvent transcriptEvent)
                {
                    foreach (var result in transcriptEvent.Transcript.Results)
                    {
                        var text = result.Alternatives[0].Transcript;
                        if (text.Contains("this is a test", StringComparison.InvariantCultureIgnoreCase))
                        {
                            foundThisIsATest = true;
                            break;
                        }
                    }
                }

                if (timeoutTime < DateTime.UtcNow)
                {
                    break;
                }
            }

            Assert.True(foundThisIsATest);
        }

        private string FindFilePath(string file)
        {
            var directory = Directory.GetParent(this.GetType().Assembly.Location).FullName;
            while (!string.IsNullOrEmpty(directory))
            {
                var filePath = Path.Combine(directory, file);
                if (File.Exists(filePath))
                    return filePath;

                directory = Directory.GetParent(directory)?.FullName;
            }

            throw new FileNotFoundException($"Failed to find file " + file);
        }
#endif
    }
}
