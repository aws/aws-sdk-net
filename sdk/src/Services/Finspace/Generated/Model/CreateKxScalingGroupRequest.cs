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
    /// Container for the parameters to the CreateKxScalingGroup operation.
    /// Creates a new scaling group.
    /// </summary>
    public partial class CreateKxScalingGroupRequest : AmazonFinspaceRequest
    {
        private string _availabilityZoneId;
        private string _clientToken;
        private string _environmentId;
        private string _hostType;
        private string _scalingGroupName;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The identifier of the availability zones.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=12)]
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that ensures idempotency. This token expires in 10 minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// A unique identifier for the kdb environment, where you want to create the scaling
        /// group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
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
        ///  
        /// <para>
        /// You can add one of the following values:
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
        [AWSProperty(Required=true, Min=1, Max=32)]
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
        /// Gets and sets the property ScalingGroupName. 
        /// <para>
        /// A unique identifier for the kdb scaling group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A list of key-value pairs to label the scaling group. You can add up to 50 tags to
        /// a scaling group. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}