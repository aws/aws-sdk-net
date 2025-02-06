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
 * Do not modify this file. This file is generated from the neptune-graph-2023-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NeptuneGraph.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.NeptuneGraph.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NeptuneImportOptions Marshaller
    /// </summary>
    public class NeptuneImportOptionsMarshaller : IRequestMarshaller<NeptuneImportOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NeptuneImportOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetPreserveDefaultVertexLabels())
            {
                context.Writer.WritePropertyName("preserveDefaultVertexLabels");
                context.Writer.WriteBooleanValue(requestObject.PreserveDefaultVertexLabels.Value);
            }

            if(requestObject.IsSetPreserveEdgeIds())
            {
                context.Writer.WritePropertyName("preserveEdgeIds");
                context.Writer.WriteBooleanValue(requestObject.PreserveEdgeIds.Value);
            }

            if(requestObject.IsSetS3ExportKmsKeyId())
            {
                context.Writer.WritePropertyName("s3ExportKmsKeyId");
                context.Writer.WriteStringValue(requestObject.S3ExportKmsKeyId);
            }

            if(requestObject.IsSetS3ExportPath())
            {
                context.Writer.WritePropertyName("s3ExportPath");
                context.Writer.WriteStringValue(requestObject.S3ExportPath);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NeptuneImportOptionsMarshaller Instance = new NeptuneImportOptionsMarshaller();

    }
}