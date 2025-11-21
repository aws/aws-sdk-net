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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DataZone.Model;
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
namespace Amazon.DataZone.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutEnvironmentBlueprintConfiguration Request Marshaller
    /// </summary>       
    public class PutEnvironmentBlueprintConfigurationRequestMarshaller : IMarshaller<IRequest, PutEnvironmentBlueprintConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutEnvironmentBlueprintConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutEnvironmentBlueprintConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataZone");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetDomainIdentifier())
                throw new AmazonDataZoneException("Request object does not have required field DomainIdentifier set");
            request.AddPathResource("{domainIdentifier}", StringUtils.FromString(publicRequest.DomainIdentifier));
            if (!publicRequest.IsSetEnvironmentBlueprintIdentifier())
                throw new AmazonDataZoneException("Request object does not have required field EnvironmentBlueprintIdentifier set");
            request.AddPathResource("{environmentBlueprintIdentifier}", StringUtils.FromString(publicRequest.EnvironmentBlueprintIdentifier));
            request.ResourcePath = "/v2/domains/{domainIdentifier}/environment-blueprint-configurations/{environmentBlueprintIdentifier}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetEnabledRegions())
            {
                context.Writer.WritePropertyName("enabledRegions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestEnabledRegionsListValue in publicRequest.EnabledRegions)
                {
                        context.Writer.WriteStringValue(publicRequestEnabledRegionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetEnvironmentRolePermissionBoundary())
            {
                context.Writer.WritePropertyName("environmentRolePermissionBoundary");
                context.Writer.WriteStringValue(publicRequest.EnvironmentRolePermissionBoundary);
            }

            if(publicRequest.IsSetGlobalParameters())
            {
                context.Writer.WritePropertyName("globalParameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestGlobalParametersKvp in publicRequest.GlobalParameters)
                {
                    context.Writer.WritePropertyName(publicRequestGlobalParametersKvp.Key);
                    var publicRequestGlobalParametersValue = publicRequestGlobalParametersKvp.Value;

                        context.Writer.WriteStringValue(publicRequestGlobalParametersValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetManageAccessRoleArn())
            {
                context.Writer.WritePropertyName("manageAccessRoleArn");
                context.Writer.WriteStringValue(publicRequest.ManageAccessRoleArn);
            }

            if(publicRequest.IsSetProvisioningConfigurations())
            {
                context.Writer.WritePropertyName("provisioningConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestProvisioningConfigurationsListValue in publicRequest.ProvisioningConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ProvisioningConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestProvisioningConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetProvisioningRoleArn())
            {
                context.Writer.WritePropertyName("provisioningRoleArn");
                context.Writer.WriteStringValue(publicRequest.ProvisioningRoleArn);
            }

            if(publicRequest.IsSetRegionalParameters())
            {
                context.Writer.WritePropertyName("regionalParameters");
                context.Writer.WriteStartObject();
                foreach (var publicRequestRegionalParametersKvp in publicRequest.RegionalParameters)
                {
                    context.Writer.WritePropertyName(publicRequestRegionalParametersKvp.Key);
                    var publicRequestRegionalParametersValue = publicRequestRegionalParametersKvp.Value;

                    context.Writer.WriteStartObject();
                    foreach (var publicRequestRegionalParametersValueKvp in publicRequestRegionalParametersValue)
                    {
                        context.Writer.WritePropertyName(publicRequestRegionalParametersValueKvp.Key);
                        var publicRequestRegionalParametersValueValue = publicRequestRegionalParametersValueKvp.Value;

                            context.Writer.WriteStringValue(publicRequestRegionalParametersValueValue);
                    }
                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
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
        private static PutEnvironmentBlueprintConfigurationRequestMarshaller _instance = new PutEnvironmentBlueprintConfigurationRequestMarshaller();        

        internal static PutEnvironmentBlueprintConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutEnvironmentBlueprintConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}