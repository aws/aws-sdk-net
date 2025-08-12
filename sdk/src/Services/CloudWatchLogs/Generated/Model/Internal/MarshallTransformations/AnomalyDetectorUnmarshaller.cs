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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatchLogs.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations
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
                    case "anomalyDetectorArn":
                        {
                            context.AddPathSegment("AnomalyDetectorArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AnomalyDetectorArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "anomalyDetectorStatus":
                        {
                            context.AddPathSegment("AnomalyDetectorStatus");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AnomalyDetectorStatus = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "anomalyVisibilityTime":
                        {
                            context.AddPathSegment("AnomalyVisibilityTime");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.AnomalyVisibilityTime = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "creationTimeStamp":
                        {
                            context.AddPathSegment("CreationTimeStamp");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.CreationTimeStamp = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "detectorName":
                        {
                            context.AddPathSegment("DetectorName");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.DetectorName = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "evaluationFrequency":
                        {
                            context.AddPathSegment("EvaluationFrequency");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.EvaluationFrequency = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "filterPattern":
                        {
                            context.AddPathSegment("FilterPattern");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.FilterPattern = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "kmsKeyId":
                        {
                            context.AddPathSegment("KmsKeyId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.KmsKeyId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "lastModifiedTimeStamp":
                        {
                            context.AddPathSegment("LastModifiedTimeStamp");
                            var unmarshaller = CborNullableLongUnmarshaller.Instance;
                            unmarshalledObject.LastModifiedTimeStamp = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "logGroupArnList":
                        {
                            context.AddPathSegment("LogGroupArnList");
                            var unmarshaller = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance);
                            unmarshalledObject.LogGroupArnList = unmarshaller.Unmarshall(context);
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