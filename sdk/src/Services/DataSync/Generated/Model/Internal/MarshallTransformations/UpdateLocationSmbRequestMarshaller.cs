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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.DataSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateLocationSmb Request Marshaller
    /// </summary>       
    public class UpdateLocationSmbRequestMarshaller : IMarshaller<IRequest, UpdateLocationSmbRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateLocationSmbRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateLocationSmbRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataSync");
            string target = "FmrsService.UpdateLocationSmb";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-09";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (StreamWriter streamWriter = new InvariantCultureStreamWriter(memoryStream))
                {
                    JsonWriter writer = new JsonWriter(streamWriter);
                    writer.Validate = false;
                    writer.WriteObjectStart();
                    var context = new JsonMarshallerContext(request, writer);
                    if(publicRequest.IsSetAgentArns())
                    {
                        context.Writer.WritePropertyName("AgentArns");
                        context.Writer.WriteArrayStart();
                        foreach(var publicRequestAgentArnsListValue in publicRequest.AgentArns)
                        {
                                context.Writer.Write(publicRequestAgentArnsListValue);
                        }
                        context.Writer.WriteArrayEnd();
                    }

<<<<<<< HEAD
                    if(publicRequest.IsSetDomain())
                    {
                        context.Writer.WritePropertyName("Domain");
                        context.Writer.Write(publicRequest.Domain);
                    }
||||||| Commit version number update changes
                if(publicRequest.IsSetDomain())
                {
                    context.Writer.WritePropertyName("Domain");
                    context.Writer.Write(publicRequest.Domain);
                }
=======
                if(publicRequest.IsSetAuthenticationType())
                {
                    context.Writer.WritePropertyName("AuthenticationType");
                    context.Writer.Write(publicRequest.AuthenticationType);
                }

                if(publicRequest.IsSetDnsIpAddresses())
                {
                    context.Writer.WritePropertyName("DnsIpAddresses");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDnsIpAddressesListValue in publicRequest.DnsIpAddresses)
                    {
                            context.Writer.Write(publicRequestDnsIpAddressesListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetDomain())
                {
                    context.Writer.WritePropertyName("Domain");
                    context.Writer.Write(publicRequest.Domain);
                }
>>>>>>> 155cf7e693f514d013f0b7a90cc36b7db1c33d52

<<<<<<< HEAD
                    if(publicRequest.IsSetLocationArn())
                    {
                        context.Writer.WritePropertyName("LocationArn");
                        context.Writer.Write(publicRequest.LocationArn);
                    }
||||||| Commit version number update changes
                if(publicRequest.IsSetLocationArn())
                {
                    context.Writer.WritePropertyName("LocationArn");
                    context.Writer.Write(publicRequest.LocationArn);
                }
=======
                if(publicRequest.IsSetKerberosKeytab())
                {
                    context.Writer.WritePropertyName("KerberosKeytab");
                    context.Writer.Write(StringUtils.FromMemoryStream(publicRequest.KerberosKeytab));
                }

                if(publicRequest.IsSetKerberosKrb5Conf())
                {
                    context.Writer.WritePropertyName("KerberosKrb5Conf");
                    context.Writer.Write(StringUtils.FromMemoryStream(publicRequest.KerberosKrb5Conf));
                }

                if(publicRequest.IsSetKerberosPrincipal())
                {
                    context.Writer.WritePropertyName("KerberosPrincipal");
                    context.Writer.Write(publicRequest.KerberosPrincipal);
                }

                if(publicRequest.IsSetLocationArn())
                {
                    context.Writer.WritePropertyName("LocationArn");
                    context.Writer.Write(publicRequest.LocationArn);
                }
>>>>>>> 155cf7e693f514d013f0b7a90cc36b7db1c33d52

                    if(publicRequest.IsSetMountOptions())
                    {
                        context.Writer.WritePropertyName("MountOptions");
                        context.Writer.WriteObjectStart();

                        var marshaller = SmbMountOptionsMarshaller.Instance;
                        marshaller.Marshall(publicRequest.MountOptions, context);

                        context.Writer.WriteObjectEnd();
                    }

                    if(publicRequest.IsSetPassword())
                    {
                        context.Writer.WritePropertyName("Password");
                        context.Writer.Write(publicRequest.Password);
                    }

                    if(publicRequest.IsSetSubdirectory())
                    {
                        context.Writer.WritePropertyName("Subdirectory");
                        context.Writer.Write(publicRequest.Subdirectory);
                    }

                    if(publicRequest.IsSetUser())
                    {
                        context.Writer.WritePropertyName("User");
                        context.Writer.Write(publicRequest.User);
                    }

                    writer.WriteObjectEnd();
                }

                request.Content = memoryStream.ToArray();
            }


            return request;
        }
        private static UpdateLocationSmbRequestMarshaller _instance = new UpdateLocationSmbRequestMarshaller();        

        internal static UpdateLocationSmbRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateLocationSmbRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}