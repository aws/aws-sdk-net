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
#pragma warning disable CS0612,CS0618
namespace Amazon.Kendra.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DataSourceConfiguration Marshaller
    /// </summary>
    public class DataSourceConfigurationMarshaller : IRequestMarshaller<DataSourceConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DataSourceConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAlfrescoConfiguration())
            {
                context.Writer.WritePropertyName("AlfrescoConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AlfrescoConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.AlfrescoConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetBoxConfiguration())
            {
                context.Writer.WritePropertyName("BoxConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = BoxConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.BoxConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetConfluenceConfiguration())
            {
                context.Writer.WritePropertyName("ConfluenceConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ConfluenceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ConfluenceConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDatabaseConfiguration())
            {
                context.Writer.WritePropertyName("DatabaseConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DatabaseConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DatabaseConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetFsxConfiguration())
            {
                context.Writer.WritePropertyName("FsxConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = FsxConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.FsxConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGitHubConfiguration())
            {
                context.Writer.WritePropertyName("GitHubConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = GitHubConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.GitHubConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetGoogleDriveConfiguration())
            {
                context.Writer.WritePropertyName("GoogleDriveConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = GoogleDriveConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.GoogleDriveConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetJiraConfiguration())
            {
                context.Writer.WritePropertyName("JiraConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = JiraConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.JiraConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetOneDriveConfiguration())
            {
                context.Writer.WritePropertyName("OneDriveConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = OneDriveConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.OneDriveConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetQuipConfiguration())
            {
                context.Writer.WritePropertyName("QuipConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = QuipConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.QuipConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3Configuration())
            {
                context.Writer.WritePropertyName("S3Configuration");
                context.Writer.WriteStartObject();

                var marshaller = S3DataSourceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Configuration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSalesforceConfiguration())
            {
                context.Writer.WritePropertyName("SalesforceConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SalesforceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SalesforceConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetServiceNowConfiguration())
            {
                context.Writer.WritePropertyName("ServiceNowConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ServiceNowConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ServiceNowConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSharePointConfiguration())
            {
                context.Writer.WritePropertyName("SharePointConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SharePointConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SharePointConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSlackConfiguration())
            {
                context.Writer.WritePropertyName("SlackConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SlackConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SlackConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTemplateConfiguration())
            {
                context.Writer.WritePropertyName("TemplateConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = TemplateConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.TemplateConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetWebCrawlerConfiguration())
            {
                context.Writer.WritePropertyName("WebCrawlerConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = WebCrawlerConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.WebCrawlerConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetWorkDocsConfiguration())
            {
                context.Writer.WritePropertyName("WorkDocsConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = WorkDocsConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.WorkDocsConfiguration, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DataSourceConfigurationMarshaller Instance = new DataSourceConfigurationMarshaller();

    }
}