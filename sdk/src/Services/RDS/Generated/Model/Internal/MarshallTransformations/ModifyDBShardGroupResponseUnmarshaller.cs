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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.RDS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.RDS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ModifyDBShardGroup operation
    /// </summary>  
    public class ModifyDBShardGroupResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            ModifyDBShardGroupResponse response = new ModifyDBShardGroupResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("ModifyDBShardGroupResult", 2))
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

        private static void UnmarshallResult(XmlUnmarshallerContext context, ModifyDBShardGroupResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("ComputeRedundancy", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        response.ComputeRedundancy = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBClusterIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.DBClusterIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBShardGroupArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.DBShardGroupArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBShardGroupIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.DBShardGroupIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DBShardGroupResourceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.DBShardGroupResourceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Endpoint", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Endpoint = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxACU", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        response.MaxACU = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MinACU", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        response.MinACU = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PubliclyAccessible", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        response.PubliclyAccessible = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TagList/Tag", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        if (response.TagList == null)
                        {
                            response.TagList = new List<Tag>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.TagList.Add(item);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("DBShardGroupAlreadyExists"))
                {
                    return DBShardGroupAlreadyExistsExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("DBShardGroupNotFound"))
                {
                    return DBShardGroupNotFoundExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidDBClusterStateFault"))
                {
                    return InvalidDBClusterStateExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonRDSException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        private static ModifyDBShardGroupResponseUnmarshaller _instance = new ModifyDBShardGroupResponseUnmarshaller();        

        internal static ModifyDBShardGroupResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ModifyDBShardGroupResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}