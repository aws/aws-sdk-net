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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// Code-specific environment properties. GetEnvironment returns the source and operating
    /// policy; UpdateEnvironment returns Collector details and the latest scan.
    /// </summary>
    public partial class CodeConfigurationDetails
    {
        /// <summary>
        /// Gets and sets the property CollectorDetails. Collector data access configuration.
        /// Omitted when no Collector data access role is configured.
        /// </summary>
        public CollectorDetails CollectorDetails { get; set; }

        /// <summary>
        /// Checks to see if the CollectorDetails property is set.
        /// </summary>
        internal bool IsSetCollectorDetails() => this.CollectorDetails != null;

        /// <summary>
        /// Gets and sets the property EnvironmentConfiguration. Operating policy in the shape
        /// accepted by CreateEnvironment and UpdateEnvironment.
        /// </summary>
        public EnvironmentConfiguration EnvironmentConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the EnvironmentConfiguration property is set.
        /// </summary>
        internal bool IsSetEnvironmentConfiguration() => this.EnvironmentConfiguration != null;

        /// <summary>
        /// Gets and sets the property LatestScan. The newest scan requested for this environment,
        /// if one exists.
        /// </summary>
        public CodeScanSummary LatestScan { get; set; }

        /// <summary>
        /// Checks to see if the LatestScan property is set.
        /// </summary>
        internal bool IsSetLatestScan() => this.LatestScan != null;

        /// <summary>
        /// Gets and sets the property SourceConfiguration. Sources in the shape accepted by CreateEnvironment
        /// and UpdateEnvironment.
        /// </summary>
        public EnvironmentSourceConfiguration SourceConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SourceConfiguration property is set.
        /// </summary>
        internal bool IsSetSourceConfiguration() => this.SourceConfiguration != null;
    }
}
