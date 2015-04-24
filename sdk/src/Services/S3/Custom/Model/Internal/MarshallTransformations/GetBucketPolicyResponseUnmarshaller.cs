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
using System.Collections.Generic;
using Amazon.S3.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;

#pragma warning disable 1591

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
    /// <summary>
    ///    Response Unmarshaller for GetBucketPolicy operation
    /// </summary>
    public class GetBucketPolicyResponseUnmarshaller : S3ReponseUnmarshaller
    {
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context) 
        {   
            GetBucketPolicyResponse response = new GetBucketPolicyResponse();
            
            UnmarshallResult(context,response);                        
                 
                        
            return response;
        }
        
        private static void UnmarshallResult(XmlUnmarshallerContext context,GetBucketPolicyResponse response)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(context.Stream))
            {
                response.Policy = reader.ReadToEnd();
                if (response.Policy.StartsWith("<?xml", StringComparison.OrdinalIgnoreCase))
                    response.Policy = null;
            }

            return;
        }

        private static GetBucketPolicyResponseUnmarshaller _instance;

        public static GetBucketPolicyResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GetBucketPolicyResponseUnmarshaller();
                }
                return _instance;
            }
        }
    
    }
}
    
