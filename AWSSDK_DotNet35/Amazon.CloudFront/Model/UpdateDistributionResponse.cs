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

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Returns information about the  UpdateDistribution response and response metadata.
    /// </summary>
    public class UpdateDistributionResponse : UpdateDistributionResult
    {
        /// <summary>
        /// Gets and sets the UpdateDistributionResult property.
        /// The returned result of the corresponding request.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the UpdateDistributionResult class are now available on the UpdateDistributionResponse class. You should use the properties on UpdateDistributionResponse instead of accessing them through UpdateDistributionResult.")]
        public UpdateDistributionResult UpdateDistributionResult
        {
            get
            {
                return this;
            }
        }
    }
}
    
