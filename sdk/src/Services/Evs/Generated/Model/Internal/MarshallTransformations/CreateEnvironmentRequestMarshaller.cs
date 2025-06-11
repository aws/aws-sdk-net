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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Evs.Model;
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
namespace Amazon.Evs.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateEnvironment Request Marshaller
    /// </summary>       
    public class CreateEnvironmentRequestMarshaller : IMarshaller<IRequest, CreateEnvironmentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateEnvironmentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateEnvironmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Evs");
            string target = "AmazonElasticVMwareService.CreateEnvironment";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-07-27";
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
            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetConnectivityInfo())
            {
                context.Writer.WritePropertyName("connectivityInfo");
                context.Writer.WriteStartObject();

                var marshaller = ConnectivityInfoMarshaller.Instance;
                marshaller.Marshall(publicRequest.ConnectivityInfo, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEnvironmentName())
            {
                context.Writer.WritePropertyName("environmentName");
                context.Writer.WriteStringValue(publicRequest.EnvironmentName);
            }

            if(publicRequest.IsSetHosts())
            {
                context.Writer.WritePropertyName("hosts");
                context.Writer.WriteStartArray();
                foreach(var publicRequestHostsListValue in publicRequest.Hosts)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = HostInfoForCreateMarshaller.Instance;
                    marshaller.Marshall(publicRequestHostsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetInitialVlans())
            {
                context.Writer.WritePropertyName("initialVlans");
                context.Writer.WriteStartObject();

                var marshaller = InitialVlansMarshaller.Instance;
                marshaller.Marshall(publicRequest.InitialVlans, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetKmsKeyId())
            {
                context.Writer.WritePropertyName("kmsKeyId");
                context.Writer.WriteStringValue(publicRequest.KmsKeyId);
            }

            if(publicRequest.IsSetLicenseInfo())
            {
                context.Writer.WritePropertyName("licenseInfo");
                context.Writer.WriteStartArray();
                foreach(var publicRequestLicenseInfoListValue in publicRequest.LicenseInfo)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = LicenseInfoMarshaller.Instance;
                    marshaller.Marshall(publicRequestLicenseInfoListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetServiceAccessSecurityGroups())
            {
                context.Writer.WritePropertyName("serviceAccessSecurityGroups");
                context.Writer.WriteStartObject();

                var marshaller = ServiceAccessSecurityGroupsMarshaller.Instance;
                marshaller.Marshall(publicRequest.ServiceAccessSecurityGroups, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetServiceAccessSubnetId())
            {
                context.Writer.WritePropertyName("serviceAccessSubnetId");
                context.Writer.WriteStringValue(publicRequest.ServiceAccessSubnetId);
            }

            if(publicRequest.IsSetSiteId())
            {
                context.Writer.WritePropertyName("siteId");
                context.Writer.WriteStringValue(publicRequest.SiteId);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTermsAccepted())
            {
                context.Writer.WritePropertyName("termsAccepted");
                context.Writer.WriteBooleanValue(publicRequest.TermsAccepted.Value);
            }

            if(publicRequest.IsSetVcfHostnames())
            {
                context.Writer.WritePropertyName("vcfHostnames");
                context.Writer.WriteStartObject();

                var marshaller = VcfHostnamesMarshaller.Instance;
                marshaller.Marshall(publicRequest.VcfHostnames, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetVcfVersion())
            {
                context.Writer.WritePropertyName("vcfVersion");
                context.Writer.WriteStringValue(publicRequest.VcfVersion);
            }

            if(publicRequest.IsSetVpcId())
            {
                context.Writer.WritePropertyName("vpcId");
                context.Writer.WriteStringValue(publicRequest.VpcId);
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
        private static CreateEnvironmentRequestMarshaller _instance = new CreateEnvironmentRequestMarshaller();        

        internal static CreateEnvironmentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateEnvironmentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}