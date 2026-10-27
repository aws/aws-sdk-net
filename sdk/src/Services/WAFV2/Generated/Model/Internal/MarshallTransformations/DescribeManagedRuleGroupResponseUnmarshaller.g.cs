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

using Amazon.WAFV2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Globalization;
using Amazon.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.WAFV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeManagedRuleGroup operation.
    /// </summary>
    public partial class DescribeManagedRuleGroupResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            var unmarshalledObject = new DescribeManagedRuleGroupResponse();
            var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);

            context.Read(ref reader);
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("AvailableLabels", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<LabelSummary, LabelSummaryUnmarshaller>(LabelSummaryUnmarshaller.Instance);
                    unmarshalledObject.AvailableLabels = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Capacity", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.Capacity = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("ConsumedLabels", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<LabelSummary, LabelSummaryUnmarshaller>(LabelSummaryUnmarshaller.Instance);
                    unmarshalledObject.ConsumedLabels = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("LabelNamespace", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LabelNamespace = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Rules", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<RuleSummary, RuleSummaryUnmarshaller>(RuleSummaryUnmarshaller.Instance);
                    unmarshalledObject.Rules = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("SnsTopicArn", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SnsTopicArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("VersionName", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.VersionName = unmarshaller.Unmarshall(context, ref reader);
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
                    if (errorResponse.Code != null && errorResponse.Code.Equals("WAFExpiredManagedRuleGroupVersionException"))
                    {
                        return WAFExpiredManagedRuleGroupVersionExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("WAFInternalErrorException"))
                    {
                        return WAFInternalErrorExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("WAFInvalidOperationException"))
                    {
                        return WAFInvalidOperationExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("WAFInvalidParameterException"))
                    {
                        return WAFInvalidParameterExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("WAFInvalidResourceException"))
                    {
                        return WAFInvalidResourceExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                    if (errorResponse.Code != null && errorResponse.Code.Equals("WAFNonexistentItemException"))
                    {
                        return WAFNonexistentItemExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse, ref readerCopy);
                    }
                }
            }
            return new AmazonWAFV2Exception(errorResponse.Message, errorResponse.InnerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, errorResponse.StatusCode);
        }

        private static DescribeManagedRuleGroupResponseUnmarshaller _instance = new DescribeManagedRuleGroupResponseUnmarshaller();

        internal static DescribeManagedRuleGroupResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DescribeManagedRuleGroupResponseUnmarshaller Instance => _instance;
    }
}
