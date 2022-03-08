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
 * Do not modify this file. This file is generated from the keyspaces-2022-02-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Keyspaces.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Keyspaces.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RestoreTable Request Marshaller
    /// </summary>       
    public class RestoreTableRequestMarshaller : IMarshaller<IRequest, RestoreTableRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RestoreTableRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RestoreTableRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Keyspaces");
            string target = "KeyspacesService.RestoreTable";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-02-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCapacitySpecificationOverride())
                {
                    context.Writer.WritePropertyName("capacitySpecificationOverride");
                    context.Writer.WriteObjectStart();

                    var marshaller = CapacitySpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CapacitySpecificationOverride, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEncryptionSpecificationOverride())
                {
                    context.Writer.WritePropertyName("encryptionSpecificationOverride");
                    context.Writer.WriteObjectStart();

                    var marshaller = EncryptionSpecificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EncryptionSpecificationOverride, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPointInTimeRecoveryOverride())
                {
                    context.Writer.WritePropertyName("pointInTimeRecoveryOverride");
                    context.Writer.WriteObjectStart();

                    var marshaller = PointInTimeRecoveryMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PointInTimeRecoveryOverride, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRestoreTimestamp())
                {
                    context.Writer.WritePropertyName("restoreTimestamp");
                    context.Writer.Write(publicRequest.RestoreTimestamp);
                }

                if(publicRequest.IsSetSourceKeyspaceName())
                {
                    context.Writer.WritePropertyName("sourceKeyspaceName");
                    context.Writer.Write(publicRequest.SourceKeyspaceName);
                }

                if(publicRequest.IsSetSourceTableName())
                {
                    context.Writer.WritePropertyName("sourceTableName");
                    context.Writer.Write(publicRequest.SourceTableName);
                }

                if(publicRequest.IsSetTagsOverride())
                {
                    context.Writer.WritePropertyName("tagsOverride");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsOverrideListValue in publicRequest.TagsOverride)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsOverrideListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTargetKeyspaceName())
                {
                    context.Writer.WritePropertyName("targetKeyspaceName");
                    context.Writer.Write(publicRequest.TargetKeyspaceName);
                }

                if(publicRequest.IsSetTargetTableName())
                {
                    context.Writer.WritePropertyName("targetTableName");
                    context.Writer.Write(publicRequest.TargetTableName);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static RestoreTableRequestMarshaller _instance = new RestoreTableRequestMarshaller();        

        internal static RestoreTableRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RestoreTableRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}