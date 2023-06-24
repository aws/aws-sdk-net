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

namespace Amazon.IoTWireless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateFuotaTask Request Marshaller
    /// </summary>       
    public class UpdateFuotaTaskRequestMarshaller : IMarshaller<IRequest, UpdateFuotaTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateFuotaTaskRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateFuotaTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTWireless");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-22";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetId())
                throw new AmazonIoTWirelessException("Request object does not have required field Id set");
            request.AddPathResource("{Id}", StringUtils.FromString(publicRequest.Id));
            request.ResourcePath = "/fuota-tasks/{Id}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
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

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateFuotaTaskRequestMarshaller _instance = new UpdateFuotaTaskRequestMarshaller();        

        internal static UpdateFuotaTaskRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateFuotaTaskRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}