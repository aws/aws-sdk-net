﻿/*
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
using System;
using System.Net;
using System.Collections.Generic;
using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for ListAnalyticsConfiguration operation
    /// </summary>
    public class ListBucketAnalyticsConfigurationsResponseUnmarshaller : S3ReponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            ListBucketAnalyticsConfigurationsResponse response = new ListBucketAnalyticsConfigurationsResponse();

            while (context.Read())
            {
                if (context.IsStartElement)
                {
                    UnmarshallResult(context, response);
                    continue;
                }
            }


            return response;
        }

        private static void UnmarshallResult(XmlUnmarshallerContext context, ListBucketAnalyticsConfigurationsResponse response)
        {

            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ContinuationToken", targetDepth))
                    {
                        response.ContinuationToken = StringUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }

                    if (context.TestExpression("AnalyticsConfiguration", targetDepth))
                    {
                        response.AnalyticsConfigurationList.Add(AnalyticsConfigurationUnmarshaller.Instance.Unmarshall(context));

                        continue;
                    }
                    if (context.TestExpression("IsTruncated", targetDepth))
                    {
                        response.IsTruncated = BoolUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("NextContinuationToken", targetDepth))
                    {
                        response.NextContinuationToken = StringUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return;
                }
            }



            return;
        }

        private static ListBucketAnalyticsConfigurationsResponseUnmarshaller _instance = new ListBucketAnalyticsConfigurationsResponseUnmarshaller();

        public static ListBucketAnalyticsConfigurationsResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ListBucketAnalyticsConfigurationsResponseUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
