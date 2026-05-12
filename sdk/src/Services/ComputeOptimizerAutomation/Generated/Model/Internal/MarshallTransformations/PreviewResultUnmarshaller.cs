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
 * Do not modify this file. This file is generated from the compute-optimizer-automation-2025-09-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ComputeOptimizerAutomation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;
#pragma warning disable CS0612,CS0618
namespace Amazon.ComputeOptimizerAutomation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PreviewResult Object
    /// </summary>  
    public class PreviewResultUnmarshaller : ICborUnmarshaller<PreviewResult, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public PreviewResult Unmarshall(CborUnmarshallerContext context)
        {
            PreviewResult unmarshalledObject = new PreviewResult();
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
                    case "currentResourceDetails":
                        {
                            context.AddPathSegment("CurrentResourceDetails");
                            var unmarshaller = ResourceDetailsUnmarshaller.Instance;
                            unmarshalledObject.CurrentResourceDetails = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "currentResourceSummary":
                        {
                            context.AddPathSegment("CurrentResourceSummary");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.CurrentResourceSummary = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "estimatedMonthlySavings":
                        {
                            context.AddPathSegment("EstimatedMonthlySavings");
                            var unmarshaller = EstimatedMonthlySavingsUnmarshaller.Instance;
                            unmarshalledObject.EstimatedMonthlySavings = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "lookBackPeriodInDays":
                        {
                            context.AddPathSegment("LookBackPeriodInDays");
                            var unmarshaller = CborNullableIntUnmarshaller.Instance;
                            unmarshalledObject.LookBackPeriodInDays = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "recommendedActionId":
                        {
                            context.AddPathSegment("RecommendedActionId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.RecommendedActionId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "recommendedActionType":
                        {
                            context.AddPathSegment("RecommendedActionType");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.RecommendedActionType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "recommendedResourceDetails":
                        {
                            context.AddPathSegment("RecommendedResourceDetails");
                            var unmarshaller = ResourceDetailsUnmarshaller.Instance;
                            unmarshalledObject.RecommendedResourceDetails = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "recommendedResourceSummary":
                        {
                            context.AddPathSegment("RecommendedResourceSummary");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.RecommendedResourceSummary = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "region":
                        {
                            context.AddPathSegment("Region");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.Region = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "resourceArn":
                        {
                            context.AddPathSegment("ResourceArn");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ResourceArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "resourceId":
                        {
                            context.AddPathSegment("ResourceId");
                            var unmarshaller = CborStringUnmarshaller.Instance;
                            unmarshalledObject.ResourceId = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "resourceTags":
                        {
                            context.AddPathSegment("ResourceTags");
                            var unmarshaller = new CborListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance);
                            unmarshalledObject.ResourceTags = unmarshaller.Unmarshall(context);
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
                    case "restartNeeded":
                        {
                            context.AddPathSegment("RestartNeeded");
                            var unmarshaller = CborNullableBoolUnmarshaller.Instance;
                            unmarshalledObject.RestartNeeded = unmarshaller.Unmarshall(context);
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


        private static PreviewResultUnmarshaller _instance = new PreviewResultUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PreviewResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}