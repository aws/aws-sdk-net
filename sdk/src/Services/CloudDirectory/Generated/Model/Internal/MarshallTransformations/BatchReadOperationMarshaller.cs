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
    /// BatchReadOperation Marshaller
    /// </summary>
    public class BatchReadOperationMarshaller : IRequestMarshaller<BatchReadOperation, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BatchReadOperation requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetGetLinkAttributes())
            {
                context.Writer.WritePropertyName("GetLinkAttributes");
                context.Writer.WriteStartObject();

                var marshaller = BatchGetLinkAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.GetLinkAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGetObjectAttributes())
            {
                context.Writer.WritePropertyName("GetObjectAttributes");
                context.Writer.WriteStartObject();

                var marshaller = BatchGetObjectAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.GetObjectAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGetObjectInformation())
            {
                context.Writer.WritePropertyName("GetObjectInformation");
                context.Writer.WriteStartObject();

                var marshaller = BatchGetObjectInformationMarshaller.Instance;
                marshaller.Marshall(requestObject.GetObjectInformation, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetListAttachedIndices())
            {
                context.Writer.WritePropertyName("ListAttachedIndices");
                context.Writer.WriteStartObject();

                var marshaller = BatchListAttachedIndicesMarshaller.Instance;
                marshaller.Marshall(requestObject.ListAttachedIndices, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetListIncomingTypedLinks())
            {
                context.Writer.WritePropertyName("ListIncomingTypedLinks");
                context.Writer.WriteStartObject();

                var marshaller = BatchListIncomingTypedLinksMarshaller.Instance;
                marshaller.Marshall(requestObject.ListIncomingTypedLinks, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetListIndex())
            {
                context.Writer.WritePropertyName("ListIndex");
                context.Writer.WriteStartObject();

                var marshaller = BatchListIndexMarshaller.Instance;
                marshaller.Marshall(requestObject.ListIndex, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetListObjectAttributes())
            {
                context.Writer.WritePropertyName("ListObjectAttributes");
                context.Writer.WriteStartObject();

                var marshaller = BatchListObjectAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.ListObjectAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetListObjectChildren())
            {
                context.Writer.WritePropertyName("ListObjectChildren");
                context.Writer.WriteStartObject();

                var marshaller = BatchListObjectChildrenMarshaller.Instance;
                marshaller.Marshall(requestObject.ListObjectChildren, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetListObjectParentPaths())
            {
                context.Writer.WritePropertyName("ListObjectParentPaths");
                context.Writer.WriteStartObject();

                var marshaller = BatchListObjectParentPathsMarshaller.Instance;
                marshaller.Marshall(requestObject.ListObjectParentPaths, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetListObjectParents())
            {
                context.Writer.WritePropertyName("ListObjectParents");
                context.Writer.WriteStartObject();

                var marshaller = BatchListObjectParentsMarshaller.Instance;
                marshaller.Marshall(requestObject.ListObjectParents, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetListObjectPolicies())
            {
                context.Writer.WritePropertyName("ListObjectPolicies");
                context.Writer.WriteStartObject();

                var marshaller = BatchListObjectPoliciesMarshaller.Instance;
                marshaller.Marshall(requestObject.ListObjectPolicies, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetListOutgoingTypedLinks())
            {
                context.Writer.WritePropertyName("ListOutgoingTypedLinks");
                context.Writer.WriteStartObject();

                var marshaller = BatchListOutgoingTypedLinksMarshaller.Instance;
                marshaller.Marshall(requestObject.ListOutgoingTypedLinks, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetListPolicyAttachments())
            {
                context.Writer.WritePropertyName("ListPolicyAttachments");
                context.Writer.WriteStartObject();

                var marshaller = BatchListPolicyAttachmentsMarshaller.Instance;
                marshaller.Marshall(requestObject.ListPolicyAttachments, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetLookupPolicy())
            {
                context.Writer.WritePropertyName("LookupPolicy");
                context.Writer.WriteStartObject();

                var marshaller = BatchLookupPolicyMarshaller.Instance;
                marshaller.Marshall(requestObject.LookupPolicy, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BatchReadOperationMarshaller Instance = new BatchReadOperationMarshaller();

    }
}