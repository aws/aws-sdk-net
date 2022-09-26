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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTFleetWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTFleetWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDecoderManifest Request Marshaller
    /// </summary>       
    public class UpdateDecoderManifestRequestMarshaller : IMarshaller<IRequest, UpdateDecoderManifestRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDecoderManifestRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDecoderManifestRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTFleetWise");
            string target = "IoTAutobahnControlPlane.UpdateDecoderManifest";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2021-06-17";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetNetworkInterfacesToAdd())
                {
                    context.Writer.WritePropertyName("networkInterfacesToAdd");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestNetworkInterfacesToAddListValue in publicRequest.NetworkInterfacesToAdd)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = NetworkInterfaceMarshaller.Instance;
                        marshaller.Marshall(publicRequestNetworkInterfacesToAddListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetNetworkInterfacesToRemove())
                {
                    context.Writer.WritePropertyName("networkInterfacesToRemove");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestNetworkInterfacesToRemoveListValue in publicRequest.NetworkInterfacesToRemove)
                    {
                            context.Writer.Write(publicRequestNetworkInterfacesToRemoveListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetNetworkInterfacesToUpdate())
                {
                    context.Writer.WritePropertyName("networkInterfacesToUpdate");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestNetworkInterfacesToUpdateListValue in publicRequest.NetworkInterfacesToUpdate)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = NetworkInterfaceMarshaller.Instance;
                        marshaller.Marshall(publicRequestNetworkInterfacesToUpdateListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSignalDecodersToAdd())
                {
                    context.Writer.WritePropertyName("signalDecodersToAdd");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSignalDecodersToAddListValue in publicRequest.SignalDecodersToAdd)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SignalDecoderMarshaller.Instance;
                        marshaller.Marshall(publicRequestSignalDecodersToAddListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSignalDecodersToRemove())
                {
                    context.Writer.WritePropertyName("signalDecodersToRemove");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSignalDecodersToRemoveListValue in publicRequest.SignalDecodersToRemove)
                    {
                            context.Writer.Write(publicRequestSignalDecodersToRemoveListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSignalDecodersToUpdate())
                {
                    context.Writer.WritePropertyName("signalDecodersToUpdate");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSignalDecodersToUpdateListValue in publicRequest.SignalDecodersToUpdate)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SignalDecoderMarshaller.Instance;
                        marshaller.Marshall(publicRequestSignalDecodersToUpdateListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetStatus())
                {
                    context.Writer.WritePropertyName("status");
                    context.Writer.Write(publicRequest.Status);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateDecoderManifestRequestMarshaller _instance = new UpdateDecoderManifestRequestMarshaller();        

        internal static UpdateDecoderManifestRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDecoderManifestRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}