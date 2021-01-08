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
 * Do not modify this file. This file is generated from the sdb-2009-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleDB.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.SimpleDB.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DomainMetadata operation
    /// </summary>  
    public class DomainMetadataResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            DomainMetadataResponse response = new DomainMetadataResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("DomainMetadataResult", 2))
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

        private static void UnmarshallResult(XmlUnmarshallerContext context, DomainMetadataResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("AttributeNameCount", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        response.AttributeNameCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AttributeNamesSizeBytes", targetDepth))
                    {
                        var unmarshaller = LongUnmarshaller.Instance;
                        response.AttributeNamesSizeBytes = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AttributeValueCount", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        response.AttributeValueCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AttributeValuesSizeBytes", targetDepth))
                    {
                        var unmarshaller = LongUnmarshaller.Instance;
                        response.AttributeValuesSizeBytes = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ItemCount", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        response.ItemCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ItemNamesSizeBytes", targetDepth))
                    {
                        var unmarshaller = LongUnmarshaller.Instance;
                        response.ItemNamesSizeBytes = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Timestamp", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        response.Timestamp = unmarshaller.Unmarshall(context);
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
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var responseBodyBytes = context.GetResponseBodyBytes();

            using (var streamCopy = new MemoryStream(responseBodyBytes))
            using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, null))
            {
                if (errorResponse.Code != null && errorResponse.Code.Equals("MissingParameter"))
                {
                    return MissingParameterExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
                if (errorResponse.Code != null && errorResponse.Code.Equals("NoSuchDomain"))
                {
                    return NoSuchDomainExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonSimpleDBException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        private static DomainMetadataResponseUnmarshaller _instance = new DomainMetadataResponseUnmarshaller();        

        internal static DomainMetadataResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DomainMetadataResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}