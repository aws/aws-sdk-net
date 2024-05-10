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
    /// ModifyMigrationProject Request Marshaller
    /// </summary>       
    public class ModifyMigrationProjectRequestMarshaller : IMarshaller<IRequest, ModifyMigrationProjectRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ModifyMigrationProjectRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ModifyMigrationProjectRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DatabaseMigrationService");
            string target = "AmazonDMSv20160101.ModifyMigrationProject";
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
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetInstanceProfileIdentifier())
                {
                    context.Writer.WritePropertyName("InstanceProfileIdentifier");
                    context.Writer.Write(publicRequest.InstanceProfileIdentifier);
                }

                if(publicRequest.IsSetMigrationProjectIdentifier())
                {
                    context.Writer.WritePropertyName("MigrationProjectIdentifier");
                    context.Writer.Write(publicRequest.MigrationProjectIdentifier);
                }

                if(publicRequest.IsSetMigrationProjectName())
                {
                    context.Writer.WritePropertyName("MigrationProjectName");
                    context.Writer.Write(publicRequest.MigrationProjectName);
                }

                if(publicRequest.IsSetSchemaConversionApplicationAttributes())
                {
                    context.Writer.WritePropertyName("SchemaConversionApplicationAttributes");
                    context.Writer.WriteObjectStart();

                    var marshaller = SCApplicationAttributesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SchemaConversionApplicationAttributes, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSourceDataProviderDescriptors())
                {
                    context.Writer.WritePropertyName("SourceDataProviderDescriptors");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSourceDataProviderDescriptorsListValue in publicRequest.SourceDataProviderDescriptors)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = DataProviderDescriptorDefinitionMarshaller.Instance;
                        marshaller.Marshall(publicRequestSourceDataProviderDescriptorsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTargetDataProviderDescriptors())
                {
                    context.Writer.WritePropertyName("TargetDataProviderDescriptors");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTargetDataProviderDescriptorsListValue in publicRequest.TargetDataProviderDescriptors)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = DataProviderDescriptorDefinitionMarshaller.Instance;
                        marshaller.Marshall(publicRequestTargetDataProviderDescriptorsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTransformationRules())
                {
                    context.Writer.WritePropertyName("TransformationRules");
                    context.Writer.Write(publicRequest.TransformationRules);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static ModifyMigrationProjectRequestMarshaller _instance = new ModifyMigrationProjectRequestMarshaller();        

        internal static ModifyMigrationProjectRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyMigrationProjectRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}