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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the resource type <code>RDSDBInstance</code> involved in
    /// a GuardDuty finding.
    /// </summary>
    public partial class RdsDbInstanceDetails
    {
        private string _dbClusterIdentifier;
        private string _dbInstanceArn;
        private string _dbInstanceIdentifier;
        private string _engine;
        private string _engineVersion;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property DbClusterIdentifier. 
        /// <para>
        /// The identifier of the database cluster that contains the database instance ID involved
        /// in the finding.
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
        /// Gets and sets the property DbInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the database instance involved in the
        /// finding.
        /// </para>
        /// </summary>
        public string DbInstanceArn
        {
            get { return this._dbInstanceArn; }
            set { this._dbInstanceArn = value; }
        }

        // Check to see if DbInstanceArn property is set
        internal bool IsSetDbInstanceArn()
        {
            return this._dbInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property DbInstanceIdentifier. 
        /// <para>
        /// The identifier associated to the database instance that was involved in the finding.
        /// </para>
        /// </summary>
        public string DbInstanceIdentifier
        {
            get { return this._dbInstanceIdentifier; }
            set { this._dbInstanceIdentifier = value; }
        }

        // Check to see if DbInstanceIdentifier property is set
        internal bool IsSetDbInstanceIdentifier()
        {
            return this._dbInstanceIdentifier != null;
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
        /// The version of the database engine that was involved in the finding.
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
        /// Instance tag key-value pairs associated with the database instance ID.
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