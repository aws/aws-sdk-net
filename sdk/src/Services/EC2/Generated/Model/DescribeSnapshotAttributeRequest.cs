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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeSnapshotAttribute operation.
    /// Describes the specified attribute of the specified snapshot. You can specify only
    /// one attribute at a time.
    /// 
    ///  
    /// <para>
    /// For more information about EBS snapshots, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/ebs-snapshots.html">Amazon
    /// EBS snapshots</a> in the <i>Amazon EBS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeSnapshotAttributeRequest : AmazonEC2Request
    {
        private SnapshotAttributeName _attribute;
        private bool? _dryRun;
        private string _snapshotId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public DescribeSnapshotAttributeRequest() { }

        /// <summary>
        /// Instantiates DescribeSnapshotAttributeRequest with the parameterized properties
        /// </summary>
        /// <param name="snapshotId">The ID of the EBS snapshot.</param>
        /// <param name="attribute">The snapshot attribute you would like to view.</param>
        public DescribeSnapshotAttributeRequest(string snapshotId, SnapshotAttributeName attribute)
        {
            _snapshotId = snapshotId;
            _attribute = attribute;
        }

        /// <summary>
        /// Gets and sets the property Attribute. 
        /// <para>
        /// The snapshot attribute you would like to view.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SnapshotAttributeName Attribute
        {
            get { return this._attribute; }
            set { this._attribute = value; }
        }

        // Check to see if Attribute property is set
        internal bool IsSetAttribute()
        {
            return this._attribute != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the EBS snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SnapshotId
        {
            get { return this._snapshotId; }
            set { this._snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this._snapshotId != null;
        }

    }
}