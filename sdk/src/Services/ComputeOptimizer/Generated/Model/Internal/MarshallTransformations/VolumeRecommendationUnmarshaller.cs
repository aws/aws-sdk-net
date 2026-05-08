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
    /// Response Unmarshaller for VolumeRecommendation Object
    /// </summary>  
    public class VolumeRecommendationUnmarshaller : ICborUnmarshaller<VolumeRecommendation, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public VolumeRecommendation Unmarshall(CborUnmarshallerContext context)
        {
            VolumeRecommendation unmarshalledObject = new VolumeRecommendation();
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
                    case "accountId":
                        {
                            context.AddPathSegment("AccountId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.AccountId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "currentConfiguration":
                        {
                            context.AddPathSegment("CurrentConfiguration");
                            var unmarshaller = VolumeConfigurationUnmarshaller.Instance;
                            unmarshalledObject.CurrentConfiguration = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "currentPerformanceRisk":
                        {
                            context.AddPathSegment("CurrentPerformanceRisk");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CurrentPerformanceRisk = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "effectiveRecommendationPreferences":
                        {
                            context.AddPathSegment("EffectiveRecommendationPreferences");
                            var unmarshaller = EBSEffectiveRecommendationPreferencesUnmarshaller.Instance;
                            unmarshalledObject.EffectiveRecommendationPreferences = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "finding":
                        {
                            context.AddPathSegment("Finding");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Finding = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "lastRefreshTimestamp":
                        {
                            context.AddPathSegment("LastRefreshTimestamp");
                            var unmarshaller = CborNullableDateTimeUnmarshaller.Instance;
                            unmarshalledObject.LastRefreshTimestamp = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "lookBackPeriodInDays":
                        {
                            context.AddPathSegment("LookBackPeriodInDays");
                            var unmarshaller = CborNullableDoubleUnmarshaller.Instance;
                            unmarshalledObject.LookBackPeriodInDays = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "tags":
                        {
                            context.AddPathSegment("Tags");
                            var unmarshaller = new CborListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                            unmarshalledObject.Tags = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "utilizationMetrics":
                        {
                            context.AddPathSegment("UtilizationMetrics");
                            var unmarshaller = new CborListUnmarshaller<EBSUtilizationMetric, EBSUtilizationMetricUnmarshaller>(EBSUtilizationMetricUnmarshaller.Instance);
                            unmarshalledObject.UtilizationMetrics = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "volumeArn":
                        {
                            context.AddPathSegment("VolumeArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.VolumeArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "volumeRecommendationOptions":
                        {
                            context.AddPathSegment("VolumeRecommendationOptions");
                            var unmarshaller = new CborListUnmarshaller<VolumeRecommendationOption, VolumeRecommendationOptionUnmarshaller>(VolumeRecommendationOptionUnmarshaller.Instance);
                            unmarshalledObject.VolumeRecommendationOptions = unmarshaller.Unmarshall(context);
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


        private static VolumeRecommendationUnmarshaller _instance = new VolumeRecommendationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static VolumeRecommendationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}