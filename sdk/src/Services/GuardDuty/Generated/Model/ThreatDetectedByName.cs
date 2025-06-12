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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains details about identified threats organized by threat name.
    /// </summary>
    public partial class ThreatDetectedByName
    {
        private int? _itemCount;
        private bool? _shortened;
        private List<ScanThreatName> _threatNames = AWSConfigs.InitializeCollections ? new List<ScanThreatName>() : null;
        private int? _uniqueThreatNameCount;

        /// <summary>
        /// Gets and sets the property ItemCount. 
        /// <para>
        /// Total number of infected files identified.
        /// </para>
        /// </summary>
        public int? ItemCount
        {
            get { return this._itemCount; }
            set { this._itemCount = value; }
        }

        // Check to see if ItemCount property is set
        internal bool IsSetItemCount()
        {
            return this._itemCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Shortened. 
        /// <para>
        /// Flag to determine if the finding contains every single infected file-path and/or every
        /// threat.
        /// </para>
        /// </summary>
        public bool? Shortened
        {
            get { return this._shortened; }
            set { this._shortened = value; }
        }

        // Check to see if Shortened property is set
        internal bool IsSetShortened()
        {
            return this._shortened.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThreatNames. 
        /// <para>
        /// List of identified threats with details, organized by threat name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ScanThreatName> ThreatNames
        {
            get { return this._threatNames; }
            set { this._threatNames = value; }
        }

        // Check to see if ThreatNames property is set
        internal bool IsSetThreatNames()
        {
            return this._threatNames != null && (this._threatNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UniqueThreatNameCount. 
        /// <para>
        /// Total number of unique threats by name identified, as part of the malware scan.
        /// </para>
        /// </summary>
        public int? UniqueThreatNameCount
        {
            get { return this._uniqueThreatNameCount; }
            set { this._uniqueThreatNameCount = value; }
        }

        // Check to see if UniqueThreatNameCount property is set
        internal bool IsSetUniqueThreatNameCount()
        {
            return this._uniqueThreatNameCount.HasValue; 
        }

    }
}