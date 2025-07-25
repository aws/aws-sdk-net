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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SocialMessaging.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SocialMessaging.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MetaLibraryTemplate Marshaller
    /// </summary>
    public class MetaLibraryTemplateMarshaller : IRequestMarshaller<MetaLibraryTemplate, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MetaLibraryTemplate requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetLibraryTemplateBodyInputs())
            {
                context.Writer.WritePropertyName("libraryTemplateBodyInputs");
                context.Writer.WriteObjectStart();

                var marshaller = LibraryTemplateBodyInputsMarshaller.Instance;
                marshaller.Marshall(requestObject.LibraryTemplateBodyInputs, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetLibraryTemplateButtonInputs())
            {
                context.Writer.WritePropertyName("libraryTemplateButtonInputs");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLibraryTemplateButtonInputsListValue in requestObject.LibraryTemplateButtonInputs)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = LibraryTemplateButtonInputMarshaller.Instance;
                    marshaller.Marshall(requestObjectLibraryTemplateButtonInputsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetLibraryTemplateName())
            {
                context.Writer.WritePropertyName("libraryTemplateName");
                context.Writer.Write(requestObject.LibraryTemplateName);
            }

            if(requestObject.IsSetTemplateCategory())
            {
                context.Writer.WritePropertyName("templateCategory");
                context.Writer.Write(requestObject.TemplateCategory);
            }

            if(requestObject.IsSetTemplateLanguage())
            {
                context.Writer.WritePropertyName("templateLanguage");
                context.Writer.Write(requestObject.TemplateLanguage);
            }

            if(requestObject.IsSetTemplateName())
            {
                context.Writer.WritePropertyName("templateName");
                context.Writer.Write(requestObject.TemplateName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MetaLibraryTemplateMarshaller Instance = new MetaLibraryTemplateMarshaller();

    }
}