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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// An instance of a threat intelligence detail that constitutes evidence for the finding.
    /// </summary>
    public partial class ThreatIntelligenceDetail
    {
        private string _threatListName;
        private List<string> _threatNames = new List<string>();

        /// <summary>
        /// Gets and sets the property ThreatListName. 
        /// <para>
        /// The name of the threat intelligence list that triggered the finding.
        /// </para>
        /// </summary>
        public string ThreatListName
        {
            get { return this._threatListName; }
            set { this._threatListName = value; }
        }

        // Check to see if ThreatListName property is set
        internal bool IsSetThreatListName()
        {
            return this._threatListName != null;
        }

        /// <summary>
        /// Gets and sets the property ThreatNames. 
        /// <para>
        /// A list of names of the threats in the threat intelligence list that triggered the
        /// finding.
        /// </para>
        /// </summary>
        public List<string> ThreatNames
        {
            get { return this._threatNames; }
            set { this._threatNames = value; }
        }

        // Check to see if ThreatNames property is set
        internal bool IsSetThreatNames()
        {
            return this._threatNames != null && this._threatNames.Count > 0; 
        }

    }
}