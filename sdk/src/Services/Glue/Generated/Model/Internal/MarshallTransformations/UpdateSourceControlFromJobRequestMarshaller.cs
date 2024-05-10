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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateSourceControlFromJob Request Marshaller
    /// </summary>       
    public class UpdateSourceControlFromJobRequestMarshaller : IMarshaller<IRequest, UpdateSourceControlFromJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateSourceControlFromJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateSourceControlFromJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glue");
            string target = "AWSGlue.UpdateSourceControlFromJob";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAuthStrategy())
                {
                    context.Writer.WritePropertyName("AuthStrategy");
                    context.Writer.Write(publicRequest.AuthStrategy);
                }

                if(publicRequest.IsSetAuthToken())
                {
                    context.Writer.WritePropertyName("AuthToken");
                    context.Writer.Write(publicRequest.AuthToken);
                }

                if(publicRequest.IsSetBranchName())
                {
                    context.Writer.WritePropertyName("BranchName");
                    context.Writer.Write(publicRequest.BranchName);
                }

                if(publicRequest.IsSetCommitId())
                {
                    context.Writer.WritePropertyName("CommitId");
                    context.Writer.Write(publicRequest.CommitId);
                }

                if(publicRequest.IsSetFolder())
                {
                    context.Writer.WritePropertyName("Folder");
                    context.Writer.Write(publicRequest.Folder);
                }

                if(publicRequest.IsSetJobName())
                {
                    context.Writer.WritePropertyName("JobName");
                    context.Writer.Write(publicRequest.JobName);
                }

                if(publicRequest.IsSetProvider())
                {
                    context.Writer.WritePropertyName("Provider");
                    context.Writer.Write(publicRequest.Provider);
                }

                if(publicRequest.IsSetRepositoryName())
                {
                    context.Writer.WritePropertyName("RepositoryName");
                    context.Writer.Write(publicRequest.RepositoryName);
                }

                if(publicRequest.IsSetRepositoryOwner())
                {
                    context.Writer.WritePropertyName("RepositoryOwner");
                    context.Writer.Write(publicRequest.RepositoryOwner);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateSourceControlFromJobRequestMarshaller _instance = new UpdateSourceControlFromJobRequestMarshaller();        

        internal static UpdateSourceControlFromJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateSourceControlFromJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}