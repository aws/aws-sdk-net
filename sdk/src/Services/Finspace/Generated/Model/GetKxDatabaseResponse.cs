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
    /// This is the response object from the GetKxDatabase operation.
    /// </summary>
    public partial class GetKxDatabaseResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdTimestamp;
        private string _databaseArn;
        private string _databaseName;
        private string _description;
        private string _environmentId;
        private string _lastCompletedChangesetId;
        private DateTime? _lastModifiedTimestamp;
        private long? _numBytes;
        private int? _numChangesets;
        private int? _numFiles;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp at which the database is created in FinSpace. The value is determined
        /// as epoch time in milliseconds. For example, the value for Monday, November 1, 2021
        /// 12:00:00 PM UTC is specified as 1635768000000.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatabaseArn. 
        /// <para>
        /// The ARN identifier of the database.
        /// </para>
        /// </summary>
        public string DatabaseArn
        {
            get { return this._databaseArn; }
            set { this._databaseArn = value; }
        }

        // Check to see if DatabaseArn property is set
        internal bool IsSetDatabaseArn()
        {
            return this._databaseArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the kdb database for which the information is retrieved.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=63)]
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the database.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// A unique identifier for the kdb environment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
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

        /// <summary>
        /// Gets and sets the property LastCompletedChangesetId. 
        /// <para>
        /// A unique identifier for the changeset.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=26)]
        public string LastCompletedChangesetId
        {
            get { return this._lastCompletedChangesetId; }
            set { this._lastCompletedChangesetId = value; }
        }

        // Check to see if LastCompletedChangesetId property is set
        internal bool IsSetLastCompletedChangesetId()
        {
            return this._lastCompletedChangesetId != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTimestamp. 
        /// <para>
        /// The last time that the database was modified. The value is determined as epoch time
        /// in milliseconds. For example, the value for Monday, November 1, 2021 12:00:00 PM UTC
        /// is specified as 1635768000000.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTimestamp
        {
            get { return this._lastModifiedTimestamp; }
            set { this._lastModifiedTimestamp = value; }
        }

        // Check to see if LastModifiedTimestamp property is set
        internal bool IsSetLastModifiedTimestamp()
        {
            return this._lastModifiedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumBytes. 
        /// <para>
        /// The total number of bytes in the database.
        /// </para>
        /// </summary>
        public long? NumBytes
        {
            get { return this._numBytes; }
            set { this._numBytes = value; }
        }

        // Check to see if NumBytes property is set
        internal bool IsSetNumBytes()
        {
            return this._numBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumChangesets. 
        /// <para>
        /// The total number of changesets in the database.
        /// </para>
        /// </summary>
        public int? NumChangesets
        {
            get { return this._numChangesets; }
            set { this._numChangesets = value; }
        }

        // Check to see if NumChangesets property is set
        internal bool IsSetNumChangesets()
        {
            return this._numChangesets.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumFiles. 
        /// <para>
        /// The total number of files in the database.
        /// </para>
        /// </summary>
        public int? NumFiles
        {
            get { return this._numFiles; }
            set { this._numFiles = value; }
        }

        // Check to see if NumFiles property is set
        internal bool IsSetNumFiles()
        {
            return this._numFiles.HasValue; 
        }

    }
}