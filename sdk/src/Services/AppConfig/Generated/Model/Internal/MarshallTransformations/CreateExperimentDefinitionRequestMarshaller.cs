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
 * Do not modify this file. This file is generated from the appconfig-2019-10-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppConfig.Model;
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
namespace Amazon.AppConfig.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateExperimentDefinition Request Marshaller
    /// </summary>       
    public class CreateExperimentDefinitionRequestMarshaller : IMarshaller<IRequest, CreateExperimentDefinitionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateExperimentDefinitionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateExperimentDefinitionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppConfig");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-10-09";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetApplicationIdentifier())
                throw new AmazonAppConfigException("Request object does not have required field ApplicationIdentifier set");
            request.AddPathResource("{ApplicationIdentifier}", StringUtils.FromString(publicRequest.ApplicationIdentifier));
            request.ResourcePath = "/applications/{ApplicationIdentifier}/experimentdefinitions";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAudienceDescription())
            {
                context.Writer.WritePropertyName("AudienceDescription");
                context.Writer.WriteStringValue(publicRequest.AudienceDescription);
            }

            if(publicRequest.IsSetAudienceRule())
            {
                context.Writer.WritePropertyName("AudienceRule");
                context.Writer.WriteStringValue(publicRequest.AudienceRule);
            }

            if(publicRequest.IsSetConfigurationProfileIdentifier())
            {
                context.Writer.WritePropertyName("ConfigurationProfileIdentifier");
                context.Writer.WriteStringValue(publicRequest.ConfigurationProfileIdentifier);
            }

            if(publicRequest.IsSetControl())
            {
                context.Writer.WritePropertyName("Control");
                context.Writer.WriteStartObject();

                var marshaller = TreatmentInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.Control, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetEnvironmentIdentifier())
            {
                context.Writer.WritePropertyName("EnvironmentIdentifier");
                context.Writer.WriteStringValue(publicRequest.EnvironmentIdentifier);
            }

            if(publicRequest.IsSetFlagKey())
            {
                context.Writer.WritePropertyName("FlagKey");
                context.Writer.WriteStringValue(publicRequest.FlagKey);
            }

            if(publicRequest.IsSetHypothesis())
            {
                context.Writer.WritePropertyName("Hypothesis");
                context.Writer.WriteStringValue(publicRequest.Hypothesis);
            }

            if(publicRequest.IsSetLaunchCriteria())
            {
                context.Writer.WritePropertyName("LaunchCriteria");
                context.Writer.WriteStringValue(publicRequest.LaunchCriteria);
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetTreatments())
            {
                context.Writer.WritePropertyName("Treatments");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTreatmentsListValue in publicRequest.Treatments)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TreatmentInputMarshaller.Instance;
                    marshaller.Marshall(publicRequestTreatmentsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateExperimentDefinitionRequestMarshaller _instance = new CreateExperimentDefinitionRequestMarshaller();        

        internal static CreateExperimentDefinitionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateExperimentDefinitionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}