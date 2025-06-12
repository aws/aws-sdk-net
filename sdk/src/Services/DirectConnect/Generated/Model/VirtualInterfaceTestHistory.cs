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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
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
namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Information about the virtual interface failover test.
    /// </summary>
    public partial class VirtualInterfaceTestHistory
    {
        private List<string> _bgpPeers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _endTime;
        private string _ownerAccount;
        private DateTime? _startTime;
        private string _status;
        private int? _testDurationInMinutes;
        private string _testId;
        private string _virtualInterfaceId;

        /// <summary>
        /// Gets and sets the property BgpPeers. 
        /// <para>
        /// The BGP peers that were put in the DOWN state as part of the virtual interface failover
        /// test.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> BgpPeers
        {
            get { return this._bgpPeers; }
            set { this._bgpPeers = value; }
        }

        // Check to see if BgpPeers property is set
        internal bool IsSetBgpPeers()
        {
            return this._bgpPeers != null && (this._bgpPeers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The time that the virtual interface moves out of the DOWN state.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OwnerAccount. 
        /// <para>
        /// The owner ID of the tested virtual interface.
        /// </para>
        /// </summary>
        public string OwnerAccount
        {
            get { return this._ownerAccount; }
            set { this._ownerAccount = value; }
        }

        // Check to see if OwnerAccount property is set
        internal bool IsSetOwnerAccount()
        {
            return this._ownerAccount != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time that the virtual interface moves to the DOWN state.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the virtual interface failover test.
        /// </para>
        /// </summary>
        public string Status
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
        /// Gets and sets the property TestDurationInMinutes. 
        /// <para>
        /// The time that the virtual interface failover test ran in minutes.
        /// </para>
        /// </summary>
        public int? TestDurationInMinutes
        {
            get { return this._testDurationInMinutes; }
            set { this._testDurationInMinutes = value; }
        }

        // Check to see if TestDurationInMinutes property is set
        internal bool IsSetTestDurationInMinutes()
        {
            return this._testDurationInMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TestId. 
        /// <para>
        /// The ID of the virtual interface failover test.
        /// </para>
        /// </summary>
        public string TestId
        {
            get { return this._testId; }
            set { this._testId = value; }
        }

        // Check to see if TestId property is set
        internal bool IsSetTestId()
        {
            return this._testId != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualInterfaceId. 
        /// <para>
        /// The ID of the tested virtual interface.
        /// </para>
        /// </summary>
        public string VirtualInterfaceId
        {
            get { return this._virtualInterfaceId; }
            set { this._virtualInterfaceId = value; }
        }

        // Check to see if VirtualInterfaceId property is set
        internal bool IsSetVirtualInterfaceId()
        {
            return this._virtualInterfaceId != null;
        }

    }
}