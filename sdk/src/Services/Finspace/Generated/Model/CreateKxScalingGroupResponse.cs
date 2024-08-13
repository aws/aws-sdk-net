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
    /// This is the response object from the CreateKxScalingGroup operation.
    /// </summary>
    public partial class CreateKxScalingGroupResponse : AmazonWebServiceResponse
    {
        private string _availabilityZoneId;
        private DateTime? _createdTimestamp;
        private string _environmentId;
        private string _hostType;
        private DateTime? _lastModifiedTimestamp;
        private string _scalingGroupName;
        private KxScalingGroupStatus _status;

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
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// A unique identifier for the kdb environment, where you create the scaling group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property HostType. 
        /// <para>
        ///  The memory and CPU capabilities of the scaling group host on which FinSpace Managed
        /// kdb clusters will be placed. 
        /// </para>
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

    }
}