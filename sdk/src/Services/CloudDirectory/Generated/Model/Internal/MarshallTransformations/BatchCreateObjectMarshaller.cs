/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the clouddirectory-2016-05-10.normal.json service model.
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
using ThirdParty.Json.LitJson;

namespace Amazon.CloudDirectory.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchCreateObject Marshaller
    /// </summary>       
    public class BatchCreateObjectMarshaller : IRequestMarshaller<BatchCreateObject, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BatchCreateObject requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetBatchReferenceName())
            {
                context.Writer.WritePropertyName("BatchReferenceName");
                context.Writer.Write(requestObject.BatchReferenceName);
            }

            if(requestObject.IsSetLinkName())
            {
                context.Writer.WritePropertyName("LinkName");
                context.Writer.Write(requestObject.LinkName);
            }

            if(requestObject.IsSetObjectAttributeList())
            {
                context.Writer.WritePropertyName("ObjectAttributeList");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectObjectAttributeListListValue in requestObject.ObjectAttributeList)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AttributeKeyAndValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectObjectAttributeListListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetParentReference())
            {
                context.Writer.WritePropertyName("ParentReference");
                context.Writer.WriteObjectStart();

                var marshaller = ObjectReferenceMarshaller.Instance;
                marshaller.Marshall(requestObject.ParentReference, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSchemaFacet())
            {
                context.Writer.WritePropertyName("SchemaFacet");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectSchemaFacetListValue in requestObject.SchemaFacet)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = SchemaFacetMarshaller.Instance;
                    marshaller.Marshall(requestObjectSchemaFacetListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static BatchCreateObjectMarshaller Instance = new BatchCreateObjectMarshaller();

    }
}