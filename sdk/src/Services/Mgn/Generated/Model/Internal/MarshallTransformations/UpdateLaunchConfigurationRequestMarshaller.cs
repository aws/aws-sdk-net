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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Mgn.Model;
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
namespace Amazon.Mgn.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateLaunchConfiguration Request Marshaller
    /// </summary>       
    public class UpdateLaunchConfigurationRequestMarshaller : IMarshaller<IRequest, UpdateLaunchConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateLaunchConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateLaunchConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Mgn");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-02-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/UpdateLaunchConfiguration";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAccountID())
            {
                context.Writer.WritePropertyName("accountID");
                context.Writer.WriteStringValue(publicRequest.AccountID);
            }

            if(publicRequest.IsSetBootMode())
            {
                context.Writer.WritePropertyName("bootMode");
                context.Writer.WriteStringValue(publicRequest.BootMode);
            }

            if(publicRequest.IsSetCopyPrivateIp())
            {
                context.Writer.WritePropertyName("copyPrivateIp");
                context.Writer.WriteBooleanValue(publicRequest.CopyPrivateIp.Value);
            }

            if(publicRequest.IsSetCopyTags())
            {
                context.Writer.WritePropertyName("copyTags");
                context.Writer.WriteBooleanValue(publicRequest.CopyTags.Value);
            }

            if(publicRequest.IsSetEnableMapAutoTagging())
            {
                context.Writer.WritePropertyName("enableMapAutoTagging");
                context.Writer.WriteBooleanValue(publicRequest.EnableMapAutoTagging.Value);
            }

            if(publicRequest.IsSetLaunchDisposition())
            {
                context.Writer.WritePropertyName("launchDisposition");
                context.Writer.WriteStringValue(publicRequest.LaunchDisposition);
            }

            if(publicRequest.IsSetLicensing())
            {
                context.Writer.WritePropertyName("licensing");
                context.Writer.WriteStartObject();

                var marshaller = LicensingMarshaller.Instance;
                marshaller.Marshall(publicRequest.Licensing, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMapAutoTaggingMpeID())
            {
                context.Writer.WritePropertyName("mapAutoTaggingMpeID");
                context.Writer.WriteStringValue(publicRequest.MapAutoTaggingMpeID);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetPostLaunchActions())
            {
                context.Writer.WritePropertyName("postLaunchActions");
                context.Writer.WriteStartObject();

                var marshaller = PostLaunchActionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.PostLaunchActions, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSourceServerID())
            {
                context.Writer.WritePropertyName("sourceServerID");
                context.Writer.WriteStringValue(publicRequest.SourceServerID);
            }

            if(publicRequest.IsSetTargetInstanceTypeRightSizingMethod())
            {
                context.Writer.WritePropertyName("targetInstanceTypeRightSizingMethod");
                context.Writer.WriteStringValue(publicRequest.TargetInstanceTypeRightSizingMethod);
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
        private static UpdateLaunchConfigurationRequestMarshaller _instance = new UpdateLaunchConfigurationRequestMarshaller();        

        internal static UpdateLaunchConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateLaunchConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}