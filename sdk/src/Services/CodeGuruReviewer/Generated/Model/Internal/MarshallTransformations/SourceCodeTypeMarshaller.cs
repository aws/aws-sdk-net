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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeGuruReviewer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CodeGuruReviewer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SourceCodeType Marshaller
    /// </summary>
    public class SourceCodeTypeMarshaller : IRequestMarshaller<SourceCodeType, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SourceCodeType requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBranchDiff())
            {
                context.Writer.WritePropertyName("BranchDiff");
                context.Writer.WriteStartObject();

                var marshaller = BranchDiffSourceCodeTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.BranchDiff, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCommitDiff())
            {
                context.Writer.WritePropertyName("CommitDiff");
                context.Writer.WriteStartObject();

                var marshaller = CommitDiffSourceCodeTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.CommitDiff, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRepositoryHead())
            {
                context.Writer.WritePropertyName("RepositoryHead");
                context.Writer.WriteStartObject();

                var marshaller = RepositoryHeadSourceCodeTypeMarshaller.Instance;
                marshaller.Marshall(requestObject.RepositoryHead, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetRequestMetadata())
            {
                context.Writer.WritePropertyName("RequestMetadata");
                context.Writer.WriteStartObject();

                var marshaller = RequestMetadataMarshaller.Instance;
                marshaller.Marshall(requestObject.RequestMetadata, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3BucketRepository())
            {
                context.Writer.WritePropertyName("S3BucketRepository");
                context.Writer.WriteStartObject();

                var marshaller = S3BucketRepositoryMarshaller.Instance;
                marshaller.Marshall(requestObject.S3BucketRepository, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SourceCodeTypeMarshaller Instance = new SourceCodeTypeMarshaller();

    }
}