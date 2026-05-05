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
 * Do not modify this file. This file is generated from the compute-optimizer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ComputeOptimizer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.ComputeOptimizer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for LicenseConfiguration Object
    /// </summary>  
    public class LicenseConfigurationUnmarshaller : ICborUnmarshaller<LicenseConfiguration, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public LicenseConfiguration Unmarshall(CborUnmarshallerContext context)
        {
            LicenseConfiguration unmarshalledObject = new LicenseConfiguration();
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
                    case "instanceType":
                        {
                            context.AddPathSegment("InstanceType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "licenseEdition":
                        {
                            context.AddPathSegment("LicenseEdition");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LicenseEdition = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "licenseModel":
                        {
                            context.AddPathSegment("LicenseModel");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LicenseModel = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "licenseName":
                        {
                            context.AddPathSegment("LicenseName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LicenseName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "licenseVersion":
                        {
                            context.AddPathSegment("LicenseVersion");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.LicenseVersion = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "metricsSource":
                        {
                            context.AddPathSegment("MetricsSource");
                            var unmarshaller = new CborListUnmarshaller<MetricSource, MetricSourceUnmarshaller>(MetricSourceUnmarshaller.Instance);
                            unmarshalledObject.MetricsSource = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "numberOfCores":
                        {
                            context.AddPathSegment("NumberOfCores");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.NumberOfCores = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "operatingSystem":
                        {
                            context.AddPathSegment("OperatingSystem");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.OperatingSystem = unmarshaller.Unmarshall(context);
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


        private static LicenseConfigurationUnmarshaller _instance = new LicenseConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static LicenseConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}