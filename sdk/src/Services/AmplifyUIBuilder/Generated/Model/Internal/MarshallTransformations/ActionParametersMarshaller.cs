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
    /// ActionParameters Marshaller
    /// </summary>
    public class ActionParametersMarshaller : IRequestMarshaller<ActionParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ActionParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAnchor())
            {
                context.Writer.WritePropertyName("anchor");
                context.Writer.WriteStartObject();

                var marshaller = ComponentPropertyMarshaller.Instance;
                marshaller.Marshall(requestObject.Anchor, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFields())
            {
                context.Writer.WritePropertyName("fields");
                context.Writer.WriteStartObject();
                foreach (var requestObjectFieldsKvp in requestObject.Fields)
                {
                    context.Writer.WritePropertyName(requestObjectFieldsKvp.Key);
                    var requestObjectFieldsValue = requestObjectFieldsKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = ComponentPropertyMarshaller.Instance;
                    marshaller.Marshall(requestObjectFieldsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGlobal())
            {
                context.Writer.WritePropertyName("global");
                context.Writer.WriteStartObject();

                var marshaller = ComponentPropertyMarshaller.Instance;
                marshaller.Marshall(requestObject.Global, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("id");
                context.Writer.WriteStartObject();

                var marshaller = ComponentPropertyMarshaller.Instance;
                marshaller.Marshall(requestObject.Id, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetModel())
            {
                context.Writer.WritePropertyName("model");
                context.Writer.WriteStringValue(requestObject.Model);
            }

            if(requestObject.IsSetState())
            {
                context.Writer.WritePropertyName("state");
                context.Writer.WriteStartObject();

                var marshaller = MutationActionSetStateParameterMarshaller.Instance;
                marshaller.Marshall(requestObject.State, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTarget())
            {
                context.Writer.WritePropertyName("target");
                context.Writer.WriteStartObject();

                var marshaller = ComponentPropertyMarshaller.Instance;
                marshaller.Marshall(requestObject.Target, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStartObject();

                var marshaller = ComponentPropertyMarshaller.Instance;
                marshaller.Marshall(requestObject.Type, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetUrl())
            {
                context.Writer.WritePropertyName("url");
                context.Writer.WriteStartObject();

                var marshaller = ComponentPropertyMarshaller.Instance;
                marshaller.Marshall(requestObject.Url, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ActionParametersMarshaller Instance = new ActionParametersMarshaller();

    }
}