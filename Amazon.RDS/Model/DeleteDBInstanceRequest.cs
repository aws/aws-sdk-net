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
 *  API Version: 2010-01-01
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Deletes a DB Instance. Once started, the process cannot be stopped, and the DB Instance will no longer be accessible.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/doc/2010-01-01/", IsNullable = false)]
    public class DeleteDBInstanceRequest
    {
        private string DBInstanceIdentifierField;
        private bool? skipFinalSnapshotField;
        private string finalDBSnapshotIdentifierField;

        /// <summary>
        /// Gets and sets the DBInstanceIdentifier property.
        /// DB Instance identifier for the DB Instance to be deleted. The input isn't case sensitive.
        /// </summary>
        [XmlElementAttribute(ElementName = "DBInstanceIdentifier")]
        public string DBInstanceIdentifier
        {
            get { return this.DBInstanceIdentifierField; }
            set { this.DBInstanceIdentifierField = value; }
        }

        /// <summary>
        /// Sets the DBInstanceIdentifier property
        /// </summary>
        /// <param name="DBInstanceIdentifier">DB Instance identifier for the DB Instance to be deleted. The input isn't case sensitive.</param>
        /// <returns>this instance</returns>
        public DeleteDBInstanceRequest WithDBInstanceIdentifier(string DBInstanceIdentifier)
        {
            this.DBInstanceIdentifierField = DBInstanceIdentifier;
            return this;
        }

        /// <summary>
        /// Checks if DBInstanceIdentifier property is set
        /// </summary>
        /// <returns>true if DBInstanceIdentifier property is set</returns>
        public bool IsSetDBInstanceIdentifier()
        {
            return this.DBInstanceIdentifierField != null;
        }

        /// <summary>
        /// Gets and sets the SkipFinalSnapshot property.
        /// Determines whether a final DB Snapshot is created before the DB Instance is deleted. If true is specified no
        /// DBSnapshot is created. If false is specified a DB Snapshot is created before the DB Instance is deleted.
        /// </summary>
        [XmlElementAttribute(ElementName = "SkipFinalSnapshot")]
        public bool SkipFinalSnapshot
        {
            get { return this.skipFinalSnapshotField.GetValueOrDefault(); }
            set { this.skipFinalSnapshotField = value; }
        }

        /// <summary>
        /// Sets the SkipFinalSnapshot property
        /// </summary>
        /// <param name="skipFinalSnapshot">Determines whether a final DB Snapshot is created before the DB Instance is deleted. If true is specified no
        /// DBSnapshot is created. If false is specified a DB Snapshot is created before the DB Instance is deleted.</param>
        /// <returns>this instance</returns>
        public DeleteDBInstanceRequest WithSkipFinalSnapshot(bool skipFinalSnapshot)
        {
            this.skipFinalSnapshotField = skipFinalSnapshot;
            return this;
        }

        /// <summary>
        /// Checks if SkipFinalSnapshot property is set
        /// </summary>
        /// <returns>true if SkipFinalSnapshot property is set</returns>
        public bool IsSetSkipFinalSnapshot()
        {
            return this.skipFinalSnapshotField.HasValue;
        }

        /// <summary>
        /// Gets and sets the FinalDBSnapshotIdentifier property.
        /// The DBSnapshotIdentifier of the new DB Snapshot created when SkipFinalSnapshot is set to false.
        /// </summary>
        [XmlElementAttribute(ElementName = "FinalDBSnapshotIdentifier")]
        public string FinalDBSnapshotIdentifier
        {
            get { return this.finalDBSnapshotIdentifierField; }
            set { this.finalDBSnapshotIdentifierField = value; }
        }

        /// <summary>
        /// Sets the FinalDBSnapshotIdentifier property
        /// </summary>
        /// <param name="finalDBSnapshotIdentifier">The DBSnapshotIdentifier of the new DB Snapshot created when SkipFinalSnapshot is set to false.</param>
        /// <returns>this instance</returns>
        public DeleteDBInstanceRequest WithFinalDBSnapshotIdentifier(string finalDBSnapshotIdentifier)
        {
            this.finalDBSnapshotIdentifierField = finalDBSnapshotIdentifier;
            return this;
        }

        /// <summary>
        /// Checks if FinalDBSnapshotIdentifier property is set
        /// </summary>
        /// <returns>true if FinalDBSnapshotIdentifier property is set</returns>
        public bool IsSetFinalDBSnapshotIdentifier()
        {
            return this.finalDBSnapshotIdentifierField != null;
        }

    }
}
