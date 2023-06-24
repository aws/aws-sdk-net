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
    /// CreateDataRepositoryAssociation Request Marshaller
    /// </summary>       
    public class CreateDataRepositoryAssociationRequestMarshaller : IMarshaller<IRequest, CreateDataRepositoryAssociationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDataRepositoryAssociationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDataRepositoryAssociationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.FSx");
            string target = "AWSSimbaAPIService_v20180301.CreateDataRepositoryAssociation";
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
                if(publicRequest.IsSetBatchImportMetaDataOnCreate())
                {
                    context.Writer.WritePropertyName("BatchImportMetaDataOnCreate");
                    context.Writer.Write(publicRequest.BatchImportMetaDataOnCreate);
                }

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
                if(publicRequest.IsSetDataRepositoryPath())
                {
                    context.Writer.WritePropertyName("DataRepositoryPath");
                    context.Writer.Write(publicRequest.DataRepositoryPath);
                }

                if(publicRequest.IsSetFileSystemId())
                {
                    context.Writer.WritePropertyName("FileSystemId");
                    context.Writer.Write(publicRequest.FileSystemId);
                }

                if(publicRequest.IsSetFileSystemPath())
                {
                    context.Writer.WritePropertyName("FileSystemPath");
                    context.Writer.Write(publicRequest.FileSystemPath);
                }

                if(publicRequest.IsSetImportedFileChunkSize())
                {
                    context.Writer.WritePropertyName("ImportedFileChunkSize");
                    context.Writer.Write(publicRequest.ImportedFileChunkSize);
                }

                if(publicRequest.IsSetS3())
                {
                    context.Writer.WritePropertyName("S3");
                    context.Writer.WriteObjectStart();

                    var marshaller = S3DataRepositoryConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.S3, context);

                    context.Writer.WriteObjectEnd();
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
        private static CreateDataRepositoryAssociationRequestMarshaller _instance = new CreateDataRepositoryAssociationRequestMarshaller();        

        internal static CreateDataRepositoryAssociationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDataRepositoryAssociationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}