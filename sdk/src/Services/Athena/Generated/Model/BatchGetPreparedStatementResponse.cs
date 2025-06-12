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
    /// This is the response object from the BatchGetPreparedStatement operation.
    /// </summary>
    public partial class BatchGetPreparedStatementResponse : AmazonWebServiceResponse
    {
        private List<PreparedStatement> _preparedStatements = AWSConfigs.InitializeCollections ? new List<PreparedStatement>() : null;
        private List<UnprocessedPreparedStatementName> _unprocessedPreparedStatementNames = AWSConfigs.InitializeCollections ? new List<UnprocessedPreparedStatementName>() : null;

        /// <summary>
        /// Gets and sets the property PreparedStatements. 
        /// <para>
        /// The list of prepared statements returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PreparedStatement> PreparedStatements
        {
            get { return this._preparedStatements; }
            set { this._preparedStatements = value; }
        }

        // Check to see if PreparedStatements property is set
        internal bool IsSetPreparedStatements()
        {
            return this._preparedStatements != null && (this._preparedStatements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedPreparedStatementNames. 
        /// <para>
        /// A list of one or more prepared statements that were requested but could not be returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UnprocessedPreparedStatementName> UnprocessedPreparedStatementNames
        {
            get { return this._unprocessedPreparedStatementNames; }
            set { this._unprocessedPreparedStatementNames = value; }
        }

        // Check to see if UnprocessedPreparedStatementNames property is set
        internal bool IsSetUnprocessedPreparedStatementNames()
        {
            return this._unprocessedPreparedStatementNames != null && (this._unprocessedPreparedStatementNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}