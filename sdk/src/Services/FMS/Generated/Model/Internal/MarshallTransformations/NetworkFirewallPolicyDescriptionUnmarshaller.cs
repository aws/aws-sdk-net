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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.FMS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.FMS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for NetworkFirewallPolicyDescription Object
    /// </summary>  
    public class NetworkFirewallPolicyDescriptionUnmarshaller : ICborUnmarshaller<NetworkFirewallPolicyDescription, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public NetworkFirewallPolicyDescription Unmarshall(CborUnmarshallerContext context)
        {
            NetworkFirewallPolicyDescription unmarshalledObject = new NetworkFirewallPolicyDescription();
            if (context.IsEmptyResponse)
                return null;
            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                string propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "StatefulDefaultActions":
                        {
                            context.AddPathSegment("StatefulDefaultActions");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.StatefulDefaultActions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StatefulEngineOptions":
                        {
                            context.AddPathSegment("StatefulEngineOptions");
                            var unmarshaller = StatefulEngineOptionsUnmarshaller.Instance;
                            unmarshalledObject.StatefulEngineOptions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StatefulRuleGroups":
                        {
                            context.AddPathSegment("StatefulRuleGroups");
                            var unmarshaller = new CborListUnmarshaller<StatefulRuleGroup, StatefulRuleGroupUnmarshaller>(StatefulRuleGroupUnmarshaller.Instance);
                            unmarshalledObject.StatefulRuleGroups = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StatelessCustomActions":
                        {
                            context.AddPathSegment("StatelessCustomActions");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.StatelessCustomActions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StatelessDefaultActions":
                        {
                            context.AddPathSegment("StatelessDefaultActions");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.StatelessDefaultActions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StatelessFragmentDefaultActions":
                        {
                            context.AddPathSegment("StatelessFragmentDefaultActions");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.StatelessFragmentDefaultActions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StatelessRuleGroups":
                        {
                            context.AddPathSegment("StatelessRuleGroups");
                            var unmarshaller = new CborListUnmarshaller<StatelessRuleGroup, StatelessRuleGroupUnmarshaller>(StatelessRuleGroupUnmarshaller.Instance);
                            unmarshalledObject.StatelessRuleGroups = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            return unmarshalledObject;
        }


        private static NetworkFirewallPolicyDescriptionUnmarshaller _instance = new NetworkFirewallPolicyDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static NetworkFirewallPolicyDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}