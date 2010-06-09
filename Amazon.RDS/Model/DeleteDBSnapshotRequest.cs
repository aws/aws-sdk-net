/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-10-16
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Deletes a DB Snapshot.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/admin/2009-10-16/", IsNullable = false)]
    public class DeleteDBSnapshotRequest
    {
        private string DBSnapshotIdentifierField;

        /// <summary>
        /// Gets and sets the DBSnapshotIdentifier property.
        /// DBSnapshot identifier. Must be the name of an existing DB Snapshot in the available state.
        /// </summary>
        [XmlElementAttribute(ElementName = "DBSnapshotIdentifier")]
        public string DBSnapshotIdentifier
        {
            get { return this.DBSnapshotIdentifierField ; }
            set { this.DBSnapshotIdentifierField= value; }
        }

        /// <summary>
        /// Sets the DBSnapshotIdentifier property
        /// </summary>
        /// <param name="DBSnapshotIdentifier">DBSnapshot identifier. Must be the name of an existing DB Snapshot in the available state.</param>
        /// <returns>this instance</returns>
        public DeleteDBSnapshotRequest WithDBSnapshotIdentifier(string DBSnapshotIdentifier)
        {
            this.DBSnapshotIdentifierField = DBSnapshotIdentifier;
            return this;
        }

        /// <summary>
        /// Checks if DBSnapshotIdentifier property is set
        /// </summary>
        /// <returns>true if DBSnapshotIdentifier property is set</returns>
        public bool IsSetDBSnapshotIdentifier()
        {
            return  this.DBSnapshotIdentifierField != null;
        }

    }
}
