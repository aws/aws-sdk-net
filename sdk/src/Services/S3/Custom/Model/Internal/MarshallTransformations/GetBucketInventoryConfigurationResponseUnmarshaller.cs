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

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for GetInventoryConfiguration operation
    /// </summary>
    public class GetBucketInventoryConfigurationResponseUnmarshaller : S3ReponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            GetBucketInventoryConfigurationResponse response = new GetBucketInventoryConfigurationResponse();

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

        private static void UnmarshallResult(XmlUnmarshallerContext context, GetBucketInventoryConfigurationResponse response)
        {

            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            response.InventoryConfiguration = new InventoryConfiguration();

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Destination", targetDepth))
                    {
                        response.InventoryConfiguration.Destination = InventoryDestinationUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("IsEnabled", targetDepth))
                    {
                        response.InventoryConfiguration.IsEnabled = BoolUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("Filter", targetDepth))
                    {
                        response.InventoryConfiguration.InventoryFilter = InventoryFilterUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("Id", targetDepth))
                    {
                        response.InventoryConfiguration.InventoryId = StringUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("IncludedObjectVersions", targetDepth))
                    {
                        response.InventoryConfiguration.IncludedObjectVersions = StringUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("Field", targetDepth + 1))
                    {
                        if (response.InventoryConfiguration.InventoryOptionalFields == null)
                        {
                            response.InventoryConfiguration.InventoryOptionalFields = new List<InventoryOptionalField>();
                        }
                        response.InventoryConfiguration.InventoryOptionalFields.Add(StringUnmarshaller.Instance.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("Schedule", targetDepth))
                    {
                        response.InventoryConfiguration.Schedule = InventoryScheduleUnmarshaller.Instance.Unmarshall(context);

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

        private static GetBucketInventoryConfigurationResponseUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static GetBucketInventoryConfigurationResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GetBucketInventoryConfigurationResponseUnmarshaller();
                }
                return _instance;
            }
        }

    }
}
