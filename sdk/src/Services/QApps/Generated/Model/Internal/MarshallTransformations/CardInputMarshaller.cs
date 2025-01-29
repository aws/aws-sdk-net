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
 * Do not modify this file. This file is generated from the qapps-2023-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QApps.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QApps.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CardInput Marshaller
    /// </summary>
    public class CardInputMarshaller : IRequestMarshaller<CardInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CardInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetFileUpload())
            {
                context.Writer.WritePropertyName("fileUpload");
                context.Writer.WriteStartObject();

                var marshaller = FileUploadCardInputMarshaller.Instance;
                marshaller.Marshall(requestObject.FileUpload, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFormInput())
            {
                context.Writer.WritePropertyName("formInput");
                context.Writer.WriteStartObject();

                var marshaller = FormInputCardInputMarshaller.Instance;
                marshaller.Marshall(requestObject.FormInput, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetQPlugin())
            {
                context.Writer.WritePropertyName("qPlugin");
                context.Writer.WriteStartObject();

                var marshaller = QPluginCardInputMarshaller.Instance;
                marshaller.Marshall(requestObject.QPlugin, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetQQuery())
            {
                context.Writer.WritePropertyName("qQuery");
                context.Writer.WriteStartObject();

                var marshaller = QQueryCardInputMarshaller.Instance;
                marshaller.Marshall(requestObject.QQuery, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTextInput())
            {
                context.Writer.WritePropertyName("textInput");
                context.Writer.WriteStartObject();

                var marshaller = TextInputCardInputMarshaller.Instance;
                marshaller.Marshall(requestObject.TextInput, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CardInputMarshaller Instance = new CardInputMarshaller();

    }
}