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
    /// Container for the parameters to the GetInvalidation operation.
    /// <para> Get the information about an invalidation. </para>
    /// </summary>
    /// <seealso cref="Amazon.CloudFront.AmazonCloudFront.GetInvalidation"/>
    public class GetInvalidationRequest : AmazonWebServiceRequest
    {
        private string distributionId;
        private string id;

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
        public GetInvalidationRequest WithDistributionId(string distributionId)
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
        /// The invalidation's id.
        ///  
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">The value to set for the Id property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public GetInvalidationRequest WithId(string id)
        {
            this.id = id;
            return this;
        }
            

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }
    }
}
    
