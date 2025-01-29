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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostExplorer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SavingsPlansPurchaseAnalysisConfiguration Marshaller
    /// </summary>
    public class SavingsPlansPurchaseAnalysisConfigurationMarshaller : IRequestMarshaller<SavingsPlansPurchaseAnalysisConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SavingsPlansPurchaseAnalysisConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAccountId())
            {
                context.Writer.WritePropertyName("AccountId");
                context.Writer.WriteStringValue(requestObject.AccountId);
            }

            if(requestObject.IsSetAccountScope())
            {
                context.Writer.WritePropertyName("AccountScope");
                context.Writer.WriteStringValue(requestObject.AccountScope);
            }

            if(requestObject.IsSetAnalysisType())
            {
                context.Writer.WritePropertyName("AnalysisType");
                context.Writer.WriteStringValue(requestObject.AnalysisType);
            }

            if(requestObject.IsSetLookBackTimePeriod())
            {
                context.Writer.WritePropertyName("LookBackTimePeriod");
                context.Writer.WriteStartObject();

                var marshaller = DateIntervalMarshaller.Instance;
                marshaller.Marshall(requestObject.LookBackTimePeriod, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSavingsPlansToAdd())
            {
                context.Writer.WritePropertyName("SavingsPlansToAdd");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSavingsPlansToAddListValue in requestObject.SavingsPlansToAdd)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SavingsPlansMarshaller.Instance;
                    marshaller.Marshall(requestObjectSavingsPlansToAddListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSavingsPlansToExclude())
            {
                context.Writer.WritePropertyName("SavingsPlansToExclude");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSavingsPlansToExcludeListValue in requestObject.SavingsPlansToExclude)
                {
                        context.Writer.WriteStringValue(requestObjectSavingsPlansToExcludeListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SavingsPlansPurchaseAnalysisConfigurationMarshaller Instance = new SavingsPlansPurchaseAnalysisConfigurationMarshaller();

    }
}