using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.SageMakerTrainingSessionRuntime;
using Amazon.SageMakerTrainingSessionRuntime.Model;

namespace AWSSDKDocSamples.Amazon.SageMakerTrainingSessionRuntime.Generated
{
    class SageMakerTrainingSessionRuntimeSamples : ISample
    {
        public void SageMakerTrainingSessionRuntimeExecuteSamplingOperation()
        {
            #region ExecuteSamplingOperation-1

            var client = new AmazonSageMakerTrainingSessionRuntimeClient();
            var response = client.ExecuteSamplingOperation(new ExecuteSamplingOperationRequest
            {
                OperationConfig = new SampleOperationConfig { Sample = new SampleConfig {
                    NumSamples = 4,
                    Prompt = new ModelInput { Chunks = new List<EncodedTextChunk> {
                        new EncodedTextChunk {
                            Tokens = new List<int> {
                                791,
                                6864,
                                315,
                                9822,
                                374
                            },
                            Type = "encoded_text"
                        }
                    } },
                    SamplingParams = new SamplingParams {
                        MaxTokens = 1024,
                        Temperature = 0.7,
                        TopP = 0.9
                    }
                } },
                TrainingSessionName = "my-training-session"
            });

            string operationId = response.OperationId;

            #endregion
        }

        public void SageMakerTrainingSessionRuntimeExecuteTrainingOperation()
        {
            #region ExecuteTrainingOperation-1

            var client = new AmazonSageMakerTrainingSessionRuntimeClient();
            var response = client.ExecuteTrainingOperation(new ExecuteTrainingOperationRequest
            {
                OperationConfig = new OperationConfig { ForwardBackward = new ForwardBackwardConfig {
                    DatumList = new List<Datum> {
                        new Datum { ModelInput = new ModelInput { Chunks = new List<EncodedTextChunk> {
                            new EncodedTextChunk {
                                Tokens = new List<int> {
                                    791,
                                    6864,
                                    315,
                                    9822,
                                    374,
                                    12366
                                },
                                Type = "encoded_text"
                            }
                        } } }
                    },
                    LossFnName = "cross_entropy"
                } },
                SequenceNumber = 1,
                TrainingSessionName = "my-training-session"
            });

            string operationId = response.OperationId;

            #endregion
        }

        public void SageMakerTrainingSessionRuntimeGetSamplingOperationResult()
        {
            #region GetSamplingOperationResult-1

            var client = new AmazonSageMakerTrainingSessionRuntimeClient();
            var response = client.GetSamplingOperationResult(new GetSamplingOperationResultRequest
            {
                OperationId = "a1b2c3d4-5678-90ab-cdef-1234567890ab",
                TrainingSessionName = "my-training-session"
            });

            SampleOperationResult operationResult = response.OperationResult;
            RequestStatus status = response.Status;

            #endregion
        }

        public void SageMakerTrainingSessionRuntimeGetTrainingOperationResult()
        {
            #region GetTrainingOperationResult-1

            var client = new AmazonSageMakerTrainingSessionRuntimeClient();
            var response = client.GetTrainingOperationResult(new GetTrainingOperationResultRequest
            {
                OperationId = "a1b2c3d4-5678-90ab-cdef-1234567890ab",
                TrainingSessionName = "my-training-session"
            });

            OperationResult operationResult = response.OperationResult;
            RequestStatus status = response.Status;
            TrainingTokenUsage tokenUsage = response.TokenUsage;

            #endregion
        }

        public void SageMakerTrainingSessionRuntimeSampleTrainingSession()
        {
            #region SampleTrainingSession-1

            var client = new AmazonSageMakerTrainingSessionRuntimeClient();
            var response = client.SampleTrainingSession(new SampleTrainingSessionRequest
            {
                Accept = "application/json",
                Body = new MemoryStream(eyJtZXNzYWdlcyI6W3sicm9sZSI6InVzZXIiLCJjb250ZW50IjoiV2hhdCBpcyB0aGUgY2FwaXRhbCBvZiBGcmFuY2U/In1dLCJtYXhfdG9rZW5zIjoxMjh9),
                ContentType = "application/json",
                TrainingSessionName = "my-training-session"
            });

            MemoryStream body = response.Body;
            string contentType = response.ContentType;

            #endregion
        }

        public void SageMakerTrainingSessionRuntimeSampleTrainingSessionWithResponseStream()
        {
            #region SampleTrainingSessionWithResponseStream-1

            var client = new AmazonSageMakerTrainingSessionRuntimeClient();
            var response = client.SampleTrainingSessionWithResponseStream(new SampleTrainingSessionWithResponseStreamRequest
            {
                Accept = "application/json",
                Body = new MemoryStream(eyJtZXNzYWdlcyI6W3sicm9sZSI6InVzZXIiLCJjb250ZW50IjoiV2hhdCBpcyB0aGUgY2FwaXRhbCBvZiBGcmFuY2U/In1dLCJtYXhfdG9rZW5zIjoxMjgsInN0cmVhbSI6dHJ1ZX0=),
                ContentType = "application/json",
                TrainingSessionName = "my-training-session"
            });


            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
