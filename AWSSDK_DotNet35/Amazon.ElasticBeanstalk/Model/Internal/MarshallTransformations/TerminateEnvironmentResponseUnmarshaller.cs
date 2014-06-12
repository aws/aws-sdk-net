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
    /// Response Unmarshaller for TerminateEnvironment operation
    /// </summary>  
    public class TerminateEnvironmentResponseUnmarshaller : XmlResponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            TerminateEnvironmentResponse response = new TerminateEnvironmentResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("TerminateEnvironmentResult", 2))
                    {
                        UnmarshallResult(context, response);                        
                        continue;
                    }
                    
                    if (context.TestExpression("ResponseMetadata", 2))
                    {
                        response.ResponseMetadata = ResponseMetadataUnmarshaller.Instance.Unmarshall(context);
                    }
                }
            }

            return response;
        }

        private static void UnmarshallResult(XmlUnmarshallerContext context, TerminateEnvironmentResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("ApplicationName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ApplicationName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CNAME", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.CNAME = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DateCreated", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        response.DateCreated = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DateUpdated", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        response.DateUpdated = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EndpointURL", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.EndpointURL = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EnvironmentId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.EnvironmentId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EnvironmentName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.EnvironmentName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Health", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Health = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Resources", targetDepth))
                    {
                        var unmarshaller = EnvironmentResourcesDescriptionUnmarshaller.Instance;
                        response.Resources = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SolutionStackName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.SolutionStackName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TemplateName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.TemplateName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Tier", targetDepth))
                    {
                        var unmarshaller = EnvironmentTierUnmarshaller.Instance;
                        response.Tier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("VersionLabel", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.VersionLabel = unmarshaller.Unmarshall(context);
                        continue;
                    }
                } 
           }

            return;
        }


        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("InsufficientPrivilegesException"))
            {
                return new InsufficientPrivilegesException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonElasticBeanstalkException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static TerminateEnvironmentResponseUnmarshaller _instance = new TerminateEnvironmentResponseUnmarshaller();        

        internal static TerminateEnvironmentResponseUnmarshaller GetInstance()
        {
            return _instance;
        }
        public static TerminateEnvironmentResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}