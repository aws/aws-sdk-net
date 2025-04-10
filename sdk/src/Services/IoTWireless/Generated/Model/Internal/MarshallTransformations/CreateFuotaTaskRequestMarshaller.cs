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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTWireless.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTWireless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFuotaTask Request Marshaller
    /// </summary>       
    public class CreateFuotaTaskRequestMarshaller : IMarshaller<IRequest, CreateFuotaTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFuotaTaskRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFuotaTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTWireless");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-22";
            request.HttpMethod = "POST";

            request.ResourcePath = "/fuota-tasks";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientRequestToken())
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(publicRequest.ClientRequestToken);
                }

                else if(!(publicRequest.IsSetClientRequestToken()))
                {
                    context.Writer.WritePropertyName("ClientRequestToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetDescriptor())
                {
                    context.Writer.WritePropertyName("Descriptor");
                    context.Writer.Write(publicRequest.Descriptor);
                }

                if(publicRequest.IsSetFirmwareUpdateImage())
                {
                    context.Writer.WritePropertyName("FirmwareUpdateImage");
                    context.Writer.Write(publicRequest.FirmwareUpdateImage);
                }

                if(publicRequest.IsSetFirmwareUpdateRole())
                {
                    context.Writer.WritePropertyName("FirmwareUpdateRole");
                    context.Writer.Write(publicRequest.FirmwareUpdateRole);
                }

                if(publicRequest.IsSetFragmentIntervalMS())
                {
                    context.Writer.WritePropertyName("FragmentIntervalMS");
                    context.Writer.Write(publicRequest.FragmentIntervalMS);
                }

                if(publicRequest.IsSetFragmentSizeBytes())
                {
                    context.Writer.WritePropertyName("FragmentSizeBytes");
                    context.Writer.Write(publicRequest.FragmentSizeBytes);
                }

                if(publicRequest.IsSetLoRaWAN())
                {
                    context.Writer.WritePropertyName("LoRaWAN");
                    context.Writer.WriteObjectStart();

                    var marshaller = LoRaWANFuotaTaskMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LoRaWAN, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetRedundancyPercent())
                {
                    context.Writer.WritePropertyName("RedundancyPercent");
                    context.Writer.Write(publicRequest.RedundancyPercent);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateFuotaTaskRequestMarshaller _instance = new CreateFuotaTaskRequestMarshaller();        

        internal static CreateFuotaTaskRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFuotaTaskRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}