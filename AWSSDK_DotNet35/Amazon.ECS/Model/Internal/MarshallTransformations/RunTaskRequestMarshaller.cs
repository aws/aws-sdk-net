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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RunTask Request Marshaller
    /// </summary>       
    public class RunTaskRequestMarshaller : IMarshaller<IRequest, RunTaskRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RunTaskRequest)input);
        }
    
        public IRequest Marshall(RunTaskRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ECS");
            request.Parameters.Add("Action", "RunTask");
            request.Parameters.Add("Version", "2014-11-13");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetCluster())
                {
                    request.Parameters.Add("cluster", StringUtils.FromString(publicRequest.Cluster));
                }
                if(publicRequest.IsSetCount())
                {
                    request.Parameters.Add("count", StringUtils.FromInt(publicRequest.Count));
                }
                if(publicRequest.IsSetOverrides())
                {
                    if(publicRequest.Overrides.IsSetContainerOverrides())
                    {
                        int publicRequestOverrideslistValueIndex = 1;
                        foreach(var publicRequestOverrideslistValue in publicRequest.Overrides.ContainerOverrides)
                        {
                            if(publicRequestOverrideslistValue.IsSetCommand())
                            {
                                int publicRequestOverrideslistValuelistValueIndex = 1;
                                foreach(var publicRequestOverrideslistValuelistValue in publicRequestOverrideslistValue.Command)
                                {
                                    request.Parameters.Add("overrides" + "." + "containerOverrides" + "." + "member" + "." + publicRequestOverrideslistValueIndex + "." + "command" + "." + "member" + "." + publicRequestOverrideslistValuelistValueIndex, StringUtils.FromString(publicRequestOverrideslistValuelistValue));
                                    publicRequestOverrideslistValuelistValueIndex++;
                                }
                            }
                            if(publicRequestOverrideslistValue.IsSetName())
                            {
                                request.Parameters.Add("overrides" + "." + "containerOverrides" + "." + "member" + "." + publicRequestOverrideslistValueIndex + "." + "name", StringUtils.FromString(publicRequestOverrideslistValue.Name));
                            }
                            publicRequestOverrideslistValueIndex++;
                        }
                    }
                }
                if(publicRequest.IsSetTaskDefinition())
                {
                    request.Parameters.Add("taskDefinition", StringUtils.FromString(publicRequest.TaskDefinition));
                }
            }
            return request;
        }
    }
}