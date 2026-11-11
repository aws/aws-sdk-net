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

using Amazon.Redshift.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EventCategoriesMap Object
    /// </summary>
    public partial class EventCategoriesMapUnmarshaller : IXmlUnmarshaller<EventCategoriesMap, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public EventCategoriesMap Unmarshall(XmlUnmarshallerContext context)
        {
            EventCategoriesMap unmarshalledObject = new EventCategoriesMap();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument)
            {
                targetDepth += 2;
            }

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Events/EventInfoMap", targetDepth))
                    {
                        if (unmarshalledObject.Events == null)
                        {
                            unmarshalledObject.Events = new List<EventInfoMap>();
                        }
                        var unmarshaller = EventInfoMapUnmarshaller.Instance;
                        unmarshalledObject.Events.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("SourceType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SourceType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        private static EventCategoriesMapUnmarshaller _instance = new EventCategoriesMapUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static EventCategoriesMapUnmarshaller Instance => _instance;
    }
}
