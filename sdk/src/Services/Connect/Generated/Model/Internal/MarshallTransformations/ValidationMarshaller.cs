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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Validation Marshaller
    /// </summary>
    public class ValidationMarshaller : IRequestMarshaller<Validation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Validation requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetEnum())
            {
                context.Writer.WritePropertyName("Enum");
                context.Writer.WriteStartObject();

                var marshaller = ValidationEnumMarshaller.Instance;
                marshaller.Marshall(requestObject.Enum, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetExclusiveMaximum())
            {
                context.Writer.WritePropertyName("ExclusiveMaximum");
                if(StringUtils.IsSpecialDoubleValue(requestObject.ExclusiveMaximum.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.ExclusiveMaximum.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.ExclusiveMaximum.Value);
                }
            }

            if(requestObject.IsSetExclusiveMinimum())
            {
                context.Writer.WritePropertyName("ExclusiveMinimum");
                if(StringUtils.IsSpecialDoubleValue(requestObject.ExclusiveMinimum.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.ExclusiveMinimum.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.ExclusiveMinimum.Value);
                }
            }

            if(requestObject.IsSetIgnoreCase())
            {
                context.Writer.WritePropertyName("IgnoreCase");
                context.Writer.WriteBooleanValue(requestObject.IgnoreCase.Value);
            }

            if(requestObject.IsSetMaximum())
            {
                context.Writer.WritePropertyName("Maximum");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Maximum.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Maximum.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Maximum.Value);
                }
            }

            if(requestObject.IsSetMaxLength())
            {
                context.Writer.WritePropertyName("MaxLength");
                context.Writer.WriteNumberValue(requestObject.MaxLength.Value);
            }

            if(requestObject.IsSetMaxValues())
            {
                context.Writer.WritePropertyName("MaxValues");
                context.Writer.WriteNumberValue(requestObject.MaxValues.Value);
            }

            if(requestObject.IsSetMinimum())
            {
                context.Writer.WritePropertyName("Minimum");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Minimum.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.Minimum.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.Minimum.Value);
                }
            }

            if(requestObject.IsSetMinLength())
            {
                context.Writer.WritePropertyName("MinLength");
                context.Writer.WriteNumberValue(requestObject.MinLength.Value);
            }

            if(requestObject.IsSetMinValues())
            {
                context.Writer.WritePropertyName("MinValues");
                context.Writer.WriteNumberValue(requestObject.MinValues.Value);
            }

            if(requestObject.IsSetMultipleOf())
            {
                context.Writer.WritePropertyName("MultipleOf");
                if(StringUtils.IsSpecialDoubleValue(requestObject.MultipleOf.Value))
                {
                    context.Writer.WriteStringValue(StringUtils.FromSpecialDoubleValue(requestObject.MultipleOf.Value));
                }
                else
                {
                    context.Writer.WriteNumberValue(requestObject.MultipleOf.Value);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ValidationMarshaller Instance = new ValidationMarshaller();

    }
}