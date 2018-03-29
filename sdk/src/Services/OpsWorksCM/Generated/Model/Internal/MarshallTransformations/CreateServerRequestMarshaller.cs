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

/*
 * Do not modify this file. This file is generated from the opsworkscm-2016-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpsWorksCM.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpsWorksCM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateServer Request Marshaller
    /// </summary>       
    public class CreateServerRequestMarshaller : IMarshaller<IRequest, CreateServerRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateServerRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateServerRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.OpsWorksCM");
            string target = "OpsWorksCM_V2016_11_01.CreateServer";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAssociatePublicIpAddress())
                {
                    context.Writer.WritePropertyName("AssociatePublicIpAddress");
                    context.Writer.Write(publicRequest.AssociatePublicIpAddress);
                }

                if(publicRequest.IsSetBackupId())
                {
                    context.Writer.WritePropertyName("BackupId");
                    context.Writer.Write(publicRequest.BackupId);
                }

                if(publicRequest.IsSetBackupRetentionCount())
                {
                    context.Writer.WritePropertyName("BackupRetentionCount");
                    context.Writer.Write(publicRequest.BackupRetentionCount);
                }

                if(publicRequest.IsSetDisableAutomatedBackup())
                {
                    context.Writer.WritePropertyName("DisableAutomatedBackup");
                    context.Writer.Write(publicRequest.DisableAutomatedBackup);
                }

                if(publicRequest.IsSetEngine())
                {
                    context.Writer.WritePropertyName("Engine");
                    context.Writer.Write(publicRequest.Engine);
                }

                if(publicRequest.IsSetEngineAttributes())
                {
                    context.Writer.WritePropertyName("EngineAttributes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestEngineAttributesListValue in publicRequest.EngineAttributes)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = EngineAttributeMarshaller.Instance;
                        marshaller.Marshall(publicRequestEngineAttributesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetEngineModel())
                {
                    context.Writer.WritePropertyName("EngineModel");
                    context.Writer.Write(publicRequest.EngineModel);
                }

                if(publicRequest.IsSetEngineVersion())
                {
                    context.Writer.WritePropertyName("EngineVersion");
                    context.Writer.Write(publicRequest.EngineVersion);
                }

                if(publicRequest.IsSetInstanceProfileArn())
                {
                    context.Writer.WritePropertyName("InstanceProfileArn");
                    context.Writer.Write(publicRequest.InstanceProfileArn);
                }

                if(publicRequest.IsSetInstanceType())
                {
                    context.Writer.WritePropertyName("InstanceType");
                    context.Writer.Write(publicRequest.InstanceType);
                }

                if(publicRequest.IsSetKeyPair())
                {
                    context.Writer.WritePropertyName("KeyPair");
                    context.Writer.Write(publicRequest.KeyPair);
                }

                if(publicRequest.IsSetPreferredBackupWindow())
                {
                    context.Writer.WritePropertyName("PreferredBackupWindow");
                    context.Writer.Write(publicRequest.PreferredBackupWindow);
                }

                if(publicRequest.IsSetPreferredMaintenanceWindow())
                {
                    context.Writer.WritePropertyName("PreferredMaintenanceWindow");
                    context.Writer.Write(publicRequest.PreferredMaintenanceWindow);
                }

                if(publicRequest.IsSetSecurityGroupIds())
                {
                    context.Writer.WritePropertyName("SecurityGroupIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSecurityGroupIdsListValue in publicRequest.SecurityGroupIds)
                    {
                            context.Writer.Write(publicRequestSecurityGroupIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetServerName())
                {
                    context.Writer.WritePropertyName("ServerName");
                    context.Writer.Write(publicRequest.ServerName);
                }

                if(publicRequest.IsSetServiceRoleArn())
                {
                    context.Writer.WritePropertyName("ServiceRoleArn");
                    context.Writer.Write(publicRequest.ServiceRoleArn);
                }

                if(publicRequest.IsSetSubnetIds())
                {
                    context.Writer.WritePropertyName("SubnetIds");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSubnetIdsListValue in publicRequest.SubnetIds)
                    {
                            context.Writer.Write(publicRequestSubnetIdsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateServerRequestMarshaller _instance = new CreateServerRequestMarshaller();        

        internal static CreateServerRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateServerRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}