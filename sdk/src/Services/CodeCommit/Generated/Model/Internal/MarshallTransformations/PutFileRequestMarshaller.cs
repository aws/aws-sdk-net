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
using ThirdParty.Json.LitJson;

namespace Amazon.CodeCommit.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutFile Request Marshaller
    /// </summary>       
    public class PutFileRequestMarshaller : IMarshaller<IRequest, PutFileRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutFileRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutFileRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeCommit");
            string target = "CodeCommit_20150413.PutFile";
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
                if(publicRequest.IsSetBranchName())
                {
                    context.Writer.WritePropertyName("branchName");
                    context.Writer.Write(publicRequest.BranchName);
                }

                if(publicRequest.IsSetCommitMessage())
                {
                    context.Writer.WritePropertyName("commitMessage");
                    context.Writer.Write(publicRequest.CommitMessage);
                }

                if(publicRequest.IsSetEmail())
                {
                    context.Writer.WritePropertyName("email");
                    context.Writer.Write(publicRequest.Email);
                }

                if(publicRequest.IsSetFileContent())
                {
                    context.Writer.WritePropertyName("fileContent");
                    context.Writer.Write(StringUtils.FromMemoryStream(publicRequest.FileContent));
                }

                if(publicRequest.IsSetFileMode())
                {
                    context.Writer.WritePropertyName("fileMode");
                    context.Writer.Write(publicRequest.FileMode);
                }

                if(publicRequest.IsSetFilePath())
                {
                    context.Writer.WritePropertyName("filePath");
                    context.Writer.Write(publicRequest.FilePath);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetParentCommitId())
                {
                    context.Writer.WritePropertyName("parentCommitId");
                    context.Writer.Write(publicRequest.ParentCommitId);
                }

                if(publicRequest.IsSetRepositoryName())
                {
                    context.Writer.WritePropertyName("repositoryName");
                    context.Writer.Write(publicRequest.RepositoryName);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutFileRequestMarshaller _instance = new PutFileRequestMarshaller();        

        internal static PutFileRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutFileRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}