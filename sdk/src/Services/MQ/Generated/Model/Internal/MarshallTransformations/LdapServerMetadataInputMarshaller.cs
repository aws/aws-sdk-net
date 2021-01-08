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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MQ.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MQ.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// LdapServerMetadataInput Marshaller
    /// </summary>       
    public class LdapServerMetadataInputMarshaller : IRequestMarshaller<LdapServerMetadataInput, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(LdapServerMetadataInput requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetHosts())
            {
                context.Writer.WritePropertyName("hosts");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectHostsListValue in requestObject.Hosts)
                {
                        context.Writer.Write(requestObjectHostsListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetRoleBase())
            {
                context.Writer.WritePropertyName("roleBase");
                context.Writer.Write(requestObject.RoleBase);
            }

            if(requestObject.IsSetRoleName())
            {
                context.Writer.WritePropertyName("roleName");
                context.Writer.Write(requestObject.RoleName);
            }

            if(requestObject.IsSetRoleSearchMatching())
            {
                context.Writer.WritePropertyName("roleSearchMatching");
                context.Writer.Write(requestObject.RoleSearchMatching);
            }

            if(requestObject.IsSetRoleSearchSubtree())
            {
                context.Writer.WritePropertyName("roleSearchSubtree");
                context.Writer.Write(requestObject.RoleSearchSubtree);
            }

            if(requestObject.IsSetServiceAccountPassword())
            {
                context.Writer.WritePropertyName("serviceAccountPassword");
                context.Writer.Write(requestObject.ServiceAccountPassword);
            }

            if(requestObject.IsSetServiceAccountUsername())
            {
                context.Writer.WritePropertyName("serviceAccountUsername");
                context.Writer.Write(requestObject.ServiceAccountUsername);
            }

            if(requestObject.IsSetUserBase())
            {
                context.Writer.WritePropertyName("userBase");
                context.Writer.Write(requestObject.UserBase);
            }

            if(requestObject.IsSetUserRoleName())
            {
                context.Writer.WritePropertyName("userRoleName");
                context.Writer.Write(requestObject.UserRoleName);
            }

            if(requestObject.IsSetUserSearchMatching())
            {
                context.Writer.WritePropertyName("userSearchMatching");
                context.Writer.Write(requestObject.UserSearchMatching);
            }

            if(requestObject.IsSetUserSearchSubtree())
            {
                context.Writer.WritePropertyName("userSearchSubtree");
                context.Writer.Write(requestObject.UserSearchSubtree);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static LdapServerMetadataInputMarshaller Instance = new LdapServerMetadataInputMarshaller();

    }
}