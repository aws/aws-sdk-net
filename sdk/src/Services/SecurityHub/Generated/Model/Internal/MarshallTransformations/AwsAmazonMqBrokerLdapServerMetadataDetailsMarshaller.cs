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
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsAmazonMqBrokerLdapServerMetadataDetails Marshaller
    /// </summary>
    public class AwsAmazonMqBrokerLdapServerMetadataDetailsMarshaller : IRequestMarshaller<AwsAmazonMqBrokerLdapServerMetadataDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsAmazonMqBrokerLdapServerMetadataDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetHosts())
            {
                context.Writer.WritePropertyName("Hosts");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectHostsListValue in requestObject.Hosts)
                {
                        context.Writer.Write(requestObjectHostsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRoleBase())
            {
                context.Writer.WritePropertyName("RoleBase");
                context.Writer.Write(requestObject.RoleBase);
            }

            if(requestObject.IsSetRoleName())
            {
                context.Writer.WritePropertyName("RoleName");
                context.Writer.Write(requestObject.RoleName);
            }

            if(requestObject.IsSetRoleSearchMatching())
            {
                context.Writer.WritePropertyName("RoleSearchMatching");
                context.Writer.Write(requestObject.RoleSearchMatching);
            }

            if(requestObject.IsSetRoleSearchSubtree())
            {
                context.Writer.WritePropertyName("RoleSearchSubtree");
                context.Writer.Write(requestObject.RoleSearchSubtree);
            }

            if(requestObject.IsSetServiceAccountUsername())
            {
                context.Writer.WritePropertyName("ServiceAccountUsername");
                context.Writer.Write(requestObject.ServiceAccountUsername);
            }

            if(requestObject.IsSetUserBase())
            {
                context.Writer.WritePropertyName("UserBase");
                context.Writer.Write(requestObject.UserBase);
            }

            if(requestObject.IsSetUserRoleName())
            {
                context.Writer.WritePropertyName("UserRoleName");
                context.Writer.Write(requestObject.UserRoleName);
            }

            if(requestObject.IsSetUserSearchMatching())
            {
                context.Writer.WritePropertyName("UserSearchMatching");
                context.Writer.Write(requestObject.UserSearchMatching);
            }

            if(requestObject.IsSetUserSearchSubtree())
            {
                context.Writer.WritePropertyName("UserSearchSubtree");
                context.Writer.Write(requestObject.UserSearchSubtree);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsAmazonMqBrokerLdapServerMetadataDetailsMarshaller Instance = new AwsAmazonMqBrokerLdapServerMetadataDetailsMarshaller();

    }
}