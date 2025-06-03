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
using System;
using System.IO;
using System.Net;
using System.Xml;
using System.Collections.Generic;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for DeleteObjects operation
    /// </summary>
    public class DeleteObjectsResponseUnmarshaller : S3ReponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {   
            DeleteObjectsResponse response = new DeleteObjectsResponse();
            
            while (context.Read())
            {
                if (context.IsStartElement)
                {                    
                    UnmarshallResult(context,response);                        
                    continue;
                }
            }
                 
                        
            return response;
        }
        
        private static void UnmarshallResult(XmlUnmarshallerContext context,DeleteObjectsResponse response)
        {
            IWebResponseData responseData = context.ResponseData;
            if (responseData.IsHeaderPresent(S3Constants.AmzHeaderRequestCharged))
                response.RequestCharged = RequestCharged.FindValue(responseData.GetHeaderValue(S3Constants.AmzHeaderRequestCharged));

            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Deleted", targetDepth))
                    {
                        if (response.DeletedObjects == null)
                        {
                            response.DeletedObjects = new List<DeletedObject>();
                        }

                        response.DeletedObjects.Add(DeletedObjectUnmarshaller.Instance.Unmarshall(context));
                        continue;
                    }
                    if (context.TestExpression("Error", targetDepth))
                    {
                        if (response.DeleteErrors == null)
                        {
                            response.DeleteErrors = new List<DeleteError>();
                        }

                        response.DeleteErrors.Add(ErrorsItemUnmarshaller.Instance.Unmarshall(context));
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return;
                }
            }

            return;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// For DeleteObjects operations, we always return DeleteObjectsException instead of AmazonS3Exception
        /// to maintain consistency in exception types regardless of the specific error scenario.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var responseBodyBytes = context.GetResponseBodyBytes();

            // First, try to parse as a standard DeleteObjects response (for cases where S3 returns mixed results)
            if (responseBodyBytes != null && responseBodyBytes.Length > 0)
            {
                using (var streamCopy = new MemoryStream(responseBodyBytes))
                using (var contextCopy = new XmlUnmarshallerContext(streamCopy, false, null))
                {
                    try
                    {
                        var deleteResponse = this.Unmarshall(contextCopy) as DeleteObjectsResponse;
                        
                        // If we successfully parsed a DeleteObjects response, use it directly
                        if (deleteResponse != null)
                        {
                            return new DeleteObjectsException(deleteResponse);
                        }
                    }
                    catch (XmlException)
                    {
                        // Response is not a valid DeleteObjects XML, fall through to error handling
                    }
                    catch (InvalidOperationException)
                    {
                        // Response is not a valid DeleteObjects XML, fall through to error handling
                    }
                }
            }

            // For standard S3 error responses (like KeyTooLongError), create a DeleteObjectsException
            // with the error information wrapped in a DeleteObjectsResponse
            var errorResponse = S3ErrorResponseUnmarshaller.Instance.Unmarshall(context);
            
            // Create a DeleteObjectsResponse containing the error information
            var deleteObjectsResponse = new DeleteObjectsResponse();
            deleteObjectsResponse.DeleteErrors = new List<DeleteError>
            {
                new DeleteError
                {
                    Code = errorResponse?.Code ?? "UnknownError",
                    Message = errorResponse?.Message ?? "An error occurred during the delete operation",
                    Key = "" // We don't know which specific key caused the error in batch validation scenarios
                }
            };

            // Create the DeleteObjectsException with our constructed response
            var deleteException = new DeleteObjectsException(deleteObjectsResponse);
            
            // Set additional properties from the error response
            if (errorResponse != null)
            {
                deleteException.ErrorCode = errorResponse.Code;
                deleteException.RequestId = errorResponse.RequestId;
                deleteException.StatusCode = statusCode;
                // Note: ResponseBody will be set by the base exception handling if available
            }
            
            return deleteException;
        }

        private static DeleteObjectsResponseUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static DeleteObjectsResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DeleteObjectsResponseUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
    
