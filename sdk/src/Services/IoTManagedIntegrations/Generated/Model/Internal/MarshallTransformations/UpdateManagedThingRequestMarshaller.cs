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
 * Do not modify this file. This file is generated from the iot-managed-integrations-2025-03-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTManagedIntegrations.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTManagedIntegrations.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateManagedThing Request Marshaller
    /// </summary>       
    public class UpdateManagedThingRequestMarshaller : IMarshaller<IRequest, UpdateManagedThingRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateManagedThingRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateManagedThingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoTManagedIntegrations");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-03-03";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetIdentifier())
                throw new AmazonIoTManagedIntegrationsException("Request object does not have required field Identifier set");
            request.AddPathResource("{Identifier}", StringUtils.FromString(publicRequest.Identifier));
            request.ResourcePath = "/managed-things/{Identifier}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBrand())
                {
                    context.Writer.WritePropertyName("Brand");
                    context.Writer.Write(publicRequest.Brand);
                }

                if(publicRequest.IsSetCapabilities())
                {
                    context.Writer.WritePropertyName("Capabilities");
                    context.Writer.Write(publicRequest.Capabilities);
                }

                if(publicRequest.IsSetCapabilityReport())
                {
                    context.Writer.WritePropertyName("CapabilityReport");
                    context.Writer.WriteObjectStart();

                    var marshaller = CapabilityReportMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CapabilityReport, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCapabilitySchemas())
                {
                    context.Writer.WritePropertyName("CapabilitySchemas");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCapabilitySchemasListValue in publicRequest.CapabilitySchemas)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CapabilitySchemaItemMarshaller.Instance;
                        marshaller.Marshall(publicRequestCapabilitySchemasListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetClassification())
                {
                    context.Writer.WritePropertyName("Classification");
                    context.Writer.Write(publicRequest.Classification);
                }

                if(publicRequest.IsSetCredentialLockerId())
                {
                    context.Writer.WritePropertyName("CredentialLockerId");
                    context.Writer.Write(publicRequest.CredentialLockerId);
                }

                if(publicRequest.IsSetHubNetworkMode())
                {
                    context.Writer.WritePropertyName("HubNetworkMode");
                    context.Writer.Write(publicRequest.HubNetworkMode);
                }

                if(publicRequest.IsSetMetaData())
                {
                    context.Writer.WritePropertyName("MetaData");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestMetaDataKvp in publicRequest.MetaData)
                    {
                        context.Writer.WritePropertyName(publicRequestMetaDataKvp.Key);
                        var publicRequestMetaDataValue = publicRequestMetaDataKvp.Value;

                            context.Writer.Write(publicRequestMetaDataValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetModel())
                {
                    context.Writer.WritePropertyName("Model");
                    context.Writer.Write(publicRequest.Model);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetOwner())
                {
                    context.Writer.WritePropertyName("Owner");
                    context.Writer.Write(publicRequest.Owner);
                }

                if(publicRequest.IsSetSerialNumber())
                {
                    context.Writer.WritePropertyName("SerialNumber");
                    context.Writer.Write(publicRequest.SerialNumber);
                }

                if(publicRequest.IsSetWiFiSimpleSetupConfiguration())
                {
                    context.Writer.WritePropertyName("WiFiSimpleSetupConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = WiFiSimpleSetupConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.WiFiSimpleSetupConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateManagedThingRequestMarshaller _instance = new UpdateManagedThingRequestMarshaller();        

        internal static UpdateManagedThingRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateManagedThingRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}