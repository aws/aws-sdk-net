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

/*
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// The IDs for the distribution resources.
    /// </summary>
    public partial class DistributionResourceId
    {
        private string _distributionId;
        private string _distributionTenantId;

        /// <summary>
        /// Gets and sets the property DistributionId. 
        /// <para>
        /// The ID of the multi-tenant distribution.
        /// </para>
        /// </summary>
        public string DistributionId
        {
            get { return this._distributionId; }
            set { this._distributionId = value; }
        }

        // Check to see if DistributionId property is set
        internal bool IsSetDistributionId()
        {
            return this._distributionId != null;
        }

        /// <summary>
        /// Gets and sets the property DistributionTenantId. 
        /// <para>
        /// The ID of the distribution tenant.
        /// </para>
        /// </summary>
        public string DistributionTenantId
        {
            get { return this._distributionTenantId; }
            set { this._distributionTenantId = value; }
        }

        // Check to see if DistributionTenantId property is set
        internal bool IsSetDistributionTenantId()
        {
            return this._distributionTenantId != null;
        }

    }
}