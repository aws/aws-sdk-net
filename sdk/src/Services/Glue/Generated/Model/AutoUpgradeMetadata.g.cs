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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// <text>The auto-upgrade assessment information for a job configured with glueVersion=auto.</text>
    /// </summary>
    public partial class AutoUpgradeMetadata
    {
        /// <summary>
        /// Gets and sets the property AnalysisId. <text>The unique identifier of the auto-upgrade
        /// assessment analysis.</text>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string AnalysisId { get; set; }

        /// <summary>
        /// Checks to see if the AnalysisId property is set.
        /// </summary>
        internal bool IsSetAnalysisId() => this.AnalysisId != null;

        /// <summary>
        /// Gets and sets the property SourceVersion. <text>The source Glue runtime version the
        /// job was running before auto-version was enabled.</text>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SourceVersion { get; set; }

        /// <summary>
        /// Checks to see if the SourceVersion property is set.
        /// </summary>
        internal bool IsSetSourceVersion() => this.SourceVersion != null;

        /// <summary>
        /// Gets and sets the property Status. <text>The current auto-upgrade lifecycle status
        /// (OBSERVING, UPGRADING, UPGRADE_SUCCEEDED, UPGRADE_FAILED, STOPPED, WAITING_FOR_CONSENT).</text>
        /// </summary>
        public AutoUpgradeStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetVersion. <text>The target Glue runtime version the
        /// job is being upgraded to.</text>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string TargetVersion { get; set; }

        /// <summary>
        /// Checks to see if the TargetVersion property is set.
        /// </summary>
        internal bool IsSetTargetVersion() => this.TargetVersion != null;
    }
}
