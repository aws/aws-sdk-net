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
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EvaluateDataQuality Marshaller
    /// </summary>
    public class EvaluateDataQualityMarshaller : IRequestMarshaller<EvaluateDataQuality, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EvaluateDataQuality requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetInputs())
            {
                context.Writer.WritePropertyName("Inputs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInputsListValue in requestObject.Inputs)
                {
                        context.Writer.Write(requestObjectInputsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetOutput())
            {
                context.Writer.WritePropertyName("Output");
                context.Writer.Write(requestObject.Output);
            }

            if(requestObject.IsSetPublishingOptions())
            {
                context.Writer.WritePropertyName("PublishingOptions");
                context.Writer.WriteObjectStart();

                var marshaller = DQResultsPublishingOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.PublishingOptions, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRuleset())
            {
                context.Writer.WritePropertyName("Ruleset");
                context.Writer.Write(requestObject.Ruleset);
            }

            if(requestObject.IsSetStopJobOnFailureOptions())
            {
                context.Writer.WritePropertyName("StopJobOnFailureOptions");
                context.Writer.WriteObjectStart();

                var marshaller = DQStopJobOnFailureOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.StopJobOnFailureOptions, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EvaluateDataQualityMarshaller Instance = new EvaluateDataQualityMarshaller();

    }
}