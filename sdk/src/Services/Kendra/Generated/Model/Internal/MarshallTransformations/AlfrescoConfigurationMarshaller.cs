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

#pragma warning disable CS0612,CS0618
namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AlfrescoConfiguration Marshaller
    /// </summary>
    public class AlfrescoConfigurationMarshaller : IRequestMarshaller<AlfrescoConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AlfrescoConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBlogFieldMappings())
            {
                context.Writer.WritePropertyName("BlogFieldMappings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectBlogFieldMappingsListValue in requestObject.BlogFieldMappings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectBlogFieldMappingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCrawlComments())
            {
                context.Writer.WritePropertyName("CrawlComments");
                context.Writer.Write(requestObject.CrawlComments);
            }

            if(requestObject.IsSetCrawlSystemFolders())
            {
                context.Writer.WritePropertyName("CrawlSystemFolders");
                context.Writer.Write(requestObject.CrawlSystemFolders);
            }

            if(requestObject.IsSetDocumentLibraryFieldMappings())
            {
                context.Writer.WritePropertyName("DocumentLibraryFieldMappings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectDocumentLibraryFieldMappingsListValue in requestObject.DocumentLibraryFieldMappings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectDocumentLibraryFieldMappingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEntityFilter())
            {
                context.Writer.WritePropertyName("EntityFilter");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectEntityFilterListValue in requestObject.EntityFilter)
                {
                        context.Writer.Write(requestObjectEntityFilterListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetExclusionPatterns())
            {
                context.Writer.WritePropertyName("ExclusionPatterns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectExclusionPatternsListValue in requestObject.ExclusionPatterns)
                {
                        context.Writer.Write(requestObjectExclusionPatternsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetInclusionPatterns())
            {
                context.Writer.WritePropertyName("InclusionPatterns");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectInclusionPatternsListValue in requestObject.InclusionPatterns)
                {
                        context.Writer.Write(requestObjectInclusionPatternsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSecretArn())
            {
                context.Writer.WritePropertyName("SecretArn");
                context.Writer.Write(requestObject.SecretArn);
            }

            if(requestObject.IsSetSiteId())
            {
                context.Writer.WritePropertyName("SiteId");
                context.Writer.Write(requestObject.SiteId);
            }

            if(requestObject.IsSetSiteUrl())
            {
                context.Writer.WritePropertyName("SiteUrl");
                context.Writer.Write(requestObject.SiteUrl);
            }

            if(requestObject.IsSetSslCertificateS3Path())
            {
                context.Writer.WritePropertyName("SslCertificateS3Path");
                context.Writer.WriteObjectStart();

                var marshaller = S3PathMarshaller.Instance;
                marshaller.Marshall(requestObject.SslCertificateS3Path, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVpcConfiguration())
            {
                context.Writer.WritePropertyName("VpcConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = DataSourceVpcConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.VpcConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetWikiFieldMappings())
            {
                context.Writer.WritePropertyName("WikiFieldMappings");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectWikiFieldMappingsListValue in requestObject.WikiFieldMappings)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = DataSourceToIndexFieldMappingMarshaller.Instance;
                    marshaller.Marshall(requestObjectWikiFieldMappingsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AlfrescoConfigurationMarshaller Instance = new AlfrescoConfigurationMarshaller();

    }
}