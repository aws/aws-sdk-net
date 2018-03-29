/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RunJobFlow Request Marshaller
    /// </summary>       
    public class RunJobFlowRequestMarshaller : IMarshaller<IRequest, RunJobFlowRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RunJobFlowRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RunJobFlowRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticMapReduce");
            string target = "ElasticMapReduce.RunJobFlow";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAdditionalInfo())
                {
                    context.Writer.WritePropertyName("AdditionalInfo");
                    context.Writer.Write(publicRequest.AdditionalInfo);
                }

                if(publicRequest.IsSetAmiVersion())
                {
                    context.Writer.WritePropertyName("AmiVersion");
                    context.Writer.Write(publicRequest.AmiVersion);
                }

                if(publicRequest.IsSetApplications())
                {
                    context.Writer.WritePropertyName("Applications");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestApplicationsListValue in publicRequest.Applications)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ApplicationMarshaller.Instance;
                        marshaller.Marshall(publicRequestApplicationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetAutoScalingRole())
                {
                    context.Writer.WritePropertyName("AutoScalingRole");
                    context.Writer.Write(publicRequest.AutoScalingRole);
                }

                if(publicRequest.IsSetBootstrapActions())
                {
                    context.Writer.WritePropertyName("BootstrapActions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestBootstrapActionsListValue in publicRequest.BootstrapActions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = BootstrapActionConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequestBootstrapActionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetConfigurations())
                {
                    context.Writer.WritePropertyName("Configurations");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestConfigurationsListValue in publicRequest.Configurations)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ConfigurationMarshaller.Instance;
                        marshaller.Marshall(publicRequestConfigurationsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetCustomAmiId())
                {
                    context.Writer.WritePropertyName("CustomAmiId");
                    context.Writer.Write(publicRequest.CustomAmiId);
                }

                if(publicRequest.IsSetEbsRootVolumeSize())
                {
                    context.Writer.WritePropertyName("EbsRootVolumeSize");
                    context.Writer.Write(publicRequest.EbsRootVolumeSize);
                }

                if(publicRequest.IsSetInstances())
                {
                    context.Writer.WritePropertyName("Instances");
                    context.Writer.WriteObjectStart();

                    var marshaller = JobFlowInstancesConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Instances, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetJobFlowRole())
                {
                    context.Writer.WritePropertyName("JobFlowRole");
                    context.Writer.Write(publicRequest.JobFlowRole);
                }

                if(publicRequest.IsSetKerberosAttributes())
                {
                    context.Writer.WritePropertyName("KerberosAttributes");
                    context.Writer.WriteObjectStart();

                    var marshaller = KerberosAttributesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.KerberosAttributes, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetLogUri())
                {
                    context.Writer.WritePropertyName("LogUri");
                    context.Writer.Write(publicRequest.LogUri);
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("Name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetNewSupportedProducts())
                {
                    context.Writer.WritePropertyName("NewSupportedProducts");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestNewSupportedProductsListValue in publicRequest.NewSupportedProducts)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SupportedProductConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequestNewSupportedProductsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetReleaseLabel())
                {
                    context.Writer.WritePropertyName("ReleaseLabel");
                    context.Writer.Write(publicRequest.ReleaseLabel);
                }

                if(publicRequest.IsSetRepoUpgradeOnBoot())
                {
                    context.Writer.WritePropertyName("RepoUpgradeOnBoot");
                    context.Writer.Write(publicRequest.RepoUpgradeOnBoot);
                }

                if(publicRequest.IsSetScaleDownBehavior())
                {
                    context.Writer.WritePropertyName("ScaleDownBehavior");
                    context.Writer.Write(publicRequest.ScaleDownBehavior);
                }

                if(publicRequest.IsSetSecurityConfiguration())
                {
                    context.Writer.WritePropertyName("SecurityConfiguration");
                    context.Writer.Write(publicRequest.SecurityConfiguration);
                }

                if(publicRequest.IsSetServiceRole())
                {
                    context.Writer.WritePropertyName("ServiceRole");
                    context.Writer.Write(publicRequest.ServiceRole);
                }

                if(publicRequest.IsSetSteps())
                {
                    context.Writer.WritePropertyName("Steps");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestStepsListValue in publicRequest.Steps)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = StepConfigMarshaller.Instance;
                        marshaller.Marshall(publicRequestStepsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSupportedProducts())
                {
                    context.Writer.WritePropertyName("SupportedProducts");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSupportedProductsListValue in publicRequest.SupportedProducts)
                    {
                            context.Writer.Write(publicRequestSupportedProductsListValue);
                    }
                    context.Writer.WriteArrayEnd();
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

                if(publicRequest.IsSetVisibleToAllUsers())
                {
                    context.Writer.WritePropertyName("VisibleToAllUsers");
                    context.Writer.Write(publicRequest.VisibleToAllUsers);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static RunJobFlowRequestMarshaller _instance = new RunJobFlowRequestMarshaller();        

        internal static RunJobFlowRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RunJobFlowRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}