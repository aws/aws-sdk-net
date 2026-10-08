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
 * Do not modify this file. This file is generated from the codeconnections-2023-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeConnections.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.CodeConnections.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateSyncConfiguration Request Marshaller
    /// </summary>       
    public class CreateSyncConfigurationRequestMarshaller : IMarshaller<IRequest, CreateSyncConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateSyncConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateSyncConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CodeConnections");
            request.Headers["smithy-protocol"] = "rpc-v2-cbor";
            request.ResourcePath = "service/com.amazonaws.codeconnections.CodeConnections_20231201/operation/CreateSyncConfiguration";
            request.Headers["Content-Type"] = "application/cbor";
            request.Headers["Accept"] = "application/cbor";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-12-01";
            request.HttpMethod = "POST";

            var writer = CborWriterPool.Rent();
            try
            {
                writer.WriteStartMap(null);
                var context = new CborMarshallerContext(request, writer);
                if (publicRequest.IsSetBranch())
                {
                    context.Writer.WriteTextString("Branch");
                    context.Writer.WriteTextString(publicRequest.Branch);
                }
                if (publicRequest.IsSetConfigFile())
                {
                    context.Writer.WriteTextString("ConfigFile");
                    context.Writer.WriteTextString(publicRequest.ConfigFile);
                }
                if (publicRequest.IsSetPublishDeploymentStatus())
                {
                    context.Writer.WriteTextString("PublishDeploymentStatus");
                    context.Writer.WriteTextString(publicRequest.PublishDeploymentStatus);
                }
                if (publicRequest.IsSetPullRequestComment())
                {
                    context.Writer.WriteTextString("PullRequestComment");
                    context.Writer.WriteTextString(publicRequest.PullRequestComment);
                }
                if (publicRequest.IsSetRepositoryLinkId())
                {
                    context.Writer.WriteTextString("RepositoryLinkId");
                    context.Writer.WriteTextString(publicRequest.RepositoryLinkId);
                }
                if (publicRequest.IsSetResourceName())
                {
                    context.Writer.WriteTextString("ResourceName");
                    context.Writer.WriteTextString(publicRequest.ResourceName);
                }
                if (publicRequest.IsSetRoleArn())
                {
                    context.Writer.WriteTextString("RoleArn");
                    context.Writer.WriteTextString(publicRequest.RoleArn);
                }
                if (publicRequest.IsSetSyncType())
                {
                    context.Writer.WriteTextString("SyncType");
                    context.Writer.WriteTextString(publicRequest.SyncType);
                }
                if (publicRequest.IsSetTriggerResourceUpdateOn())
                {
                    context.Writer.WriteTextString("TriggerResourceUpdateOn");
                    context.Writer.WriteTextString(publicRequest.TriggerResourceUpdateOn);
                }
                writer.WriteEndMap();
#if !NETFRAMEWORK
                // Encode directly into a pooled buffer instead of allocating a new byte[] per request.
                // The buffer is pre-sized to writer.BytesWritten so it's rented at the right size up front,
                // avoiding the default-size rent followed by a resize+return.
                var encodedLength = writer.BytesWritten;
                request.ContentStream = new PooledContentStream(encodedLength);
                var bufferWriter = ((PooledContentStream)request.ContentStream).BufferWriter;
                var span = bufferWriter.GetSpan(encodedLength);
                var bytesWritten = writer.Encode(span);
                bufferWriter.Advance(bytesWritten);
#else
                request.Content = writer.Encode();
#endif
            }
            finally
            {
                CborWriterPool.Return(writer);
            }
            
            return request;
        }
        private static CreateSyncConfigurationRequestMarshaller _instance = new CreateSyncConfigurationRequestMarshaller();        

        internal static CreateSyncConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateSyncConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}