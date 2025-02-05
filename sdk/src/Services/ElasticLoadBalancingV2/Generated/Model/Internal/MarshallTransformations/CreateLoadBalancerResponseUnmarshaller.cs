/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticLoadBalancingV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.ElasticLoadBalancingV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CreateLoadBalancer operation
    /// </summary>  
    public class CreateLoadBalancerResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            CreateLoadBalancerResponse response = new CreateLoadBalancerResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("CreateLoadBalancerResult", 2))
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

        private static void UnmarshallResult(XmlUnmarshallerContext context, CreateLoadBalancerResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("LoadBalancers/member", targetDepth))
                    {
                        var unmarshaller = LoadBalancerUnmarshaller.Instance;
                        if (response.LoadBalancers == null)
                        {
                            response.LoadBalancers = new List<LoadBalancer>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.LoadBalancers.Add(item);
                        continue;
                    }
                } 
           }

            return;
        }


        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = XmlErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, null))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("AllocationIdNotFound"))
                {
                    return AllocationIdNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("AvailabilityZoneNotSupported"))
                {
                    return AvailabilityZoneNotSupportedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("DuplicateLoadBalancerName"))
                {
                    return DuplicateLoadBalancerNameExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("DuplicateTagKeys"))
                {
                    return DuplicateTagKeysExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidConfigurationRequest"))
                {
                    return InvalidConfigurationRequestExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidScheme"))
                {
                    return InvalidSchemeExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidSecurityGroup"))
                {
                    return InvalidSecurityGroupExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidSubnet"))
                {
                    return InvalidSubnetExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("OperationNotPermitted"))
                {
                    return OperationNotPermittedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceInUse"))
                {
                    return ResourceInUseExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("SubnetNotFound"))
                {
                    return SubnetNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("TooManyLoadBalancers"))
                {
                    return TooManyLoadBalancersExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("TooManyTags"))
                {
                    return TooManyTagsExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonElasticLoadBalancingV2Exception(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        private static CreateLoadBalancerResponseUnmarshaller _instance = new CreateLoadBalancerResponseUnmarshaller();        

        internal static CreateLoadBalancerResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateLoadBalancerResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}