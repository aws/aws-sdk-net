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
using System.Xml.Serialization;
using System.Text;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Add Job Flow Steps Request Marshaller
    /// </summary>       
    public class AddJobFlowStepsRequestMarshaller : IMarshaller<IRequest, AddJobFlowStepsRequest>
    {
        public IRequest Marshall(AddJobFlowStepsRequest addJobFlowStepsRequest)
        {
            IRequest request = new DefaultRequest(addJobFlowStepsRequest, "AmazonElasticMapReduce");
            request.Parameters.Add("Action", "AddJobFlowSteps");
            request.Parameters.Add("Version", "2009-03-31");
            if (addJobFlowStepsRequest != null && addJobFlowStepsRequest.IsSetJobFlowId())
            {
                request.Parameters.Add("JobFlowId", StringUtils.FromString(addJobFlowStepsRequest.JobFlowId));
            }

            if (addJobFlowStepsRequest != null)
            {
                List<StepConfig> stepsList = addJobFlowStepsRequest.Steps;
                int stepsListIndex = 1;
                foreach (StepConfig stepsListValue in stepsList)
                {
                    if (stepsListValue != null && stepsListValue.IsSetName())
                    {
                        request.Parameters.Add("Steps.member." + stepsListIndex + ".Name", StringUtils.FromString(stepsListValue.Name));
                    }
                    if (stepsListValue != null && stepsListValue.IsSetActionOnFailure())
                    {
                        request.Parameters.Add("Steps.member." + stepsListIndex + ".ActionOnFailure", StringUtils.FromString(stepsListValue.ActionOnFailure));
                    }
                    if (stepsListValue != null)
                    {
                        HadoopJarStepConfig hadoopJarStep = stepsListValue.HadoopJarStep;

                        if (hadoopJarStep != null)
                        {
                            List<KeyValue> propertiesList = hadoopJarStep.Properties;
                            int propertiesListIndex = 1;
                            foreach (KeyValue propertiesListValue in propertiesList)
                            {
                                if (propertiesListValue != null && propertiesListValue.IsSetKey())
                                {
                                    request.Parameters.Add("Steps.member." + stepsListIndex + ".HadoopJarStep.Properties.member." + propertiesListIndex + ".Key", StringUtils.FromString(propertiesListValue.Key));
                                }
                                if (propertiesListValue != null && propertiesListValue.IsSetValue())
                                {
                                    request.Parameters.Add("Steps.member." + stepsListIndex + ".HadoopJarStep.Properties.member." + propertiesListIndex + ".Value", StringUtils.FromString(propertiesListValue.Value));
                                }

                                propertiesListIndex++;
                            }
                        }
                        if (hadoopJarStep != null && hadoopJarStep.IsSetJar())
                        {
                            request.Parameters.Add("Steps.member." + stepsListIndex + ".HadoopJarStep.Jar", StringUtils.FromString(hadoopJarStep.Jar));
                        }
                        if (hadoopJarStep != null && hadoopJarStep.IsSetMainClass())
                        {
                            request.Parameters.Add("Steps.member." + stepsListIndex + ".HadoopJarStep.MainClass", StringUtils.FromString(hadoopJarStep.MainClass));
                        }
                        if (hadoopJarStep != null)
                        {
                            List<string> argsList = hadoopJarStep.Args;

                            int argsListIndex = 1;
                            foreach (string argsListValue in argsList)
                            { 
                                request.Parameters.Add("Steps.member." + stepsListIndex + ".HadoopJarStep.Args.member." + argsListIndex, StringUtils.FromString(argsListValue));
                                argsListIndex++;
                            }
                        }
                    }

                    stepsListIndex++;
                }
            }

            return request;
        }
    }
}
