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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsDmsEndpointDetails Marshaller
    /// </summary>
    public class AwsDmsEndpointDetailsMarshaller : IRequestMarshaller<AwsDmsEndpointDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsDmsEndpointDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCertificateArn())
            {
                context.Writer.WritePropertyName("CertificateArn");
                context.Writer.WriteStringValue(requestObject.CertificateArn);
            }

            if(requestObject.IsSetDatabaseName())
            {
                context.Writer.WritePropertyName("DatabaseName");
                context.Writer.WriteStringValue(requestObject.DatabaseName);
            }

            if(requestObject.IsSetEndpointArn())
            {
                context.Writer.WritePropertyName("EndpointArn");
                context.Writer.WriteStringValue(requestObject.EndpointArn);
            }

            if(requestObject.IsSetEndpointIdentifier())
            {
                context.Writer.WritePropertyName("EndpointIdentifier");
                context.Writer.WriteStringValue(requestObject.EndpointIdentifier);
            }

            if(requestObject.IsSetEndpointType())
            {
                context.Writer.WritePropertyName("EndpointType");
                context.Writer.WriteStringValue(requestObject.EndpointType);
            }

            if(requestObject.IsSetEngineName())
            {
                context.Writer.WritePropertyName("EngineName");
                context.Writer.WriteStringValue(requestObject.EngineName);
            }

            if(requestObject.IsSetExternalId())
            {
                context.Writer.WritePropertyName("ExternalId");
                context.Writer.WriteStringValue(requestObject.ExternalId);
            }

            if(requestObject.IsSetExtraConnectionAttributes())
            {
                context.Writer.WritePropertyName("ExtraConnectionAttributes");
                context.Writer.WriteStringValue(requestObject.ExtraConnectionAttributes);
            }

            if(requestObject.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("KmsKeyId");
                context.Writer.WriteStringValue(requestObject.KmsKeyId);
            }

            if(requestObject.IsSetPort())
            {
                context.Writer.WritePropertyName("Port");
                context.Writer.WriteNumberValue(requestObject.Port.Value);
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

            if(requestObject.IsSetUsername())
            {
                context.Writer.WritePropertyName("Username");
                context.Writer.WriteStringValue(requestObject.Username);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsDmsEndpointDetailsMarshaller Instance = new AwsDmsEndpointDetailsMarshaller();

    }
}