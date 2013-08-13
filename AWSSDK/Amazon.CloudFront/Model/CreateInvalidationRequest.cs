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
    /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.CreateInvalidation"/>
    public class CreateInvalidationRequest : AmazonWebServiceRequest
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

        /// <summary>
        /// Sets the DistributionId property
        /// </summary>
        /// <param name="distributionId">The value to set for the DistributionId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInvalidationRequest WithDistributionId(string distributionId)
        {
            this.distributionId = distributionId;
            return this;
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

        /// <summary>
        /// Sets the InvalidationBatch property
        /// </summary>
        /// <param name="invalidationBatch">The value to set for the InvalidationBatch property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateInvalidationRequest WithInvalidationBatch(InvalidationBatch invalidationBatch)
        {
            this.invalidationBatch = invalidationBatch;
            return this;
        }
            

        // Check to see if InvalidationBatch property is set
        internal bool IsSetInvalidationBatch()
        {
            return this.invalidationBatch != null;
        }
    }
}
    
