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
    /// Response Unmarshaller for SecurityGroupRuleDescription Object
    /// </summary>  
    public class SecurityGroupRuleDescriptionUnmarshaller : ICborUnmarshaller<SecurityGroupRuleDescription, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SecurityGroupRuleDescription Unmarshall(CborUnmarshallerContext context)
        {
            SecurityGroupRuleDescription unmarshalledObject = new SecurityGroupRuleDescription();
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
                    case "FromPort":
                        {
                            context.AddPathSegment("FromPort");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.FromPort = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "IPV4Range":
                        {
                            context.AddPathSegment("IPV4Range");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.IPV4Range = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "IPV6Range":
                        {
                            context.AddPathSegment("IPV6Range");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.IPV6Range = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PrefixListId":
                        {
                            context.AddPathSegment("PrefixListId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PrefixListId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Protocol":
                        {
                            context.AddPathSegment("Protocol");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Protocol = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ToPort":
                        {
                            context.AddPathSegment("ToPort");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.ToPort = unmarshaller.Unmarshall(context);
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


        private static SecurityGroupRuleDescriptionUnmarshaller _instance = new SecurityGroupRuleDescriptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SecurityGroupRuleDescriptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}