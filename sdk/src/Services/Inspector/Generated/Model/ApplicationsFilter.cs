/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the inspector-2015-08-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector.Model
{
    /// <summary>
    /// This data type is used as the request parameter in the <a>ListApplications</a> action.
    /// </summary>
    public partial class ApplicationsFilter
    {
        private List<string> _applicationNamePatterns = new List<string>();

        /// <summary>
        /// Gets and sets the property ApplicationNamePatterns. 
        /// <para>
        /// For a record to match a filter, an explicit value or a string containing a wildcard
        /// specified for this data type property must match the value of the <b>applicationName</b>
        /// property of the <a>Application</a> data type.
        /// </para>
        /// </summary>
        public List<string> ApplicationNamePatterns
        {
            get { return this._applicationNamePatterns; }
            set { this._applicationNamePatterns = value; }
        }

        // Check to see if ApplicationNamePatterns property is set
        internal bool IsSetApplicationNamePatterns()
        {
            return this._applicationNamePatterns != null && this._applicationNamePatterns.Count > 0; 
        }

    }
}