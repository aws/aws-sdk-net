/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;

namespace Amazon.DynamoDB
{

    /// <summary>
    /// Configuration for accessing  service
    /// </summary>
    public class AmazonDynamoDBConfig : ClientConfig
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public AmazonDynamoDBConfig()
        {
            this.ServiceURL = "https://dynamodb.us-east-1.amazonaws.com/";
            this.MaxErrorRetry = 10;
        }

        /// <summary>
        /// Gets the ServiceVersion property.
        /// </summary>
        public override string ServiceVersion
        {
            get
            {
                return "2011-12-05";
            }
        }
    }
}

    
