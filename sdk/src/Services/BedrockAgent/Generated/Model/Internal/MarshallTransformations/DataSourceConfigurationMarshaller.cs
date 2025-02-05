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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgent.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgent.Model.Internal.MarshallTransformations
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
            if(requestObject.IsSetConfluenceConfiguration())
            {
                context.Writer.WritePropertyName("confluenceConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ConfluenceDataSourceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ConfluenceConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetS3Configuration())
            {
                context.Writer.WritePropertyName("s3Configuration");
                context.Writer.WriteStartObject();

                var marshaller = S3DataSourceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Configuration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSalesforceConfiguration())
            {
                context.Writer.WritePropertyName("salesforceConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SalesforceDataSourceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SalesforceConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSharePointConfiguration())
            {
                context.Writer.WritePropertyName("sharePointConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = SharePointDataSourceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SharePointConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(requestObject.Type);
            }

            if(requestObject.IsSetWebConfiguration())
            {
                context.Writer.WritePropertyName("webConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = WebDataSourceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.WebConfiguration, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static DataSourceConfigurationMarshaller Instance = new DataSourceConfigurationMarshaller();

    }
}