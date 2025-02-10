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
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DataZone");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetDomainIdentifier())
                throw new AmazonDataZoneException("Request object does not have required field DomainIdentifier set");
            request.AddPathResource("{domainIdentifier}", StringUtils.FromString(publicRequest.DomainIdentifier));
            request.ResourcePath = "/v2/domains/{domainIdentifier}/environments";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDeploymentOrder())
            {
                context.Writer.WritePropertyName("deploymentOrder");
                context.Writer.WriteNumberValue(publicRequest.DeploymentOrder.Value);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEnvironmentAccountIdentifier())
            {
                context.Writer.WritePropertyName("environmentAccountIdentifier");
                context.Writer.WriteStringValue(publicRequest.EnvironmentAccountIdentifier);
            }

            if(publicRequest.IsSetEnvironmentAccountRegion())
            {
                context.Writer.WritePropertyName("environmentAccountRegion");
                context.Writer.WriteStringValue(publicRequest.EnvironmentAccountRegion);
            }

            if(publicRequest.IsSetEnvironmentBlueprintIdentifier())
            {
                context.Writer.WritePropertyName("environmentBlueprintIdentifier");
                context.Writer.WriteStringValue(publicRequest.EnvironmentBlueprintIdentifier);
            }

            if(publicRequest.IsSetEnvironmentConfigurationId())
            {
                context.Writer.WritePropertyName("environmentConfigurationId");
                context.Writer.WriteStringValue(publicRequest.EnvironmentConfigurationId);
            }

            if(publicRequest.IsSetEnvironmentProfileIdentifier())
            {
                context.Writer.WritePropertyName("environmentProfileIdentifier");
                context.Writer.WriteStringValue(publicRequest.EnvironmentProfileIdentifier);
            }

            if(publicRequest.IsSetGlossaryTerms())
            {
                context.Writer.WritePropertyName("glossaryTerms");
                context.Writer.WriteStartArray();
                foreach(var publicRequestGlossaryTermsListValue in publicRequest.GlossaryTerms)
                {
                        context.Writer.WriteStringValue(publicRequestGlossaryTermsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetProjectIdentifier())
            {
                context.Writer.WritePropertyName("projectIdentifier");
                context.Writer.WriteStringValue(publicRequest.ProjectIdentifier);
            }

            if(publicRequest.IsSetUserParameters())
            {
                context.Writer.WritePropertyName("userParameters");
                context.Writer.WriteStartArray();
                foreach(var publicRequestUserParametersListValue in publicRequest.UserParameters)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = EnvironmentParameterMarshaller.Instance;
                    marshaller.Marshall(publicRequestUserParametersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
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