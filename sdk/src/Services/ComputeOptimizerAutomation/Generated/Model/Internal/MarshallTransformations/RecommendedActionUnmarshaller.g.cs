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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.ComputeOptimizerAutomation.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.ComputeOptimizerAutomation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for RecommendedAction Object
    /// </summary>
    public partial class RecommendedActionUnmarshaller : ICborUnmarshaller<RecommendedAction, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public RecommendedAction Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new RecommendedAction();
            if (context.IsEmptyResponse) return null;

            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "accountId":
                        context.AddPathSegment("AccountId");
                        unmarshalledObject.AccountId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "currentResourceDetails":
                        context.AddPathSegment("CurrentResourceDetails");
                        unmarshalledObject.CurrentResourceDetails = ResourceDetailsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "currentResourceSummary":
                        context.AddPathSegment("CurrentResourceSummary");
                        unmarshalledObject.CurrentResourceSummary = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "estimatedMonthlySavings":
                        context.AddPathSegment("EstimatedMonthlySavings");
                        unmarshalledObject.EstimatedMonthlySavings = EstimatedMonthlySavingsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "lookBackPeriodInDays":
                        context.AddPathSegment("LookBackPeriodInDays");
                        unmarshalledObject.LookBackPeriodInDays = CborNullableIntUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "recommendedActionId":
                        context.AddPathSegment("RecommendedActionId");
                        unmarshalledObject.RecommendedActionId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "recommendedActionType":
                        context.AddPathSegment("RecommendedActionType");
                        unmarshalledObject.RecommendedActionType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "recommendedResourceDetails":
                        context.AddPathSegment("RecommendedResourceDetails");
                        unmarshalledObject.RecommendedResourceDetails = ResourceDetailsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "recommendedResourceSummary":
                        context.AddPathSegment("RecommendedResourceSummary");
                        unmarshalledObject.RecommendedResourceSummary = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "region":
                        context.AddPathSegment("Region");
                        unmarshalledObject.Region = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "resourceArn":
                        context.AddPathSegment("ResourceArn");
                        unmarshalledObject.ResourceArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "resourceId":
                        context.AddPathSegment("ResourceId");
                        unmarshalledObject.ResourceId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "resourceTags":
                        context.AddPathSegment("ResourceTags");
                        unmarshalledObject.ResourceTags = new CborListUnmarshaller<Tag, TagUnmarshaller>(TagUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "resourceType":
                        context.AddPathSegment("ResourceType");
                        unmarshalledObject.ResourceType = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "restartNeeded":
                        context.AddPathSegment("RestartNeeded");
                        unmarshalledObject.RestartNeeded = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            return unmarshalledObject;
        }

        private static RecommendedActionUnmarshaller _instance = new RecommendedActionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static RecommendedActionUnmarshaller Instance => _instance;
    }
}
