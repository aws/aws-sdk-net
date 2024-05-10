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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AttributeSuggestionsGetConfig Marshaller
    /// </summary>
    public class AttributeSuggestionsGetConfigMarshaller : IRequestMarshaller<AttributeSuggestionsGetConfig, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AttributeSuggestionsGetConfig requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAdditionalResponseAttributes())
            {
                context.Writer.WritePropertyName("AdditionalResponseAttributes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectAdditionalResponseAttributesListValue in requestObject.AdditionalResponseAttributes)
                {
                        context.Writer.Write(requestObjectAdditionalResponseAttributesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetAttributeFilter())
            {
                context.Writer.WritePropertyName("AttributeFilter");
                context.Writer.WriteObjectStart();

                var marshaller = AttributeFilterMarshaller.Instance;
                marshaller.Marshall(requestObject.AttributeFilter, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSuggestionAttributes())
            {
                context.Writer.WritePropertyName("SuggestionAttributes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSuggestionAttributesListValue in requestObject.SuggestionAttributes)
                {
                        context.Writer.Write(requestObjectSuggestionAttributesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetUserContext())
            {
                context.Writer.WritePropertyName("UserContext");
                context.Writer.WriteObjectStart();

                var marshaller = UserContextMarshaller.Instance;
                marshaller.Marshall(requestObject.UserContext, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AttributeSuggestionsGetConfigMarshaller Instance = new AttributeSuggestionsGetConfigMarshaller();

    }
}