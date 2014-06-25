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
    /// Response Unmarshaller for JobFlowInstancesDetail Object
    /// </summary>  
    public class JobFlowInstancesDetailUnmarshaller : IUnmarshaller<JobFlowInstancesDetail, XmlUnmarshallerContext>, IUnmarshaller<JobFlowInstancesDetail, JsonUnmarshallerContext>
    {
        JobFlowInstancesDetail IUnmarshaller<JobFlowInstancesDetail, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public JobFlowInstancesDetail Unmarshall(JsonUnmarshallerContext context)
        {
            if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                return null;
            
            var unmarshalledObject = new JobFlowInstancesDetail();
            unmarshalledObject.InstanceGroups = null;
                    
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;

            while (context.Read())
            {
                if ((context.IsKey) && (context.CurrentDepth == targetDepth))
                {
                    context.Read();
                    context.Read();
                    if (context.TestExpression("Ec2KeyName", targetDepth))
                    {
                        unmarshalledObject.Ec2KeyName = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Ec2SubnetId", targetDepth))
                    {
                        unmarshalledObject.Ec2SubnetId = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("HadoopVersion", targetDepth))
                    {
                        unmarshalledObject.HadoopVersion = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("InstanceCount", targetDepth))
                    {
                        unmarshalledObject.InstanceCount = IntUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("InstanceGroups", targetDepth))
                    {
                        if (context.CurrentTokenType == JsonUnmarshallerContext.TokenType.Null)
                        {
                            unmarshalledObject.InstanceGroups =  null;
                            continue;
                        }
                        unmarshalledObject.InstanceGroups = new List<InstanceGroupDetail>();
                        var unmarshaller = InstanceGroupDetailUnmarshaller.GetInstance();
                        while (context.Read())
                        {
                          if ((context.IsArrayElement) && (context.CurrentDepth == targetDepth))
                          {
                             unmarshalledObject.InstanceGroups.Add(unmarshaller.Unmarshall(context));
                          }
                          else if (context.IsEndArray)
                          {
                            break;
                          }
                        }
                        continue;
                    }
                    if (context.TestExpression("KeepJobFlowAliveWhenNoSteps", targetDepth))
                    {
                        unmarshalledObject.KeepJobFlowAliveWhenNoSteps = BoolUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MasterInstanceId", targetDepth))
                    {
                        unmarshalledObject.MasterInstanceId = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MasterInstanceType", targetDepth))
                    {
                        unmarshalledObject.MasterInstanceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MasterPublicDnsName", targetDepth))
                    {
                        unmarshalledObject.MasterPublicDnsName = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NormalizedInstanceHours", targetDepth))
                    {
                        unmarshalledObject.NormalizedInstanceHours = IntUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Placement", targetDepth))
                    {
                        unmarshalledObject.Placement = PlacementTypeUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SlaveInstanceType", targetDepth))
                    {
                        unmarshalledObject.SlaveInstanceType = StringUnmarshaller.GetInstance().Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TerminationProtected", targetDepth))
                    {
                        unmarshalledObject.TerminationProtected = BoolUnmarshaller.GetInstance().Unmarshall(context);
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


        private static JobFlowInstancesDetailUnmarshaller instance;
        public static JobFlowInstancesDetailUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new JobFlowInstancesDetailUnmarshaller();
            }
            return instance;
        }

    }
}