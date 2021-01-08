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
    /// AwsIamAccessKeyDetails Marshaller
    /// </summary>       
    public class AwsIamAccessKeyDetailsMarshaller : IRequestMarshaller<AwsIamAccessKeyDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsIamAccessKeyDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetAccessKeyId())
            {
                context.Writer.WritePropertyName("AccessKeyId");
                context.Writer.Write(requestObject.AccessKeyId);
            }

            if(requestObject.IsSetAccountId())
            {
                context.Writer.WritePropertyName("AccountId");
                context.Writer.Write(requestObject.AccountId);
            }

            if(requestObject.IsSetCreatedAt())
            {
                context.Writer.WritePropertyName("CreatedAt");
                context.Writer.Write(requestObject.CreatedAt);
            }

            if(requestObject.IsSetPrincipalId())
            {
                context.Writer.WritePropertyName("PrincipalId");
                context.Writer.Write(requestObject.PrincipalId);
            }

            if(requestObject.IsSetPrincipalName())
            {
                context.Writer.WritePropertyName("PrincipalName");
                context.Writer.Write(requestObject.PrincipalName);
            }

            if(requestObject.IsSetPrincipalType())
            {
                context.Writer.WritePropertyName("PrincipalType");
                context.Writer.Write(requestObject.PrincipalType);
            }

            if(requestObject.IsSetSessionContext())
            {
                context.Writer.WritePropertyName("SessionContext");
                context.Writer.WriteObjectStart();

                var marshaller = AwsIamAccessKeySessionContextMarshaller.Instance;
                marshaller.Marshall(requestObject.SessionContext, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetStatus())
            {
                context.Writer.WritePropertyName("Status");
                context.Writer.Write(requestObject.Status);
            }

            if(requestObject.IsSetUserName())
            {
                context.Writer.WritePropertyName("UserName");
                context.Writer.Write(requestObject.UserName);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsIamAccessKeyDetailsMarshaller Instance = new AwsIamAccessKeyDetailsMarshaller();

    }
}