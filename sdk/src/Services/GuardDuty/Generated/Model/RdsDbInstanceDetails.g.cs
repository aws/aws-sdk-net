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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Contains information about the resource type <c>RDSDBInstance</c> involved in a GuardDuty
    /// finding.
    /// </summary>
    public partial class RdsDbInstanceDetails
    {
        /// <summary>
        /// Gets and sets the property DbClusterIdentifier. 
        /// <para>
        /// The identifier of the database cluster that contains the database instance ID involved
        /// in the finding.
        /// </para>
        /// </summary>
        public string DbClusterIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DbClusterIdentifier property is set.
        /// </summary>
        internal bool IsSetDbClusterIdentifier() => this.DbClusterIdentifier != null;

        /// <summary>
        /// Gets and sets the property DbInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that identifies the database instance involved in the
        /// finding.
        /// </para>
        /// </summary>
        public string DbInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the DbInstanceArn property is set.
        /// </summary>
        internal bool IsSetDbInstanceArn() => this.DbInstanceArn != null;

        /// <summary>
        /// Gets and sets the property DbInstanceIdentifier. 
        /// <para>
        /// The identifier associated to the database instance that was involved in the finding.
        /// </para>
        /// </summary>
        public string DbInstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DbInstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetDbInstanceIdentifier() => this.DbInstanceIdentifier != null;

        /// <summary>
        /// Gets and sets the property DbiResourceId. 
        /// <para>
        /// The unique ID of the database resource involved in the activity that prompted GuardDuty
        /// to generate the finding.
        /// </para>
        /// </summary>
        public string DbiResourceId { get; set; }

        /// <summary>
        /// Checks to see if the DbiResourceId property is set.
        /// </summary>
        internal bool IsSetDbiResourceId() => this.DbiResourceId != null;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The database engine of the database instance involved in the finding.
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version of the database engine that was involved in the finding.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Information about the tag key-value pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
