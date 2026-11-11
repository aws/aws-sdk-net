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

using Amazon.ElasticLoadBalancingV2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618

namespace Amazon.ElasticLoadBalancingV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Listener Object
    /// </summary>
    public partial class ListenerUnmarshaller : IXmlUnmarshaller<Listener, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Listener Unmarshall(XmlUnmarshallerContext context)
        {
            Listener unmarshalledObject = new Listener();
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
                    if (context.TestExpression("AlpnPolicy/member", targetDepth))
                    {
                        if (unmarshalledObject.AlpnPolicy == null)
                        {
                            unmarshalledObject.AlpnPolicy = new List<string>();
                        }
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AlpnPolicy.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("Certificates/member", targetDepth))
                    {
                        if (unmarshalledObject.Certificates == null)
                        {
                            unmarshalledObject.Certificates = new List<Certificate>();
                        }
                        var unmarshaller = CertificateUnmarshaller.Instance;
                        unmarshalledObject.Certificates.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("DefaultActions/member", targetDepth))
                    {
                        if (unmarshalledObject.DefaultActions == null)
                        {
                            unmarshalledObject.DefaultActions = new List<Action>();
                        }
                        var unmarshaller = ActionUnmarshaller.Instance;
                        unmarshalledObject.DefaultActions.Add(unmarshaller.Unmarshall(context));
                        continue;
                    }

                    if (context.TestExpression("ListenerArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ListenerArn = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("LoadBalancerArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LoadBalancerArn = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("MutualAuthentication", targetDepth))
                    {
                        var unmarshaller = MutualAuthenticationAttributesUnmarshaller.Instance;
                        unmarshalledObject.MutualAuthentication = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Port", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.Port = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("Protocol", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Protocol = unmarshaller.Unmarshall(context);
                        continue;
                    }

                    if (context.TestExpression("SslPolicy", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.SslPolicy = unmarshaller.Unmarshall(context);
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

        private static ListenerUnmarshaller _instance = new ListenerUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ListenerUnmarshaller Instance => _instance;
    }
}
