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
    /// This is the response object from the DescribeRegion operation.
    /// </summary>
    public partial class DescribeRegionResponse : AmazonWebServiceResponse
    {
        private DateTime? _addedDate;
        private bool? _isPrimaryRegion;
        private string _regionName;
        private RegionStatus _status;

        /// <summary>
        /// Gets and sets the property AddedDate. 
        /// <para>
        /// The timestamp when the Region was added to the IAM Identity Center instance. For the
        /// primary Region, this is the IAM Identity Center instance creation time.
        /// </para>
        /// </summary>
        public DateTime? AddedDate
        {
            get { return this._addedDate; }
            set { this._addedDate = value; }
        }

        // Check to see if AddedDate property is set
        internal bool IsSetAddedDate()
        {
            return this._addedDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsPrimaryRegion. 
        /// <para>
        /// Indicates whether this is the primary Region where the IAM Identity Center instance
        /// was originally enabled. For more information on the difference between the primary
        /// Region and additional Regions, see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/multi-region-iam-identity-center.html">IAM
        /// Identity Center User Guide</a> 
        /// </para>
        /// </summary>
        public bool? IsPrimaryRegion
        {
            get { return this._isPrimaryRegion; }
            set { this._isPrimaryRegion = value; }
        }

        // Check to see if IsPrimaryRegion property is set
        internal bool IsSetIsPrimaryRegion()
        {
            return this._isPrimaryRegion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The Amazon Web Services Region name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the Region. Valid values are ACTIVE (Region is operational),
        /// ADDING (Region replication workflow is in progress), or REMOVING (Region removal workflow
        /// is in progress).
        /// </para>
        /// </summary>
        public RegionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}