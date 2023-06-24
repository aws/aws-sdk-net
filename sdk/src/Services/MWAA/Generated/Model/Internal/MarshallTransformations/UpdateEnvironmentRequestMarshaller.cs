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
 * Do not modify this file. This file is generated from the mwaa-2020-07-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MWAA.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MWAA.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateEnvironment Request Marshaller
    /// </summary>       
    public class UpdateEnvironmentRequestMarshaller : IMarshaller<IRequest, UpdateEnvironmentRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateEnvironmentRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateEnvironmentRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MWAA");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-07-01";
            request.HttpMethod = "PATCH";

            if (!publicRequest.IsSetName())
                throw new AmazonMWAAException("Request object does not have required field Name set");
            request.AddPathResource("{Name}", StringUtils.FromString(publicRequest.Name));
            request.ResourcePath = "/environments/{Name}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAirflowConfigurationOptions())
                {
                    context.Writer.WritePropertyName("AirflowConfigurationOptions");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestAirflowConfigurationOptionsKvp in publicRequest.AirflowConfigurationOptions)
                    {
                        context.Writer.WritePropertyName(publicRequestAirflowConfigurationOptionsKvp.Key);
                        var publicRequestAirflowConfigurationOptionsValue = publicRequestAirflowConfigurationOptionsKvp.Value;

                            context.Writer.Write(publicRequestAirflowConfigurationOptionsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAirflowVersion())
                {
                    context.Writer.WritePropertyName("AirflowVersion");
                    context.Writer.Write(publicRequest.AirflowVersion);
                }

                if(publicRequest.IsSetDagS3Path())
                {
                    context.Writer.WritePropertyName("DagS3Path");
                    context.Writer.Write(publicRequest.DagS3Path);
                }

                if(publicRequest.IsSetEnvironmentClass())
                {
                    context.Writer.WritePropertyName("EnvironmentClass");
                    context.Writer.Write(publicRequest.EnvironmentClass);
                }

                if(publicRequest.IsSetExecutionRoleArn())
                {
                    context.Writer.WritePropertyName("ExecutionRoleArn");
                    context.Writer.Write(publicRequest.ExecutionRoleArn);
                }

                if(publicRequest.IsSetLoggingConfiguration())
                {
                    context.Writer.WritePropertyName("LoggingConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = LoggingConfigurationInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LoggingConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMaxWorkers())
                {
                    context.Writer.WritePropertyName("MaxWorkers");
                    context.Writer.Write(publicRequest.MaxWorkers);
                }

                if(publicRequest.IsSetMinWorkers())
                {
                    context.Writer.WritePropertyName("MinWorkers");
                    context.Writer.Write(publicRequest.MinWorkers);
                }

                if(publicRequest.IsSetNetworkConfiguration())
                {
                    context.Writer.WritePropertyName("NetworkConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = UpdateNetworkConfigurationInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NetworkConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPluginsS3ObjectVersion())
                {
                    context.Writer.WritePropertyName("PluginsS3ObjectVersion");
                    context.Writer.Write(publicRequest.PluginsS3ObjectVersion);
                }

                if(publicRequest.IsSetPluginsS3Path())
                {
                    context.Writer.WritePropertyName("PluginsS3Path");
                    context.Writer.Write(publicRequest.PluginsS3Path);
                }

                if(publicRequest.IsSetRequirementsS3ObjectVersion())
                {
                    context.Writer.WritePropertyName("RequirementsS3ObjectVersion");
                    context.Writer.Write(publicRequest.RequirementsS3ObjectVersion);
                }

                if(publicRequest.IsSetRequirementsS3Path())
                {
                    context.Writer.WritePropertyName("RequirementsS3Path");
                    context.Writer.Write(publicRequest.RequirementsS3Path);
                }

                if(publicRequest.IsSetSchedulers())
                {
                    context.Writer.WritePropertyName("Schedulers");
                    context.Writer.Write(publicRequest.Schedulers);
                }

                if(publicRequest.IsSetSourceBucketArn())
                {
                    context.Writer.WritePropertyName("SourceBucketArn");
                    context.Writer.Write(publicRequest.SourceBucketArn);
                }

                if(publicRequest.IsSetStartupScriptS3ObjectVersion())
                {
                    context.Writer.WritePropertyName("StartupScriptS3ObjectVersion");
                    context.Writer.Write(publicRequest.StartupScriptS3ObjectVersion);
                }

                if(publicRequest.IsSetStartupScriptS3Path())
                {
                    context.Writer.WritePropertyName("StartupScriptS3Path");
                    context.Writer.Write(publicRequest.StartupScriptS3Path);
                }

                if(publicRequest.IsSetWebserverAccessMode())
                {
                    context.Writer.WritePropertyName("WebserverAccessMode");
                    context.Writer.Write(publicRequest.WebserverAccessMode);
                }

                if(publicRequest.IsSetWeeklyMaintenanceWindowStart())
                {
                    context.Writer.WritePropertyName("WeeklyMaintenanceWindowStart");
                    context.Writer.Write(publicRequest.WeeklyMaintenanceWindowStart);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

            
            request.HostPrefix = $"api.";

            return request;
        }
        private static UpdateEnvironmentRequestMarshaller _instance = new UpdateEnvironmentRequestMarshaller();        

        internal static UpdateEnvironmentRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateEnvironmentRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}