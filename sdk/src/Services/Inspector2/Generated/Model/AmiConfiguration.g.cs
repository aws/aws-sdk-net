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
    /// The configuration that controls how Amazon Machine Images (AMIs) are scanned for an
    /// account.
    /// </summary>
    public partial class AmiConfiguration
    {
        /// <summary>
        /// Gets and sets the property CreatedWithin. 
        /// <para>
        /// Restricts scanning to AMIs that were created within the specified duration.
        /// </para>
        /// </summary>
        public AmiScanDuration CreatedWithin { get; set; }

        /// <summary>
        /// Checks to see if the CreatedWithin property is set.
        /// </summary>
        internal bool IsSetCreatedWithin() => this.CreatedWithin != null;

        /// <summary>
        /// Gets and sets the property LastLaunchedWithin. 
        /// <para>
        /// Restricts scanning to AMIs that were last launched within the specified duration.
        /// </para>
        /// </summary>
        public AmiScanDuration LastLaunchedWithin { get; set; }

        /// <summary>
        /// Checks to see if the LastLaunchedWithin property is set.
        /// </summary>
        internal bool IsSetLastLaunchedWithin() => this.LastLaunchedWithin != null;

        /// <summary>
        /// Gets and sets the property ScanModeConfiguration. 
        /// <para>
        /// The scan mode configuration that determines which AMIs are scanned.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AmiScanModeConfiguration ScanModeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ScanModeConfiguration property is set.
        /// </summary>
        internal bool IsSetScanModeConfiguration() => this.ScanModeConfiguration != null;
    }
}
