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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Returns information about the GetBucketLocation response and response metadata.
    /// </summary>
    public class GetBucketLocationResponse : AmazonWebServiceResponse
    {
        private string location;

        /// <summary>
        /// Gets and sets the Location property.
        /// If the the bucket is located in us-east-1 S3Region.US will be return which has a 
        /// value of empty string.
        /// </summary>
        public S3Region Location
        {
            get { return this.location; }
            set { this.location = value; }
        }
    }
}
    
