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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
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
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// This is the response object from the GetKxScalingGroup operation.
    /// </summary>
    public partial class GetKxScalingGroupResponse : AmazonWebServiceResponse
    {
        private string _availabilityZoneId;
        private List<string> _clusters = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _createdTimestamp;
        private string _hostType;
        private DateTime? _lastModifiedTimestamp;
        private string _scalingGroupArn;
        private string _scalingGroupName;
        private KxScalingGroupStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The identifier of the availability zones.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=12)]
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property Clusters. 
        /// <para>
        ///  The list of Managed kdb clusters that are currently active in the given scaling group.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Clusters
        {
            get { return this._clusters; }
            set { this._clusters = value; }
        }

        // Check to see if Clusters property is set
        internal bool IsSetClusters()
        {
            return this._clusters != null && (this._clusters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        ///  The timestamp at which the scaling group was created in FinSpace. The value is determined
        /// as epoch time in milliseconds. For example, the value for Monday, November 1, 2021
        /// 12:00:00 PM UTC is specified as 1635768000000.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HostType. 
        /// <para>
        ///  The memory and CPU capabilities of the scaling group host on which FinSpace Managed
        /// kdb clusters will be placed.
        /// </para>
        ///  
        /// <para>
        /// It can have one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>kx.sg.large</c> – The host type with a configuration of 16 GiB memory and 2 vCPUs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>kx.sg.xlarge</c> – The host type with a configuration of 32 GiB memory and 4 vCPUs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>kx.sg.2xlarge</c> – The host type with a configuration of 64 GiB memory and 8
        /// vCPUs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>kx.sg.4xlarge</c> – The host type with a configuration of 108 GiB memory and 16
        /// vCPUs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>kx.sg.8xlarge</c> – The host type with a configuration of 216 GiB memory and 32
        /// vCPUs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>kx.sg.16xlarge</c> – The host type with a configuration of 432 GiB memory and
        /// 64 vCPUs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>kx.sg.32xlarge</c> – The host type with a configuration of 864 GiB memory and
        /// 128 vCPUs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>kx.sg1.16xlarge</c> – The host type with a configuration of 1949 GiB memory and
        /// 64 vCPUs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>kx.sg1.24xlarge</c> – The host type with a configuration of 2948 GiB memory and
        /// 96 vCPUs.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string HostType
        {
            get { return this._hostType; }
            set { this._hostType = value; }
        }

        // Check to see if HostType property is set
        internal bool IsSetHostType()
        {
            return this._hostType != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTimestamp. 
        /// <para>
        ///  The last time that the scaling group was updated in FinSpace. The value is determined
        /// as epoch time in milliseconds. For example, the value for Monday, November 1, 2021
        /// 12:00:00 PM UTC is specified as 1635768000000. 
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTimestamp
        {
            get { return this._lastModifiedTimestamp; }
            set { this._lastModifiedTimestamp = value; }
        }

        // Check to see if LastModifiedTimestamp property is set
        internal bool IsSetLastModifiedTimestamp()
        {
            return this._lastModifiedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScalingGroupArn. 
        /// <para>
        ///  The ARN identifier for the scaling group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ScalingGroupArn
        {
            get { return this._scalingGroupArn; }
            set { this._scalingGroupArn = value; }
        }

        // Check to see if ScalingGroupArn property is set
        internal bool IsSetScalingGroupArn()
        {
            return this._scalingGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property ScalingGroupName. 
        /// <para>
        /// A unique identifier for the kdb scaling group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
        public string ScalingGroupName
        {
            get { return this._scalingGroupName; }
            set { this._scalingGroupName = value; }
        }

        // Check to see if ScalingGroupName property is set
        internal bool IsSetScalingGroupName()
        {
            return this._scalingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of scaling group.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CREATING – The scaling group creation is in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CREATE_FAILED – The scaling group creation has failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ACTIVE – The scaling group is active.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UPDATING – The scaling group is in the process of being updated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// UPDATE_FAILED – The update action failed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETING – The scaling group is in the process of being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE_FAILED – The system failed to delete the scaling group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETED – The scaling group is successfully deleted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public KxScalingGroupStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        ///  The error message when a failed state occurs. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}