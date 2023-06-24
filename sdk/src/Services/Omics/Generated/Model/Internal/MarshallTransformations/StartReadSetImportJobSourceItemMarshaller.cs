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
using ThirdParty.Json.LitJson;

namespace Amazon.Omics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartReadSetImportJobSourceItem Marshaller
    /// </summary>
    public class StartReadSetImportJobSourceItemMarshaller : IRequestMarshaller<StartReadSetImportJobSourceItem, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(StartReadSetImportJobSourceItem requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.Write(requestObject.Description);
            }

            if(requestObject.IsSetGeneratedFrom())
            {
                context.Writer.WritePropertyName("generatedFrom");
                context.Writer.Write(requestObject.GeneratedFrom);
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetReferenceArn())
            {
                context.Writer.WritePropertyName("referenceArn");
                context.Writer.Write(requestObject.ReferenceArn);
            }

            if(requestObject.IsSetSampleId())
            {
                context.Writer.WritePropertyName("sampleId");
                context.Writer.Write(requestObject.SampleId);
            }

            if(requestObject.IsSetSourceFiles())
            {
                context.Writer.WritePropertyName("sourceFiles");
                context.Writer.WriteObjectStart();

                var marshaller = SourceFilesMarshaller.Instance;
                marshaller.Marshall(requestObject.SourceFiles, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSourceFileType())
            {
                context.Writer.WritePropertyName("sourceFileType");
                context.Writer.Write(requestObject.SourceFileType);
            }

            if(requestObject.IsSetSubjectId())
            {
                context.Writer.WritePropertyName("subjectId");
                context.Writer.Write(requestObject.SubjectId);
            }

            if(requestObject.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectTagsKvp in requestObject.Tags)
                {
                    context.Writer.WritePropertyName(requestObjectTagsKvp.Key);
                    var requestObjectTagsValue = requestObjectTagsKvp.Value;

                        context.Writer.Write(requestObjectTagsValue);
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static StartReadSetImportJobSourceItemMarshaller Instance = new StartReadSetImportJobSourceItemMarshaller();

    }
}