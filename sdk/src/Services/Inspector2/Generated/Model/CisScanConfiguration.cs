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
    /// The CIS scan configuration.
    /// </summary>
    public partial class CisScanConfiguration
    {
        private string _ownerId;
        private string _scanConfigurationArn;
        private string _scanName;
        private Schedule _schedule;
        private CisSecurityLevel _securityLevel;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private CisTargets _targets;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The CIS scan configuration's owner ID.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property ScanConfigurationArn. 
        /// <para>
        /// The CIS scan configuration's scan configuration ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ScanConfigurationArn
        {
            get { return this._scanConfigurationArn; }
            set { this._scanConfigurationArn = value; }
        }

        // Check to see if ScanConfigurationArn property is set
        internal bool IsSetScanConfigurationArn()
        {
            return this._scanConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property ScanName. 
        /// <para>
        /// The name of the CIS scan configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ScanName
        {
            get { return this._scanName; }
            set { this._scanName = value; }
        }

        // Check to see if ScanName property is set
        internal bool IsSetScanName()
        {
            return this._scanName != null;
        }

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The CIS scan configuration's schedule.
        /// </para>
        /// </summary>
        public Schedule Schedule
        {
            get { return this._schedule; }
            set { this._schedule = value; }
        }

        // Check to see if Schedule property is set
        internal bool IsSetSchedule()
        {
            return this._schedule != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityLevel. 
        /// <para>
        /// The CIS scan configuration's security level.
        /// </para>
        /// </summary>
        public CisSecurityLevel SecurityLevel
        {
            get { return this._securityLevel; }
            set { this._securityLevel = value; }
        }

        // Check to see if SecurityLevel property is set
        internal bool IsSetSecurityLevel()
        {
            return this._securityLevel != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The CIS scan configuration's tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The CIS scan configuration's targets.
        /// </para>
        /// </summary>
        public CisTargets Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null;
        }

    }
}