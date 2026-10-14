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
    /// Response Unmarshaller for AdminScope Object
    /// </summary>  
    public class AdminScopeUnmarshaller : ICborUnmarshaller<AdminScope, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AdminScope Unmarshall(CborUnmarshallerContext context)
        {
            AdminScope unmarshalledObject = new AdminScope();
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
                    case "AccountScope":
                        {
                            context.AddPathSegment("AccountScope");
                            var unmarshaller = AccountScopeUnmarshaller.Instance;
                            unmarshalledObject.AccountScope = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "OrganizationalUnitScope":
                        {
                            context.AddPathSegment("OrganizationalUnitScope");
                            var unmarshaller = OrganizationalUnitScopeUnmarshaller.Instance;
                            unmarshalledObject.OrganizationalUnitScope = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PolicyTypeScope":
                        {
                            context.AddPathSegment("PolicyTypeScope");
                            var unmarshaller = PolicyTypeScopeUnmarshaller.Instance;
                            unmarshalledObject.PolicyTypeScope = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "RegionScope":
                        {
                            context.AddPathSegment("RegionScope");
                            var unmarshaller = RegionScopeUnmarshaller.Instance;
                            unmarshalledObject.RegionScope = unmarshaller.Unmarshall(context);
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


        private static AdminScopeUnmarshaller _instance = new AdminScopeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AdminScopeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}