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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The Amazon Web Services Threat Intel Group (ATIG) details for a specific vulnerability.
    /// </summary>
    public partial class AtigData
    {
        private DateTime? _firstSeen;
        private DateTime? _lastSeen;
        private List<string> _targets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _ttps = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property FirstSeen. 
        /// <para>
        /// The date and time this vulnerability was first observed.
        /// </para>
        /// </summary>
        public DateTime? FirstSeen
        {
            get { return this._firstSeen; }
            set { this._firstSeen = value; }
        }

        // Check to see if FirstSeen property is set
        internal bool IsSetFirstSeen()
        {
            return this._firstSeen.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastSeen. 
        /// <para>
        /// The date and time this vulnerability was last observed.
        /// </para>
        /// </summary>
        public DateTime? LastSeen
        {
            get { return this._lastSeen; }
            set { this._lastSeen = value; }
        }

        // Check to see if LastSeen property is set
        internal bool IsSetLastSeen()
        {
            return this._lastSeen.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The commercial sectors this vulnerability targets.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0)]
        public List<string> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && (this._targets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Ttps. 
        /// <para>
        /// The <a href="https://attack.mitre.org/">MITRE ATT&amp;CK</a> tactics, techniques,
        /// and procedures (TTPs) associated with vulnerability.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0)]
        public List<string> Ttps
        {
            get { return this._ttps; }
            set { this._ttps = value; }
        }

        // Check to see if Ttps property is set
        internal bool IsSetTtps()
        {
            return this._ttps != null && (this._ttps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}