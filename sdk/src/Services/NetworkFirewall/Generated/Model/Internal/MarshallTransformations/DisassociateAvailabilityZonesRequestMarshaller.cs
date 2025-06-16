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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkFirewall.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DisassociateAvailabilityZones Request Marshaller
    /// </summary>       
    public class DisassociateAvailabilityZonesRequestMarshaller : IMarshaller<IRequest, DisassociateAvailabilityZonesRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DisassociateAvailabilityZonesRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DisassociateAvailabilityZonesRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkFirewall");
            string target = "NetworkFirewall_20201112.DisassociateAvailabilityZones";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-12";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAvailabilityZoneMappings())
                {
                    context.Writer.WritePropertyName("AvailabilityZoneMappings");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestAvailabilityZoneMappingsListValue in publicRequest.AvailabilityZoneMappings)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = AvailabilityZoneMappingMarshaller.Instance;
                        marshaller.Marshall(publicRequestAvailabilityZoneMappingsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetFirewallArn())
                {
                    context.Writer.WritePropertyName("FirewallArn");
                    context.Writer.Write(publicRequest.FirewallArn);
                }

                if(publicRequest.IsSetFirewallName())
                {
                    context.Writer.WritePropertyName("FirewallName");
                    context.Writer.Write(publicRequest.FirewallName);
                }

                if(publicRequest.IsSetUpdateToken())
                {
                    context.Writer.WritePropertyName("UpdateToken");
                    context.Writer.Write(publicRequest.UpdateToken);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static DisassociateAvailabilityZonesRequestMarshaller _instance = new DisassociateAvailabilityZonesRequestMarshaller();        

        internal static DisassociateAvailabilityZonesRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DisassociateAvailabilityZonesRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}