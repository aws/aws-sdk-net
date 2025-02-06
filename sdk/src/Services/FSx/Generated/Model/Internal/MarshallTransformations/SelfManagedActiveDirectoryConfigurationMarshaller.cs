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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FSx.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.FSx.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SelfManagedActiveDirectoryConfiguration Marshaller
    /// </summary>
    public class SelfManagedActiveDirectoryConfigurationMarshaller : IRequestMarshaller<SelfManagedActiveDirectoryConfiguration, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SelfManagedActiveDirectoryConfiguration requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetDnsIps())
            {
                context.Writer.WritePropertyName("DnsIps");
                context.Writer.WriteStartArray();
                foreach(var requestObjectDnsIpsListValue in requestObject.DnsIps)
                {
                        context.Writer.WriteStringValue(requestObjectDnsIpsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetDomainName())
            {
                context.Writer.WritePropertyName("DomainName");
                context.Writer.WriteStringValue(requestObject.DomainName);
            }

            if(requestObject.IsSetFileSystemAdministratorsGroup())
            {
                context.Writer.WritePropertyName("FileSystemAdministratorsGroup");
                context.Writer.WriteStringValue(requestObject.FileSystemAdministratorsGroup);
            }

            if(requestObject.IsSetOrganizationalUnitDistinguishedName())
            {
                context.Writer.WritePropertyName("OrganizationalUnitDistinguishedName");
                context.Writer.WriteStringValue(requestObject.OrganizationalUnitDistinguishedName);
            }

            if(requestObject.IsSetPassword())
            {
                context.Writer.WritePropertyName("Password");
                context.Writer.WriteStringValue(requestObject.Password);
            }

            if(requestObject.IsSetUserName())
            {
                context.Writer.WritePropertyName("UserName");
                context.Writer.WriteStringValue(requestObject.UserName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SelfManagedActiveDirectoryConfigurationMarshaller Instance = new SelfManagedActiveDirectoryConfigurationMarshaller();

    }
}