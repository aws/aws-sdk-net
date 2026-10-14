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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AWSHealth.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.AWSHealth.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ServiceLifecycle Object
    /// </summary>  
    public class ServiceLifecycleUnmarshaller : ICborUnmarshaller<ServiceLifecycle, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ServiceLifecycle Unmarshall(CborUnmarshallerContext context)
        {
            ServiceLifecycle unmarshalledObject = new ServiceLifecycle();
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
                    case "lifecycleEvents":
                        {
                            context.AddPathSegment("LifecycleEvents");
                            var unmarshaller = new CborListUnmarshaller<LifecycleEvent, LifecycleEventUnmarshaller>(LifecycleEventUnmarshaller.Instance);
                            unmarshalledObject.LifecycleEvents = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "recommendedVersion":
                        {
                            context.AddPathSegment("RecommendedVersion");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.RecommendedVersion = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "service":
                        {
                            context.AddPathSegment("Service");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Service = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "title":
                        {
                            context.AddPathSegment("Title");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Title = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "version":
                        {
                            context.AddPathSegment("Version");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Version = unmarshaller.Unmarshall(context);
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


        private static ServiceLifecycleUnmarshaller _instance = new ServiceLifecycleUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ServiceLifecycleUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}