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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The CIS scan configuration's owner ID.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property ScanConfigurationArn. 
        /// <para>
        /// The CIS scan configuration's scan configuration ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ScanConfigurationArn { get; set; }

        /// <summary>
        /// Checks to see if the ScanConfigurationArn property is set.
        /// </summary>
        internal bool IsSetScanConfigurationArn() => this.ScanConfigurationArn != null;

        /// <summary>
        /// Gets and sets the property ScanName. 
        /// <para>
        /// The name of the CIS scan configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ScanName { get; set; }

        /// <summary>
        /// Checks to see if the ScanName property is set.
        /// </summary>
        internal bool IsSetScanName() => this.ScanName != null;

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// The CIS scan configuration's schedule.
        /// </para>
        /// </summary>
        public Schedule Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

        /// <summary>
        /// Gets and sets the property SecurityLevel. 
        /// <para>
        /// The CIS scan configuration's security level.
        /// </para>
        /// </summary>
        public CisSecurityLevel SecurityLevel { get; set; }

        /// <summary>
        /// Checks to see if the SecurityLevel property is set.
        /// </summary>
        internal bool IsSetSecurityLevel() => this.SecurityLevel != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The CIS scan configuration's tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The CIS scan configuration's targets.
        /// </para>
        /// </summary>
        public CisTargets Targets { get; set; }

        /// <summary>
        /// Checks to see if the Targets property is set.
        /// </summary>
        internal bool IsSetTargets() => this.Targets != null;
    }
}
