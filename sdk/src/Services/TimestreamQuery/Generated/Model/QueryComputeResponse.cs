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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
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
namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// The response to a request to retrieve or update the compute capacity settings for
    /// querying data.
    /// </summary>
    public partial class QueryComputeResponse
    {
        private ComputeMode _computeMode;
        private ProvisionedCapacityResponse _provisionedCapacity;

        /// <summary>
        /// Gets and sets the property ComputeMode. 
        /// <para>
        /// The mode in which Timestream Compute Units (TCUs) are allocated and utilized within
        /// an account. Note that in the Asia Pacific (Mumbai) region, the API operation only
        /// recognizes the value <c>PROVISIONED</c>.
        /// </para>
        /// </summary>
        public ComputeMode ComputeMode
        {
            get { return this._computeMode; }
            set { this._computeMode = value; }
        }

        // Check to see if ComputeMode property is set
        internal bool IsSetComputeMode()
        {
            return this._computeMode != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedCapacity. 
        /// <para>
        /// Configuration object that contains settings for provisioned Timestream Compute Units
        /// (TCUs) in your account.
        /// </para>
        /// </summary>
        public ProvisionedCapacityResponse ProvisionedCapacity
        {
            get { return this._provisionedCapacity; }
            set { this._provisionedCapacity = value; }
        }

        // Check to see if ProvisionedCapacity property is set
        internal bool IsSetProvisionedCapacity()
        {
            return this._provisionedCapacity != null;
        }

    }
}