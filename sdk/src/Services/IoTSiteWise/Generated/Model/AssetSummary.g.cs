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

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains a summary of an asset.
    /// </summary>
    public partial class AssetSummary
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the asset, which has the following format.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:${Partition}:iotsitewise:${Region}:${Account}:asset/${AssetId}</c> 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property AssetModelId. 
        /// <para>
        /// The ID of the asset model used to create this asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string AssetModelId { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelId property is set.
        /// </summary>
        internal bool IsSetAssetModelId() => this.AssetModelId != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date the asset was created, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The external ID of the asset. For more information, see <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/object-ids.html#external-ids">Using
        /// external IDs</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 128)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Checks to see if the ExternalId property is set.
        /// </summary>
        internal bool IsSetExternalId() => this.ExternalId != null;

        /// <summary>
        /// Gets and sets the property Hierarchies. 
        /// <para>
        /// A list of asset hierarchies that each contain a <c>hierarchyId</c>. A hierarchy specifies
        /// allowed parent/child asset relationships.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AssetHierarchy> Hierarchies { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetHierarchy>() : null;

        /// <summary>
        /// Checks to see if the Hierarchies property is set.
        /// </summary>
        internal bool IsSetHierarchies() => this.Hierarchies != null && (this.Hierarchies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the asset, in UUID format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property LastUpdateDate. 
        /// <para>
        /// The date the asset was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastUpdateDate { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateDate property is set.
        /// </summary>
        internal bool IsSetLastUpdateDate() => this.LastUpdateDate.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AssetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
