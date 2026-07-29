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
    /// Response Unmarshaller for Workload Object
    /// </summary>  
    public class WorkloadUnmarshaller : ICborUnmarshaller<Workload, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Workload Unmarshall(CborUnmarshallerContext context)
        {
            Workload unmarshalledObject = new Workload();
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
                    case "MissingWorkloadConfig":
                        {
                            context.AddPathSegment("MissingWorkloadConfig");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.MissingWorkloadConfig = unmarshaller.Unmarshall(context);
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
                    case "WorkloadId":
                        {
                            context.AddPathSegment("WorkloadId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.WorkloadId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "WorkloadName":
                        {
                            context.AddPathSegment("WorkloadName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.WorkloadName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "WorkloadRemarks":
                        {
                            context.AddPathSegment("WorkloadRemarks");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.WorkloadRemarks = unmarshaller.Unmarshall(context);
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


        private static WorkloadUnmarshaller _instance = new WorkloadUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static WorkloadUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}