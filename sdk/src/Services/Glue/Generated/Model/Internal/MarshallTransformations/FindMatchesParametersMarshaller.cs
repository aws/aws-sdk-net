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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FindMatchesParameters Marshaller
    /// </summary>
    public class FindMatchesParametersMarshaller : IRequestMarshaller<FindMatchesParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(FindMatchesParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccuracyCostTradeoff())
            {
                context.Writer.WritePropertyName("AccuracyCostTradeoff");
                if(StringUtils.IsSpecialDoubleValue(requestObject.AccuracyCostTradeoff.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.AccuracyCostTradeoff.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.AccuracyCostTradeoff.Value);
                }
            }

            if(requestObject.IsSetEnforceProvidedLabels())
            {
                context.Writer.WritePropertyName("EnforceProvidedLabels");
                context.Writer.WriteBooleanValue(requestObject.EnforceProvidedLabels.Value);
            }

            if(requestObject.IsSetPrecisionRecallTradeoff())
            {
                context.Writer.WritePropertyName("PrecisionRecallTradeoff");
                if(StringUtils.IsSpecialDoubleValue(requestObject.PrecisionRecallTradeoff.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.PrecisionRecallTradeoff.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.PrecisionRecallTradeoff.Value);
                }
            }

            if(requestObject.IsSetPrimaryKeyColumnName())
            {
                context.Writer.WritePropertyName("PrimaryKeyColumnName");
                context.Writer.WriteStringValue(requestObject.PrimaryKeyColumnName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static FindMatchesParametersMarshaller Instance = new FindMatchesParametersMarshaller();

    }
}