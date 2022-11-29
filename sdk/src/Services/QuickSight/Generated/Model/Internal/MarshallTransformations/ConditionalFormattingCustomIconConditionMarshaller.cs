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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ConditionalFormattingCustomIconCondition Marshaller
    /// </summary>
    public class ConditionalFormattingCustomIconConditionMarshaller : IRequestMarshaller<ConditionalFormattingCustomIconCondition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ConditionalFormattingCustomIconCondition requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetColor())
            {
                context.Writer.WritePropertyName("Color");
                context.Writer.Write(requestObject.Color);
            }

            if(requestObject.IsSetDisplayConfiguration())
            {
                context.Writer.WritePropertyName("DisplayConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ConditionalFormattingIconDisplayConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DisplayConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetExpression())
            {
                context.Writer.WritePropertyName("Expression");
                context.Writer.Write(requestObject.Expression);
            }

            if(requestObject.IsSetIconOptions())
            {
                context.Writer.WritePropertyName("IconOptions");
                context.Writer.WriteObjectStart();

                var marshaller = ConditionalFormattingCustomIconOptionsMarshaller.Instance;
                marshaller.Marshall(requestObject.IconOptions, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ConditionalFormattingCustomIconConditionMarshaller Instance = new ConditionalFormattingCustomIconConditionMarshaller();

    }
}