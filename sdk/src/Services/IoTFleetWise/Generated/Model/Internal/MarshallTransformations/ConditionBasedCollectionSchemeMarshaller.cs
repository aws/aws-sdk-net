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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTFleetWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTFleetWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ConditionBasedCollectionScheme Marshaller
    /// </summary>
    public class ConditionBasedCollectionSchemeMarshaller : IRequestMarshaller<ConditionBasedCollectionScheme, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ConditionBasedCollectionScheme requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetConditionLanguageVersion())
            {
                context.Writer.WritePropertyName("conditionLanguageVersion");
                context.Writer.Write(requestObject.ConditionLanguageVersion);
            }

            if(requestObject.IsSetExpression())
            {
                context.Writer.WritePropertyName("expression");
                context.Writer.Write(requestObject.Expression);
            }

            if(requestObject.IsSetMinimumTriggerIntervalMs())
            {
                context.Writer.WritePropertyName("minimumTriggerIntervalMs");
                context.Writer.Write(requestObject.MinimumTriggerIntervalMs);
            }

            if(requestObject.IsSetTriggerMode())
            {
                context.Writer.WritePropertyName("triggerMode");
                context.Writer.Write(requestObject.TriggerMode);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ConditionBasedCollectionSchemeMarshaller Instance = new ConditionBasedCollectionSchemeMarshaller();

    }
}