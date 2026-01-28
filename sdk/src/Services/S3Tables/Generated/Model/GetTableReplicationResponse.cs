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
 * Do not modify this file. This file is generated from the s3tables-2018-05-10.normal.json service model.
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
namespace Amazon.S3Tables.Model
{
    /// <summary>
    /// This is the response object from the GetTableReplication operation.
    /// </summary>
    public partial class GetTableReplicationResponse : AmazonWebServiceResponse
    {
        private TableReplicationConfiguration _configuration;
        private string _versionToken;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The replication configuration for the table, including the IAM role and replication
        /// rules.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TableReplicationConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property VersionToken. 
        /// <para>
        /// A version token that represents the current state of the table's replication configuration.
        /// Use this token when updating the configuration to ensure consistency.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VersionToken
        {
            get { return this._versionToken; }
            set { this._versionToken = value; }
        }

        // Check to see if VersionToken property is set
        internal bool IsSetVersionToken()
        {
            return this._versionToken != null;
        }

    }
}