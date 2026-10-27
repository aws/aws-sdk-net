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
    /// The Common Vulnerability Scoring System (CVSS) version 3 details for the vulnerability.
    /// </summary>
    public partial class Cvss3
    {
        /// <summary>
        /// Gets and sets the property BaseScore. 
        /// <para>
        /// The CVSS v3 base score for the vulnerability.
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
        /// The scoring vector associated with the CVSS v3 score.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public string ScoringVector { get; set; }

        /// <summary>
        /// Checks to see if the ScoringVector property is set.
        /// </summary>
        internal bool IsSetScoringVector() => this.ScoringVector != null;
    }
}
