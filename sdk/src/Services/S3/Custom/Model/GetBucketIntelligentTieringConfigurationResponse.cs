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
using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Response object for the GetBucketIntelligentTieringConfiguration operation.
    /// </summary>
    public partial class GetBucketIntelligentTieringConfigurationResponse : AmazonWebServiceResponse
	{
        IntelligentTieringConfiguration intelligentTieringConfiguration;

        /// <summary>
        /// <para>Container for S3 Intelligent-Tiering configuration.</para>
        /// </summary>
        public IntelligentTieringConfiguration IntelligentTieringConfiguration
        {
            get { return this.intelligentTieringConfiguration; }
            set { this.intelligentTieringConfiguration = value; }
        }

        // Check to see if InventoryConfiguration property is set
        internal bool IsSetIntelligentTieringConfiguration()
        {
            return this.intelligentTieringConfiguration != null;
        }
    }
}
