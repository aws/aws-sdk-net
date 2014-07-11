/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CognitoIdentity.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CognitoIdentity.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetId Request Marshaller
    /// </summary>       
    public class GetIdRequestMarshaller : IMarshaller<IRequest, GetIdRequest> 
    {
        public IRequest Marshall(GetIdRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoIdentity");
            string target = "AWSCognitoIdentityService.GetId";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                if(publicRequest.IsSetAccountId())
                {
                    writer.WritePropertyName("AccountId");
                    writer.Write(publicRequest.AccountId);
                }

                if(publicRequest.IsSetIdentityPoolId())
                {
                    writer.WritePropertyName("IdentityPoolId");
                    writer.Write(publicRequest.IdentityPoolId);
                }

                if(publicRequest.IsSetLogins())
                {
                    writer.WritePropertyName("Logins");
                    writer.WriteObjectStart();
                    foreach (var publicRequestLoginsKvp in publicRequest.Logins)
                    {
                        writer.WritePropertyName(publicRequestLoginsKvp.Key);
                        var publicRequestLoginsValue = publicRequestLoginsKvp.Value;

                        writer.Write(publicRequestLoginsValue);
                    }
                    writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}