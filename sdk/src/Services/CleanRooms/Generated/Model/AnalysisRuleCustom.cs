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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// A type of analysis rule that enables the table owner to approve custom SQL queries
    /// on their configured tables.
    /// </summary>
    public partial class AnalysisRuleCustom
    {
        private List<string> _allowedAnalyses = new List<string>();
        private List<string> _allowedAnalysisProviders = new List<string>();

        /// <summary>
        /// Gets and sets the property AllowedAnalyses. 
        /// <para>
        /// The analysis templates that are allowed by the custom analysis rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public List<string> AllowedAnalyses
        {
            get { return this._allowedAnalyses; }
            set { this._allowedAnalyses = value; }
        }

        // Check to see if AllowedAnalyses property is set
        internal bool IsSetAllowedAnalyses()
        {
            return this._allowedAnalyses != null && this._allowedAnalyses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AllowedAnalysisProviders. 
        /// <para>
        /// The Amazon Web Services accounts that are allowed to query by the custom analysis
        /// rule. Required when <code>allowedAnalyses</code> is <code>ANY_QUERY</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public List<string> AllowedAnalysisProviders
        {
            get { return this._allowedAnalysisProviders; }
            set { this._allowedAnalysisProviders = value; }
        }

        // Check to see if AllowedAnalysisProviders property is set
        internal bool IsSetAllowedAnalysisProviders()
        {
            return this._allowedAnalysisProviders != null && this._allowedAnalysisProviders.Count > 0; 
        }

    }
}