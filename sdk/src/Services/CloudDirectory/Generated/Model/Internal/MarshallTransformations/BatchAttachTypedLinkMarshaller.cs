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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudDirectory.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudDirectory.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchAttachTypedLink Marshaller
    /// </summary>
    public class BatchAttachTypedLinkMarshaller : IRequestMarshaller<BatchAttachTypedLink, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BatchAttachTypedLink requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAttributes())
            {
                context.Writer.WritePropertyName("Attributes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectAttributesListValue in requestObject.Attributes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AttributeNameAndValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectAttributesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetSourceObjectReference())
            {
                context.Writer.WritePropertyName("SourceObjectReference");
                context.Writer.WriteStartObject();

                var marshaller = ObjectReferenceMarshaller.Instance;
                marshaller.Marshall(requestObject.SourceObjectReference, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTargetObjectReference())
            {
                context.Writer.WritePropertyName("TargetObjectReference");
                context.Writer.WriteStartObject();

                var marshaller = ObjectReferenceMarshaller.Instance;
                marshaller.Marshall(requestObject.TargetObjectReference, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTypedLinkFacet())
            {
                context.Writer.WritePropertyName("TypedLinkFacet");
                context.Writer.WriteStartObject();

                var marshaller = TypedLinkSchemaAndFacetNameMarshaller.Instance;
                marshaller.Marshall(requestObject.TypedLinkFacet, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BatchAttachTypedLinkMarshaller Instance = new BatchAttachTypedLinkMarshaller();

    }
}