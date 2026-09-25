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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.AmplifyUIBuilder.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.AmplifyUIBuilder.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// FormCTA Marshaller
    /// </summary>
    public partial class FormCTAMarshaller : IRequestMarshaller<FormCTA, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(FormCTA requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetCancel())
            {
                context.Writer.WritePropertyName("cancel");
                context.Writer.WriteStartObject();

                var marshaller = FormButtonMarshaller.Instance;
                marshaller.Marshall(requestObject.Cancel, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetClear())
            {
                context.Writer.WritePropertyName("clear");
                context.Writer.WriteStartObject();

                var marshaller = FormButtonMarshaller.Instance;
                marshaller.Marshall(requestObject.Clear, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetPosition())
            {
                context.Writer.WritePropertyName("position");
                context.Writer.WriteStringValue(requestObject.Position);
            }

            if (requestObject.IsSetSubmit())
            {
                context.Writer.WritePropertyName("submit");
                context.Writer.WriteStartObject();

                var marshaller = FormButtonMarshaller.Instance;
                marshaller.Marshall(requestObject.Submit, context);

                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static FormCTAMarshaller Instance = new FormCTAMarshaller();
    }
}
