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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
namespace Amazon.Athena.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetPreparedStatement operation.
    /// Returns the details of a single prepared statement or a list of up to 256 prepared
    /// statements for the array of prepared statement names that you provide. Requires you
    /// to have access to the workgroup to which the prepared statements belong. If a prepared
    /// statement cannot be retrieved for the name specified, the statement is listed in <c>UnprocessedPreparedStatementNames</c>.
    /// </summary>
    public partial class BatchGetPreparedStatementRequest : AmazonAthenaRequest
    {
        private List<string> _preparedStatementNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _workGroup;

        /// <summary>
        /// Gets and sets the property PreparedStatementNames. 
        /// <para>
        /// A list of prepared statement names to return.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> PreparedStatementNames
        {
            get { return this._preparedStatementNames; }
            set { this._preparedStatementNames = value; }
        }

        // Check to see if PreparedStatementNames property is set
        internal bool IsSetPreparedStatementNames()
        {
            return this._preparedStatementNames != null && (this._preparedStatementNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WorkGroup. 
        /// <para>
        /// The name of the workgroup to which the prepared statements belong.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkGroup
        {
            get { return this._workGroup; }
            set { this._workGroup = value; }
        }

        // Check to see if WorkGroup property is set
        internal bool IsSetWorkGroup()
        {
            return this._workGroup != null;
        }

    }
}