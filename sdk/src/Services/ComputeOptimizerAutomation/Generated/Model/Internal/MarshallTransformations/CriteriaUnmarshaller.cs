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
    /// Response Unmarshaller for Criteria Object
    /// </summary>  
    public class CriteriaUnmarshaller : ICborUnmarshaller<Criteria, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public Criteria Unmarshall(CborUnmarshallerContext context)
        {
            Criteria unmarshalledObject = new Criteria();
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
                    case "ebsVolumeSizeInGib":
                        {
                            context.AddPathSegment("EbsVolumeSizeInGib");
                            var unmarshaller = new CborListUnmarshaller<IntegerCriteriaCondition, IntegerCriteriaConditionUnmarshaller>(IntegerCriteriaConditionUnmarshaller.Instance);
                            unmarshalledObject.EbsVolumeSizeInGib = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "ebsVolumeType":
                        {
                            context.AddPathSegment("EbsVolumeType");
                            var unmarshaller = new CborListUnmarshaller<StringCriteriaCondition, StringCriteriaConditionUnmarshaller>(StringCriteriaConditionUnmarshaller.Instance);
                            unmarshalledObject.EbsVolumeType = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "estimatedMonthlySavings":
                        {
                            context.AddPathSegment("EstimatedMonthlySavings");
                            var unmarshaller = new CborListUnmarshaller<DoubleCriteriaCondition, DoubleCriteriaConditionUnmarshaller>(DoubleCriteriaConditionUnmarshaller.Instance);
                            unmarshalledObject.EstimatedMonthlySavings = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "lookBackPeriodInDays":
                        {
                            context.AddPathSegment("LookBackPeriodInDays");
                            var unmarshaller = new CborListUnmarshaller<IntegerCriteriaCondition, IntegerCriteriaConditionUnmarshaller>(IntegerCriteriaConditionUnmarshaller.Instance);
                            unmarshalledObject.LookBackPeriodInDays = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "region":
                        {
                            context.AddPathSegment("Region");
                            var unmarshaller = new CborListUnmarshaller<StringCriteriaCondition, StringCriteriaConditionUnmarshaller>(StringCriteriaConditionUnmarshaller.Instance);
                            unmarshalledObject.Region = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "resourceArn":
                        {
                            context.AddPathSegment("ResourceArn");
                            var unmarshaller = new CborListUnmarshaller<StringCriteriaCondition, StringCriteriaConditionUnmarshaller>(StringCriteriaConditionUnmarshaller.Instance);
                            unmarshalledObject.ResourceArn = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "resourceTag":
                        {
                            context.AddPathSegment("ResourceTag");
                            var unmarshaller = new CborListUnmarshaller<ResourceTagsCriteriaCondition, ResourceTagsCriteriaConditionUnmarshaller>(ResourceTagsCriteriaConditionUnmarshaller.Instance);
                            unmarshalledObject.ResourceTag = unmarshaller.Unmarshall(context);
                            context.PopPathSegment();
                            break;
                        }
                    case "restartNeeded":
                        {
                            context.AddPathSegment("RestartNeeded");
                            var unmarshaller = new CborListUnmarshaller<StringCriteriaCondition, StringCriteriaConditionUnmarshaller>(StringCriteriaConditionUnmarshaller.Instance);
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


        private static CriteriaUnmarshaller _instance = new CriteriaUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CriteriaUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}