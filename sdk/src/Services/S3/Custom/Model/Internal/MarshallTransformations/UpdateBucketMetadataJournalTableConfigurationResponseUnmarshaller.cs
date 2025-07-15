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
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    public class UpdateBucketMetadataJournalTableConfigurationResponseUnmarshaller : S3ReponseUnmarshaller
    {
        private static UpdateBucketMetadataJournalTableConfigurationResponseUnmarshaller _instance;

        /// <summary>
        /// Singleton for the unmarshaller
        /// </summary>
        public static UpdateBucketMetadataJournalTableConfigurationResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UpdateBucketMetadataJournalTableConfigurationResponseUnmarshaller();
                }
                return _instance;
            }
        }

        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            UpdateBucketMetadataJournalTableConfigurationResponse response = new UpdateBucketMetadataJournalTableConfigurationResponse();

            return response;
        }

        public override AmazonServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            var errorResponse = S3ErrorResponseUnmarshaller.Instance.Unmarshall(context);
            errorResponse.InnerException = innerException;
            errorResponse.StatusCode = statusCode;

            var errorCode = errorResponse.Code;
            if (errorCode != null && errorCode.Equals("NoSuchBucket"))
            {
                return new NoSuchBucketException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonS3Exception(errorResponse.Message, innerException, errorResponse.Type, errorCode, errorResponse.RequestId, statusCode);
        }
    }
}