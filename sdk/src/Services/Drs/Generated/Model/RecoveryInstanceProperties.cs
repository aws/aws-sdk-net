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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
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
namespace Amazon.Drs.Model
{
    /// <summary>
    /// Properties of the Recovery Instance machine.
    /// </summary>
    public partial class RecoveryInstanceProperties
    {
        private List<CPU> _cpus = AWSConfigs.InitializeCollections ? new List<CPU>() : null;
        private List<RecoveryInstanceDisk> _disks = AWSConfigs.InitializeCollections ? new List<RecoveryInstanceDisk>() : null;
        private IdentificationHints _identificationHints;
        private string _lastUpdatedDateTime;
        private List<NetworkInterface> _networkInterfaces = AWSConfigs.InitializeCollections ? new List<NetworkInterface>() : null;
        private OS _os;
        private long? _ramBytes;

        /// <summary>
        /// Gets and sets the property Cpus. 
        /// <para>
        /// An array of CPUs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public List<CPU> Cpus
        {
            get { return this._cpus; }
            set { this._cpus = value; }
        }

        // Check to see if Cpus property is set
        internal bool IsSetCpus()
        {
            return this._cpus != null && (this._cpus.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Disks. 
        /// <para>
        /// An array of disks.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public List<RecoveryInstanceDisk> Disks
        {
            get { return this._disks; }
            set { this._disks = value; }
        }

        // Check to see if Disks property is set
        internal bool IsSetDisks()
        {
            return this._disks != null && (this._disks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IdentificationHints. 
        /// <para>
        /// Hints used to uniquely identify a machine.
        /// </para>
        /// </summary>
        public IdentificationHints IdentificationHints
        {
            get { return this._identificationHints; }
            set { this._identificationHints = value; }
        }

        // Check to see if IdentificationHints property is set
        internal bool IsSetIdentificationHints()
        {
            return this._identificationHints != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedDateTime. 
        /// <para>
        /// The date and time the Recovery Instance properties were last updated on.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=32)]
        public string LastUpdatedDateTime
        {
            get { return this._lastUpdatedDateTime; }
            set { this._lastUpdatedDateTime = value; }
        }

        // Check to see if LastUpdatedDateTime property is set
        internal bool IsSetLastUpdatedDateTime()
        {
            return this._lastUpdatedDateTime != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaces. 
        /// <para>
        /// An array of network interfaces.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=32)]
        public List<NetworkInterface> NetworkInterfaces
        {
            get { return this._networkInterfaces; }
            set { this._networkInterfaces = value; }
        }

        // Check to see if NetworkInterfaces property is set
        internal bool IsSetNetworkInterfaces()
        {
            return this._networkInterfaces != null && (this._networkInterfaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Os. 
        /// <para>
        /// Operating system.
        /// </para>
        /// </summary>
        public OS Os
        {
            get { return this._os; }
            set { this._os = value; }
        }

        // Check to see if Os property is set
        internal bool IsSetOs()
        {
            return this._os != null;
        }

        /// <summary>
        /// Gets and sets the property RamBytes. 
        /// <para>
        /// The amount of RAM in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? RamBytes
        {
            get { return this._ramBytes; }
            set { this._ramBytes = value; }
        }

        // Check to see if RamBytes property is set
        internal bool IsSetRamBytes()
        {
            return this._ramBytes.HasValue; 
        }

    }
}