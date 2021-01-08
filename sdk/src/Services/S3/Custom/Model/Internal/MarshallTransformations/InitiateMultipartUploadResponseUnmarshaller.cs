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
using System.Net;
using System.Collections.Generic;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Util;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for InitiateMultipartUpload operation
    /// </summary>
    public class InitiateMultipartUploadResponseUnmarshaller : S3ReponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {   
            InitiateMultipartUploadResponse response = new InitiateMultipartUploadResponse();
            
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
        
        private static void UnmarshallResult(XmlUnmarshallerContext context,InitiateMultipartUploadResponse response)
        {
            
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.Read())
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Bucket", targetDepth))
                    {
                        response.BucketName = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("Key", targetDepth))
                    {
                        response.Key = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                    if (context.TestExpression("UploadId", targetDepth))
                    {
                        response.UploadId = StringUnmarshaller.GetInstance().Unmarshall(context);
                            
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return;
                }
            }
                

            IWebResponseData responseData = context.ResponseData;
            if (responseData.IsHeaderPresent("x-amz-server-side-encryption"))
                response.ServerSideEncryptionMethod = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-server-side-encryption"));
            if (responseData.IsHeaderPresent("x-amz-server-side-encryption-customer-algorithm"))
                response.ServerSideEncryptionCustomerMethod = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-server-side-encryption-customer-algorithm"));
            if (responseData.IsHeaderPresent("x-amz-server-side-encryption-customer-key-MD5"))
                response.ServerSideEncryptionCustomerProvidedKeyMD5 = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-server-side-encryption-customer-key-MD5"));
            if (responseData.IsHeaderPresent(HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader))
                response.ServerSideEncryptionKeyManagementServiceKeyId = S3Transforms.ToString(responseData.GetHeaderValue(HeaderKeys.XAmzServerSideEncryptionAwsKmsKeyIdHeader));
            if (responseData.IsHeaderPresent("x-amz-server-side-encryption-context"))
                response.ServerSideEncryptionKeyManagementServiceEncryptionContext = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-server-side-encryption-context"));
            if (responseData.IsHeaderPresent(HeaderKeys.XAmzAbortDateHeader))
                response.AbortDate = S3Transforms.ToDateTime(responseData.GetHeaderValue(HeaderKeys.XAmzAbortDateHeader));
            if (responseData.IsHeaderPresent(HeaderKeys.XAmzAbortRuleIdHeader))
                response.AbortRuleId = S3Transforms.ToString(responseData.GetHeaderValue(HeaderKeys.XAmzAbortRuleIdHeader));
            if (responseData.IsHeaderPresent(S3Constants.AmzHeaderRequestCharged))
                response.RequestCharged = RequestCharged.FindValue(responseData.GetHeaderValue(S3Constants.AmzHeaderRequestCharged));
            if (responseData.IsHeaderPresent(S3Constants.AmzHeaderBucketKeyEnabled))
                response.BucketKeyEnabled = S3Transforms.ToBool(responseData.GetHeaderValue(S3Constants.AmzHeaderBucketKeyEnabled));
            return;
        }

        private static InitiateMultipartUploadResponseUnmarshaller _instance;

        public static InitiateMultipartUploadResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new InitiateMultipartUploadResponseUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
    
