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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeVpcAttribute operation
    /// </summary>  
    public class DescribeVpcAttributeResponseUnmarshaller : EC2ResponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            DescribeVpcAttributeResponse response = new DescribeVpcAttributeResponse();

            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            if (context.IsStartOfDocument) 
               targetDepth = 2;

            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("enableDnsHostnames/value", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        response.EnableDnsHostnames = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("enableDnsSupport/value", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        response.EnableDnsSupport = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("vpcId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.VpcId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                } 
            }

            return response;
        }

        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            return new AmazonEC2Exception(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        private static DescribeVpcAttributeResponseUnmarshaller _instance = new DescribeVpcAttributeResponseUnmarshaller();        

        internal static DescribeVpcAttributeResponseUnmarshaller GetInstance()
        {
            return _instance;
        }
        public static DescribeVpcAttributeResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}