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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Neptune.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Neptune.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ModifyDBInstance operation
    /// </summary>  
    public class ModifyDBInstanceResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            ModifyDBInstanceResponse response = new ModifyDBInstanceResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("ModifyDBInstanceResult", 2))
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

        private static void UnmarshallResult(XmlUnmarshallerContext context, ModifyDBInstanceResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("DBInstance", targetDepth))
                    {
                        var unmarshaller = DBInstanceUnmarshaller.Instance;
                        response.DBInstance = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("AuthorizationNotFound"))
                {
                    return AuthorizationNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("CertificateNotFound"))
                {
                    return CertificateNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("DBInstanceAlreadyExists"))
                {
                    return DBInstanceAlreadyExistsExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("DBInstanceNotFound"))
                {
                    return DBInstanceNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("DBParameterGroupNotFound"))
                {
                    return DBParameterGroupNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("DBSecurityGroupNotFound"))
                {
                    return DBSecurityGroupNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("DBUpgradeDependencyFailure"))
                {
                    return DBUpgradeDependencyFailureExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("DomainNotFoundFault"))
                {
                    return DomainNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InsufficientDBInstanceCapacity"))
                {
                    return InsufficientDBInstanceCapacityExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidDBInstanceState"))
                {
                    return InvalidDBInstanceStateExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidDBSecurityGroupState"))
                {
                    return InvalidDBSecurityGroupStateExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidVPCNetworkStateFault"))
                {
                    return InvalidVPCNetworkStateExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("OptionGroupNotFoundFault"))
                {
                    return OptionGroupNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("ProvisionedIopsNotAvailableInAZFault"))
                {
                    return ProvisionedIopsNotAvailableInAZExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("StorageQuotaExceeded"))
                {
                    return StorageQuotaExceededExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("StorageTypeNotSupported"))
                {
                    return StorageTypeNotSupportedExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonNeptuneException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        private static ModifyDBInstanceResponseUnmarshaller _instance = new ModifyDBInstanceResponseUnmarshaller();        

        internal static ModifyDBInstanceResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyDBInstanceResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}