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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Synthetics.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Synthetics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartCanaryDryRun Request Marshaller
    /// </summary>       
    public class StartCanaryDryRunRequestMarshaller : IMarshaller<IRequest, StartCanaryDryRunRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartCanaryDryRunRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartCanaryDryRunRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Synthetics");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-11";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetName())
                throw new AmazonSyntheticsException("Request object does not have required field Name set");
            request.AddPathResource("{name}", StringUtils.FromString(publicRequest.Name));
            request.ResourcePath = "/canary/{name}/dry-run/start";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetArtifactConfig())
                {
                    context.Writer.WritePropertyName("ArtifactConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = ArtifactConfigInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ArtifactConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetArtifactS3Location())
                {
                    context.Writer.WritePropertyName("ArtifactS3Location");
                    context.Writer.Write(publicRequest.ArtifactS3Location);
                }

                if(publicRequest.IsSetBrowserConfigs())
                {
                    context.Writer.WritePropertyName("BrowserConfigs");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestBrowserConfigsListValue in publicRequest.BrowserConfigs)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = BrowserConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequestBrowserConfigsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetCode())
                {
                    context.Writer.WritePropertyName("Code");
                    context.Writer.WriteObjectStart();

                    var marshaller = CanaryCodeInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Code, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetExecutionRoleArn())
                {
                    context.Writer.WritePropertyName("ExecutionRoleArn");
                    context.Writer.Write(publicRequest.ExecutionRoleArn);
                }

                if(publicRequest.IsSetFailureRetentionPeriodInDays())
                {
                    context.Writer.WritePropertyName("FailureRetentionPeriodInDays");
                    context.Writer.Write(publicRequest.FailureRetentionPeriodInDays);
                }

                if(publicRequest.IsSetProvisionedResourceCleanup())
                {
                    context.Writer.WritePropertyName("ProvisionedResourceCleanup");
                    context.Writer.Write(publicRequest.ProvisionedResourceCleanup);
                }

                if(publicRequest.IsSetRunConfig())
                {
                    context.Writer.WritePropertyName("RunConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = CanaryRunConfigInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RunConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRuntimeVersion())
                {
                    context.Writer.WritePropertyName("RuntimeVersion");
                    context.Writer.Write(publicRequest.RuntimeVersion);
                }

                if(publicRequest.IsSetSuccessRetentionPeriodInDays())
                {
                    context.Writer.WritePropertyName("SuccessRetentionPeriodInDays");
                    context.Writer.Write(publicRequest.SuccessRetentionPeriodInDays);
                }

                if(publicRequest.IsSetVisualReference())
                {
                    context.Writer.WritePropertyName("VisualReference");
                    context.Writer.WriteObjectStart();

                    var marshaller = VisualReferenceInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VisualReference, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetVisualReferences())
                {
                    context.Writer.WritePropertyName("VisualReferences");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestVisualReferencesListValue in publicRequest.VisualReferences)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = VisualReferenceInputMarshaller.Instance;
                        marshaller.Marshall(publicRequestVisualReferencesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetVpcConfig())
                {
                    context.Writer.WritePropertyName("VpcConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = VpcConfigInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.VpcConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static StartCanaryDryRunRequestMarshaller _instance = new StartCanaryDryRunRequestMarshaller();        

        internal static StartCanaryDryRunRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartCanaryDryRunRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}