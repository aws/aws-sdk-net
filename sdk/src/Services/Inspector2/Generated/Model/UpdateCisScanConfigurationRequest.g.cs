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
    /// Container for the parameters to the UpdateCisScanConfiguration operation. Updates
    /// a CIS scan configuration.
    /// </summary>
    public partial class UpdateCisScanConfigurationRequest : AmazonInspector2Request
    {
        /// <summary>
        /// Gets and sets the property ScanConfigurationArn. 
        /// <para>
        /// The CIS scan configuration ARN.
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
        /// The scan name for the CIS scan configuration.
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
        /// The schedule for the CIS scan configuration.
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
        ///  The security level for the CIS scan configuration. Security level refers to the Benchmark
        /// levels that CIS assigns to a profile. 
        /// </para>
        /// </summary>
        public CisSecurityLevel SecurityLevel { get; set; }

        /// <summary>
        /// Checks to see if the SecurityLevel property is set.
        /// </summary>
        internal bool IsSetSecurityLevel() => this.SecurityLevel != null;

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The targets for the CIS scan configuration.
        /// </para>
        /// </summary>
        public UpdateCisTargets Targets { get; set; }

        /// <summary>
        /// Checks to see if the Targets property is set.
        /// </summary>
        internal bool IsSetTargets() => this.Targets != null;
    }
}
