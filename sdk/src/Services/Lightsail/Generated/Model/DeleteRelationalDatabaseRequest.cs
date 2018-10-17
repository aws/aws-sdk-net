/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteRelationalDatabase operation.
    /// Deletes a database in Amazon Lightsail.
    /// </summary>
    public partial class DeleteRelationalDatabaseRequest : AmazonLightsailRequest
    {
        private string _finalRelationalDatabaseSnapshotName;
        private string _relationalDatabaseName;
        private bool? _skipFinalSnapshot;

        /// <summary>
        /// Gets and sets the property FinalRelationalDatabaseSnapshotName. 
        /// <para>
        /// The name of the database snapshot created if <code>skip final snapshot</code> is <code>false</code>,
        /// which is the default value for that parameter.
        /// </para>
        ///  <note> 
        /// <para>
        /// Specifying this parameter and also specifying the <code>skip final snapshot</code>
        /// parameter to <code>true</code> results in an error.
        /// </para>
        ///  </note> 
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
        public string FinalRelationalDatabaseSnapshotName
        {
            get { return this._finalRelationalDatabaseSnapshotName; }
            set { this._finalRelationalDatabaseSnapshotName = value; }
        }

        // Check to see if FinalRelationalDatabaseSnapshotName property is set
        internal bool IsSetFinalRelationalDatabaseSnapshotName()
        {
            return this._finalRelationalDatabaseSnapshotName != null;
        }

        /// <summary>
        /// Gets and sets the property RelationalDatabaseName. 
        /// <para>
        /// The name of the database that you are deleting.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property SkipFinalSnapshot. 
        /// <para>
        /// Determines whether a final database snapshot is created before your database is deleted.
        /// If <code>true</code> is specified, no database snapshot is created. If <code>false</code>
        /// is specified, a database snapshot is created before your database is deleted.
        /// </para>
        ///  
        /// <para>
        /// You must specify the <code>final relational database snapshot name</code> parameter
        /// if the <code>skip final snapshot</code> parameter is <code>false</code>.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>false</code> 
        /// </para>
        /// </summary>
        public bool SkipFinalSnapshot
        {
            get { return this._skipFinalSnapshot.GetValueOrDefault(); }
            set { this._skipFinalSnapshot = value; }
        }

        // Check to see if SkipFinalSnapshot property is set
        internal bool IsSetSkipFinalSnapshot()
        {
            return this._skipFinalSnapshot.HasValue; 
        }

    }
}