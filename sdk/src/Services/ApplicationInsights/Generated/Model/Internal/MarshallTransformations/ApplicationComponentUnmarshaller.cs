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
 * Do not modify this file. This file is generated from the application-insights-2018-11-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationInsights.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationInsights.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ApplicationComponent Object
    /// </summary>  
    public class ApplicationComponentUnmarshaller : ICborUnmarshaller<ApplicationComponent, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ApplicationComponent Unmarshall(CborUnmarshallerContext context)
        {
            ApplicationComponent unmarshalledObject = new ApplicationComponent();
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
                    case "ComponentName":
                        {
                            context.AddPathSegment("ComponentName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ComponentName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ComponentRemarks":
                        {
                            context.AddPathSegment("ComponentRemarks");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ComponentRemarks = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "DetectedWorkload":
                        {
                            context.AddPathSegment("DetectedWorkload");
                            var unmarshaller = new CborDictionaryUnmarshaller<string, Dictionary<string, string>, CborStringUnmarshaller, CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>>(CborStringUnmarshaller.Instance, new CborDictionaryUnmarshaller<string, string, CborStringUnmarshaller, CborStringUnmarshaller>(CborStringUnmarshaller.Instance, CborStringUnmarshaller.Instance));
                            unmarshalledObject.DetectedWorkload = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Monitor":
                        {
                            context.AddPathSegment("Monitor");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.Monitor = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "OsType":
                        {
                            context.AddPathSegment("OsType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.OsType = unmarshaller.Unmarshall(context);
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
                    case "Tier":
                        {
                            context.AddPathSegment("Tier");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Tier = unmarshaller.Unmarshall(context);
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


        private static ApplicationComponentUnmarshaller _instance = new ApplicationComponentUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ApplicationComponentUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}