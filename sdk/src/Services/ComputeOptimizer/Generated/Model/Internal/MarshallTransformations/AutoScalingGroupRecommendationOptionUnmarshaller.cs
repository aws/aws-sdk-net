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
    /// Response Unmarshaller for AutoScalingGroupRecommendationOption Object
    /// </summary>  
    public class AutoScalingGroupRecommendationOptionUnmarshaller : ICborUnmarshaller<AutoScalingGroupRecommendationOption, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public AutoScalingGroupRecommendationOption Unmarshall(CborUnmarshallerContext context)
        {
            AutoScalingGroupRecommendationOption unmarshalledObject = new AutoScalingGroupRecommendationOption();
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
                    case "configuration":
                        {
                            context.AddPathSegment("Configuration");
                            var unmarshaller = AutoScalingGroupConfigurationUnmarshaller.Instance;
                            unmarshalledObject.Configuration = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "instanceGpuInfo":
                        {
                            context.AddPathSegment("InstanceGpuInfo");
                            var unmarshaller = GpuInfoUnmarshaller.Instance;
                            unmarshalledObject.InstanceGpuInfo = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "migrationEffort":
                        {
                            context.AddPathSegment("MigrationEffort");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.MigrationEffort = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "performanceRisk":
                        {
                            context.AddPathSegment("PerformanceRisk");
                            var unmarshaller = CborNullableDoubleUnmarshaller.Instance;
                            unmarshalledObject.PerformanceRisk = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "projectedUtilizationMetrics":
                        {
                            context.AddPathSegment("ProjectedUtilizationMetrics");
                            var unmarshaller = new CborListUnmarshaller<UtilizationMetric, UtilizationMetricUnmarshaller>(UtilizationMetricUnmarshaller.Instance);
                            unmarshalledObject.ProjectedUtilizationMetrics = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "rank":
                        {
                            context.AddPathSegment("Rank");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.Rank = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "savingsOpportunity":
                        {
                            context.AddPathSegment("SavingsOpportunity");
                            var unmarshaller = SavingsOpportunityUnmarshaller.Instance;
                            unmarshalledObject.SavingsOpportunity = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "savingsOpportunityAfterDiscounts":
                        {
                            context.AddPathSegment("SavingsOpportunityAfterDiscounts");
                            var unmarshaller = AutoScalingGroupSavingsOpportunityAfterDiscountsUnmarshaller.Instance;
                            unmarshalledObject.SavingsOpportunityAfterDiscounts = unmarshaller.Unmarshall(context);
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


        private static AutoScalingGroupRecommendationOptionUnmarshaller _instance = new AutoScalingGroupRecommendationOptionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AutoScalingGroupRecommendationOptionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}