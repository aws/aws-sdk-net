/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    using Amazon.CloudTrail.Model;
    using Amazon.Runtime;
    using Amazon.Runtime.Internal;
    using Amazon.Runtime.Internal.Transform;

    namespace Amazon.CloudTrail.Model.Internal.MarshallTransformations
    {
      /// <summary>
      /// Response Unmarshaller for UpdateTrail operation
      /// </summary>
      internal class UpdateTrailResponseUnmarshaller : JsonResponseUnmarshaller
      {
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
          UpdateTrailResponse response = new UpdateTrailResponse();
          
          context.Read();
      
          response.UpdateTrailResult = UpdateTrailResultUnmarshaller.GetInstance().Unmarshall(context);
          
          return response;
        }
        
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
          ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
          
          if (errorResponse.Code != null && errorResponse.Code.Equals("S3BucketDoesNotExistException"))
          {
            S3BucketDoesNotExistException ex = new S3BucketDoesNotExistException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            
            return ex;
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidS3PrefixException"))
          {
            InvalidS3PrefixException ex = new InvalidS3PrefixException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            
            return ex;
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidTrailNameException"))
          {
            InvalidTrailNameException ex = new InvalidTrailNameException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            
            return ex;
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidS3BucketNameException"))
          {
            InvalidS3BucketNameException ex = new InvalidS3BucketNameException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            
            return ex;
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("TrailNotProvidedException"))
          {
            TrailNotProvidedException ex = new TrailNotProvidedException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            
            return ex;
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("InsufficientSnsTopicPolicyException"))
          {
            InsufficientSnsTopicPolicyException ex = new InsufficientSnsTopicPolicyException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            
            return ex;
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidSnsTopicNameException"))
          {
            InvalidSnsTopicNameException ex = new InvalidSnsTopicNameException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            
            return ex;
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("InsufficientS3BucketPolicyException"))
          {
            InsufficientS3BucketPolicyException ex = new InsufficientS3BucketPolicyException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            
            return ex;
          }
  
          if (errorResponse.Code != null && errorResponse.Code.Equals("TrailNotFoundException"))
          {
            TrailNotFoundException ex = new TrailNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            
            return ex;
          }
  
          return new AmazonCloudTrailException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static UpdateTrailResponseUnmarshaller instance;
        public static UpdateTrailResponseUnmarshaller GetInstance()
        {
          if (instance == null)
          {
            instance = new UpdateTrailResponseUnmarshaller();
          }
          return instance;
        }
  
      }
    }
  
