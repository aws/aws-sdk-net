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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AnomalyDetector Object
    /// </summary>  
    public class AnomalyDetectorUnmarshaller : ICborUnmarshaller<AnomalyDetector, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AnomalyDetector Unmarshall(CborUnmarshallerContext context)
        {
            AnomalyDetector unmarshalledObject = new AnomalyDetector();
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
                    case "Configuration":
                        {
                            context.AddPathSegment("Configuration");
                            var unmarshaller = AnomalyDetectorConfigurationUnmarshaller.Instance;
                            unmarshalledObject.Configuration = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Dimensions":
                        {
                            context.AddPathSegment("Dimensions");
                            var unmarshaller = new CborListUnmarshaller<Dimension, DimensionUnmarshaller>(DimensionUnmarshaller.Instance);
                            unmarshalledObject.Dimensions = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MetricCharacteristics":
                        {
                            context.AddPathSegment("MetricCharacteristics");
                            var unmarshaller = MetricCharacteristicsUnmarshaller.Instance;
                            unmarshalledObject.MetricCharacteristics = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MetricMathAnomalyDetector":
                        {
                            context.AddPathSegment("MetricMathAnomalyDetector");
                            var unmarshaller = MetricMathAnomalyDetectorUnmarshaller.Instance;
                            unmarshalledObject.MetricMathAnomalyDetector = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "MetricName":
                        {
                            context.AddPathSegment("MetricName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.MetricName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Namespace":
                        {
                            context.AddPathSegment("Namespace");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Namespace = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "SingleMetricAnomalyDetector":
                        {
                            context.AddPathSegment("SingleMetricAnomalyDetector");
                            var unmarshaller = SingleMetricAnomalyDetectorUnmarshaller.Instance;
                            unmarshalledObject.SingleMetricAnomalyDetector = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "Stat":
                        {
                            context.AddPathSegment("Stat");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Stat = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "StateValue":
                        {
                            context.AddPathSegment("StateValue");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.StateValue = unmarshaller.Unmarshall(context);
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


        private static AnomalyDetectorUnmarshaller _instance = new AnomalyDetectorUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AnomalyDetectorUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}