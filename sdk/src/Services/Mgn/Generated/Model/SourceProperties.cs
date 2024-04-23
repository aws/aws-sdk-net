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
 * Do not modify this file. This file is generated from the mgn-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Mgn.Model
{
    /// <summary>
    /// Source server properties.
    /// </summary>
    public partial class SourceProperties
    {
        private List<CPU> _cpus = AWSConfigs.InitializeCollections ? new List<CPU>() : null;
        private List<Disk> _disks = AWSConfigs.InitializeCollections ? new List<Disk>() : null;
        private IdentificationHints _identificationHints;
        private string _lastUpdatedDateTime;
        private List<NetworkInterface> _networkInterfaces = AWSConfigs.InitializeCollections ? new List<NetworkInterface>() : null;
        private OS _os;
        private long? _ramBytes;
        private string _recommendedInstanceType;

        /// <summary>
        /// Gets and sets the property Cpus. 
        /// <para>
        /// Source Server CPUs.
        /// </para>
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
        /// Source Server disks.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public List<Disk> Disks
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
        /// Source server identification hints.
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
        /// Source server last update date and time.
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
        /// Source server network interfaces.
        /// </para>
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
        /// Source server OS.
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
        /// Source server RAM in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long RamBytes
        {
            get { return this._ramBytes.GetValueOrDefault(); }
            set { this._ramBytes = value; }
        }

        // Check to see if RamBytes property is set
        internal bool IsSetRamBytes()
        {
            return this._ramBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecommendedInstanceType. 
        /// <para>
        /// Source server recommended instance type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=255)]
        public string RecommendedInstanceType
        {
            get { return this._recommendedInstanceType; }
            set { this._recommendedInstanceType = value; }
        }

        // Check to see if RecommendedInstanceType property is set
        internal bool IsSetRecommendedInstanceType()
        {
            return this._recommendedInstanceType != null;
        }

    }
}