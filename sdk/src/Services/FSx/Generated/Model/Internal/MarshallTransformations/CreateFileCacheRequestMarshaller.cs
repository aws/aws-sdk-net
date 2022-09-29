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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.FSx.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.FSx.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFileCache Request Marshaller
    /// </summary>       
    public class CreateFileCacheRequestMarshaller : IMarshaller<IRequest, CreateFileCacheRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFileCacheRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFileCacheRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.FSx");
            string target = "AWSSimbaAPIService_v20180301.CreateFileCache";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-03-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(publicRequest.ClientRequestToken);
                }

                else if(!(publicRequest.IsSetClientRequestToken()))
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetCopyTagsToDataRepositoryAssociations())
                {
                    context.Writer.WritePropertyName("CopyTagsToDataRepositoryAssociations");
                    context.Writer.Write(publicRequest.CopyTagsToDataRepositoryAssociations);
                }

                if(publicRequest.IsSetDataRepositoryAssociations())
                {
                    context.Writer.WritePropertyName("DataRepositoryAssociations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDataRepositoryAssociationsListValue in publicRequest.DataRepositoryAssociations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = FileCacheDataRepositoryAssociationMarshaller.Instance;
                        marshaller.Marshall(publicRequestDataRepositoryAssociationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetFileCacheType())
                {
                    context.Writer.WritePropertyName("FileCacheType");
                    context.Writer.Write(publicRequest.FileCacheType);
                }

                if(publicRequest.IsSetFileCacheTypeVersion())
                {
                    context.Writer.WritePropertyName("FileCacheTypeVersion");
                    context.Writer.Write(publicRequest.FileCacheTypeVersion);
                }

                if(publicRequest.IsSetKmsKeyId())
                {
                    context.Writer.WritePropertyName("KmsKeyId");
                    context.Writer.Write(publicRequest.KmsKeyId);
                }

                if(publicRequest.IsSetLustreConfiguration())
                {
                    context.Writer.WritePropertyName("LustreConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = CreateFileCacheLustreConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LustreConfiguration, context);

                    context.Writer.WriteObjectEnd();
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

                if(publicRequest.IsSetStorageCapacity())
                {
                    context.Writer.WritePropertyName("StorageCapacity");
                    context.Writer.Write(publicRequest.StorageCapacity);
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

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

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
        private static CreateFileCacheRequestMarshaller _instance = new CreateFileCacheRequestMarshaller();        

        internal static CreateFileCacheRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFileCacheRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}