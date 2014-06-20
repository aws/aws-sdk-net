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
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticMapReduce.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElasticMapReduce.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for JobFlowDetail Object
    /// </summary>  
    public class JobFlowDetailUnmarshaller : IUnmarshaller<JobFlowDetail, XmlUnmarshallerContext>, IUnmarshaller<JobFlowDetail, JsonUnmarshallerContext>
    {
        JobFlowDetail IUnmarshaller<JobFlowDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public JobFlowDetail Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            
            var unmarshalledObject = new JobFlowDetail();
            unmarshalledObject.BootstrapActions = null;
            unmarshalledObject.Steps = null;
            unmarshalledObject.SupportedProducts = null;
                    
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                    context.Read();
                    context.Read();
                    if (context.TestExpression("AmiVersion", targetDepth))
                    {
                        unmarshalledObject.AmiVersion = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("BootstrapActions", targetDepth))
                    {
                        unmarshalledObject.BootstrapActions = new List<BootstrapActionDetail>();
                        var unmarshaller = BootstrapActionDetailUnmarshaller.GetInstance();
                        while (context.Read())
                        {
                          if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                          {
                             unmarshalledObject.BootstrapActions.Add(unmarshaller.Unmarshall(context));
                          }
                          else if (context.IsEndArray)
                          {
                            break;
                          }
                        }
                        continue;
                    }
                    if (context.TestExpression("ExecutionStatusDetail", targetDepth))
                    {
                        unmarshalledObject.ExecutionStatusDetail = JobFlowExecutionStatusDetailUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Instances", targetDepth))
                    {
                        unmarshalledObject.Instances = JobFlowInstancesDetailUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("JobFlowId", targetDepth))
                    {
                        unmarshalledObject.JobFlowId = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("JobFlowRole", targetDepth))
                    {
                        unmarshalledObject.JobFlowRole = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LogUri", targetDepth))
                    {
                        unmarshalledObject.LogUri = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Name", targetDepth))
                    {
                        unmarshalledObject.Name = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ServiceRole", targetDepth))
                    {
                        unmarshalledObject.ServiceRole = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Steps", targetDepth))
                    {
                        unmarshalledObject.Steps = new List<StepDetail>();
                        var unmarshaller = StepDetailUnmarshaller.GetInstance();
                        while (context.Read())
                        {
                          if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                          {
                             unmarshalledObject.Steps.Add(unmarshaller.Unmarshall(context));
                          }
                          else if (context.IsEndArray)
                          {
                            break;
                          }
                        }
                        continue;
                    }
                    if (context.TestExpression("SupportedProducts", targetDepth))
                    {
                        unmarshalledObject.SupportedProducts = new List<string>();
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        while (context.Read())
                        {
                          if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                          {
                             unmarshalledObject.SupportedProducts.Add(unmarshaller.Unmarshall(context));
                          }
                          else if (context.IsEndArray)
                          {
                            break;
                          }
                        }
                        continue;
                    }
                    if (context.TestExpression("VisibleToAllUsers", targetDepth))
                    {
                        unmarshalledObject.VisibleToAllUsers = BoolUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth <= originalDepth)
                {
                    return unmarshalledObject;
                }
            }          
            return unmarshalledObject;
        }


        private static JobFlowDetailUnmarshaller instance;
        public static JobFlowDetailUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new JobFlowDetailUnmarshaller();
            }
            return instance;
        }

    }
}