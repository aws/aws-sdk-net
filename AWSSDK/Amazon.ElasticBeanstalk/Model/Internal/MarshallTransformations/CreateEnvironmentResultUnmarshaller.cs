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

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CreateEnvironment Object
    /// </summary>  
    public class CreateEnvironmentResultUnmarshaller : IUnmarshaller<CreateEnvironmentResult, XmlUnmarshallerContext>
    {
        public CreateEnvironmentResult Unmarshall(XmlUnmarshallerContext context) 
        {
            CreateEnvironmentResult result = new CreateEnvironmentResult();

            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth += 2;

            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("ApplicationName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        result.ApplicationName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CNAME", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        result.CNAME = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DateCreated", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.GetInstance();
                        result.DateCreated = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DateUpdated", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.GetInstance();
                        result.DateUpdated = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        result.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EndpointURL", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        result.EndpointURL = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EnvironmentId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        result.EnvironmentId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EnvironmentName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        result.EnvironmentName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Health", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        result.Health = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Resources", targetDepth))
                    {
                        var unmarshaller = EnvironmentResourcesDescriptionUnmarshaller.GetInstance();
                        result.Resources = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SolutionStackName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        result.SolutionStackName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        result.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TemplateName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        result.TemplateName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Tier", targetDepth))
                    {
                        var unmarshaller = EnvironmentTierUnmarshaller.GetInstance();
                        result.Tier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("VersionLabel", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.GetInstance();
                        result.VersionLabel = unmarshaller.Unmarshall(context);
                        continue;
                    }
                } 
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return result;
                }
            }

            return result;
        }


        private static CreateEnvironmentResultUnmarshaller instance;
        public static CreateEnvironmentResultUnmarshaller GetInstance()
        {
            if (instance == null)
            {
                instance = new CreateEnvironmentResultUnmarshaller();
            }
            return instance;
        }

    }
}