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
    /// RegisterTaskDefinition Request Marshaller
    /// </summary>       
    public class RegisterTaskDefinitionRequestMarshaller : IMarshaller<IRequest, RegisterTaskDefinitionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterTaskDefinitionRequest)input);
        }
    
        public IRequest Marshall(RegisterTaskDefinitionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ECS");
            request.Parameters.Add("Action", "RegisterTaskDefinition");
            request.Parameters.Add("Version", "2014-11-13");

            if(publicRequest != null)
            {
                if(publicRequest.IsSetContainerDefinitions())
                {
                    int publicRequestlistValueIndex = 1;
                    foreach(var publicRequestlistValue in publicRequest.ContainerDefinitions)
                    {
                        if(publicRequestlistValue.IsSetCommand())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Command)
                            {
                                request.Parameters.Add("containerDefinitions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "command" + "." + "member" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValue));
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
                        if(publicRequestlistValue.IsSetCpu())
                        {
                            request.Parameters.Add("containerDefinitions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "cpu", StringUtils.FromInt(publicRequestlistValue.Cpu));
                        }
                        if(publicRequestlistValue.IsSetEntryPoint())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.EntryPoint)
                            {
                                request.Parameters.Add("containerDefinitions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "entryPoint" + "." + "member" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValue));
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
                        if(publicRequestlistValue.IsSetEnvironment())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Environment)
                            {
                                if(publicRequestlistValuelistValue.IsSetName())
                                {
                                    request.Parameters.Add("containerDefinitions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "environment" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "name", StringUtils.FromString(publicRequestlistValuelistValue.Name));
                                }
                                if(publicRequestlistValuelistValue.IsSetValue())
                                {
                                    request.Parameters.Add("containerDefinitions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "environment" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "value", StringUtils.FromString(publicRequestlistValuelistValue.Value));
                                }
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
                        if(publicRequestlistValue.IsSetEssential())
                        {
                            request.Parameters.Add("containerDefinitions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "essential", StringUtils.FromBool(publicRequestlistValue.Essential));
                        }
                        if(publicRequestlistValue.IsSetImage())
                        {
                            request.Parameters.Add("containerDefinitions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "image", StringUtils.FromString(publicRequestlistValue.Image));
                        }
                        if(publicRequestlistValue.IsSetLinks())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.Links)
                            {
                                request.Parameters.Add("containerDefinitions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "links" + "." + "member" + "." + publicRequestlistValuelistValueIndex, StringUtils.FromString(publicRequestlistValuelistValue));
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
                        if(publicRequestlistValue.IsSetMemory())
                        {
                            request.Parameters.Add("containerDefinitions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "memory", StringUtils.FromInt(publicRequestlistValue.Memory));
                        }
                        if(publicRequestlistValue.IsSetName())
                        {
                            request.Parameters.Add("containerDefinitions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "name", StringUtils.FromString(publicRequestlistValue.Name));
                        }
                        if(publicRequestlistValue.IsSetPortMappings())
                        {
                            int publicRequestlistValuelistValueIndex = 1;
                            foreach(var publicRequestlistValuelistValue in publicRequestlistValue.PortMappings)
                            {
                                if(publicRequestlistValuelistValue.IsSetContainerPort())
                                {
                                    request.Parameters.Add("containerDefinitions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "portMappings" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "containerPort", StringUtils.FromInt(publicRequestlistValuelistValue.ContainerPort));
                                }
                                if(publicRequestlistValuelistValue.IsSetHostPort())
                                {
                                    request.Parameters.Add("containerDefinitions" + "." + "member" + "." + publicRequestlistValueIndex + "." + "portMappings" + "." + "member" + "." + publicRequestlistValuelistValueIndex + "." + "hostPort", StringUtils.FromInt(publicRequestlistValuelistValue.HostPort));
                                }
                                publicRequestlistValuelistValueIndex++;
                            }
                        }
                        publicRequestlistValueIndex++;
                    }
                }
                if(publicRequest.IsSetFamily())
                {
                    request.Parameters.Add("family", StringUtils.FromString(publicRequest.Family));
                }
            }
            return request;
        }
    }
}