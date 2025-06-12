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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRelationalDatabaseFromSnapshot operation.
    /// Creates a new database from an existing database snapshot in Amazon Lightsail.
    /// 
    ///  
    /// <para>
    /// You can create a new database from a snapshot in if something goes wrong with your
    /// original database, or to change it to a different plan, such as a high availability
    /// or standard plan.
    /// </para>
    ///  
    /// <para>
    /// The <c>create relational database from snapshot</c> operation supports tag-based access
    /// control via request tags and resource tags applied to the resource identified by relationalDatabaseSnapshotName.
    /// For more information, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-controlling-access-using-tags">Amazon
    /// Lightsail Developer Guide</a>.
    /// </para>
    /// </summary>
    public partial class CreateRelationalDatabaseFromSnapshotRequest : AmazonLightsailRequest
    {
        private string _availabilityZone;
        private bool? _publiclyAccessible;
        private string _relationalDatabaseBundleId;
        private string _relationalDatabaseName;
        private string _relationalDatabaseSnapshotName;
        private DateTime? _restoreTime;
        private string _sourceRelationalDatabaseName;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private bool? _useLatestRestorableTime;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone in which to create your new database. Use the <c>us-east-2a</c>
        /// case-sensitive format.
        /// </para>
        ///  
        /// <para>
        /// You can get a list of Availability Zones by using the <c>get regions</c> operation.
        /// Be sure to add the <c>include relational database Availability Zones</c> parameter
        /// to your request.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Specifies the accessibility options for your new database. A value of <c>true</c>
        /// specifies a database that is available to resources outside of your Lightsail account.
        /// A value of <c>false</c> specifies a database that is available only to your Lightsail
        /// resources in the same region as your database.
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible
        {
            get { return this._publiclyAccessible; }
            set { this._publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this._publiclyAccessible.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RelationalDatabaseBundleId. 
        /// <para>
        /// The bundle ID for your new database. A bundle describes the performance specifications
        /// for your database.
        /// </para>
        ///  
        /// <para>
        /// You can get a list of database bundle IDs by using the <c>get relational database
        /// bundles</c> operation.
        /// </para>
        ///  
        /// <para>
        /// When creating a new database from a snapshot, you cannot choose a bundle that is smaller
        /// than the bundle of the source database.
        /// </para>
        /// </summary>
        public string RelationalDatabaseBundleId
        {
            get { return this._relationalDatabaseBundleId; }
            set { this._relationalDatabaseBundleId = value; }
        }

        // Check to see if RelationalDatabaseBundleId property is set
        internal bool IsSetRelationalDatabaseBundleId()
        {
            return this._relationalDatabaseBundleId != null;
        }

        /// <summary>
        /// Gets and sets the property RelationalDatabaseName. 
        /// <para>
        /// The name to use for your new Lightsail database resource.
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
        /// The name of the database snapshot from which to create your new database.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property RestoreTime. 
        /// <para>
        /// The date and time to restore your database from.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Must be before the latest restorable time for the database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cannot be specified if the <c>use latest restorable time</c> parameter is <c>true</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specified in Coordinated Universal Time (UTC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specified in the Unix time format.
        /// </para>
        ///  
        /// <para>
        /// For example, if you wish to use a restore time of October 1, 2018, at 8 PM UTC, then
        /// you input <c>1538424000</c> as the restore time.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DateTime? RestoreTime
        {
            get { return this._restoreTime; }
            set { this._restoreTime = value; }
        }

        // Check to see if RestoreTime property is set
        internal bool IsSetRestoreTime()
        {
            return this._restoreTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceRelationalDatabaseName. 
        /// <para>
        /// The name of the source database.
        /// </para>
        /// </summary>
        public string SourceRelationalDatabaseName
        {
            get { return this._sourceRelationalDatabaseName; }
            set { this._sourceRelationalDatabaseName = value; }
        }

        // Check to see if SourceRelationalDatabaseName property is set
        internal bool IsSetSourceRelationalDatabaseName()
        {
            return this._sourceRelationalDatabaseName != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values to add to the resource during create.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>TagResource</c> action to tag a resource after it's created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UseLatestRestorableTime. 
        /// <para>
        /// Specifies whether your database is restored from the latest backup time. A value of
        /// <c>true</c> restores from the latest backup time. 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>false</c> 
        /// </para>
        ///  
        /// <para>
        /// Constraints: Cannot be specified if the <c>restore time</c> parameter is provided.
        /// </para>
        /// </summary>
        public bool? UseLatestRestorableTime
        {
            get { return this._useLatestRestorableTime; }
            set { this._useLatestRestorableTime = value; }
        }

        // Check to see if UseLatestRestorableTime property is set
        internal bool IsSetUseLatestRestorableTime()
        {
            return this._useLatestRestorableTime.HasValue; 
        }

    }
}