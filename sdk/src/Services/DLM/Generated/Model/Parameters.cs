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
 * Do not modify this file. This file is generated from the dlm-2018-01-12.normal.json service model.
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
namespace Amazon.DLM.Model
{
    /// <summary>
    /// <b>[Custom snapshot and AMI policies only]</b> Specifies optional parameters for
    /// snapshot and AMI policies. The set of valid parameters depends on the combination
    /// of policy type and target resource type.
    /// 
    ///  
    /// <para>
    /// If you choose to exclude boot volumes and you specify tags that consequently exclude
    /// all of the additional data volumes attached to an instance, then Amazon Data Lifecycle
    /// Manager will not create any snapshots for the affected instance, and it will emit
    /// a <c>SnapshotsCreateFailed</c> Amazon CloudWatch metric. For more information, see
    /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitor-dlm-cw-metrics.html">Monitor
    /// your policies using Amazon CloudWatch</a>.
    /// </para>
    /// </summary>
    public partial class Parameters
    {
        private bool? _excludeBootVolume;
        private List<Tag> _excludeDataVolumeTags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private bool? _noReboot;

        /// <summary>
        /// Gets and sets the property ExcludeBootVolume. 
        /// <para>
        ///  <b>[Custom snapshot policies that target instances only]</b> Indicates whether to
        /// exclude the root volume from multi-volume snapshot sets. The default is <c>false</c>.
        /// If you specify <c>true</c>, then the root volumes attached to targeted instances will
        /// be excluded from the multi-volume snapshot sets created by the policy.
        /// </para>
        /// </summary>
        public bool? ExcludeBootVolume
        {
            get { return this._excludeBootVolume; }
            set { this._excludeBootVolume = value; }
        }

        // Check to see if ExcludeBootVolume property is set
        internal bool IsSetExcludeBootVolume()
        {
            return this._excludeBootVolume.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExcludeDataVolumeTags. 
        /// <para>
        ///  <b>[Custom snapshot policies that target instances only]</b> The tags used to identify
        /// data (non-root) volumes to exclude from multi-volume snapshot sets.
        /// </para>
        ///  
        /// <para>
        /// If you create a snapshot lifecycle policy that targets instances and you specify tags
        /// for this parameter, then data volumes with the specified tags that are attached to
        /// targeted instances will be excluded from the multi-volume snapshot sets created by
        /// the policy.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> ExcludeDataVolumeTags
        {
            get { return this._excludeDataVolumeTags; }
            set { this._excludeDataVolumeTags = value; }
        }

        // Check to see if ExcludeDataVolumeTags property is set
        internal bool IsSetExcludeDataVolumeTags()
        {
            return this._excludeDataVolumeTags != null && (this._excludeDataVolumeTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NoReboot. 
        /// <para>
        ///  <b>[Custom AMI policies only]</b> Indicates whether targeted instances are rebooted
        /// when the lifecycle policy runs. <c>true</c> indicates that targeted instances are
        /// not rebooted when the policy runs. <c>false</c> indicates that target instances are
        /// rebooted when the policy runs. The default is <c>true</c> (instances are not rebooted).
        /// </para>
        /// </summary>
        public bool? NoReboot
        {
            get { return this._noReboot; }
            set { this._noReboot = value; }
        }

        // Check to see if NoReboot property is set
        internal bool IsSetNoReboot()
        {
            return this._noReboot.HasValue; 
        }

    }
}