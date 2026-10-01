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

namespace Amazon.SSMIncidents.Model
{
    /// <summary>
    /// The set of Amazon Web Services Region that your Incident Manager data will be replicated
    /// to and the KMS key used to encrypt the data.
    /// </summary>
    public partial class ReplicationSet
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the replication set.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1000)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Details about who created the replication set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1000)]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// When the replication set was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeletionProtected. 
        /// <para>
        /// Determines if the replication set deletion protection is enabled or not. If deletion
        /// protection is enabled, you can't delete the last Amazon Web Services Region in the
        /// replication set. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? DeletionProtected { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtected property is set.
        /// </summary>
        internal bool IsSetDeletionProtected() => this.DeletionProtected.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedBy. 
        /// <para>
        /// Who last modified the replication set.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1000)]
        public string LastModifiedBy { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedBy property is set.
        /// </summary>
        internal bool IsSetLastModifiedBy() => this.LastModifiedBy != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// When the replication set was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property RegionMap. 
        /// <para>
        /// The map between each Amazon Web Services Region in your replication set and the KMS
        /// key that's used to encrypt the data in that Region.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public Dictionary<string, RegionInfo> RegionMap { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, RegionInfo>() : null;

        /// <summary>
        /// Checks to see if the RegionMap property is set.
        /// </summary>
        internal bool IsSetRegionMap() => this.RegionMap != null && (this.RegionMap.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the replication set. If the replication set is still pending, you can't
        /// use Incident Manager functionality.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReplicationSetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
