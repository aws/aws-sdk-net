/*
 * Copyright 2010-2016 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DeleteObjectTagging operation
    /// </summary>
    public class PutObjectTaggingResponseUnmarshaller : S3ReponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {
            PutObjectTaggingResponse response = new PutObjectTaggingResponse();

            UnmarshallResult(context, response);

            return response;
        }

        private static void UnmarshallResult(XmlUnmarshallerContext context, PutObjectTaggingResponse response)
        {
            IWebResponseData responseData = context.ResponseData;
            if (responseData.IsHeaderPresent("x-amz-version-id"))
                response.VersionId = S3Transforms.ToString(responseData.GetHeaderValue("x-amz-version-id"));
            return;
        }

        private static PutObjectTaggingResponseUnmarshaller _instance;

        public static PutObjectTaggingResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PutObjectTaggingResponseUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
    
