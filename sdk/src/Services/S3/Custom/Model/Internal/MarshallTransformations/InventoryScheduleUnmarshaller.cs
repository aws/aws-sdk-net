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
    ///   InventorySchedule Unmarshaller
    /// </summary>
    public class InventoryScheduleUnmarshaller : IUnmarshaller<InventorySchedule, XmlUnmarshallerContext>, IUnmarshaller<InventorySchedule, JsonUnmarshallerContext> 
    {
        public InventorySchedule Unmarshall(XmlUnmarshallerContext context)
        {
            InventorySchedule condition = new InventorySchedule();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            if (context.IsStartOfDocument)
                targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Frequency", targetDepth))
                    {

                        condition.Frequency = InventoryFrequency.FindValue(StringUnmarshaller.GetInstance().Unmarshall(context));

                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return condition;
                }
            }

            return condition;
        }

        public InventorySchedule Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }

        private static InventoryScheduleUnmarshaller _instance;

        public static InventoryScheduleUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new InventoryScheduleUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
