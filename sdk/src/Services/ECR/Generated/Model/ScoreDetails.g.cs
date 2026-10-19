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
    /// Information about the Amazon Inspector score given to a finding.
    /// </summary>
    public partial class ScoreDetails
    {
        /// <summary>
        /// Gets and sets the property Cvss. 
        /// <para>
        /// An object that contains details about the CVSS score given to a finding.
        /// </para>
        /// </summary>
        public CvssScoreDetails Cvss { get; set; }

        /// <summary>
        /// Checks to see if the Cvss property is set.
        /// </summary>
        internal bool IsSetCvss() => this.Cvss != null;
    }
}
