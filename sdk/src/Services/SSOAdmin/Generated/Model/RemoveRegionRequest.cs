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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
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
namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// Container for the parameters to the RemoveRegion operation.
    /// Removes an additional Region from an IAM Identity Center instance. This operation
    /// initiates an asynchronous workflow to clean up IAM Identity Center resources in the
    /// specified additional Region. The Region status is set to REMOVING and the Region record
    /// is deleted when the workflow completes. The request must be made from the primary
    /// Region. The target Region cannot be the primary Region, and no other add or remove
    /// Region workflows can be in progress.
    /// 
    ///  
    /// <para>
    /// The following actions are related to <c>RemoveRegion</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_AddRegion.html">
    /// AddRegion</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_DescribeRegion.html">DescribeRegion</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_ListRegions.html">ListRegions</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RemoveRegionRequest : AmazonSSOAdminRequest
    {
        private string _instanceArn;
        private string _regionName;

        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM Identity Center instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=1224)]
        public string InstanceArn
        {
            get { return this._instanceArn; }
            set { this._instanceArn = value; }
        }

        // Check to see if InstanceArn property is set
        internal bool IsSetInstanceArn()
        {
            return this._instanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The name of the Amazon Web Services Region to remove from the IAM Identity Center
        /// instance. The Region name must be 1-32 characters long and follow the pattern of Amazon
        /// Web Services Region names (for example, us-east-1). The primary Region cannot be removed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string RegionName
        {
            get { return this._regionName; }
            set { this._regionName = value; }
        }

        // Check to see if RegionName property is set
        internal bool IsSetRegionName()
        {
            return this._regionName != null;
        }

    }
}