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
using ThirdParty.Json.LitJson;

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
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetConnectivityInfo())
                {
                    context.Writer.WritePropertyName("connectivityInfo");
                    context.Writer.WriteObjectStart();

                    var marshaller = ConnectivityInfoMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ConnectivityInfo, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetEnvironmentName())
                {
                    context.Writer.WritePropertyName("environmentName");
                    context.Writer.Write(publicRequest.EnvironmentName);
                }

                if(publicRequest.IsSetHosts())
                {
                    context.Writer.WritePropertyName("hosts");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestHostsListValue in publicRequest.Hosts)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = HostInfoForCreateMarshaller.Instance;
                        marshaller.Marshall(publicRequestHostsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetInitialVlans())
                {
                    context.Writer.WritePropertyName("initialVlans");
                    context.Writer.WriteObjectStart();

                    var marshaller = InitialVlansMarshaller.Instance;
                    marshaller.Marshall(publicRequest.InitialVlans, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetKmsKeyId())
                {
                    context.Writer.WritePropertyName("kmsKeyId");
                    context.Writer.Write(publicRequest.KmsKeyId);
                }

                if(publicRequest.IsSetLicenseInfo())
                {
                    context.Writer.WritePropertyName("licenseInfo");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLicenseInfoListValue in publicRequest.LicenseInfo)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = LicenseInfoMarshaller.Instance;
                        marshaller.Marshall(publicRequestLicenseInfoListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetServiceAccessSecurityGroups())
                {
                    context.Writer.WritePropertyName("serviceAccessSecurityGroups");
                    context.Writer.WriteObjectStart();

                    var marshaller = ServiceAccessSecurityGroupsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ServiceAccessSecurityGroups, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetServiceAccessSubnetId())
                {
                    context.Writer.WritePropertyName("serviceAccessSubnetId");
                    context.Writer.Write(publicRequest.ServiceAccessSubnetId);
                }

                if(publicRequest.IsSetSiteId())
                {
                    context.Writer.WritePropertyName("siteId");
                    context.Writer.Write(publicRequest.SiteId);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTermsAccepted())
                {
                    context.Writer.WritePropertyName("termsAccepted");
                    context.Writer.Write(publicRequest.TermsAccepted);
                }

                if(publicRequest.IsSetVcfHostnames())
                {
                    context.Writer.WritePropertyName("vcfHostnames");
                    context.Writer.WriteObjectStart();

                    var marshaller = VcfHostnamesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VcfHostnames, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetVcfVersion())
                {
                    context.Writer.WritePropertyName("vcfVersion");
                    context.Writer.Write(publicRequest.VcfVersion);
                }

                if(publicRequest.IsSetVpcId())
                {
                    context.Writer.WritePropertyName("vpcId");
                    context.Writer.Write(publicRequest.VpcId);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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