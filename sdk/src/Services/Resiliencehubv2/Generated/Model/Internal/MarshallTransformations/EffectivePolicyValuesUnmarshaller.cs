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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Resiliencehubv2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Resiliencehubv2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EffectivePolicyValues Object
    /// </summary>  
    public class EffectivePolicyValuesUnmarshaller : IJsonUnmarshaller<EffectivePolicyValues, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public EffectivePolicyValues Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            EffectivePolicyValues unmarshalledObject = new EffectivePolicyValues();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("availabilitySlo", targetDepth, ref reader))
                {
                    var unmarshaller = SloSourceUnmarshaller.Instance;
                    unmarshalledObject.AvailabilitySlo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("dataRecoveryTimeBetweenBackups", targetDepth, ref reader))
                {
                    var unmarshaller = TargetSourceUnmarshaller.Instance;
                    unmarshalledObject.DataRecoveryTimeBetweenBackups = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("multiAzDrApproach", targetDepth, ref reader))
                {
                    var unmarshaller = DisasterRecoverySourceUnmarshaller.Instance;
                    unmarshalledObject.MultiAzDrApproach = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("multiAzRpo", targetDepth, ref reader))
                {
                    var unmarshaller = TargetSourceUnmarshaller.Instance;
                    unmarshalledObject.MultiAzRpo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("multiAzRto", targetDepth, ref reader))
                {
                    var unmarshaller = TargetSourceUnmarshaller.Instance;
                    unmarshalledObject.MultiAzRto = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("multiRegionDrApproach", targetDepth, ref reader))
                {
                    var unmarshaller = DisasterRecoverySourceUnmarshaller.Instance;
                    unmarshalledObject.MultiRegionDrApproach = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("multiRegionRpo", targetDepth, ref reader))
                {
                    var unmarshaller = TargetSourceUnmarshaller.Instance;
                    unmarshalledObject.MultiRegionRpo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("multiRegionRto", targetDepth, ref reader))
                {
                    var unmarshaller = TargetSourceUnmarshaller.Instance;
                    unmarshalledObject.MultiRegionRto = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static EffectivePolicyValuesUnmarshaller _instance = new EffectivePolicyValuesUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EffectivePolicyValuesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}