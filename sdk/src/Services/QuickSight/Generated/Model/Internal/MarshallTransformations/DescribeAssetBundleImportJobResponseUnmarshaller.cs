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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using Amazon.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeAssetBundleImportJob operation
    /// </summary>  
    public class DescribeAssetBundleImportJobResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeAssetBundleImportJobResponse response = new DescribeAssetBundleImportJobResponse();
            StreamingUtf8JsonReader reader = new StreamingUtf8JsonReader(context.Stream);
            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("Arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Arn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AssetBundleImportJobId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AssetBundleImportJobId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AssetBundleImportSource", targetDepth))
                {
                    var unmarshaller = AssetBundleImportSourceDescriptionUnmarshaller.Instance;
                    response.AssetBundleImportSource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("AwsAccountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AwsAccountId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("CreatedTime", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    response.CreatedTime = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Errors", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetBundleImportJobError, AssetBundleImportJobErrorUnmarshaller>(AssetBundleImportJobErrorUnmarshaller.Instance);
                    response.Errors = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("FailureAction", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FailureAction = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("JobStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.JobStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OverrideParameters", targetDepth))
                {
                    var unmarshaller = AssetBundleImportJobOverrideParametersUnmarshaller.Instance;
                    response.OverrideParameters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OverridePermissions", targetDepth))
                {
                    var unmarshaller = AssetBundleImportJobOverridePermissionsUnmarshaller.Instance;
                    response.OverridePermissions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OverrideTags", targetDepth))
                {
                    var unmarshaller = AssetBundleImportJobOverrideTagsUnmarshaller.Instance;
                    response.OverrideTags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("OverrideValidationStrategy", targetDepth))
                {
                    var unmarshaller = AssetBundleImportJobOverrideValidationStrategyUnmarshaller.Instance;
                    response.OverrideValidationStrategy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RequestId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.RequestId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("RollbackErrors", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetBundleImportJobError, AssetBundleImportJobErrorUnmarshaller>(AssetBundleImportJobErrorUnmarshaller.Instance);
                    response.RollbackErrors = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("Warnings", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AssetBundleImportJobWarning, AssetBundleImportJobWarningUnmarshaller>(AssetBundleImportJobWarningUnmarshaller.Instance);
                    response.Warnings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            response.Status = (int)context.ResponseData.StatusCode;

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
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
                {
                    return ResourceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ThrottlingException"))
                {
                    return ThrottlingExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("UnsupportedUserEditionException"))
                {
                    return UnsupportedUserEditionExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                }
            }
            return new AmazonQuickSightException(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeAssetBundleImportJobResponseUnmarshaller _instance = new DescribeAssetBundleImportJobResponseUnmarshaller();        

        internal static DescribeAssetBundleImportJobResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeAssetBundleImportJobResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}