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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Physical connection requirements of a connection.
    /// </summary>
    public partial class PhysicalConnectionRequirements
    {
        private string _availabilityZone;
        private List<string> _securityGroupIdList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _subnetId;
        private List<string> _subnetIdList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The availability zone of the physical connection requirements of a connection. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIdList. 
        /// <para>
        /// The group ID list of the physical connection requirements of a connection. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> SecurityGroupIdList
        {
            get { return this._securityGroupIdList; }
            set { this._securityGroupIdList = value; }
        }

        // Check to see if SecurityGroupIdList property is set
        internal bool IsSetSecurityGroupIdList()
        {
            return this._securityGroupIdList != null && (this._securityGroupIdList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The subnet ID of the physical connection requirements of a connection. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=32)]
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIdList. 
        /// <para>
        /// The subnet ID list of the physical connection requirements of a connection. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> SubnetIdList
        {
            get { return this._subnetIdList; }
            set { this._subnetIdList = value; }
        }

        // Check to see if SubnetIdList property is set
        internal bool IsSetSubnetIdList()
        {
            return this._subnetIdList != null && (this._subnetIdList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}