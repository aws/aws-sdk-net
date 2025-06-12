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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
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
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// Container for the parameters to the CreateKxChangeset operation.
    /// Creates a changeset for a kdb database. A changeset allows you to add and delete
    /// existing files by using an ordered list of change requests.
    /// </summary>
    public partial class CreateKxChangesetRequest : AmazonFinspaceRequest
    {
        private List<ChangeRequest> _changeRequests = AWSConfigs.InitializeCollections ? new List<ChangeRequest>() : null;
        private string _clientToken;
        private string _databaseName;
        private string _environmentId;

        /// <summary>
        /// Gets and sets the property ChangeRequests. 
        /// <para>
        /// A list of change request objects that are run in order. A change request object consists
        /// of <c>changeType</c> , <c>s3Path</c>, and <c>dbPath</c>. A changeType can have the
        /// following values: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PUT – Adds or updates files in a database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DELETE – Deletes files in a database.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// All the change requests require a mandatory <c>dbPath</c> attribute that defines the
        /// path within the database directory. All database paths must start with a leading /
        /// and end with a trailing /. The <c>s3Path</c> attribute defines the s3 source file
        /// path and is required for a PUT change type. The <c>s3path</c> must end with a trailing
        /// / if it is a directory and must end without a trailing / if it is a file. 
        /// </para>
        ///  
        /// <para>
        /// Here are few examples of how you can use the change request object:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// This request adds a single sym file at database root location. 
        /// </para>
        ///  
        /// <para>
        ///  <c>{ "changeType": "PUT", "s3Path":"s3://bucket/db/sym", "dbPath":"/"}</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This request adds files in the given <c>s3Path</c> under the 2020.01.02 partition
        /// of the database.
        /// </para>
        ///  
        /// <para>
        ///  <c>{ "changeType": "PUT", "s3Path":"s3://bucket/db/2020.01.02/", "dbPath":"/2020.01.02/"}</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This request adds files in the given <c>s3Path</c> under the <i>taq</i> table partition
        /// of the database.
        /// </para>
        ///  
        /// <para>
        ///  <c>[ { "changeType": "PUT", "s3Path":"s3://bucket/db/2020.01.02/taq/", "dbPath":"/2020.01.02/taq/"}]</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This request deletes the 2020.01.02 partition of the database.
        /// </para>
        ///  
        /// <para>
        ///  <c>[{ "changeType": "DELETE", "dbPath": "/2020.01.02/"} ]</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <i>DELETE</i> request allows you to delete the existing files under the 2020.01.02
        /// partition of the database, and the <i>PUT</i> request adds a new taq table under it.
        /// </para>
        ///  
        /// <para>
        ///  <c>[ {"changeType": "DELETE", "dbPath":"/2020.01.02/"}, {"changeType": "PUT", "s3Path":"s3://bucket/db/2020.01.02/taq/",
        /// "dbPath":"/2020.01.02/taq/"}]</c> 
        /// </para>
        ///  </li> </ol>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public List<ChangeRequest> ChangeRequests
        {
            get { return this._changeRequests; }
            set { this._changeRequests = value; }
        }

        // Check to see if ChangeRequests property is set
        internal bool IsSetChangeRequests()
        {
            return this._changeRequests != null && (this._changeRequests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that ensures idempotency. This token expires in 10 minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the kdb database.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// A unique identifier of the kdb environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

    }
}