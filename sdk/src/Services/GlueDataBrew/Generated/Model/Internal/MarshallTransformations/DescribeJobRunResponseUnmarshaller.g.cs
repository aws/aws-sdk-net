/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.GlueDataBrew.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.GlueDataBrew.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeJobRun operation.
    /// </summary>
    public partial class DescribeJobRunResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new DescribeJobRunResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Attempt", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.Attempt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("CompletedOn", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CompletedOn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("DataCatalogOutputs", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<DataCatalogOutput, DataCatalogOutputUnmarshaller>(DataCatalogOutputUnmarshaller.Instance);
                    unmarshalledObject.DataCatalogOutputs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("DatabaseOutputs", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<DatabaseOutput, DatabaseOutputUnmarshaller>(DatabaseOutputUnmarshaller.Instance);
                    unmarshalledObject.DatabaseOutputs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("DatasetName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DatasetName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ErrorMessage", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ErrorMessage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ExecutionTime", targetDepth, ref reader))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.ExecutionTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("JobName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.JobName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("JobSample", targetDepth, ref reader))
                {
                    var unmarshaller = JobSampleUnmarshaller.Instance;
                    unmarshalledObject.JobSample = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("LogGroupName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogGroupName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("LogSubscription", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LogSubscription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Outputs", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<Output, OutputUnmarshaller>(OutputUnmarshaller.Instance);
                    unmarshalledObject.Outputs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ProfileConfiguration", targetDepth, ref reader))
                {
                    var unmarshaller = ProfileConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ProfileConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("RecipeReference", targetDepth, ref reader))
                {
                    var unmarshaller = RecipeReferenceUnmarshaller.Instance;
                    unmarshalledObject.RecipeReference = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("RunId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RunId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("StartedBy", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.StartedBy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("StartedOn", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartedOn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("State", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.State = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ValidationConfigurations", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<ValidationConfiguration, ValidationConfigurationUnmarshaller>(ValidationConfigurationUnmarshaller.Instance);
                    unmarshalledObject.ValidationConfigurations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);

            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            {
                using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
                {
                    var readerCopy = new StreamingUtf8JsonReader(streamCopy, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                    {
                        return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("ValidationException"))
                    {
                        return ValidationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                }
            }
            return new AmazonGlueDataBrewException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeJobRunResponseUnmarshaller _instance = new DescribeJobRunResponseUnmarshaller();

        internal static DescribeJobRunResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeJobRunResponseUnmarshaller Instance => _instance;
    }
}
