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
using ThirdParty.Json.LitJson;

namespace Amazon.AmplifyUIBuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ComponentChild Marshaller
    /// </summary>
    public class ComponentChildMarshaller : IRequestMarshaller<ComponentChild, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ComponentChild requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetChildren())
            {
                context.Writer.WritePropertyName("children");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectChildrenListValue in requestObject.Children)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = ComponentChildMarshaller.Instance;
                    marshaller.Marshall(requestObjectChildrenListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetComponentType())
            {
                context.Writer.WritePropertyName("componentType");
                context.Writer.Write(requestObject.ComponentType);
            }

            if(requestObject.IsSetEvents())
            {
                context.Writer.WritePropertyName("events");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectEventsKvp in requestObject.Events)
                {
                    context.Writer.WritePropertyName(requestObjectEventsKvp.Key);
                    var requestObjectEventsValue = requestObjectEventsKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = ComponentEventMarshaller.Instance;
                    marshaller.Marshall(requestObjectEventsValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetProperties())
            {
                context.Writer.WritePropertyName("properties");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectPropertiesKvp in requestObject.Properties)
                {
                    context.Writer.WritePropertyName(requestObjectPropertiesKvp.Key);
                    var requestObjectPropertiesValue = requestObjectPropertiesKvp.Value;

                    context.Writer.WriteObjectStart();

                    var marshaller = ComponentPropertyMarshaller.Instance;
                    marshaller.Marshall(requestObjectPropertiesValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSourceId())
            {
                context.Writer.WritePropertyName("sourceId");
                context.Writer.Write(requestObject.SourceId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ComponentChildMarshaller Instance = new ComponentChildMarshaller();

    }
}