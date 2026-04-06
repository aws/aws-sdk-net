using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Polly;
using Amazon.Polly.Model;

namespace AWSSDKDocSamples.Amazon.Polly.Generated
{
    class PollySamples : ISample
    {
        public void PollyDeleteLexicon()
        {
            #region to-delete-a-lexicon-1481922498332

            var client = new AmazonPollyClient();
            var response = client.DeleteLexicon(new DeleteLexiconRequest 
            {
                Name = "example"
            });


            #endregion
        }

        public void PollyDescribeVoices()
        {
            #region to-describe-available-voices-1482180557753

            var client = new AmazonPollyClient();
            var response = client.DescribeVoices(new DescribeVoicesRequest 
            {
                LanguageCode = "en-GB"
            });

            List<Voice> voices = response.Voices;

            #endregion
        }

        public void PollyGetLexicon()
        {
            #region to-retrieve-a-lexicon-1481912870836

            var client = new AmazonPollyClient();
            var response = client.GetLexicon(new GetLexiconRequest 
            {
                Name = ""
            });

            Lexicon lexicon = response.Lexicon;
            LexiconAttributes lexiconAttributes = response.LexiconAttributes;

            #endregion
        }

        public void PollyListLexicons()
        {
            #region to-list-all-lexicons-in-a-region-1481842106487

            var client = new AmazonPollyClient();
            var response = client.ListLexicons(new ListLexiconsRequest 
            {
            });

            List<LexiconDescription> lexicons = response.Lexicons;

            #endregion
        }

        public void PollyPutLexicon()
        {
            #region to-save-a-lexicon-1482272584088

            var client = new AmazonPollyClient();
            var response = client.PutLexicon(new PutLexiconRequest 
            {
                Content = "<Lexicon Content>",
                Name = "W3C"
            });


            #endregion
        }

        public void PollyStartSpeechSynthesisStream()
        {
            #region to-start-speech-synthesis-stream-1741791835844

            var client = new AmazonPollyClient();
            var response = client.StartSpeechSynthesisStream(new StartSpeechSynthesisStreamRequest 
            {
                ActionStreamPublisher = new StartSpeechSynthesisStreamActionStream {
                    CloseStreamEvent = new CloseStreamEvent {  },
                    TextEvent = new TextEvent {
                        Text = "Hello, this is a test of bidirectional streaming synthesis.",
                        TextType = "text"
                    }
                }, // The input event stream. Send TextEvent messages with text to synthesize, and a CloseStreamEvent to signal the end of input.
                Engine = "generative", // The engine to use for synthesis.
                LanguageCode = "en-US",
                OutputFormat = "pcm", // The audio format.
                SampleRate = "16000",
                VoiceId = "Joanna"
            });

            StartSpeechSynthesisStreamEventStream eventStream = response.EventStream; // The output event stream. AudioEvent messages contain synthesized audio chunks, and StreamClosedEvent signals completion with the total character count.

            #endregion
        }

        public void PollySynthesizeSpeech()
        {
            #region to-synthesize-speech-1482186064046

            var client = new AmazonPollyClient();
            var response = client.SynthesizeSpeech(new SynthesizeSpeechRequest 
            {
                LexiconNames = new List<string> {
                    "example"
                },
                OutputFormat = "mp3",
                SampleRate = "8000",
                Text = "All Gaul is divided into three parts",
                TextType = "text",
                VoiceId = "Joanna"
            });

            MemoryStream audioStream = response.AudioStream;
            string contentType = response.ContentType;
            int requestCharacters = response.RequestCharacters;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}