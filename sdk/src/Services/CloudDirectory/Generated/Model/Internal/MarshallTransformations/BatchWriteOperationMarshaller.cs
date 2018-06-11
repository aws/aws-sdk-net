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
    /// BatchWriteOperation Marshaller
    /// </summary>       
    public class BatchWriteOperationMarshaller : IRequestMarshaller<BatchWriteOperation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BatchWriteOperation requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAddFacetToObject())
            {
                context.Writer.WritePropertyName("AddFacetToObject");
                context.Writer.WriteObjectStart();

                var marshaller = BatchAddFacetToObjectMarshaller.Instance;
                marshaller.Marshall(requestObject.AddFacetToObject, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAttachObject())
            {
                context.Writer.WritePropertyName("AttachObject");
                context.Writer.WriteObjectStart();

                var marshaller = BatchAttachObjectMarshaller.Instance;
                marshaller.Marshall(requestObject.AttachObject, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAttachPolicy())
            {
                context.Writer.WritePropertyName("AttachPolicy");
                context.Writer.WriteObjectStart();

                var marshaller = BatchAttachPolicyMarshaller.Instance;
                marshaller.Marshall(requestObject.AttachPolicy, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAttachToIndex())
            {
                context.Writer.WritePropertyName("AttachToIndex");
                context.Writer.WriteObjectStart();

                var marshaller = BatchAttachToIndexMarshaller.Instance;
                marshaller.Marshall(requestObject.AttachToIndex, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetAttachTypedLink())
            {
                context.Writer.WritePropertyName("AttachTypedLink");
                context.Writer.WriteObjectStart();

                var marshaller = BatchAttachTypedLinkMarshaller.Instance;
                marshaller.Marshall(requestObject.AttachTypedLink, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCreateIndex())
            {
                context.Writer.WritePropertyName("CreateIndex");
                context.Writer.WriteObjectStart();

                var marshaller = BatchCreateIndexMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateIndex, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetCreateObject())
            {
                context.Writer.WritePropertyName("CreateObject");
                context.Writer.WriteObjectStart();

                var marshaller = BatchCreateObjectMarshaller.Instance;
                marshaller.Marshall(requestObject.CreateObject, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDeleteObject())
            {
                context.Writer.WritePropertyName("DeleteObject");
                context.Writer.WriteObjectStart();

                var marshaller = BatchDeleteObjectMarshaller.Instance;
                marshaller.Marshall(requestObject.DeleteObject, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDetachFromIndex())
            {
                context.Writer.WritePropertyName("DetachFromIndex");
                context.Writer.WriteObjectStart();

                var marshaller = BatchDetachFromIndexMarshaller.Instance;
                marshaller.Marshall(requestObject.DetachFromIndex, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDetachObject())
            {
                context.Writer.WritePropertyName("DetachObject");
                context.Writer.WriteObjectStart();

                var marshaller = BatchDetachObjectMarshaller.Instance;
                marshaller.Marshall(requestObject.DetachObject, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDetachPolicy())
            {
                context.Writer.WritePropertyName("DetachPolicy");
                context.Writer.WriteObjectStart();

                var marshaller = BatchDetachPolicyMarshaller.Instance;
                marshaller.Marshall(requestObject.DetachPolicy, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDetachTypedLink())
            {
                context.Writer.WritePropertyName("DetachTypedLink");
                context.Writer.WriteObjectStart();

                var marshaller = BatchDetachTypedLinkMarshaller.Instance;
                marshaller.Marshall(requestObject.DetachTypedLink, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetRemoveFacetFromObject())
            {
                context.Writer.WritePropertyName("RemoveFacetFromObject");
                context.Writer.WriteObjectStart();

                var marshaller = BatchRemoveFacetFromObjectMarshaller.Instance;
                marshaller.Marshall(requestObject.RemoveFacetFromObject, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetUpdateLinkAttributes())
            {
                context.Writer.WritePropertyName("UpdateLinkAttributes");
                context.Writer.WriteObjectStart();

                var marshaller = BatchUpdateLinkAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.UpdateLinkAttributes, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetUpdateObjectAttributes())
            {
                context.Writer.WritePropertyName("UpdateObjectAttributes");
                context.Writer.WriteObjectStart();

                var marshaller = BatchUpdateObjectAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.UpdateObjectAttributes, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static BatchWriteOperationMarshaller Instance = new BatchWriteOperationMarshaller();

    }
}