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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchOmni.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchOmni.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OrganizationAccessGrantSummary Object
    /// </summary>  
    public class OrganizationAccessGrantSummaryUnmarshaller : ICborUnmarshaller<OrganizationAccessGrantSummary, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public OrganizationAccessGrantSummary Unmarshall(CborUnmarshallerContext context)
        {
            OrganizationAccessGrantSummary unmarshalledObject = new OrganizationAccessGrantSummary();
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
                    case "createdAt":
                        {
                            context.AddPathSegment("CreatedAt");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "domainId":
                        {
                            context.AddPathSegment("DomainId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.DomainId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "grantArn":
                        {
                            context.AddPathSegment("GrantArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GrantArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "grantId":
                        {
                            context.AddPathSegment("GrantId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GrantId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "grantType":
                        {
                            context.AddPathSegment("GrantType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.GrantType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "name":
                        {
                            context.AddPathSegment("Name");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "permission":
                        {
                            context.AddPathSegment("Permission");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Permission = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "principal":
                        {
                            context.AddPathSegment("Principal");
                            var unmarshaller = OrganizationAccessGrantPrincipalUnmarshaller.Instance;
                            unmarshalledObject.Principal = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "updatedAt":
                        {
                            context.AddPathSegment("UpdatedAt");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.UpdatedAt = unmarshaller.Unmarshall(context);
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


        private static OrganizationAccessGrantSummaryUnmarshaller _instance = new OrganizationAccessGrantSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OrganizationAccessGrantSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}