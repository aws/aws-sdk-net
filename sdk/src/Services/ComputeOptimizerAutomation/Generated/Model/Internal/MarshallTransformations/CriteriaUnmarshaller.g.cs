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
    /// Response Unmarshaller for Criteria Object
    /// </summary>
    public partial class CriteriaUnmarshaller : ICborUnmarshaller<Criteria, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Criteria Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new Criteria();
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
                    case "ebsVolumeSizeInGib":
                        context.AddPathSegment("EbsVolumeSizeInGib");
                        unmarshalledObject.EbsVolumeSizeInGib = new CborListUnmarshaller<IntegerCriteriaCondition, IntegerCriteriaConditionUnmarshaller>(IntegerCriteriaConditionUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ebsVolumeType":
                        context.AddPathSegment("EbsVolumeType");
                        unmarshalledObject.EbsVolumeType = new CborListUnmarshaller<StringCriteriaCondition, StringCriteriaConditionUnmarshaller>(StringCriteriaConditionUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "estimatedMonthlySavings":
                        context.AddPathSegment("EstimatedMonthlySavings");
                        unmarshalledObject.EstimatedMonthlySavings = new CborListUnmarshaller<DoubleCriteriaCondition, DoubleCriteriaConditionUnmarshaller>(DoubleCriteriaConditionUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "lookBackPeriodInDays":
                        context.AddPathSegment("LookBackPeriodInDays");
                        unmarshalledObject.LookBackPeriodInDays = new CborListUnmarshaller<IntegerCriteriaCondition, IntegerCriteriaConditionUnmarshaller>(IntegerCriteriaConditionUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "region":
                        context.AddPathSegment("Region");
                        unmarshalledObject.Region = new CborListUnmarshaller<StringCriteriaCondition, StringCriteriaConditionUnmarshaller>(StringCriteriaConditionUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "resourceArn":
                        context.AddPathSegment("ResourceArn");
                        unmarshalledObject.ResourceArn = new CborListUnmarshaller<StringCriteriaCondition, StringCriteriaConditionUnmarshaller>(StringCriteriaConditionUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "resourceTag":
                        context.AddPathSegment("ResourceTag");
                        unmarshalledObject.ResourceTag = new CborListUnmarshaller<ResourceTagsCriteriaCondition, ResourceTagsCriteriaConditionUnmarshaller>(ResourceTagsCriteriaConditionUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "restartNeeded":
                        context.AddPathSegment("RestartNeeded");
                        unmarshalledObject.RestartNeeded = new CborListUnmarshaller<StringCriteriaCondition, StringCriteriaConditionUnmarshaller>(StringCriteriaConditionUnmarshaller.Instance).Unmarshall(context);
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

        private static CriteriaUnmarshaller _instance = new CriteriaUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CriteriaUnmarshaller Instance => _instance;
    }
}
