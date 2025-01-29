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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AmplifyUIBuilder.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AmplifyUIBuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ComponentVariant Marshaller
    /// </summary>
    public class ComponentVariantMarshaller : IRequestMarshaller<ComponentVariant, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ComponentVariant requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetOverrides())
            {
                context.Writer.WritePropertyName("overrides");
                context.Writer.WriteStartObject();
                foreach (var requestObjectOverridesKvp in requestObject.Overrides)
                {
                    context.Writer.WritePropertyName(requestObjectOverridesKvp.Key);
                    var requestObjectOverridesValue = requestObjectOverridesKvp.Value;

                    context.Writer.WriteStartObject();
                    foreach (var requestObjectOverridesValueKvp in requestObjectOverridesValue)
                    {
                        context.Writer.WritePropertyName(requestObjectOverridesValueKvp.Key);
                        var requestObjectOverridesValueValue = requestObjectOverridesValueKvp.Value;

                            context.Writer.WriteStringValue(requestObjectOverridesValueValue);
                    }
                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVariantValues())
            {
                context.Writer.WritePropertyName("variantValues");
                context.Writer.WriteStartObject();
                foreach (var requestObjectVariantValuesKvp in requestObject.VariantValues)
                {
                    context.Writer.WritePropertyName(requestObjectVariantValuesKvp.Key);
                    var requestObjectVariantValuesValue = requestObjectVariantValuesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectVariantValuesValue);
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ComponentVariantMarshaller Instance = new ComponentVariantMarshaller();

    }
}