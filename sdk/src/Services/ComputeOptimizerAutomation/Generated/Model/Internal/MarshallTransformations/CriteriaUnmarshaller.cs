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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.ComputeOptimizerAutomation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Criteria Object
    /// </summary>  
    public class CriteriaUnmarshaller : IJsonUnmarshaller<Criteria, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Criteria Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Criteria unmarshalledObject = new Criteria();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("ebsVolumeSizeInGib", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<IntegerCriteriaCondition, IntegerCriteriaConditionUnmarshaller>(IntegerCriteriaConditionUnmarshaller.Instance);
                    unmarshalledObject.EbsVolumeSizeInGib = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ebsVolumeType", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringCriteriaCondition, StringCriteriaConditionUnmarshaller>(StringCriteriaConditionUnmarshaller.Instance);
                    unmarshalledObject.EbsVolumeType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("estimatedMonthlySavings", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<DoubleCriteriaCondition, DoubleCriteriaConditionUnmarshaller>(DoubleCriteriaConditionUnmarshaller.Instance);
                    unmarshalledObject.EstimatedMonthlySavings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lookBackPeriodInDays", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<IntegerCriteriaCondition, IntegerCriteriaConditionUnmarshaller>(IntegerCriteriaConditionUnmarshaller.Instance);
                    unmarshalledObject.LookBackPeriodInDays = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("region", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringCriteriaCondition, StringCriteriaConditionUnmarshaller>(StringCriteriaConditionUnmarshaller.Instance);
                    unmarshalledObject.Region = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("resourceArn", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringCriteriaCondition, StringCriteriaConditionUnmarshaller>(StringCriteriaConditionUnmarshaller.Instance);
                    unmarshalledObject.ResourceArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("resourceTag", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ResourceTagsCriteriaCondition, ResourceTagsCriteriaConditionUnmarshaller>(ResourceTagsCriteriaConditionUnmarshaller.Instance);
                    unmarshalledObject.ResourceTag = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("restartNeeded", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<StringCriteriaCondition, StringCriteriaConditionUnmarshaller>(StringCriteriaConditionUnmarshaller.Instance);
                    unmarshalledObject.RestartNeeded = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
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