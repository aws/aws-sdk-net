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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glacier.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glacier.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeJob operation
    /// </summary>  
    public class DescribeJobResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeJobResponse response = new DescribeJobResponse();
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Action", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Action = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ArchiveId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ArchiveId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ArchiveSHA256TreeHash", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ArchiveSHA256TreeHash = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ArchiveSizeInBytes", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    response.ArchiveSizeInBytes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Completed", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    response.Completed = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CompletionDate", targetDepth))
                {
                    var unmarshaller = Amazon.Runtime.Internal.Transform.NullableDateTimeUnmarshaller.Instance;
                    response.CompletionDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreationDate", targetDepth))
                {
                    var unmarshaller = Amazon.Runtime.Internal.Transform.NullableDateTimeUnmarshaller.Instance;
                    response.CreationDate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InventoryRetrievalParameters", targetDepth))
                {
                    var unmarshaller = InventoryRetrievalJobDescriptionUnmarshaller.Instance;
                    response.InventoryRetrievalParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("InventorySizeInBytes", targetDepth))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    response.InventorySizeInBytes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("JobDescription", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.JobDescription = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("JobId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.JobId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("JobOutputPath", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.JobOutputPath = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OutputLocation", targetDepth))
                {
                    var unmarshaller = OutputLocationUnmarshaller.Instance;
                    response.OutputLocation = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RetrievalByteRange", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RetrievalByteRange = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SelectParameters", targetDepth))
                {
                    var unmarshaller = SelectParametersUnmarshaller.Instance;
                    response.SelectParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SHA256TreeHash", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SHA256TreeHash = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("SNSTopic", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SNSTopic = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StatusCode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.StatusCode = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("StatusMessage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.StatusMessage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Tier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Tier = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("VaultARN", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VaultARN = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            var errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context, ref reader);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new JsonUnmarshallerContext(streamCopy, false, context.ResponseData))
            {
                StreamingUtf8JsonReader readerCopy = new StreamingUtf8JsonReader(streamCopy);
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterValueException"))
                {
                    return InvalidParameterValueExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("MissingParameterValueException"))
                {
                    return MissingParameterValueExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceUnavailableException"))
                {
                    return ServiceUnavailableExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
            }
            return new AmazonGlacierException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeJobResponseUnmarshaller _instance = new DescribeJobResponseUnmarshaller();        

        internal static DescribeJobResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeJobResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}