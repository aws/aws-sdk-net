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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Omics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Omics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CompleteReadSetUploadPartListItem Marshaller
    /// </summary>
    public class CompleteReadSetUploadPartListItemMarshaller : IRequestMarshaller<CompleteReadSetUploadPartListItem, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(CompleteReadSetUploadPartListItem requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetChecksum())
            {
                context.Writer.WritePropertyName("checksum");
                context.Writer.WriteStringValue(requestObject.Checksum);
            }

            if(requestObject.IsSetPartNumber())
            {
                context.Writer.WritePropertyName("partNumber");
                context.Writer.WriteNumberValue(requestObject.PartNumber.Value);
            }

            if(requestObject.IsSetPartSource())
            {
                context.Writer.WritePropertyName("partSource");
                context.Writer.WriteStringValue(requestObject.PartSource);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static CompleteReadSetUploadPartListItemMarshaller Instance = new CompleteReadSetUploadPartListItemMarshaller();

    }
}