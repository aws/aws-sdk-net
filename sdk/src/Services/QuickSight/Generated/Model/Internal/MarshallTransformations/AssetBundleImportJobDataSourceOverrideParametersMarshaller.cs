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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AssetBundleImportJobDataSourceOverrideParameters Marshaller
    /// </summary>
    public class AssetBundleImportJobDataSourceOverrideParametersMarshaller : IRequestMarshaller<AssetBundleImportJobDataSourceOverrideParameters, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AssetBundleImportJobDataSourceOverrideParameters requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCredentials())
            {
                context.Writer.WritePropertyName("Credentials");
                context.Writer.WriteStartObject();

                var marshaller = AssetBundleImportJobDataSourceCredentialsMarshaller.Instance;
                marshaller.Marshall(requestObject.Credentials, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDataSourceId())
            {
                context.Writer.WritePropertyName("DataSourceId");
                context.Writer.WriteStringValue(requestObject.DataSourceId);
            }

            if(requestObject.IsSetDataSourceParameters())
            {
                context.Writer.WritePropertyName("DataSourceParameters");
                context.Writer.WriteStartObject();

                var marshaller = DataSourceParametersMarshaller.Instance;
                marshaller.Marshall(requestObject.DataSourceParameters, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetSslProperties())
            {
                context.Writer.WritePropertyName("SslProperties");
                context.Writer.WriteStartObject();

                var marshaller = SslPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.SslProperties, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetVpcConnectionProperties())
            {
                context.Writer.WritePropertyName("VpcConnectionProperties");
                context.Writer.WriteStartObject();

                var marshaller = VpcConnectionPropertiesMarshaller.Instance;
                marshaller.Marshall(requestObject.VpcConnectionProperties, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AssetBundleImportJobDataSourceOverrideParametersMarshaller Instance = new AssetBundleImportJobDataSourceOverrideParametersMarshaller();

    }
}