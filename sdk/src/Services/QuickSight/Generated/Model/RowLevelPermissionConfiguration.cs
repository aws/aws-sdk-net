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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Configuration for row level security.
    /// </summary>
    public partial class RowLevelPermissionConfiguration
    {
        private RowLevelPermissionDataSet _rowLevelPermissionDataSet;
        private RowLevelPermissionTagConfiguration _tagConfiguration;

        /// <summary>
        /// Gets and sets the property RowLevelPermissionDataSet.
        /// </summary>
        public RowLevelPermissionDataSet RowLevelPermissionDataSet
        {
            get { return this._rowLevelPermissionDataSet; }
            set { this._rowLevelPermissionDataSet = value; }
        }

        // Check to see if RowLevelPermissionDataSet property is set
        internal bool IsSetRowLevelPermissionDataSet()
        {
            return this._rowLevelPermissionDataSet != null;
        }

        /// <summary>
        /// Gets and sets the property TagConfiguration.
        /// </summary>
        public RowLevelPermissionTagConfiguration TagConfiguration
        {
            get { return this._tagConfiguration; }
            set { this._tagConfiguration = value; }
        }

        // Check to see if TagConfiguration property is set
        internal bool IsSetTagConfiguration()
        {
            return this._tagConfiguration != null;
        }

    }
}