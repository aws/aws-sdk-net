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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// A type of analysis rule that enables row-level analysis.
    /// </summary>
    public partial class AnalysisRuleList
    {
        private List<string> _allowedJoinOperators = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _joinColumns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _listColumns = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AllowedJoinOperators. 
        /// <para>
        /// The logical operators (if any) that are to be used in an INNER JOIN match condition.
        /// Default is <c>AND</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public List<string> AllowedJoinOperators
        {
            get { return this._allowedJoinOperators; }
            set { this._allowedJoinOperators = value; }
        }

        // Check to see if AllowedJoinOperators property is set
        internal bool IsSetAllowedJoinOperators()
        {
            return this._allowedJoinOperators != null && (this._allowedJoinOperators.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property JoinColumns. 
        /// <para>
        /// Columns that can be used to join a configured table with the table of the member who
        /// can query and other members' configured tables.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> JoinColumns
        {
            get { return this._joinColumns; }
            set { this._joinColumns = value; }
        }

        // Check to see if JoinColumns property is set
        internal bool IsSetJoinColumns()
        {
            return this._joinColumns != null && (this._joinColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ListColumns. 
        /// <para>
        /// Columns that can be listed in the output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ListColumns
        {
            get { return this._listColumns; }
            set { this._listColumns = value; }
        }

        // Check to see if ListColumns property is set
        internal bool IsSetListColumns()
        {
            return this._listColumns != null && (this._listColumns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}