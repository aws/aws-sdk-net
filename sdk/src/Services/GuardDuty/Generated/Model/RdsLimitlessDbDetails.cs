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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the resource type <c>RDSLimitlessDB</c> that is involved
    /// in a GuardDuty finding.
    /// </summary>
    public partial class RdsLimitlessDbDetails
    {
        private string _dbClusterIdentifier;
        private string _dbShardGroupArn;
        private string _dbShardGroupIdentifier;
        private string _dbShardGroupResourceId;
        private string _engine;
        private string _engineVersion;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property DbClusterIdentifier. 
        /// <para>
        /// The name of the database cluster that is a part of the Limitless Database.
        /// </para>
        /// </summary>
        public string DbClusterIdentifier
        {
            get { return this._dbClusterIdentifier; }
            set { this._dbClusterIdentifier = value; }
        }

        // Check to see if DbClusterIdentifier property is set
        internal bool IsSetDbClusterIdentifier()
        {
            return this._dbClusterIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DbShardGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the DB shard group.
        /// </para>
        /// </summary>
        public string DbShardGroupArn
        {
            get { return this._dbShardGroupArn; }
            set { this._dbShardGroupArn = value; }
        }

        // Check to see if DbShardGroupArn property is set
        internal bool IsSetDbShardGroupArn()
        {
            return this._dbShardGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property DbShardGroupIdentifier. 
        /// <para>
        /// The name associated with the Limitless DB shard group.
        /// </para>
        /// </summary>
        public string DbShardGroupIdentifier
        {
            get { return this._dbShardGroupIdentifier; }
            set { this._dbShardGroupIdentifier = value; }
        }

        // Check to see if DbShardGroupIdentifier property is set
        internal bool IsSetDbShardGroupIdentifier()
        {
            return this._dbShardGroupIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property DbShardGroupResourceId. 
        /// <para>
        /// The resource identifier of the DB shard group within the Limitless Database.
        /// </para>
        /// </summary>
        public string DbShardGroupResourceId
        {
            get { return this._dbShardGroupResourceId; }
            set { this._dbShardGroupResourceId = value; }
        }

        // Check to see if DbShardGroupResourceId property is set
        internal bool IsSetDbShardGroupResourceId()
        {
            return this._dbShardGroupResourceId != null;
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The database engine of the database instance involved in the finding.
        /// </para>
        /// </summary>
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version of the database engine.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Information about the tag key-value pair.
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

    }
}