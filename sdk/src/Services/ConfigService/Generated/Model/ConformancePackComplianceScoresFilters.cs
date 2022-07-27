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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// A list of filters to apply to the conformance pack compliance score result set.
    /// </summary>
    public partial class ConformancePackComplianceScoresFilters
    {
        private List<string> _conformancePackNames = new List<string>();

        /// <summary>
        /// Gets and sets the property ConformancePackNames. 
        /// <para>
        /// The name of a conformance pack whose score should be included in the compliance score
        /// result.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<string> ConformancePackNames
        {
            get { return this._conformancePackNames; }
            set { this._conformancePackNames = value; }
        }

        // Check to see if ConformancePackNames property is set
        internal bool IsSetConformancePackNames()
        {
            return this._conformancePackNames != null && this._conformancePackNames.Count > 0; 
        }

    }
}