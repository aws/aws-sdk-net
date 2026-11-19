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

using Amazon.EC2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetDeclarativePoliciesReportSummary operation.
    /// </summary>
    public partial class GetDeclarativePoliciesReportSummaryResponseUnmarshaller : EC2ResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            GetDeclarativePoliciesReportSummaryResponse unmarshalledObject = new GetDeclarativePoliciesReportSummaryResponse();

            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
            {
                targetDepth = 2;
            }

            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("attributeSummarySet/item", targetDepth))
                    {
                        if (unmarshalledObject.AttributeSummaries == null)
                        {
                            unmarshalledObject.AttributeSummaries = new List<AttributeSummary>();
                        }
                        var unmarshaller = AttributeSummaryUnmarshaller.Instance;
                        unmarshalledObject.AttributeSummaries.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("endTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.EndTime = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("numberOfAccounts", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.NumberOfAccounts = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("numberOfFailedAccounts", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.NumberOfFailedAccounts = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("reportId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ReportId = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("s3Bucket", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.S3Bucket = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("s3Prefix", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.S3Prefix = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("startTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.StartTime = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("targetId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TargetId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshall error response to exception.
        /// </summary>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            return new AmazonEC2Exception(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static GetDeclarativePoliciesReportSummaryResponseUnmarshaller _instance = new GetDeclarativePoliciesReportSummaryResponseUnmarshaller();

        internal static GetDeclarativePoliciesReportSummaryResponseUnmarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GetDeclarativePoliciesReportSummaryResponseUnmarshaller Instance => _instance;
    }
}
