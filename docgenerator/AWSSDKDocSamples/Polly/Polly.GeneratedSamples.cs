using System;
using System.Collections.Generic;
using System.IO;
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
            #region DeleteLexicon-1

            var client = new AmazonPollyClient();
            var response = client.DeleteLexicon(new DeleteLexiconRequest
            {
                Name = "example"
            });


            #endregion
        }

        public void PollyDescribeVoices()
        {
            #region DescribeVoices-1

            var client = new AmazonPollyClient();
            var response = client.DescribeVoices(new DescribeVoicesRequest
            {
                LanguageCode = "en-GB"
            });

            List<Voice> voices = response.Voices;

            #endregion
        }

        public void PollyListLexicons()
        {
            #region ListLexicons-1

            var client = new AmazonPollyClient();
            var response = client.ListLexicons(new ListLexiconsRequest
            {
            });

            List<LexiconDescription> lexicons = response.Lexicons;

            #endregion
        }

        public void PollyPutLexicon()
        {
            #region PutLexicon-1

            var client = new AmazonPollyClient();
            var response = client.PutLexicon(new PutLexiconRequest
            {
                Content = "<Lexicon Content>",
                Name = "W3C"
            });


            #endregion
        }

        public void PollySynthesizeSpeech()
        {
            #region SynthesizeSpeech-1

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

            Stream audioStream = response.AudioStream;
            string contentType = response.ContentType;
            int? requestCharacters = response.RequestCharacters;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
