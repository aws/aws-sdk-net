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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the BatchImportFindings operation.
    /// Imports security findings generated from an integrated third-party product into Security
    /// Hub. This action is requested by the integrated product to import its findings into
    /// Security Hub.
    /// 
    ///  
    /// <para>
    /// The maximum allowed size for a finding is 240 Kb. An error is returned for any finding
    /// larger than 240 Kb.
    /// </para>
    ///  
    /// <para>
    /// After a finding is created, <code>BatchImportFindings</code> cannot be used to update
    /// the following finding fields and objects, which Security Hub customers use to manage
    /// their investigation workflow.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>Note</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>UserDefinedFields</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>VerificationState</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Workflow</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <code>BatchImportFindings</code> can be used to update the following finding fields
    /// and objects only if they have not been updated using <code>BatchUpdateFindings</code>.
    /// After they are updated using <code>BatchUpdateFindings</code>, these fields cannot
    /// be updated using <code>BatchImportFindings</code>.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>Confidence</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Criticality</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>RelatedFindings</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Severity</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>Types</code> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class BatchImportFindingsRequest : AmazonSecurityHubRequest
    {
        private List<AwsSecurityFinding> _findings = new List<AwsSecurityFinding>();

        /// <summary>
        /// Gets and sets the property Findings. 
        /// <para>
        /// A list of findings to import. To successfully import a finding, it must follow the
        /// <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-findings-format.html">AWS
        /// Security Finding Format</a>. Maximum of 100 findings per request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AwsSecurityFinding> Findings
        {
            get { return this._findings; }
            set { this._findings = value; }
        }

        // Check to see if Findings property is set
        internal bool IsSetFindings()
        {
            return this._findings != null && this._findings.Count > 0; 
        }

    }
}