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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DatabaseMigrationService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ModifyDataMigration Request Marshaller
    /// </summary>       
    public class ModifyDataMigrationRequestMarshaller : IMarshaller<IRequest, ModifyDataMigrationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyDataMigrationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyDataMigrationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DatabaseMigrationService");
            string target = "AmazonDMSv20160101.ModifyDataMigration";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-01-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDataMigrationIdentifier())
                {
                    context.Writer.WritePropertyName("DataMigrationIdentifier");
                    context.Writer.Write(publicRequest.DataMigrationIdentifier);
                }

                if(publicRequest.IsSetDataMigrationName())
                {
                    context.Writer.WritePropertyName("DataMigrationName");
                    context.Writer.Write(publicRequest.DataMigrationName);
                }

                if(publicRequest.IsSetDataMigrationType())
                {
                    context.Writer.WritePropertyName("DataMigrationType");
                    context.Writer.Write(publicRequest.DataMigrationType);
                }

                if(publicRequest.IsSetEnableCloudwatchLogs())
                {
                    context.Writer.WritePropertyName("EnableCloudwatchLogs");
                    context.Writer.Write(publicRequest.EnableCloudwatchLogs);
                }

                if(publicRequest.IsSetNumberOfJobs())
                {
                    context.Writer.WritePropertyName("NumberOfJobs");
                    context.Writer.Write(publicRequest.NumberOfJobs);
                }

                if(publicRequest.IsSetSelectionRules())
                {
                    context.Writer.WritePropertyName("SelectionRules");
                    context.Writer.Write(publicRequest.SelectionRules);
                }

                if(publicRequest.IsSetServiceAccessRoleArn())
                {
                    context.Writer.WritePropertyName("ServiceAccessRoleArn");
                    context.Writer.Write(publicRequest.ServiceAccessRoleArn);
                }

                if(publicRequest.IsSetSourceDataSettings())
                {
                    context.Writer.WritePropertyName("SourceDataSettings");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSourceDataSettingsListValue in publicRequest.SourceDataSettings)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SourceDataSettingMarshaller.Instance;
                        marshaller.Marshall(publicRequestSourceDataSettingsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ModifyDataMigrationRequestMarshaller _instance = new ModifyDataMigrationRequestMarshaller();        

        internal static ModifyDataMigrationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyDataMigrationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}