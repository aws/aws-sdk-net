/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.StorageGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Update Chap Credentials Request Marshaller
    /// </summary>       
    internal class UpdateChapCredentialsRequestMarshaller : IMarshaller<IRequest, UpdateChapCredentialsRequest> 
    {
        public IRequest Marshall(UpdateChapCredentialsRequest updateChapCredentialsRequest) 
        {

            IRequest request = new DefaultRequest(updateChapCredentialsRequest, "AmazonStorageGateway");
            string target = "StorageGateway_20120430.UpdateChapCredentials";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";

            using (StringWriter stringWriter = new StringWriter())
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (updateChapCredentialsRequest != null && updateChapCredentialsRequest.IsSetTargetARN()) 
                {
                    writer.WritePropertyName("TargetARN");
                    writer.Write(updateChapCredentialsRequest.TargetARN);
                }
                if (updateChapCredentialsRequest != null && updateChapCredentialsRequest.IsSetSecretToAuthenticateInitiator()) 
                {
                    writer.WritePropertyName("SecretToAuthenticateInitiator");
                    writer.Write(updateChapCredentialsRequest.SecretToAuthenticateInitiator);
                }
                if (updateChapCredentialsRequest != null && updateChapCredentialsRequest.IsSetInitiatorName()) 
                {
                    writer.WritePropertyName("InitiatorName");
                    writer.Write(updateChapCredentialsRequest.InitiatorName);
                }
                if (updateChapCredentialsRequest != null && updateChapCredentialsRequest.IsSetSecretToAuthenticateTarget()) 
                {
                    writer.WritePropertyName("SecretToAuthenticateTarget");
                    writer.Write(updateChapCredentialsRequest.SecretToAuthenticateTarget);
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
                return request;
            }
        }
    }
}
