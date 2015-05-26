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
 * Do not modify this file. This file is generated from the efs-2015-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticFileSystem.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ElasticFileSystem.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CreateMountTarget operation
    /// </summary>  
    public class CreateMountTargetResponseUnmarshaller : JsonResponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            CreateMountTargetResponse response = new CreateMountTargetResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("FileSystemId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.FileSystemId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IpAddress", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.IpAddress = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LifeCycleState", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.LifeCycleState = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MountTargetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.MountTargetId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NetworkInterfaceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.NetworkInterfaceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OwnerId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.OwnerId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SubnetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SubnetId = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("BadRequest"))
            {
                return new BadRequestException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("FileSystemNotFound"))
            {
                return new FileSystemNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("IncorrectFileSystemLifeCycleState"))
            {
                return new IncorrectFileSystemLifeCycleStateException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerError"))
            {
                return new InternalServerErrorException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("IpAddressInUse"))
            {
                return new IpAddressInUseException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("MountTargetConflict"))
            {
                return new MountTargetConflictException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("NetworkInterfaceLimitExceeded"))
            {
                return new NetworkInterfaceLimitExceededException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("NoFreeAddressesInSubnet"))
            {
                return new NoFreeAddressesInSubnetException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("SecurityGroupLimitExceeded"))
            {
                return new SecurityGroupLimitExceededException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("SecurityGroupNotFound"))
            {
                return new SecurityGroupNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("SubnetNotFound"))
            {
                return new SubnetNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("UnsupportedAvailabilityZone"))
            {
                return new UnsupportedAvailabilityZoneException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonElasticFileSystemException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static CreateMountTargetResponseUnmarshaller _instance = new CreateMountTargetResponseUnmarshaller();        

        internal static CreateMountTargetResponseUnmarshaller GetInstance()
        {
            return _instance;
        }
        public static CreateMountTargetResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}