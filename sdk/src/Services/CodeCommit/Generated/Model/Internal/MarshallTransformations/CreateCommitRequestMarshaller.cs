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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeCommit.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.CodeCommit.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCommit Request Marshaller
    /// </summary>       
    public class CreateCommitRequestMarshaller : IMarshaller<IRequest, CreateCommitRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCommitRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCommitRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeCommit");
            string target = "CodeCommit_20150413.CreateCommit";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-04-13";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAuthorName())
            {
                context.Writer.WritePropertyName("authorName");
                context.Writer.WriteStringValue(publicRequest.AuthorName);
            }

            if(publicRequest.IsSetBranchName())
            {
                context.Writer.WritePropertyName("branchName");
                context.Writer.WriteStringValue(publicRequest.BranchName);
            }

            if(publicRequest.IsSetCommitMessage())
            {
                context.Writer.WritePropertyName("commitMessage");
                context.Writer.WriteStringValue(publicRequest.CommitMessage);
            }

            if(publicRequest.IsSetDeleteFiles())
            {
                context.Writer.WritePropertyName("deleteFiles");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDeleteFilesListValue in publicRequest.DeleteFiles)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DeleteFileEntryMarshaller.Instance;
                    marshaller.Marshall(publicRequestDeleteFilesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetEmail())
            {
                context.Writer.WritePropertyName("email");
                context.Writer.WriteStringValue(publicRequest.Email);
            }

            if(publicRequest.IsSetKeepEmptyFolders())
            {
                context.Writer.WritePropertyName("keepEmptyFolders");
                context.Writer.WriteBooleanValue(publicRequest.KeepEmptyFolders.Value);
            }

            if(publicRequest.IsSetParentCommitId())
            {
                context.Writer.WritePropertyName("parentCommitId");
                context.Writer.WriteStringValue(publicRequest.ParentCommitId);
            }

            if(publicRequest.IsSetPutFiles())
            {
                context.Writer.WritePropertyName("putFiles");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPutFilesListValue in publicRequest.PutFiles)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PutFileEntryMarshaller.Instance;
                    marshaller.Marshall(publicRequestPutFilesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetRepositoryName())
            {
                context.Writer.WritePropertyName("repositoryName");
                context.Writer.WriteStringValue(publicRequest.RepositoryName);
            }

            if(publicRequest.IsSetSetFileModes())
            {
                context.Writer.WritePropertyName("setFileModes");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSetFileModesListValue in publicRequest.SetFileModes)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = SetFileModeEntryMarshaller.Instance;
                    marshaller.Marshall(publicRequestSetFileModesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateCommitRequestMarshaller _instance = new CreateCommitRequestMarshaller();        

        internal static CreateCommitRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCommitRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}