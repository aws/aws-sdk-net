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
    /// ComponentBindingPropertiesValueProperties Marshaller
    /// </summary>
    public class ComponentBindingPropertiesValuePropertiesMarshaller : IRequestMarshaller<ComponentBindingPropertiesValueProperties, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ComponentBindingPropertiesValueProperties requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBucket())
            {
                context.Writer.WritePropertyName("bucket");
                context.Writer.WriteStringValue(requestObject.Bucket);
            }

            if(requestObject.IsSetDefaultValue())
            {
                context.Writer.WritePropertyName("defaultValue");
                context.Writer.WriteStringValue(requestObject.DefaultValue);
            }

            if(requestObject.IsSetField())
            {
                context.Writer.WritePropertyName("field");
                context.Writer.WriteStringValue(requestObject.Field);
            }

            if(requestObject.IsSetKey())
            {
                context.Writer.WritePropertyName("key");
                context.Writer.WriteStringValue(requestObject.Key);
            }

            if(requestObject.IsSetModel())
            {
                context.Writer.WritePropertyName("model");
                context.Writer.WriteStringValue(requestObject.Model);
            }

            if(requestObject.IsSetPredicates())
            {
                context.Writer.WritePropertyName("predicates");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPredicatesListValue in requestObject.Predicates)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PredicateMarshaller.Instance;
                    marshaller.Marshall(requestObjectPredicatesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSlotName())
            {
                context.Writer.WritePropertyName("slotName");
                context.Writer.WriteStringValue(requestObject.SlotName);
            }

            if(requestObject.IsSetUserAttribute())
            {
                context.Writer.WritePropertyName("userAttribute");
                context.Writer.WriteStringValue(requestObject.UserAttribute);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ComponentBindingPropertiesValuePropertiesMarshaller Instance = new ComponentBindingPropertiesValuePropertiesMarshaller();

    }
}