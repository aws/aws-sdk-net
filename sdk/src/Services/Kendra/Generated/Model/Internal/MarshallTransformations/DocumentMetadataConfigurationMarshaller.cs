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

namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DocumentMetadataConfiguration Marshaller
    /// </summary>       
    public class DocumentMetadataConfigurationMarshaller : IRequestMarshaller<DocumentMetadataConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DocumentMetadataConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetRelevance())
            {
                context.Writer.WritePropertyName("Relevance");
                context.Writer.WriteObjectStart();

                var marshaller = RelevanceMarshaller.Instance;
                marshaller.Marshall(requestObject.Relevance, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSearch())
            {
                context.Writer.WritePropertyName("Search");
                context.Writer.WriteObjectStart();

                var marshaller = SearchMarshaller.Instance;
                marshaller.Marshall(requestObject.Search, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("Type");
                context.Writer.Write(requestObject.Type);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static DocumentMetadataConfigurationMarshaller Instance = new DocumentMetadataConfigurationMarshaller();

    }
}