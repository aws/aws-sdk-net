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
 * Do not modify this file. This file is generated from the cloudhsm-2014-05-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudHSM.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CloudHSM.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeHsm operation
    /// </summary>  
    public class DescribeHsmResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeHsmResponse response = new DescribeHsmResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AvailabilityZone", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.AvailabilityZone = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EniId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.EniId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EniIp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.EniIp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HsmArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.HsmArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("HsmType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.HsmType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IamRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.IamRoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Partitions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.Partitions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SerialNumber", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SerialNumber = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServerCertLastUpdated", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ServerCertLastUpdated = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServerCertUri", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ServerCertUri = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SoftwareVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SoftwareVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SshKeyLastUpdated", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SshKeyLastUpdated = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SshPublicKey", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SshPublicKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StatusDetails", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.StatusDetails = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubnetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SubnetId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubscriptionEndDate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SubscriptionEndDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubscriptionStartDate", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SubscriptionStartDate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubscriptionType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SubscriptionType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VendorName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VendorName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VpcId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.VpcId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("CloudHsmInternalException"))
            {
                return new CloudHsmInternalException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("CloudHsmServiceException"))
            {
                return new CloudHsmServiceException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidRequestException"))
            {
                return new InvalidRequestException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonCloudHSMException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static DescribeHsmResponseUnmarshaller _instance = new DescribeHsmResponseUnmarshaller();        

        internal static DescribeHsmResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeHsmResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}