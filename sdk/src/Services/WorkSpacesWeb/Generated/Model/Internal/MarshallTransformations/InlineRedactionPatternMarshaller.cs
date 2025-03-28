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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkSpacesWeb.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.WorkSpacesWeb.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InlineRedactionPattern Marshaller
    /// </summary>
    public class InlineRedactionPatternMarshaller : IRequestMarshaller<InlineRedactionPattern, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(InlineRedactionPattern requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBuiltInPatternId())
            {
                context.Writer.WritePropertyName("builtInPatternId");
                context.Writer.Write(requestObject.BuiltInPatternId);
            }

            if(requestObject.IsSetConfidenceLevel())
            {
                context.Writer.WritePropertyName("confidenceLevel");
                context.Writer.Write(requestObject.ConfidenceLevel);
            }

            if(requestObject.IsSetCustomPattern())
            {
                context.Writer.WritePropertyName("customPattern");
                context.Writer.WriteObjectStart();

                var marshaller = CustomPatternMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomPattern, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEnforcedUrls())
            {
                context.Writer.WritePropertyName("enforcedUrls");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEnforcedUrlsListValue in requestObject.EnforcedUrls)
                {
                        context.Writer.Write(requestObjectEnforcedUrlsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetExemptUrls())
            {
                context.Writer.WritePropertyName("exemptUrls");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectExemptUrlsListValue in requestObject.ExemptUrls)
                {
                        context.Writer.Write(requestObjectExemptUrlsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRedactionPlaceHolder())
            {
                context.Writer.WritePropertyName("redactionPlaceHolder");
                context.Writer.WriteObjectStart();

                var marshaller = RedactionPlaceHolderMarshaller.Instance;
                marshaller.Marshall(requestObject.RedactionPlaceHolder, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static InlineRedactionPatternMarshaller Instance = new InlineRedactionPatternMarshaller();

    }
}