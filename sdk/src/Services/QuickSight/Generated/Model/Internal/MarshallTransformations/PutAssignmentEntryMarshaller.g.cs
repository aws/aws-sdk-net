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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.QuickSight.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutAssignmentEntry Marshaller
    /// </summary>
    public partial class PutAssignmentEntryMarshaller : IRequestMarshaller<PutAssignmentEntry, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(PutAssignmentEntry requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetExistingPolicyArn())
            {
                context.Writer.WritePropertyName("ExistingPolicyArn");
                context.Writer.WriteStringValue(requestObject.ExistingPolicyArn);
            }

            if (requestObject.IsSetPrincipalArn())
            {
                context.Writer.WritePropertyName("PrincipalArn");
                context.Writer.WriteStringValue(requestObject.PrincipalArn);
            }

            if (requestObject.IsSetRevision())
            {
                context.Writer.WritePropertyName("Revision");
                context.Writer.WriteNumberValue(requestObject.Revision.Value);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static PutAssignmentEntryMarshaller Instance = new PutAssignmentEntryMarshaller();
    }
}
