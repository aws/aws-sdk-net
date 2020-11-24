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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Elasticsearch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Elasticsearch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DomainEndpointOptions Marshaller
    /// </summary>       
    public class DomainEndpointOptionsMarshaller : IRequestMarshaller<DomainEndpointOptions, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(DomainEndpointOptions requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCustomEndpoint())
            {
                context.Writer.WritePropertyName("CustomEndpoint");
                context.Writer.Write(requestObject.CustomEndpoint);
            }

            if(requestObject.IsSetCustomEndpointCertificateArn())
            {
                context.Writer.WritePropertyName("CustomEndpointCertificateArn");
                context.Writer.Write(requestObject.CustomEndpointCertificateArn);
            }

            if(requestObject.IsSetCustomEndpointEnabled())
            {
                context.Writer.WritePropertyName("CustomEndpointEnabled");
                context.Writer.Write(requestObject.CustomEndpointEnabled);
            }

            if(requestObject.IsSetEnforceHTTPS())
            {
                context.Writer.WritePropertyName("EnforceHTTPS");
                context.Writer.Write(requestObject.EnforceHTTPS);
            }

            if(requestObject.IsSetTLSSecurityPolicy())
            {
                context.Writer.WritePropertyName("TLSSecurityPolicy");
                context.Writer.Write(requestObject.TLSSecurityPolicy);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static DomainEndpointOptionsMarshaller Instance = new DomainEndpointOptionsMarshaller();

    }
}