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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleEmailV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SimpleEmailV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BulkEmailEntry Marshaller
    /// </summary>
    public class BulkEmailEntryMarshaller : IRequestMarshaller<BulkEmailEntry, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BulkEmailEntry requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDestination())
            {
                context.Writer.WritePropertyName("Destination");
                context.Writer.WriteStartObject();

                var marshaller = DestinationMarshaller.Instance;
                marshaller.Marshall(requestObject.Destination, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetReplacementEmailContent())
            {
                context.Writer.WritePropertyName("ReplacementEmailContent");
                context.Writer.WriteStartObject();

                var marshaller = ReplacementEmailContentMarshaller.Instance;
                marshaller.Marshall(requestObject.ReplacementEmailContent, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetReplacementHeaders())
            {
                context.Writer.WritePropertyName("ReplacementHeaders");
                context.Writer.WriteStartArray();
                foreach(var requestObjectReplacementHeadersListValue in requestObject.ReplacementHeaders)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MessageHeaderMarshaller.Instance;
                    marshaller.Marshall(requestObjectReplacementHeadersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetReplacementTags())
            {
                context.Writer.WritePropertyName("ReplacementTags");
                context.Writer.WriteStartArray();
                foreach(var requestObjectReplacementTagsListValue in requestObject.ReplacementTags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = MessageTagMarshaller.Instance;
                    marshaller.Marshall(requestObjectReplacementTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BulkEmailEntryMarshaller Instance = new BulkEmailEntryMarshaller();

    }
}