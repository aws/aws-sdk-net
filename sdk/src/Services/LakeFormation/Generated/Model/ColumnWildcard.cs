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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// A wildcard object, consisting of an optional list of excluded column names or indexes.
    /// </summary>
    public partial class ColumnWildcard
    {
        private List<string> _excludedColumnNames = new List<string>();

        /// <summary>
        /// Gets and sets the property ExcludedColumnNames. 
        /// <para>
        /// Excludes column names. Any column with this name will be excluded.
        /// </para>
        /// </summary>
        public List<string> ExcludedColumnNames
        {
            get { return this._excludedColumnNames; }
            set { this._excludedColumnNames = value; }
        }

        // Check to see if ExcludedColumnNames property is set
        internal bool IsSetExcludedColumnNames()
        {
            return this._excludedColumnNames != null && this._excludedColumnNames.Count > 0; 
        }

    }
}