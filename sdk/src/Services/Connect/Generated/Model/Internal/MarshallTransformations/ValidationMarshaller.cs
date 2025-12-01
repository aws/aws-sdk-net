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
using ThirdParty.Json.LitJson;

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
                context.Writer.WriteObjectStart();

                var marshaller = ValidationEnumMarshaller.Instance;
                marshaller.Marshall(requestObject.Enum, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetExclusiveMaximum())
            {
                context.Writer.WritePropertyName("ExclusiveMaximum");
                if(StringUtils.IsSpecialDoubleValue(requestObject.ExclusiveMaximum))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.ExclusiveMaximum));
                }
                else
                {
                    context.Writer.Write(requestObject.ExclusiveMaximum);
                }
            }

            if(requestObject.IsSetExclusiveMinimum())
            {
                context.Writer.WritePropertyName("ExclusiveMinimum");
                if(StringUtils.IsSpecialDoubleValue(requestObject.ExclusiveMinimum))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.ExclusiveMinimum));
                }
                else
                {
                    context.Writer.Write(requestObject.ExclusiveMinimum);
                }
            }

            if(requestObject.IsSetIgnoreCase())
            {
                context.Writer.WritePropertyName("IgnoreCase");
                context.Writer.Write(requestObject.IgnoreCase);
            }

            if(requestObject.IsSetMaximum())
            {
                context.Writer.WritePropertyName("Maximum");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Maximum))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.Maximum));
                }
                else
                {
                    context.Writer.Write(requestObject.Maximum);
                }
            }

            if(requestObject.IsSetMaxLength())
            {
                context.Writer.WritePropertyName("MaxLength");
                context.Writer.Write(requestObject.MaxLength);
            }

            if(requestObject.IsSetMaxValues())
            {
                context.Writer.WritePropertyName("MaxValues");
                context.Writer.Write(requestObject.MaxValues);
            }

            if(requestObject.IsSetMinimum())
            {
                context.Writer.WritePropertyName("Minimum");
                if(StringUtils.IsSpecialDoubleValue(requestObject.Minimum))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.Minimum));
                }
                else
                {
                    context.Writer.Write(requestObject.Minimum);
                }
            }

            if(requestObject.IsSetMinLength())
            {
                context.Writer.WritePropertyName("MinLength");
                context.Writer.Write(requestObject.MinLength);
            }

            if(requestObject.IsSetMinValues())
            {
                context.Writer.WritePropertyName("MinValues");
                context.Writer.Write(requestObject.MinValues);
            }

            if(requestObject.IsSetMultipleOf())
            {
                context.Writer.WritePropertyName("MultipleOf");
                if(StringUtils.IsSpecialDoubleValue(requestObject.MultipleOf))
                {
                    context.Writer.Write(StringUtils.FromSpecialDoubleValue(requestObject.MultipleOf));
                }
                else
                {
                    context.Writer.Write(requestObject.MultipleOf);
                }
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ValidationMarshaller Instance = new ValidationMarshaller();

    }
}