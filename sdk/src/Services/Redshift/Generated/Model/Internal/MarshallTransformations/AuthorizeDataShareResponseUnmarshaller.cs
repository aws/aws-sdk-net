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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Redshift.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Redshift.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AuthorizeDataShare operation
    /// </summary>  
    public class AuthorizeDataShareResponseUnmarshaller : XmlResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            AuthorizeDataShareResponse response = new AuthorizeDataShareResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("AuthorizeDataShareResult", 2))
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

        private static void UnmarshallResult(XmlUnmarshallerContext context, AuthorizeDataShareResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("AllowPubliclyAccessibleConsumers", targetDepth))
                    {
                        var unmarshaller = NullableBoolUnmarshaller.Instance;
                        response.AllowPubliclyAccessibleConsumers = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DataShareArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.DataShareArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DataShareAssociations/member", targetDepth))
                    {
                        var unmarshaller = DataShareAssociationUnmarshaller.Instance;
                        if (response.DataShareAssociations == null)
                        {
                            response.DataShareAssociations = new List<DataShareAssociation>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        response.DataShareAssociations.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ManagedBy", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ManagedBy = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ProducerArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ProducerArn = unmarshaller.Unmarshall(context);
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
                if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidDataShareFault"))
                {
                    return InvalidDataShareExceptionUnmarshaller.Instance.Unmarshall(contextCopy, errorResponse);
                }
            }
            return new AmazonRedshiftException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        private static AuthorizeDataShareResponseUnmarshaller _instance = new AuthorizeDataShareResponseUnmarshaller();        

        internal static AuthorizeDataShareResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AuthorizeDataShareResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}