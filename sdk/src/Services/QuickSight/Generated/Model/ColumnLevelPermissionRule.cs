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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A rule defined to grant access on one or more restricted columns. Each dataset can
    /// have multiple rules. To create a restricted column, you add it to one or more rules.
    /// Each rule must contain at least one column and at least one user or group. To be able
    /// to see a restricted column, a user or group needs to be added to a rule for that column.
    /// </summary>
    public partial class ColumnLevelPermissionRule
    {
        private List<string> _columnNames = new List<string>();
        private List<string> _principals = new List<string>();

        /// <summary>
        /// Gets and sets the property ColumnNames. 
        /// <para>
        /// An array of column names.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<string> ColumnNames
        {
            get { return this._columnNames; }
            set { this._columnNames = value; }
        }

        // Check to see if ColumnNames property is set
        internal bool IsSetColumnNames()
        {
            return this._columnNames != null && this._columnNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Principals. 
        /// <para>
        /// An array of Amazon Resource Names (ARNs) for QuickSight users or groups.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> Principals
        {
            get { return this._principals; }
            set { this._principals = value; }
        }

        // Check to see if Principals property is set
        internal bool IsSetPrincipals()
        {
            return this._principals != null && this._principals.Count > 0; 
        }

    }
}