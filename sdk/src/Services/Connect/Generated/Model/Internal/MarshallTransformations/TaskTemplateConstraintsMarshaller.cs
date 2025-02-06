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
    /// TaskTemplateConstraints Marshaller
    /// </summary>
    public class TaskTemplateConstraintsMarshaller : IRequestMarshaller<TaskTemplateConstraints, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(TaskTemplateConstraints requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetInvisibleFields())
            {
                context.Writer.WritePropertyName("InvisibleFields");
                context.Writer.WriteStartArray();
                foreach(var requestObjectInvisibleFieldsListValue in requestObject.InvisibleFields)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = InvisibleFieldInfoMarshaller.Instance;
                    marshaller.Marshall(requestObjectInvisibleFieldsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetReadOnlyFields())
            {
                context.Writer.WritePropertyName("ReadOnlyFields");
                context.Writer.WriteStartArray();
                foreach(var requestObjectReadOnlyFieldsListValue in requestObject.ReadOnlyFields)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ReadOnlyFieldInfoMarshaller.Instance;
                    marshaller.Marshall(requestObjectReadOnlyFieldsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetRequiredFields())
            {
                context.Writer.WritePropertyName("RequiredFields");
                context.Writer.WriteStartArray();
                foreach(var requestObjectRequiredFieldsListValue in requestObject.RequiredFields)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = RequiredFieldInfoMarshaller.Instance;
                    marshaller.Marshall(requestObjectRequiredFieldsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static TaskTemplateConstraintsMarshaller Instance = new TaskTemplateConstraintsMarshaller();

    }
}