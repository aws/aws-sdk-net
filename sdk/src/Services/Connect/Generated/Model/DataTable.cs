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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Represents a data table in Amazon Connect. A data table is a JSON-like data structure
    /// where attributes and values are dynamically set by customers. Customers can reference
    /// table values within call flows, applications, views, and workspaces to pinpoint dynamic
    /// configuration that changes their contact center's behavior in a predetermined and
    /// safe way.
    /// </summary>
    public partial class DataTable
    {
        private string _arn;
        private DateTime? _createdTime;
        private string _description;
        private string _id;
        private string _lastModifiedRegion;
        private DateTime? _lastModifiedTime;
        private DataTableLockVersion _lockVersion;
        private string _name;
        private DataTableStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _timeZone;
        private DataTableLockLevel _valueLockLevel;
        private string _version;
        private string _versionDescription;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the data table. Does not include version aliases.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp when the data table was created.
        /// </para>
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description of the data table's purpose and contents.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=250)]
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
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the data table. Does not include version aliases.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedRegion. 
        /// <para>
        /// The AWS region where the data table was last modified, used for region replication.
        /// </para>
        /// </summary>
        public string LastModifiedRegion
        {
            get { return this._lastModifiedRegion; }
            set { this._lastModifiedRegion = value; }
        }

        // Check to see if LastModifiedRegion property is set
        internal bool IsSetLastModifiedRegion()
        {
            return this._lastModifiedRegion != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The timestamp when the data table or any of its properties were last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LockVersion. 
        /// <para>
        /// The lock version information used for optimistic locking and table versioning. Changes
        /// with each update to prevent concurrent modification conflicts.
        /// </para>
        /// </summary>
        public DataTableLockVersion LockVersion
        {
            get { return this._lockVersion; }
            set { this._lockVersion = value; }
        }

        // Check to see if LockVersion property is set
        internal bool IsSetLockVersion()
        {
            return this._lockVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The human-readable name of the data table. Must be unique within the instance and
        /// conform to Connect naming standards.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the data table. One of PUBLISHED or SAVED.
        /// </para>
        /// </summary>
        public DataTableStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Key-value pairs for attribute based access control (TBAC or ABAC) and organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
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
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// The IANA timezone identifier used when resolving time based dynamic values. Required
        /// even if no time slices are specified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TimeZone
        {
            get { return this._timeZone; }
            set { this._timeZone = value; }
        }

        // Check to see if TimeZone property is set
        internal bool IsSetTimeZone()
        {
            return this._timeZone != null;
        }

        /// <summary>
        /// Gets and sets the property ValueLockLevel. 
        /// <para>
        /// The data level that concurrent value edits are locked on. One of DATA_TABLE, PRIMARY_VALUE,
        /// ATTRIBUTE, VALUE, and NONE. Determines how concurrent edits are handled when multiple
        /// users attempt to modify values simultaneously.
        /// </para>
        /// </summary>
        public DataTableLockLevel ValueLockLevel
        {
            get { return this._valueLockLevel; }
            set { this._valueLockLevel = value; }
        }

        // Check to see if ValueLockLevel property is set
        internal bool IsSetValueLockLevel()
        {
            return this._valueLockLevel != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// A unique identifier and alias for customer managed versions (not $LATEST or $SAVED).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version != null;
        }

        /// <summary>
        /// Gets and sets the property VersionDescription. 
        /// <para>
        /// A description of the customer managed version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=250)]
        public string VersionDescription
        {
            get { return this._versionDescription; }
            set { this._versionDescription = value; }
        }

        // Check to see if VersionDescription property is set
        internal bool IsSetVersionDescription()
        {
            return this._versionDescription != null;
        }

    }
}