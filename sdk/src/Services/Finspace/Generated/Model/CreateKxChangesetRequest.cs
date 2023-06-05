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

namespace Amazon.Finspace.Model
{
    /// <summary>
    /// Container for the parameters to the CreateKxChangeset operation.
    /// Creates a changeset for a kdb database. A changeset allows you to add and delete
    /// existing files by using an ordered list of change requests.
    /// </summary>
    public partial class CreateKxChangesetRequest : AmazonFinspaceRequest
    {
        private List<ChangeRequest> _changeRequests = new List<ChangeRequest>();
        private string _clientToken;
        private string _databaseName;
        private string _environmentId;

        /// <summary>
        /// Gets and sets the property ChangeRequests. 
        /// <para>
        /// A list of change request objects that are run in order. A change request object consists
        /// of changeType , s3Path, and a dbPath. A changeType can has the following values: 
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
        /// All the change requests require a mandatory <i>dbPath</i> attribute that defines the
        /// path within the database directory. The <i>s3Path</i> attribute defines the s3 source
        /// file path and is required for a PUT change type.
        /// </para>
        ///  
        /// <para>
        /// Here is an example of how you can use the change request object:
        /// </para>
        ///  
        /// <para>
        ///  <code>[ { "changeType": "PUT", "s3Path":"s3://bucket/db/2020.01.02/", "dbPath":"/2020.01.02/"},
        /// { "changeType": "PUT", "s3Path":"s3://bucket/db/sym", "dbPath":"/"}, { "changeType":
        /// "DELETE", "dbPath": "/2020.01.01/"} ]</code> 
        /// </para>
        ///  
        /// <para>
        /// In this example, the first request with <i>PUT</i> change type allows you to add files
        /// in the given s3Path under the <i>2020.01.02</i> partition of the database. The second
        /// request with <i>PUT</i> change type allows you to add a single sym file at database
        /// root location. The last request with <i>DELETE</i> change type allows you to delete
        /// the files under the <i>2020.01.01</i> partition of the database. 
        /// </para>
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
            return this._changeRequests != null && this._changeRequests.Count > 0; 
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