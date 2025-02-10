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
 * Do not modify this file. This file is generated from the license-manager-user-subscriptions-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LicenseManagerUserSubscriptions.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.LicenseManagerUserSubscriptions.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ActiveDirectorySettings Marshaller
    /// </summary>
    public class ActiveDirectorySettingsMarshaller : IRequestMarshaller<ActiveDirectorySettings, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ActiveDirectorySettings requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDomainCredentialsProvider())
            {
                context.Writer.WritePropertyName("DomainCredentialsProvider");
                context.Writer.WriteStartObject();

                var marshaller = CredentialsProviderMarshaller.Instance;
                marshaller.Marshall(requestObject.DomainCredentialsProvider, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDomainIpv4List())
            {
                context.Writer.WritePropertyName("DomainIpv4List");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDomainIpv4ListListValue in requestObject.DomainIpv4List)
                {
                        context.Writer.WriteStringValue(requestObjectDomainIpv4ListListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDomainName())
            {
                context.Writer.WritePropertyName("DomainName");
                context.Writer.WriteStringValue(requestObject.DomainName);
            }

            if(requestObject.IsSetDomainNetworkSettings())
            {
                context.Writer.WritePropertyName("DomainNetworkSettings");
                context.Writer.WriteStartObject();

                var marshaller = DomainNetworkSettingsMarshaller.Instance;
                marshaller.Marshall(requestObject.DomainNetworkSettings, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ActiveDirectorySettingsMarshaller Instance = new ActiveDirectorySettingsMarshaller();

    }
}