/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeVolumesModifications operation.
    /// Reports the current modification status of EBS volumes.
    /// 
    ///  
    /// <para>
    /// Current-generation EBS volumes support modification of attributes including type,
    /// size, and (for <code>io1</code> volumes) IOPS provisioning while either attached to
    /// or detached from an instance. Following an action from the API or the console to modify
    /// a volume, the status of the modification may be <code>modifying</code>, <code>optimizing</code>,
    /// <code>completed</code>, or <code>failed</code>. If a volume has never been modified,
    /// then certain elements of the returned <code>VolumeModification</code> objects are
    /// null. 
    /// </para>
    ///  
    /// <para>
    ///  You can also use CloudWatch Events to check the status of a modification to an EBS
    /// volume. For information about CloudWatch Events, see the <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/events/">Amazon
    /// CloudWatch Events User Guide</a>. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-expand-volume.html#monitoring_mods">Monitoring
    /// Volume Modifications"</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeVolumesModificationsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private int? _maxResults;
        private string _nextToken;
        private List<string> _volumeIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters. Supported filters: <code>volume-id</code>, <code>modification-state</code>,
        /// <code>target-size</code>, <code>target-iops</code>, <code>target-volume-type</code>,
        /// <code>original-size</code>, <code>original-iops</code>, <code>original-volume-type</code>,
        /// <code>start-time</code>. 
        /// </para>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results (up to a limit of 500) to be returned in a paginated
        /// request.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> value returned by a previous paginated request.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeIds. 
        /// <para>
        /// One or more volume IDs for which in-progress modifications will be described.
        /// </para>
        /// </summary>
        public List<string> VolumeIds
        {
            get { return this._volumeIds; }
            set { this._volumeIds = value; }
        }

        // Check to see if VolumeIds property is set
        internal bool IsSetVolumeIds()
        {
            return this._volumeIds != null && this._volumeIds.Count > 0; 
        }

    }
}