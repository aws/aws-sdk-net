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
 * Do not modify this file. This file is generated from the codeguru-security-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruSecurity.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetFindings operation.
    /// Returns a list of all requested findings.
    /// </summary>
    public partial class BatchGetFindingsRequest : AmazonCodeGuruSecurityRequest
    {
        private List<FindingIdentifier> _findingIdentifiers = new List<FindingIdentifier>();

        /// <summary>
        /// Gets and sets the property FindingIdentifiers. 
        /// <para>
        /// A list of finding identifiers. Each identifier consists of a <code>scanName</code>
        /// and a <code>findingId</code>. You retrieve the <code>findingId</code> when you call
        /// <code>GetFindings</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<FindingIdentifier> FindingIdentifiers
        {
            get { return this._findingIdentifiers; }
            set { this._findingIdentifiers = value; }
        }

        // Check to see if FindingIdentifiers property is set
        internal bool IsSetFindingIdentifiers()
        {
            return this._findingIdentifiers != null && this._findingIdentifiers.Count > 0; 
        }

    }
}