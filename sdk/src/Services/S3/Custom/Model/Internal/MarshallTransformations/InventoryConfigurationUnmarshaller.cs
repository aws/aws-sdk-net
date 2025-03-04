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
using System.Collections.Generic;

using Amazon.S3.Model;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///   InventoryConfiguration Unmarshaller
    /// </summary>
    public class InventoryConfigurationUnmarshaller : IXmlUnmarshaller<InventoryConfiguration, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public InventoryConfiguration Unmarshall(XmlUnmarshallerContext context)
        {
            InventoryConfiguration response = new InventoryConfiguration();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Destination", targetDepth))
                    {
                        response.Destination = InventoryDestinationUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("IsEnabled", targetDepth))
                    {
                        response.IsEnabled = BoolUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("Filter", targetDepth))
                    {
                        response.InventoryFilter = InventoryFilterUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("Id", targetDepth))
                    {
                        response.InventoryId = StringUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                    if (context.TestExpression("IncludedObjectVersions", targetDepth))
                    {
                        response.IncludedObjectVersions = InventoryIncludedObjectVersions.FindValue(StringUnmarshaller.Instance.Unmarshall(context));

                        continue;
                    }
                    if (context.TestExpression("Field", targetDepth + 1))
                    {
                        if (response.InventoryOptionalFields == null)
                        {
                            response.InventoryOptionalFields = new List<InventoryOptionalField>();
                        }
                        response.InventoryOptionalFields.Add(InventoryOptionalField.FindValue(StringUnmarshaller.Instance.Unmarshall(context)));
                        continue;
                    }
                    if (context.TestExpression("Schedule", targetDepth))
                    {
                        response.Schedule = InventoryScheduleUnmarshaller.Instance.Unmarshall(context);

                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return response;
                }
            }



            return response;
        }


        private static InventoryConfigurationUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static InventoryConfigurationUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new InventoryConfigurationUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
