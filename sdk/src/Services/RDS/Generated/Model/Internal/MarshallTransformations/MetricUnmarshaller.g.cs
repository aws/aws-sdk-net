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

using Amazon.RDS.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Metric Object
    /// </summary>
    public partial class MetricUnmarshaller : IXmlUnmarshaller<Metric, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Metric Unmarshall(XmlUnmarshallerContext context)
        {
            Metric unmarshalledObject = new Metric();
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
                    if (context.TestExpression("MetricQuery", targetDepth))
                    {
                        var unmarshaller = MetricQueryUnmarshaller.Instance;
                        unmarshalledObject.MetricQuery = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Name", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("References/member", targetDepth))
                    {
                        if (unmarshalledObject.References == null)
                        {
                            unmarshalledObject.References = new List<MetricReference>();
                        }
                        var unmarshaller = MetricReferenceUnmarshaller.Instance;
                        unmarshalledObject.References.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("StatisticsDetails", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StatisticsDetails = unmarshaller.Unmarshall(context);
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

        private static MetricUnmarshaller _instance = new MetricUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static MetricUnmarshaller Instance => _instance;
    }
}
