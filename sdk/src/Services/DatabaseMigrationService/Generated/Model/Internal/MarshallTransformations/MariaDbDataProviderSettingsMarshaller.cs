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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DatabaseMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MariaDbDataProviderSettings Marshaller
    /// </summary>
    public class MariaDbDataProviderSettingsMarshaller : IRequestMarshaller<MariaDbDataProviderSettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MariaDbDataProviderSettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCertificateArn())
            {
                context.Writer.WritePropertyName("CertificateArn");
                context.Writer.WriteStringValue(requestObject.CertificateArn);
            }

            if(requestObject.IsSetPort())
            {
                context.Writer.WritePropertyName("Port");
                context.Writer.WriteNumberValue(requestObject.Port.Value);
            }

            if(requestObject.IsSetS3AccessRoleArn())
            {
                context.Writer.WritePropertyName("S3AccessRoleArn");
                context.Writer.WriteStringValue(requestObject.S3AccessRoleArn);
            }

            if(requestObject.IsSetS3Path())
            {
                context.Writer.WritePropertyName("S3Path");
                context.Writer.WriteStringValue(requestObject.S3Path);
            }

            if(requestObject.IsSetServerName())
            {
                context.Writer.WritePropertyName("ServerName");
                context.Writer.WriteStringValue(requestObject.ServerName);
            }

            if(requestObject.IsSetSslMode())
            {
                context.Writer.WritePropertyName("SslMode");
                context.Writer.WriteStringValue(requestObject.SslMode);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MariaDbDataProviderSettingsMarshaller Instance = new MariaDbDataProviderSettingsMarshaller();

    }
}