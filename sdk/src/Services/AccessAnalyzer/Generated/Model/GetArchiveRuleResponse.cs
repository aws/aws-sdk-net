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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// The response to the request.
    /// </summary>
    public partial class GetArchiveRuleResponse : AmazonWebServiceResponse
    {
        private ArchiveRuleSummary _archiveRule;

        /// <summary>
        /// Gets and sets the property ArchiveRule.
        /// </summary>
        [AWSProperty(Required=true)]
        public ArchiveRuleSummary ArchiveRule
        {
            get { return this._archiveRule; }
            set { this._archiveRule = value; }
        }

        // Check to see if ArchiveRule property is set
        internal bool IsSetArchiveRule()
        {
            return this._archiveRule != null;
        }

    }
}