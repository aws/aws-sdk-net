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
    /// Filter by the associated distribution ID or connection group ID.
    /// </summary>
    public partial class DistributionTenantAssociationFilter
    {
        private string _connectionGroupId;
        private string _distributionId;

        /// <summary>
        /// Gets and sets the property ConnectionGroupId. 
        /// <para>
        /// The ID of the connection group to filter by. You can find distribution tenants associated
        /// with a specific connection group.
        /// </para>
        /// </summary>
        public string ConnectionGroupId
        {
            get { return this._connectionGroupId; }
            set { this._connectionGroupId = value; }
        }

        // Check to see if ConnectionGroupId property is set
        internal bool IsSetConnectionGroupId()
        {
            return this._connectionGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property DistributionId. 
        /// <para>
        /// The distribution ID to filter by. You can find distribution tenants associated with
        /// a specific distribution.
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

    }
}