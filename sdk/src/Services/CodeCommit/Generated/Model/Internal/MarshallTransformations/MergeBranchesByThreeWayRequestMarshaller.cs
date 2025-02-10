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
    /// MergeBranchesByThreeWay Request Marshaller
    /// </summary>       
    public class MergeBranchesByThreeWayRequestMarshaller : IMarshaller<IRequest, MergeBranchesByThreeWayRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((MergeBranchesByThreeWayRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(MergeBranchesByThreeWayRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeCommit");
            string target = "CodeCommit_20150413.MergeBranchesByThreeWay";
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

            if(publicRequest.IsSetCommitMessage())
            {
                context.Writer.WritePropertyName("commitMessage");
                context.Writer.WriteStringValue(publicRequest.CommitMessage);
            }

            if(publicRequest.IsSetConflictDetailLevel())
            {
                context.Writer.WritePropertyName("conflictDetailLevel");
                context.Writer.WriteStringValue(publicRequest.ConflictDetailLevel);
            }

            if(publicRequest.IsSetConflictResolution())
            {
                context.Writer.WritePropertyName("conflictResolution");
                context.Writer.WriteStartObject();

                var marshaller = ConflictResolutionMarshaller.Instance;
                marshaller.Marshall(publicRequest.ConflictResolution, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetConflictResolutionStrategy())
            {
                context.Writer.WritePropertyName("conflictResolutionStrategy");
                context.Writer.WriteStringValue(publicRequest.ConflictResolutionStrategy);
            }

            if(publicRequest.IsSetDestinationCommitSpecifier())
            {
                context.Writer.WritePropertyName("destinationCommitSpecifier");
                context.Writer.WriteStringValue(publicRequest.DestinationCommitSpecifier);
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

            if(publicRequest.IsSetRepositoryName())
            {
                context.Writer.WritePropertyName("repositoryName");
                context.Writer.WriteStringValue(publicRequest.RepositoryName);
            }

            if(publicRequest.IsSetSourceCommitSpecifier())
            {
                context.Writer.WritePropertyName("sourceCommitSpecifier");
                context.Writer.WriteStringValue(publicRequest.SourceCommitSpecifier);
            }

            if(publicRequest.IsSetTargetBranch())
            {
                context.Writer.WritePropertyName("targetBranch");
                context.Writer.WriteStringValue(publicRequest.TargetBranch);
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
        private static MergeBranchesByThreeWayRequestMarshaller _instance = new MergeBranchesByThreeWayRequestMarshaller();        

        internal static MergeBranchesByThreeWayRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MergeBranchesByThreeWayRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}