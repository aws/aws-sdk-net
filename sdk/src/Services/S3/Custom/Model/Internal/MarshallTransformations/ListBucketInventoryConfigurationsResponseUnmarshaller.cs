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
    ///    Response Unmarshaller for ListInventoryConfiguration operation
    /// </summary>
    public class ListBucketInventoryConfigurationsResponseUnmarshaller : S3ReponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            ListBucketInventoryConfigurationsResponse response = new ListBucketInventoryConfigurationsResponse();

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

        private static void UnmarshallResult(XmlUnmarshallerContext context, ListBucketInventoryConfigurationsResponse response)
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
                        response.Token = StringUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }

                    if (context.TestExpression("InventoryConfiguration", targetDepth))
                    {
                        if (response.InventoryConfigurationList == null)
                        {
                            response.InventoryConfigurationList = new List<InventoryConfiguration>();
                        }
                        response.InventoryConfigurationList.Add(InventoryConfigurationUnmarshaller.Instance.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("IsTruncated", targetDepth))
                    {
                        response.IsTruncated = BoolUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("NextContinuationToken", targetDepth))
                    {
                        response.NextToken = StringUnmarshaller.Instance.Unmarshall(context);

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

        private static ListBucketInventoryConfigurationsResponseUnmarshaller _instance = new ListBucketInventoryConfigurationsResponseUnmarshaller();

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static ListBucketInventoryConfigurationsResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ListBucketInventoryConfigurationsResponseUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
