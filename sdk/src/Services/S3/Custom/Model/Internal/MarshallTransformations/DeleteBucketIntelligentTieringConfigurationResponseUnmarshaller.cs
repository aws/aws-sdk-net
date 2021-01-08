﻿/*
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
using Amazon.Runtime;
using Amazon.Runtime.Internal.Transform;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.S3.Model.Internal.MarshallTransformations
{
	/// <summary>
	///    Response Unmarshaller for DeleteBucketIntelligentTiering operation
	/// </summary>
	public class DeleteBucketIntelligentTieringConfigurationResponseUnmarshaller : S3ReponseUnmarshaller
	{
        public override AmazonWebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            DeleteBucketIntelligentTieringConfigurationResponse response = new DeleteBucketIntelligentTieringConfigurationResponse();

            return response;
        }

        private static DeleteBucketIntelligentTieringConfigurationResponseUnmarshaller _instance;

        public static DeleteBucketIntelligentTieringConfigurationResponseUnmarshaller Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DeleteBucketIntelligentTieringConfigurationResponseUnmarshaller();
                }
                return _instance;
            }
        }
    }
}
