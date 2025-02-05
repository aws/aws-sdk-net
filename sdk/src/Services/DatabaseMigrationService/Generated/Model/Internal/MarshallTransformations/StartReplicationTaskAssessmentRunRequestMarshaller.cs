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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartReplicationTaskAssessmentRun Request Marshaller
    /// </summary>       
    public class StartReplicationTaskAssessmentRunRequestMarshaller : IMarshaller<IRequest, StartReplicationTaskAssessmentRunRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartReplicationTaskAssessmentRunRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartReplicationTaskAssessmentRunRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DatabaseMigrationService");
            string target = "AmazonDMSv20160101.StartReplicationTaskAssessmentRun";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-01-01";
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
            if(publicRequest.IsSetAssessmentRunName())
            {
                context.Writer.WritePropertyName("AssessmentRunName");
                context.Writer.WriteStringValue(publicRequest.AssessmentRunName);
            }

            if(publicRequest.IsSetExclude())
            {
                context.Writer.WritePropertyName("Exclude");
                context.Writer.WriteStartArray();
                foreach(var publicRequestExcludeListValue in publicRequest.Exclude)
                {
                        context.Writer.WriteStringValue(publicRequestExcludeListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetIncludeOnly())
            {
                context.Writer.WritePropertyName("IncludeOnly");
                context.Writer.WriteStartArray();
                foreach(var publicRequestIncludeOnlyListValue in publicRequest.IncludeOnly)
                {
                        context.Writer.WriteStringValue(publicRequestIncludeOnlyListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetReplicationTaskArn())
            {
                context.Writer.WritePropertyName("ReplicationTaskArn");
                context.Writer.WriteStringValue(publicRequest.ReplicationTaskArn);
            }

            if(publicRequest.IsSetResultEncryptionMode())
            {
                context.Writer.WritePropertyName("ResultEncryptionMode");
                context.Writer.WriteStringValue(publicRequest.ResultEncryptionMode);
            }

            if(publicRequest.IsSetResultKmsKeyArn())
            {
                context.Writer.WritePropertyName("ResultKmsKeyArn");
                context.Writer.WriteStringValue(publicRequest.ResultKmsKeyArn);
            }

            if(publicRequest.IsSetResultLocationBucket())
            {
                context.Writer.WritePropertyName("ResultLocationBucket");
                context.Writer.WriteStringValue(publicRequest.ResultLocationBucket);
            }

            if(publicRequest.IsSetResultLocationFolder())
            {
                context.Writer.WritePropertyName("ResultLocationFolder");
                context.Writer.WriteStringValue(publicRequest.ResultLocationFolder);
            }

            if(publicRequest.IsSetServiceAccessRoleArn())
            {
                context.Writer.WritePropertyName("ServiceAccessRoleArn");
                context.Writer.WriteStringValue(publicRequest.ServiceAccessRoleArn);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

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
        private static StartReplicationTaskAssessmentRunRequestMarshaller _instance = new StartReplicationTaskAssessmentRunRequestMarshaller();        

        internal static StartReplicationTaskAssessmentRunRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartReplicationTaskAssessmentRunRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}