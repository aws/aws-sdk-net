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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TrafficMirrorFilter Object
    /// </summary>  
    public class TrafficMirrorFilterUnmarshaller : IXmlUnmarshaller<TrafficMirrorFilter, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public TrafficMirrorFilter Unmarshall(XmlUnmarshallerContext context)
        {
            TrafficMirrorFilter unmarshalledObject = new TrafficMirrorFilter();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("egressFilterRuleSet/item", targetDepth))
                    {
                        var unmarshaller = TrafficMirrorFilterRuleUnmarshaller.Instance;
                        if (unmarshalledObject.EgressFilterRules == null)
                        {
                            unmarshalledObject.EgressFilterRules = new List<TrafficMirrorFilterRule>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.EgressFilterRules.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ingressFilterRuleSet/item", targetDepth))
                    {
                        var unmarshaller = TrafficMirrorFilterRuleUnmarshaller.Instance;
                        if (unmarshalledObject.IngressFilterRules == null)
                        {
                            unmarshalledObject.IngressFilterRules = new List<TrafficMirrorFilterRule>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.IngressFilterRules.Add(item);
                        continue;
                    }
                    if (context.TestExpression("networkServiceSet/item", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.NetworkServices == null)
                        {
                            unmarshalledObject.NetworkServices = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.NetworkServices.Add(item);
                        continue;
                    }
                    if (context.TestExpression("tagSet/item", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        if (unmarshalledObject.Tags == null)
                        {
                            unmarshalledObject.Tags = new List<Tag>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Tags.Add(item);
                        continue;
                    }
                    if (context.TestExpression("trafficMirrorFilterId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TrafficMirrorFilterId = unmarshaller.Unmarshall(context);
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

        private static TrafficMirrorFilterUnmarshaller _instance = new TrafficMirrorFilterUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TrafficMirrorFilterUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}