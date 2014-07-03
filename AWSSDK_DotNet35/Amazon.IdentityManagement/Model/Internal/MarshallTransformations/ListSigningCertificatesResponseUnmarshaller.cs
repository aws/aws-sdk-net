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

using Amazon.IdentityManagement.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.IdentityManagement.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ListSigningCertificates operation
    /// </summary>  
    public class ListSigningCertificatesResponseUnmarshaller : XmlResponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            ListSigningCertificatesResponse response = new ListSigningCertificatesResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("ListSigningCertificatesResult", 2))
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

        private static void UnmarshallResult(XmlUnmarshallerContext context, ListSigningCertificatesResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("Certificates/member", targetDepth))
                    {
                        var unmarshaller = SigningCertificateUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        response.Certificates.Add(item);
                        continue;
                    }
                    if (context.TestExpression("IsTruncated", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        response.IsTruncated = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Marker", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Marker = unmarshaller.Unmarshall(context);
                        continue;
                    }
                } 
           }

            return;
        }


        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("NoSuchEntity"))
            {
                return new NoSuchEntityException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonIdentityManagementServiceException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static ListSigningCertificatesResponseUnmarshaller _instance = new ListSigningCertificatesResponseUnmarshaller();        

        internal static ListSigningCertificatesResponseUnmarshaller GetInstance()
        {
            return _instance;
        }
        public static ListSigningCertificatesResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}