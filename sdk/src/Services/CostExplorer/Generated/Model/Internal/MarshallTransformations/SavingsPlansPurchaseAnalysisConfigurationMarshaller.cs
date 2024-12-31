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
using ThirdParty.Json.LitJson;

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
                context.Writer.Write(requestObject.AccountId);
            }

            if(requestObject.IsSetAccountScope())
            {
                context.Writer.WritePropertyName("AccountScope");
                context.Writer.Write(requestObject.AccountScope);
            }

            if(requestObject.IsSetAnalysisType())
            {
                context.Writer.WritePropertyName("AnalysisType");
                context.Writer.Write(requestObject.AnalysisType);
            }

            if(requestObject.IsSetLookBackTimePeriod())
            {
                context.Writer.WritePropertyName("LookBackTimePeriod");
                context.Writer.WriteObjectStart();

                var marshaller = DateIntervalMarshaller.Instance;
                marshaller.Marshall(requestObject.LookBackTimePeriod, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSavingsPlansToAdd())
            {
                context.Writer.WritePropertyName("SavingsPlansToAdd");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSavingsPlansToAddListValue in requestObject.SavingsPlansToAdd)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = SavingsPlansMarshaller.Instance;
                    marshaller.Marshall(requestObjectSavingsPlansToAddListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSavingsPlansToExclude())
            {
                context.Writer.WritePropertyName("SavingsPlansToExclude");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSavingsPlansToExcludeListValue in requestObject.SavingsPlansToExclude)
                {
                        context.Writer.Write(requestObjectSavingsPlansToExcludeListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SavingsPlansPurchaseAnalysisConfigurationMarshaller Instance = new SavingsPlansPurchaseAnalysisConfigurationMarshaller();

    }
}