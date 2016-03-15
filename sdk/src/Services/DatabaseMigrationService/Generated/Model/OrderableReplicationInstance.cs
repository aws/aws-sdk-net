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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class OrderableReplicationInstance
    {
        private int? _defaultAllocatedStorage;
        private string _engineVersion;
        private int? _includedAllocatedStorage;
        private int? _maxAllocatedStorage;
        private int? _minAllocatedStorage;
        private string _replicationInstanceClass;
        private string _storageType;

        /// <summary>
        /// Gets and sets the property DefaultAllocatedStorage. 
        /// <para>
        ///  The default amount of storage (in gigabytes) that is allocated for the replication
        /// instance. 
        /// </para>
        /// </summary>
        public int DefaultAllocatedStorage
        {
            get { return this._defaultAllocatedStorage.GetValueOrDefault(); }
            set { this._defaultAllocatedStorage = value; }
        }

        // Check to see if DefaultAllocatedStorage property is set
        internal bool IsSetDefaultAllocatedStorage()
        {
            return this._defaultAllocatedStorage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version of the replication engine.
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property IncludedAllocatedStorage. 
        /// <para>
        ///  The amount of storage (in gigabytes) that is allocated for the replication instance.
        /// 
        /// </para>
        /// </summary>
        public int IncludedAllocatedStorage
        {
            get { return this._includedAllocatedStorage.GetValueOrDefault(); }
            set { this._includedAllocatedStorage = value; }
        }

        // Check to see if IncludedAllocatedStorage property is set
        internal bool IsSetIncludedAllocatedStorage()
        {
            return this._includedAllocatedStorage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxAllocatedStorage. 
        /// <para>
        ///  The minimum amount of storage (in gigabytes) that can be allocated for the replication
        /// instance. 
        /// </para>
        /// </summary>
        public int MaxAllocatedStorage
        {
            get { return this._maxAllocatedStorage.GetValueOrDefault(); }
            set { this._maxAllocatedStorage = value; }
        }

        // Check to see if MaxAllocatedStorage property is set
        internal bool IsSetMaxAllocatedStorage()
        {
            return this._maxAllocatedStorage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinAllocatedStorage. 
        /// <para>
        ///  The minimum amount of storage (in gigabytes) that can be allocated for the replication
        /// instance. 
        /// </para>
        /// </summary>
        public int MinAllocatedStorage
        {
            get { return this._minAllocatedStorage.GetValueOrDefault(); }
            set { this._minAllocatedStorage = value; }
        }

        // Check to see if MinAllocatedStorage property is set
        internal bool IsSetMinAllocatedStorage()
        {
            return this._minAllocatedStorage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationInstanceClass. 
        /// <para>
        ///  The compute and memory capacity of the replication instance. 
        /// </para>
        ///  
        /// <para>
        ///  Valid Values: <code>dms.t2.micro | dms.t2.small | dms.t2.medium | dms.t2.large |
        /// dms.c4.large | dms.c4.xlarge | dms.c4.2xlarge | dms.c4.4xlarge </code>
        /// </para>
        /// </summary>
        public string ReplicationInstanceClass
        {
            get { return this._replicationInstanceClass; }
            set { this._replicationInstanceClass = value; }
        }

        // Check to see if ReplicationInstanceClass property is set
        internal bool IsSetReplicationInstanceClass()
        {
            return this._replicationInstanceClass != null;
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The type of storage used by the replication instance.
        /// </para>
        /// </summary>
        public string StorageType
        {
            get { return this._storageType; }
            set { this._storageType = value; }
        }

        // Check to see if StorageType property is set
        internal bool IsSetStorageType()
        {
            return this._storageType != null;
        }

    }
}