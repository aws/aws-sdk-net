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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaConvert.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.MediaConvert.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AutomatedAbrSettings Marshaller
    /// </summary>
    public class AutomatedAbrSettingsMarshaller : IRequestMarshaller<AutomatedAbrSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AutomatedAbrSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetMaxAbrBitrate())
            {
                context.Writer.WritePropertyName("maxAbrBitrate");
                context.Writer.WriteNumberValue(requestObject.MaxAbrBitrate.Value);
            }

            if(requestObject.IsSetMaxQualityLevel())
            {
                context.Writer.WritePropertyName("maxQualityLevel");
                if(StringUtils.IsSpecialDoubleValue(requestObject.MaxQualityLevel.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.MaxQualityLevel.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.MaxQualityLevel.Value);
                }
            }

            if(requestObject.IsSetMaxRenditions())
            {
                context.Writer.WritePropertyName("maxRenditions");
                context.Writer.WriteNumberValue(requestObject.MaxRenditions.Value);
            }

            if(requestObject.IsSetMinAbrBitrate())
            {
                context.Writer.WritePropertyName("minAbrBitrate");
                context.Writer.WriteNumberValue(requestObject.MinAbrBitrate.Value);
            }

            if(requestObject.IsSetRules())
            {
                context.Writer.WritePropertyName("rules");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRulesListValue in requestObject.Rules)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AutomatedAbrRuleMarshaller.Instance;
                    marshaller.Marshall(requestObjectRulesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AutomatedAbrSettingsMarshaller Instance = new AutomatedAbrSettingsMarshaller();

    }
}