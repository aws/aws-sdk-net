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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LakeFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LakeFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GetTemporaryGluePartitionCredentials Request Marshaller
    /// </summary>       
    public class GetTemporaryGluePartitionCredentialsRequestMarshaller : IMarshaller<IRequest, GetTemporaryGluePartitionCredentialsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GetTemporaryGluePartitionCredentialsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GetTemporaryGluePartitionCredentialsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LakeFormation");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-03-31";
            request.HttpMethod = "POST";

            request.ResourcePath = "/GetTemporaryGluePartitionCredentials";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAuditContext())
                {
                    context.Writer.WritePropertyName("AuditContext");
                    context.Writer.WriteObjectStart();

                    var marshaller = AuditContextMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AuditContext, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDurationSeconds())
                {
                    context.Writer.WritePropertyName("DurationSeconds");
                    context.Writer.Write(publicRequest.DurationSeconds);
                }

                if(publicRequest.IsSetPartition())
                {
                    context.Writer.WritePropertyName("Partition");
                    context.Writer.WriteObjectStart();

                    var marshaller = PartitionValueListMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Partition, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPermissions())
                {
                    context.Writer.WritePropertyName("Permissions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPermissionsListValue in publicRequest.Permissions)
                    {
                            context.Writer.Write(publicRequestPermissionsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSupportedPermissionTypes())
                {
                    context.Writer.WritePropertyName("SupportedPermissionTypes");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSupportedPermissionTypesListValue in publicRequest.SupportedPermissionTypes)
                    {
                            context.Writer.Write(publicRequestSupportedPermissionTypesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTableArn())
                {
                    context.Writer.WritePropertyName("TableArn");
                    context.Writer.Write(publicRequest.TableArn);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static GetTemporaryGluePartitionCredentialsRequestMarshaller _instance = new GetTemporaryGluePartitionCredentialsRequestMarshaller();        

        internal static GetTemporaryGluePartitionCredentialsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetTemporaryGluePartitionCredentialsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}