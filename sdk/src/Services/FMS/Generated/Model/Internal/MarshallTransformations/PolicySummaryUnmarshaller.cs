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
    /// Response Unmarshaller for PolicySummary Object
    /// </summary>  
    public class PolicySummaryUnmarshaller : ICborUnmarshaller<PolicySummary, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public PolicySummary Unmarshall(CborUnmarshallerContext context)
        {
            PolicySummary unmarshalledObject = new PolicySummary();
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
                    case "DeleteUnusedFMManagedResources":
                        {
                            context.AddPathSegment("DeleteUnusedFMManagedResources");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.DeleteUnusedFMManagedResources = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PolicyArn":
                        {
                            context.AddPathSegment("PolicyArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PolicyArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PolicyId":
                        {
                            context.AddPathSegment("PolicyId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PolicyId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PolicyName":
                        {
                            context.AddPathSegment("PolicyName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PolicyName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PolicyStatus":
                        {
                            context.AddPathSegment("PolicyStatus");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PolicyStatus = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "RemediationEnabled":
                        {
                            context.AddPathSegment("RemediationEnabled");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.RemediationEnabled = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ResourceType":
                        {
                            context.AddPathSegment("ResourceType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ResourceType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SecurityServiceType":
                        {
                            context.AddPathSegment("SecurityServiceType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.SecurityServiceType = unmarshaller.Unmarshall(context);
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


        private static PolicySummaryUnmarshaller _instance = new PolicySummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PolicySummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}