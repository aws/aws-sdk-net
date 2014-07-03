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
    /// AddJobFlowSteps Request Marshaller
    /// </summary>       
    public class AddJobFlowStepsRequestMarshaller : IMarshaller<IRequest, AddJobFlowStepsRequest> 
    {
        public IRequest Marshall(AddJobFlowStepsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ElasticMapReduce");
            string target = "ElasticMapReduce.AddJobFlowSteps";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                if(publicRequest.IsSetJobFlowId())
                {
                    writer.WritePropertyName("JobFlowId");
                    writer.Write(publicRequest.JobFlowId);
                }

                if(publicRequest.IsSetSteps())
                {
                    writer.WritePropertyName("Steps");
                    writer.WriteArrayStart();
                    foreach(var publicRequestStepsListValue in publicRequest.Steps)
                    {
                        writer.WriteObjectStart();
                        if(publicRequestStepsListValue.IsSetActionOnFailure())
                        {
                            writer.WritePropertyName("ActionOnFailure");
                            writer.Write(publicRequestStepsListValue.ActionOnFailure);
                        }

                        if(publicRequestStepsListValue.IsSetHadoopJarStep())
                        {
                            writer.WritePropertyName("HadoopJarStep");
                            writer.WriteObjectStart();
                            if(publicRequestStepsListValue.HadoopJarStep.IsSetArgs())
                            {
                                writer.WritePropertyName("Args");
                                writer.WriteArrayStart();
                                foreach(var publicRequestStepsListValueHadoopJarStepArgsListValue in publicRequestStepsListValue.HadoopJarStep.Args)
                                {
                                    writer.Write(publicRequestStepsListValueHadoopJarStepArgsListValue);
                                }
                                writer.WriteArrayEnd();
                            }

                            if(publicRequestStepsListValue.HadoopJarStep.IsSetJar())
                            {
                                writer.WritePropertyName("Jar");
                                writer.Write(publicRequestStepsListValue.HadoopJarStep.Jar);
                            }

                            if(publicRequestStepsListValue.HadoopJarStep.IsSetMainClass())
                            {
                                writer.WritePropertyName("MainClass");
                                writer.Write(publicRequestStepsListValue.HadoopJarStep.MainClass);
                            }

                            if(publicRequestStepsListValue.HadoopJarStep.IsSetProperties())
                            {
                                writer.WritePropertyName("Properties");
                                writer.WriteArrayStart();
                                foreach(var publicRequestStepsListValueHadoopJarStepPropertiesListValue in publicRequestStepsListValue.HadoopJarStep.Properties)
                                {
                                    writer.WriteObjectStart();
                                    if(publicRequestStepsListValueHadoopJarStepPropertiesListValue.IsSetKey())
                                    {
                                        writer.WritePropertyName("Key");
                                        writer.Write(publicRequestStepsListValueHadoopJarStepPropertiesListValue.Key);
                                    }

                                    if(publicRequestStepsListValueHadoopJarStepPropertiesListValue.IsSetValue())
                                    {
                                        writer.WritePropertyName("Value");
                                        writer.Write(publicRequestStepsListValueHadoopJarStepPropertiesListValue.Value);
                                    }

                                    writer.WriteObjectEnd();
                                }
                                writer.WriteArrayEnd();
                            }

                            writer.WriteObjectEnd();
                        }

                        if(publicRequestStepsListValue.IsSetName())
                        {
                            writer.WritePropertyName("Name");
                            writer.Write(publicRequestStepsListValue.Name);
                        }

                        writer.WriteObjectEnd();
                    }
                    writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}