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
 * Do not modify this file. This file is generated from the workspaces-instances-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkspacesInstances.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.WorkspacesInstances.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for SupportedInstanceConfiguration Object
    /// </summary>  
    public class SupportedInstanceConfigurationUnmarshaller : ICborUnmarshaller<SupportedInstanceConfiguration, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public SupportedInstanceConfiguration Unmarshall(CborUnmarshallerContext context)
        {
            SupportedInstanceConfiguration unmarshalledObject = new SupportedInstanceConfiguration();
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
                    case "BillingMode":
                        {
                            context.AddPathSegment("BillingMode");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.BillingMode = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "PlatformType":
                        {
                            context.AddPathSegment("PlatformType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.PlatformType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Tenancy":
                        {
                            context.AddPathSegment("Tenancy");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Tenancy = unmarshaller.Unmarshall(context);
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


        private static SupportedInstanceConfigurationUnmarshaller _instance = new SupportedInstanceConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static SupportedInstanceConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}