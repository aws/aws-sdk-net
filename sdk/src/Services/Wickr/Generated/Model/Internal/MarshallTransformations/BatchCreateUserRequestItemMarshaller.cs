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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Wickr.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Wickr.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchCreateUserRequestItem Marshaller
    /// </summary>
    public class BatchCreateUserRequestItemMarshaller : IRequestMarshaller<BatchCreateUserRequestItem, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(BatchCreateUserRequestItem requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCodeValidation())
            {
                context.Writer.WritePropertyName("codeValidation");
                context.Writer.WriteBooleanValue(requestObject.CodeValidation.Value);
            }

            if(requestObject.IsSetFirstName())
            {
                context.Writer.WritePropertyName("firstName");
                context.Writer.WriteStringValue(requestObject.FirstName);
            }

            if(requestObject.IsSetInviteCode())
            {
                context.Writer.WritePropertyName("inviteCode");
                context.Writer.WriteStringValue(requestObject.InviteCode);
            }

            if(requestObject.IsSetInviteCodeTtl())
            {
                context.Writer.WritePropertyName("inviteCodeTtl");
                context.Writer.WriteNumberValue(requestObject.InviteCodeTtl.Value);
            }

            if(requestObject.IsSetLastName())
            {
                context.Writer.WritePropertyName("lastName");
                context.Writer.WriteStringValue(requestObject.LastName);
            }

            if(requestObject.IsSetSecurityGroupIds())
            {
                context.Writer.WritePropertyName("securityGroupIds");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSecurityGroupIdsListValue in requestObject.SecurityGroupIds)
                {
                        context.Writer.WriteStringValue(requestObjectSecurityGroupIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetUsername())
            {
                context.Writer.WritePropertyName("username");
                context.Writer.WriteStringValue(requestObject.Username);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static BatchCreateUserRequestItemMarshaller Instance = new BatchCreateUserRequestItemMarshaller();

    }
}