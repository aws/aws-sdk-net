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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRelationalDatabaseSnapshot operation.
    /// Creates a snapshot of your database in Amazon Lightsail. You can use snapshots for
    /// backups, to make copies of a database, and to save data before deleting a database.
    /// 
    ///  
    /// <para>
    /// The <code>create relational database snapshot</code> operation supports tag-based
    /// access control via request tags. For more information, see the <a href="https://lightsail.aws.amazon.com/ls/docs/en/articles/amazon-lightsail-controlling-access-using-tags">Lightsail
    /// Dev Guide</a>.
    /// </para>
    /// </summary>
    public partial class CreateRelationalDatabaseSnapshotRequest : AmazonLightsailRequest
    {
        private string _relationalDatabaseName;
        private string _relationalDatabaseSnapshotName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property RelationalDatabaseName. 
        /// <para>
        /// The name of the database on which to base your new snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RelationalDatabaseName
        {
            get { return this._relationalDatabaseName; }
            set { this._relationalDatabaseName = value; }
        }

        // Check to see if RelationalDatabaseName property is set
        internal bool IsSetRelationalDatabaseName()
        {
            return this._relationalDatabaseName != null;
        }

        /// <summary>
        /// Gets and sets the property RelationalDatabaseSnapshotName. 
        /// <para>
        /// The name for your new database snapshot.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must contain from 2 to 255 alphanumeric characters, or hyphens.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The first and last character must be a letter or number.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RelationalDatabaseSnapshotName
        {
            get { return this._relationalDatabaseSnapshotName; }
            set { this._relationalDatabaseSnapshotName = value; }
        }

        // Check to see if RelationalDatabaseSnapshotName property is set
        internal bool IsSetRelationalDatabaseSnapshotName()
        {
            return this._relationalDatabaseSnapshotName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values to add to the resource during create.
        /// </para>
        ///  
        /// <para>
        /// Use the <code>TagResource</code> action to tag a resource after it's created.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}