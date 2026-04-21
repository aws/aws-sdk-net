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
    /// Response Unmarshaller for RecommendationExportJob Object
    /// </summary>  
    public class RecommendationExportJobUnmarshaller : ICborUnmarshaller<RecommendationExportJob, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public RecommendationExportJob Unmarshall(CborUnmarshallerContext context)
        {
            RecommendationExportJob unmarshalledObject = new RecommendationExportJob();
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
                    case "creationTimestamp":
                        {
                            context.AddPathSegment("CreationTimestamp");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.CreationTimestamp = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "destination":
                        {
                            context.AddPathSegment("Destination");
                            var unmarshaller = ExportDestinationUnmarshaller.Instance;
                            unmarshalledObject.Destination = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "failureReason":
                        {
                            context.AddPathSegment("FailureReason");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.FailureReason = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "jobId":
                        {
                            context.AddPathSegment("JobId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.JobId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "lastUpdatedTimestamp":
                        {
                            context.AddPathSegment("LastUpdatedTimestamp");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.LastUpdatedTimestamp = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "resourceType":
                        {
                            context.AddPathSegment("ResourceType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ResourceType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "status":
                        {
                            context.AddPathSegment("Status");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Status = unmarshaller.Unmarshall(context);
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


        private static RecommendationExportJobUnmarshaller _instance = new RecommendationExportJobUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RecommendationExportJobUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}