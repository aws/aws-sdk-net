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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kendra.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ServiceNowServiceCatalogConfiguration Marshaller
    /// </summary>       
    public class ServiceNowServiceCatalogConfigurationMarshaller : IRequestMarshaller<ServiceNowServiceCatalogConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ServiceNowServiceCatalogConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCrawlAttachments())
            {
                context.Writer.WritePropertyName("CrawlAttachments");
                context.Writer.Write(requestObject.CrawlAttachments);
            }

            if(requestObject.IsSetDocumentDataFieldName())
            {
                context.Writer.WritePropertyName("DocumentDataFieldName");
                context.Writer.Write(requestObject.DocumentDataFieldName);
            }

            if(requestObject.IsSetDocumentTitleFieldName())
            {
                context.Writer.WritePropertyName("DocumentTitleFieldName");
                context.Writer.Write(requestObject.DocumentTitleFieldName);
            }

            if(requestObject.IsSetExcludeAttachmentFilePatterns())
            {
                context.Writer.WritePropertyName("ExcludeAttachmentFilePatterns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectExcludeAttachmentFilePatternsListValue in requestObject.ExcludeAttachmentFilePatterns)
                {
                        context.Writer.Write(requestObjectExcludeAttachmentFilePatternsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetFieldMappings())
            {
                context.Writer.WritePropertyName("FieldMappings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectFieldMappingsListValue in requestObject.FieldMappings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectFieldMappingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetIncludeAttachmentFilePatterns())
            {
                context.Writer.WritePropertyName("IncludeAttachmentFilePatterns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectIncludeAttachmentFilePatternsListValue in requestObject.IncludeAttachmentFilePatterns)
                {
                        context.Writer.Write(requestObjectIncludeAttachmentFilePatternsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static ServiceNowServiceCatalogConfigurationMarshaller Instance = new ServiceNowServiceCatalogConfigurationMarshaller();

    }
}