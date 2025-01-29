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
    /// EvaluateDataQualityMultiFrame Marshaller
    /// </summary>
    public class EvaluateDataQualityMultiFrameMarshaller : IRequestMarshaller<EvaluateDataQualityMultiFrame, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EvaluateDataQualityMultiFrame requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalDataSources())
            {
                context.Writer.WritePropertyName("AdditionalDataSources");
                context.Writer.WriteStartObject();
                foreach (var requestObjectAdditionalDataSourcesKvp in requestObject.AdditionalDataSources)
                {
                    context.Writer.WritePropertyName(requestObjectAdditionalDataSourcesKvp.Key);
                    var requestObjectAdditionalDataSourcesValue = requestObjectAdditionalDataSourcesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectAdditionalDataSourcesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetAdditionalOptions())
            {
                context.Writer.WritePropertyName("AdditionalOptions");
                context.Writer.WriteStartObject();
                foreach (var requestObjectAdditionalOptionsKvp in requestObject.AdditionalOptions)
                {
                    context.Writer.WritePropertyName(requestObjectAdditionalOptionsKvp.Key);
                    var requestObjectAdditionalOptionsValue = requestObjectAdditionalOptionsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectAdditionalOptionsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetInputs())
            {
                context.Writer.WritePropertyName("Inputs");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInputsListValue in requestObject.Inputs)
                {
                        context.Writer.WriteStringValue(requestObjectInputsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetPublishingOptions())
            {
                context.Writer.WritePropertyName("PublishingOptions");
                context.Writer.WriteStartObject();

                var marshaller = DQResultsPublishingOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.PublishingOptions, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRuleset())
            {
                context.Writer.WritePropertyName("Ruleset");
                context.Writer.WriteStringValue(requestObject.Ruleset);
            }

            if(requestObject.IsSetStopJobOnFailureOptions())
            {
                context.Writer.WritePropertyName("StopJobOnFailureOptions");
                context.Writer.WriteStartObject();

                var marshaller = DQStopJobOnFailureOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.StopJobOnFailureOptions, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EvaluateDataQualityMultiFrameMarshaller Instance = new EvaluateDataQualityMultiFrameMarshaller();

    }
}