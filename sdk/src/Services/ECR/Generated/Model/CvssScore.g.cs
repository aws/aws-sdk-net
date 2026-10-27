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

namespace Amazon.ECR.Model
{
    /// <summary>
    /// The CVSS score for a finding.
    /// </summary>
    public partial class CvssScore
    {
        /// <summary>
        /// Gets and sets the property BaseScore. 
        /// <para>
        /// The base CVSS score used for the finding.
        /// </para>
        /// </summary>
        public double? BaseScore { get; set; }

        /// <summary>
        /// Checks to see if the BaseScore property is set.
        /// </summary>
        internal bool IsSetBaseScore() => this.BaseScore.HasValue;

        /// <summary>
        /// Gets and sets the property ScoringVector. 
        /// <para>
        /// The vector string of the CVSS score.
        /// </para>
        /// </summary>
        public string ScoringVector { get; set; }

        /// <summary>
        /// Checks to see if the ScoringVector property is set.
        /// </summary>
        internal bool IsSetScoringVector() => this.ScoringVector != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the CVSS score.
        /// </para>
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version of CVSS used for the score.
        /// </para>
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
