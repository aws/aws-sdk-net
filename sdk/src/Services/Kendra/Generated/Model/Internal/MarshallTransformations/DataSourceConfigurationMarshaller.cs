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
            if(requestObject.IsSetConfluenceConfiguration())
            {
                context.Writer.WritePropertyName("ConfluenceConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ConfluenceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ConfluenceConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDatabaseConfiguration())
            {
                context.Writer.WritePropertyName("DatabaseConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = DatabaseConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.DatabaseConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetGoogleDriveConfiguration())
            {
                context.Writer.WritePropertyName("GoogleDriveConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = GoogleDriveConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.GoogleDriveConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetOneDriveConfiguration())
            {
                context.Writer.WritePropertyName("OneDriveConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = OneDriveConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.OneDriveConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetS3Configuration())
            {
                context.Writer.WritePropertyName("S3Configuration");
                context.Writer.WriteObjectStart();

                var marshaller = S3DataSourceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.S3Configuration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSalesforceConfiguration())
            {
                context.Writer.WritePropertyName("SalesforceConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = SalesforceConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SalesforceConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetServiceNowConfiguration())
            {
                context.Writer.WritePropertyName("ServiceNowConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = ServiceNowConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.ServiceNowConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetSharePointConfiguration())
            {
                context.Writer.WritePropertyName("SharePointConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = SharePointConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.SharePointConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static DataSourceConfigurationMarshaller Instance = new DataSourceConfigurationMarshaller();

    }
}