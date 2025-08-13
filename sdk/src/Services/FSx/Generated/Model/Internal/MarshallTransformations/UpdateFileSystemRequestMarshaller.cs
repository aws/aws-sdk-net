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

#pragma warning disable CS0612,CS0618
namespace Amazon.FSx.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateFileSystem Request Marshaller
    /// </summary>       
    public class UpdateFileSystemRequestMarshaller : IMarshaller<IRequest, UpdateFileSystemRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFileSystemRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateFileSystemRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.FSx");
            string target = "AWSSimbaAPIService_v20180301.UpdateFileSystem";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-03-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
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
                if(publicRequest.IsSetFileSystemId())
                {
                    context.Writer.WritePropertyName("FileSystemId");
                    context.Writer.Write(publicRequest.FileSystemId);
                }

                if(publicRequest.IsSetFileSystemTypeVersion())
                {
                    context.Writer.WritePropertyName("FileSystemTypeVersion");
                    context.Writer.Write(publicRequest.FileSystemTypeVersion);
                }

                if(publicRequest.IsSetLustreConfiguration())
                {
                    context.Writer.WritePropertyName("LustreConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = UpdateFileSystemLustreConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LustreConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetNetworkType())
                {
                    context.Writer.WritePropertyName("NetworkType");
                    context.Writer.Write(publicRequest.NetworkType);
                }

                if(publicRequest.IsSetOntapConfiguration())
                {
                    context.Writer.WritePropertyName("OntapConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = UpdateFileSystemOntapConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OntapConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOpenZFSConfiguration())
                {
                    context.Writer.WritePropertyName("OpenZFSConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = UpdateFileSystemOpenZFSConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.OpenZFSConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetStorageCapacity())
                {
                    context.Writer.WritePropertyName("StorageCapacity");
                    context.Writer.Write(publicRequest.StorageCapacity);
                }

                if(publicRequest.IsSetStorageType())
                {
                    context.Writer.WritePropertyName("StorageType");
                    context.Writer.Write(publicRequest.StorageType);
                }

                if(publicRequest.IsSetWindowsConfiguration())
                {
                    context.Writer.WritePropertyName("WindowsConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = UpdateFileSystemWindowsConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.WindowsConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateFileSystemRequestMarshaller _instance = new UpdateFileSystemRequestMarshaller();        

        internal static UpdateFileSystemRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFileSystemRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}