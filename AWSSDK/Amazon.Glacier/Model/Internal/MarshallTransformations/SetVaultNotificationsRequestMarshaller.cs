/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Glacier.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glacier.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Set Vault Notifications Request Marshaller
    /// </summary>       
    internal class SetVaultNotificationsRequestMarshaller : IMarshaller<IRequest, SetVaultNotificationsRequest> 
    {
        

        public IRequest Marshall(SetVaultNotificationsRequest setVaultNotificationsRequest) 
        {

            IRequest request = new DefaultRequest(setVaultNotificationsRequest, "AmazonGlacier");
            string target = "Glacier.SetVaultNotifications";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";

            request.HttpMethod = "PUT";
              
            string uriResourcePath = "/{accountId}/vaults/{vaultName}/notification-configuration"; 
            if(setVaultNotificationsRequest.IsSetAccountId())
                uriResourcePath = uriResourcePath.Replace("{accountId}", StringUtils.FromString(setVaultNotificationsRequest.AccountId) ); 
            else
                uriResourcePath = uriResourcePath.Replace("{accountId}", "" ); 
            if(setVaultNotificationsRequest.IsSetVaultName())
                uriResourcePath = uriResourcePath.Replace("{vaultName}", StringUtils.FromString(setVaultNotificationsRequest.VaultName) ); 
            else
                uriResourcePath = uriResourcePath.Replace("{vaultName}", "" ); 
            
            if (uriResourcePath.Contains("?")) 
            {
                string queryString = uriResourcePath.Substring(uriResourcePath.IndexOf("?") + 1);
                uriResourcePath    = uriResourcePath.Substring(0, uriResourcePath.IndexOf("?"));
        
                foreach (string s in queryString.Split('&', ';')) 
                {
                    string[] nameValuePair = s.Split('=');
                    if (nameValuePair.Length == 2 && nameValuePair[1].Length > 0) 
                    {
                        request.Parameters.Add(nameValuePair[0], nameValuePair[1]);
                    }
                    else
                    {
                        request.Parameters.Add(nameValuePair[0], null);
                    }
                }
            }
            
            request.ResourcePath = uriResourcePath;
            
             
            using (StringWriter stringWriter = new StringWriter())
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (setVaultNotificationsRequest.VaultNotificationConfig != null && setVaultNotificationsRequest.VaultNotificationConfig.IsSetSNSTopic()) 
                {
                    writer.WritePropertyName("SNSTopic");
                    writer.Write(setVaultNotificationsRequest.VaultNotificationConfig.SNSTopic);
                }

                if (setVaultNotificationsRequest.VaultNotificationConfig != null && setVaultNotificationsRequest.VaultNotificationConfig.Events != null && setVaultNotificationsRequest.VaultNotificationConfig.Events.Count > 0) 
                {
                    List<string> eventsList = setVaultNotificationsRequest.VaultNotificationConfig.Events;
                    writer.WritePropertyName("Events");
                    writer.WriteArrayStart();

                    foreach (string eventsListValue in eventsList) 
                    { 
                        writer.Write(StringUtils.FromString(eventsListValue));
                    }

                    writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }
        

            return request;
        }
    }
}
