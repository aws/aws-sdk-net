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
    /// AutomatedAbrRule Marshaller
    /// </summary>
    public class AutomatedAbrRuleMarshaller : IRequestMarshaller<AutomatedAbrRule, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AutomatedAbrRule requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAllowedRenditions())
            {
                context.Writer.WritePropertyName("allowedRenditions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAllowedRenditionsListValue in requestObject.AllowedRenditions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AllowedRenditionSizeMarshaller.Instance;
                    marshaller.Marshall(requestObjectAllowedRenditionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetForceIncludeRenditions())
            {
                context.Writer.WritePropertyName("forceIncludeRenditions");
                context.Writer.WriteStartArray();
                foreach(var requestObjectForceIncludeRenditionsListValue in requestObject.ForceIncludeRenditions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ForceIncludeRenditionSizeMarshaller.Instance;
                    marshaller.Marshall(requestObjectForceIncludeRenditionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetMinBottomRenditionSize())
            {
                context.Writer.WritePropertyName("minBottomRenditionSize");
                context.Writer.WriteStartObject();

                var marshaller = MinBottomRenditionSizeMarshaller.Instance;
                marshaller.Marshall(requestObject.MinBottomRenditionSize, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMinTopRenditionSize())
            {
                context.Writer.WritePropertyName("minTopRenditionSize");
                context.Writer.WriteStartObject();

                var marshaller = MinTopRenditionSizeMarshaller.Instance;
                marshaller.Marshall(requestObject.MinTopRenditionSize, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AutomatedAbrRuleMarshaller Instance = new AutomatedAbrRuleMarshaller();

    }
}