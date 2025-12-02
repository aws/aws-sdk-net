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
    /// This is the response object from the GetTableReplicationStatus operation.
    /// </summary>
    public partial class GetTableReplicationStatusResponse : AmazonWebServiceResponse
    {
        private List<ReplicationDestinationStatusModel> _destinations = AWSConfigs.InitializeCollections ? new List<ReplicationDestinationStatusModel>() : null;
        private string _sourceTableArn;

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// An array of status information for each replication destination, including the current
        /// state, last successful update, and any error messages.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<ReplicationDestinationStatusModel> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && (this._destinations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourceTableArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source table being replicated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string SourceTableArn
        {
            get { return this._sourceTableArn; }
            set { this._sourceTableArn = value; }
        }

        // Check to see if SourceTableArn property is set
        internal bool IsSetSourceTableArn()
        {
            return this._sourceTableArn != null;
        }

    }
}