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
using ThirdParty.Json.LitJson;

namespace Amazon.CodeCommit.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BatchDescribeMergeConflicts Request Marshaller
    /// </summary>       
    public class BatchDescribeMergeConflictsRequestMarshaller : IMarshaller<IRequest, BatchDescribeMergeConflictsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((BatchDescribeMergeConflictsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(BatchDescribeMergeConflictsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeCommit");
            string target = "CodeCommit_20150413.BatchDescribeMergeConflicts";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-04-13";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetConflictDetailLevel())
                {
                    context.Writer.WritePropertyName("conflictDetailLevel");
                    context.Writer.Write(publicRequest.ConflictDetailLevel);
                }

                if(publicRequest.IsSetConflictResolutionStrategy())
                {
                    context.Writer.WritePropertyName("conflictResolutionStrategy");
                    context.Writer.Write(publicRequest.ConflictResolutionStrategy);
                }

                if(publicRequest.IsSetDestinationCommitSpecifier())
                {
                    context.Writer.WritePropertyName("destinationCommitSpecifier");
                    context.Writer.Write(publicRequest.DestinationCommitSpecifier);
                }

                if(publicRequest.IsSetFilePaths())
                {
                    context.Writer.WritePropertyName("filePaths");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestFilePathsListValue in publicRequest.FilePaths)
                    {
                            context.Writer.Write(publicRequestFilePathsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetMaxConflictFiles())
                {
                    context.Writer.WritePropertyName("maxConflictFiles");
                    context.Writer.Write(publicRequest.MaxConflictFiles);
                }

                if(publicRequest.IsSetMaxMergeHunks())
                {
                    context.Writer.WritePropertyName("maxMergeHunks");
                    context.Writer.Write(publicRequest.MaxMergeHunks);
                }

                if(publicRequest.IsSetMergeOption())
                {
                    context.Writer.WritePropertyName("mergeOption");
                    context.Writer.Write(publicRequest.MergeOption);
                }

                if(publicRequest.IsSetNextToken())
                {
                    context.Writer.WritePropertyName("nextToken");
                    context.Writer.Write(publicRequest.NextToken);
                }

                if(publicRequest.IsSetRepositoryName())
                {
                    context.Writer.WritePropertyName("repositoryName");
                    context.Writer.Write(publicRequest.RepositoryName);
                }

                if(publicRequest.IsSetSourceCommitSpecifier())
                {
                    context.Writer.WritePropertyName("sourceCommitSpecifier");
                    context.Writer.Write(publicRequest.SourceCommitSpecifier);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static BatchDescribeMergeConflictsRequestMarshaller _instance = new BatchDescribeMergeConflictsRequestMarshaller();        

        internal static BatchDescribeMergeConflictsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static BatchDescribeMergeConflictsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}