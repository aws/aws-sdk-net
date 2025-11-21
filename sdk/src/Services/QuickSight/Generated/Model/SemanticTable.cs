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
    /// A semantic table that represents the final analytical structure of the data.
    /// </summary>
    public partial class SemanticTable
    {
        private string _alias;
        private string _destinationTableId;
        private RowLevelPermissionConfiguration _rowLevelPermissionConfiguration;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// Alias for the semantic table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationTableId. 
        /// <para>
        /// The identifier of the destination table from data preparation that provides data to
        /// this semantic table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string DestinationTableId
        {
            get { return this._destinationTableId; }
            set { this._destinationTableId = value; }
        }

        // Check to see if DestinationTableId property is set
        internal bool IsSetDestinationTableId()
        {
            return this._destinationTableId != null;
        }

        /// <summary>
        /// Gets and sets the property RowLevelPermissionConfiguration. 
        /// <para>
        /// Configuration for row level security that control data access for this semantic table.
        /// </para>
        /// </summary>
        public RowLevelPermissionConfiguration RowLevelPermissionConfiguration
        {
            get { return this._rowLevelPermissionConfiguration; }
            set { this._rowLevelPermissionConfiguration = value; }
        }

        // Check to see if RowLevelPermissionConfiguration property is set
        internal bool IsSetRowLevelPermissionConfiguration()
        {
            return this._rowLevelPermissionConfiguration != null;
        }

    }
}