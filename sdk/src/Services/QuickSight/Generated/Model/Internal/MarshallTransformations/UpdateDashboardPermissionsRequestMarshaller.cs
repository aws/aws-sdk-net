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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QuickSight.Model;
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
namespace Amazon.QuickSight.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDashboardPermissions Request Marshaller
    /// </summary>       
    public class UpdateDashboardPermissionsRequestMarshaller : IMarshaller<IRequest, UpdateDashboardPermissionsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDashboardPermissionsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDashboardPermissionsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QuickSight");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-04-01";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetAwsAccountId())
                throw new AmazonQuickSightException("Request object does not have required field AwsAccountId set");
            request.AddPathResource("{AwsAccountId}", StringUtils.FromString(publicRequest.AwsAccountId));
            if (!publicRequest.IsSetDashboardId())
                throw new AmazonQuickSightException("Request object does not have required field DashboardId set");
            request.AddPathResource("{DashboardId}", StringUtils.FromString(publicRequest.DashboardId));
            request.ResourcePath = "/accounts/{AwsAccountId}/dashboards/{DashboardId}/permissions";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetGrantLinkPermissions())
            {
                context.Writer.WritePropertyName("GrantLinkPermissions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestGrantLinkPermissionsListValue in publicRequest.GrantLinkPermissions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ResourcePermissionMarshaller.Instance;
                    marshaller.Marshall(publicRequestGrantLinkPermissionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetGrantPermissions())
            {
                context.Writer.WritePropertyName("GrantPermissions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestGrantPermissionsListValue in publicRequest.GrantPermissions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ResourcePermissionMarshaller.Instance;
                    marshaller.Marshall(publicRequestGrantPermissionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetRevokeLinkPermissions())
            {
                context.Writer.WritePropertyName("RevokeLinkPermissions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRevokeLinkPermissionsListValue in publicRequest.RevokeLinkPermissions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ResourcePermissionMarshaller.Instance;
                    marshaller.Marshall(publicRequestRevokeLinkPermissionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetRevokePermissions())
            {
                context.Writer.WritePropertyName("RevokePermissions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestRevokePermissionsListValue in publicRequest.RevokePermissions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ResourcePermissionMarshaller.Instance;
                    marshaller.Marshall(publicRequestRevokePermissionsListValue, context);

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
        private static UpdateDashboardPermissionsRequestMarshaller _instance = new UpdateDashboardPermissionsRequestMarshaller();        

        internal static UpdateDashboardPermissionsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDashboardPermissionsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}