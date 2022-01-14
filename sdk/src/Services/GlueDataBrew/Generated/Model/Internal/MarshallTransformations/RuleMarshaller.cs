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
 * Do not modify this file. This file is generated from the databrew-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.GlueDataBrew.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GlueDataBrew.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Rule Marshaller
    /// </summary>
    public class RuleMarshaller : IRequestMarshaller<Rule, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Rule requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCheckExpression())
            {
                context.Writer.WritePropertyName("CheckExpression");
                context.Writer.Write(requestObject.CheckExpression);
            }

            if(requestObject.IsSetColumnSelectors())
            {
                context.Writer.WritePropertyName("ColumnSelectors");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectColumnSelectorsListValue in requestObject.ColumnSelectors)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ColumnSelectorMarshaller.Instance;
                    marshaller.Marshall(requestObjectColumnSelectorsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetDisabled())
            {
                context.Writer.WritePropertyName("Disabled");
                context.Writer.Write(requestObject.Disabled);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetSubstitutionMap())
            {
                context.Writer.WritePropertyName("SubstitutionMap");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectSubstitutionMapKvp in requestObject.SubstitutionMap)
                {
                    context.Writer.WritePropertyName(requestObjectSubstitutionMapKvp.Key);
                    var requestObjectSubstitutionMapValue = requestObjectSubstitutionMapKvp.Value;

                        context.Writer.Write(requestObjectSubstitutionMapValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetThreshold())
            {
                context.Writer.WritePropertyName("Threshold");
                context.Writer.WriteObjectStart();

                var marshaller = ThresholdMarshaller.Instance;
                marshaller.Marshall(requestObject.Threshold, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static RuleMarshaller Instance = new RuleMarshaller();

    }
}