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
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the CreateInvalidation operation.
    /// <para> Create a new invalidation. </para>
    /// </summary>
    public partial class CreateInvalidationRequest : AmazonCloudFrontRequest
    {
        private string distributionId;
        private InvalidationBatch invalidationBatch;


        /// <summary>
        /// The distribution's id.
        ///  
        /// </summary>
        public string DistributionId
        {
            get { return this.distributionId; }
            set { this.distributionId = value; }
        }

        // Check to see if DistributionId property is set
        internal bool IsSetDistributionId()
        {
            return this.distributionId != null;
        }

        /// <summary>
        /// The batch information for the invalidation.
        ///  
        /// </summary>
        public InvalidationBatch InvalidationBatch
        {
            get { return this.invalidationBatch; }
            set { this.invalidationBatch = value; }
        }

        // Check to see if InvalidationBatch property is set
        internal bool IsSetInvalidationBatch()
        {
            return this.invalidationBatch != null;
        }

    }
}
    
