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
 * Do not modify this file. This file is generated from the importexport-2010-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ImportExport.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ImportExport.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetStatus operation
    /// </summary>  
    public class GetStatusResponseUnmarshaller : XmlResponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            GetStatusResponse response = new GetStatusResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.IsStartElement)
                {                    
                    if(context.TestExpression("GetStatusResult", 2))
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

        private static void UnmarshallResult(XmlUnmarshallerContext context, GetStatusResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {

                    if (context.TestExpression("ArtifactList/member", targetDepth))
                    {
                        var unmarshaller = ArtifactUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        response.ArtifactList.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Carrier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Carrier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CreationDate", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        response.CreationDate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CurrentManifest", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.CurrentManifest = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ErrorCount", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        response.ErrorCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("JobId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.JobId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("JobType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.JobType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LocationCode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.LocationCode = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LocationMessage", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.LocationMessage = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LogBucket", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.LogBucket = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("LogKey", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.LogKey = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ProgressCode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ProgressCode = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ProgressMessage", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.ProgressMessage = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Signature", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.Signature = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SignatureFileContents", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.SignatureFileContents = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TrackingNumber", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        response.TrackingNumber = unmarshaller.Unmarshall(context);
                        continue;
                    }
                } 
           }

            return;
        }


        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("CanceledJobIdException"))
            {
                return new CanceledJobIdException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ExpiredJobIdException"))
            {
                return new ExpiredJobIdException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidAccessKeyIdException"))
            {
                return new InvalidAccessKeyIdException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidJobIdException"))
            {
                return new InvalidJobIdException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidVersionException"))
            {
                return new InvalidVersionException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonImportExportException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }
        private static GetStatusResponseUnmarshaller _instance = new GetStatusResponseUnmarshaller();        

        internal static GetStatusResponseUnmarshaller GetInstance()
        {
            return _instance;
        }
        public static GetStatusResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}