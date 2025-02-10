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
    /// BatchCreateIndex Marshaller
    /// </summary>
    public class BatchCreateIndexMarshaller : IRequestMarshaller<BatchCreateIndex, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BatchCreateIndex requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBatchReferenceName())
            {
                context.Writer.WritePropertyName("BatchReferenceName");
                context.Writer.WriteStringValue(requestObject.BatchReferenceName);
            }

            if(requestObject.IsSetIsUnique())
            {
                context.Writer.WritePropertyName("IsUnique");
                context.Writer.WriteBooleanValue(requestObject.IsUnique.Value);
            }

            if(requestObject.IsSetLinkName())
            {
                context.Writer.WritePropertyName("LinkName");
                context.Writer.WriteStringValue(requestObject.LinkName);
            }

            if(requestObject.IsSetOrderedIndexedAttributeList())
            {
                context.Writer.WritePropertyName("OrderedIndexedAttributeList");
                context.Writer.WriteStartArray();
                foreach(var requestObjectOrderedIndexedAttributeListListValue in requestObject.OrderedIndexedAttributeList)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AttributeKeyMarshaller.Instance;
                    marshaller.Marshall(requestObjectOrderedIndexedAttributeListListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetParentReference())
            {
                context.Writer.WritePropertyName("ParentReference");
                context.Writer.WriteStartObject();

                var marshaller = ObjectReferenceMarshaller.Instance;
                marshaller.Marshall(requestObject.ParentReference, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BatchCreateIndexMarshaller Instance = new BatchCreateIndexMarshaller();

    }
}