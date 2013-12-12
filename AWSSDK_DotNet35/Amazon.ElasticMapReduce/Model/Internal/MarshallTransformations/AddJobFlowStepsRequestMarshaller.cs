/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Add Job Flow Steps Request Marshaller
    /// </summary>       
    internal class AddJobFlowStepsRequestMarshaller : IMarshaller<IRequest, AddJobFlowStepsRequest> 
    {
        

        public IRequest Marshall(AddJobFlowStepsRequest addJobFlowStepsRequest) 
        {

            IRequest request = new DefaultRequest(addJobFlowStepsRequest, "AmazonElasticMapReduce");
            string target = "ElasticMapReduce.AddJobFlowSteps";
            request.Headers["X-Amz-Target"] = target;
            
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            
              
            string uriResourcePath = ""; 
            
            if (uriResourcePath.Contains("?")) 
            {
                int queryPosition = uriResourcePath.IndexOf("?", StringComparison.OrdinalIgnoreCase);
                string queryString = uriResourcePath.Substring(queryPosition + 1);
                uriResourcePath    = uriResourcePath.Substring(0, queryPosition);
        
                foreach (string s in queryString.Split('&', ';')) 
                {
                    string[] nameValuePair = s.Split('=');
                    if (nameValuePair.Length == 2 && nameValuePair[1].Length > 0) 
                    {
                        request.Parameters.Add(nameValuePair[0], nameValuePair[1]);
                    }
                    else
                    {
                        request.Parameters.Add(nameValuePair[0], null);
                    }
                }
            }
            
            request.ResourcePath = uriResourcePath;
            
             
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                
                if (addJobFlowStepsRequest != null && addJobFlowStepsRequest.IsSetJobFlowId()) 
                {
                    writer.WritePropertyName("JobFlowId");
                    writer.Write(addJobFlowStepsRequest.JobFlowId);
                }

                if (addJobFlowStepsRequest != null && addJobFlowStepsRequest.Steps != null && addJobFlowStepsRequest.Steps.Count > 0)
                {
                    List<StepConfig> stepsList = addJobFlowStepsRequest.Steps;
                    writer.WritePropertyName("Steps");
                    writer.WriteArrayStart();

                    foreach (StepConfig stepsListValue in stepsList) 
                    {
                        writer.WriteObjectStart();
                        if (stepsListValue != null && stepsListValue.IsSetName()) 
                        {
                            writer.WritePropertyName("Name");
                            writer.Write(stepsListValue.Name);
                        }
                        if (stepsListValue != null && stepsListValue.IsSetActionOnFailure()) 
                        {
                            writer.WritePropertyName("ActionOnFailure");
                            writer.Write(stepsListValue.ActionOnFailure);
                        }

                        if (stepsListValue != null) 
                        {
                            HadoopJarStepConfig hadoopJarStep = stepsListValue.HadoopJarStep;
                            if (hadoopJarStep != null)
                            {
                                writer.WritePropertyName("HadoopJarStep");
                                writer.WriteObjectStart();

                                if (hadoopJarStep != null && hadoopJarStep.Properties != null && hadoopJarStep.Properties.Count > 0)
                                {
                                    List<KeyValue> propertiesList = hadoopJarStep.Properties;
                                    writer.WritePropertyName("Properties");
                                    writer.WriteArrayStart();

                                    foreach (KeyValue propertiesListValue in propertiesList) 
                                    {
                                        writer.WriteObjectStart();
                                        if (propertiesListValue != null && propertiesListValue.IsSetKey()) 
                                        {
                                            writer.WritePropertyName("Key");
                                            writer.Write(propertiesListValue.Key);
                                        }
                                        if (propertiesListValue != null && propertiesListValue.IsSetValue()) 
                                        {
                                            writer.WritePropertyName("Value");
                                            writer.Write(propertiesListValue.Value);
                                        }
                                        writer.WriteObjectEnd();
                                    }
                                    writer.WriteArrayEnd();
                                }
                                if (hadoopJarStep != null && hadoopJarStep.IsSetJar()) 
                                {
                                    writer.WritePropertyName("Jar");
                                    writer.Write(hadoopJarStep.Jar);
                                }
                                if (hadoopJarStep != null && hadoopJarStep.IsSetMainClass()) 
                                {
                                    writer.WritePropertyName("MainClass");
                                    writer.Write(hadoopJarStep.MainClass);
                                }

                                if (hadoopJarStep != null && hadoopJarStep.Args != null && hadoopJarStep.Args.Count > 0) 
                                {
                                    List<string> argsList = hadoopJarStep.Args;
                                    writer.WritePropertyName("Args");
                                    writer.WriteArrayStart();

                                    foreach (string argsListValue in argsList) 
                                    { 
                                        writer.Write(StringUtils.FromString(argsListValue));
                                    }

                                    writer.WriteArrayEnd();
                                }
                                writer.WriteObjectEnd();
                            }
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
