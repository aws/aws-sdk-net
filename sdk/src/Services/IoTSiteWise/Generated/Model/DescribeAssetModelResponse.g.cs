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
    /// This is the response object from the DescribeAssetModel operation.
    /// </summary>
    public partial class DescribeAssetModelResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AssetModelArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the asset model, which has the following format.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:${Partition}:iotsitewise:${Region}:${Account}:asset-model/${AssetModelId}</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string AssetModelArn { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelArn property is set.
        /// </summary>
        internal bool IsSetAssetModelArn() => this.AssetModelArn != null;

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModelSummaries. 
        /// <para>
        /// The list of the immediate child custom composite model summaries for the asset model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetModelCompositeModelSummary> AssetModelCompositeModelSummaries { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetModelCompositeModelSummary>() : null;

        /// <summary>
        /// Checks to see if the AssetModelCompositeModelSummaries property is set.
        /// </summary>
        internal bool IsSetAssetModelCompositeModelSummaries() => this.AssetModelCompositeModelSummaries != null && (this.AssetModelCompositeModelSummaries.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModels. 
        /// <para>
        /// The list of built-in composite models for the asset model, such as those with those
        /// of type <c>AWS/ALARMS</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AssetModelCompositeModel> AssetModelCompositeModels { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetModelCompositeModel>() : null;

        /// <summary>
        /// Checks to see if the AssetModelCompositeModels property is set.
        /// </summary>
        internal bool IsSetAssetModelCompositeModels() => this.AssetModelCompositeModels != null && (this.AssetModelCompositeModels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssetModelCreationDate. 
        /// <para>
        /// The date the asset model was created, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? AssetModelCreationDate { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelCreationDate property is set.
        /// </summary>
        internal bool IsSetAssetModelCreationDate() => this.AssetModelCreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property AssetModelDescription. 
        /// <para>
        /// The asset model's description.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string AssetModelDescription { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelDescription property is set.
        /// </summary>
        internal bool IsSetAssetModelDescription() => this.AssetModelDescription != null;

        /// <summary>
        /// Gets and sets the property AssetModelExternalId. 
        /// <para>
        /// The external ID of the asset model, if any.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 128)]
        public string AssetModelExternalId { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelExternalId property is set.
        /// </summary>
        internal bool IsSetAssetModelExternalId() => this.AssetModelExternalId != null;

        /// <summary>
        /// Gets and sets the property AssetModelHierarchies. 
        /// <para>
        /// A list of asset model hierarchies that each contain a <c>childAssetModelId</c> and
        /// a <c>hierarchyId</c> (named <c>id</c>). A hierarchy specifies allowed parent/child
        /// asset relationships for an asset model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AssetModelHierarchy> AssetModelHierarchies { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetModelHierarchy>() : null;

        /// <summary>
        /// Checks to see if the AssetModelHierarchies property is set.
        /// </summary>
        internal bool IsSetAssetModelHierarchies() => this.AssetModelHierarchies != null && (this.AssetModelHierarchies.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssetModelId. 
        /// <para>
        /// The ID of the asset model, in UUID format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string AssetModelId { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelId property is set.
        /// </summary>
        internal bool IsSetAssetModelId() => this.AssetModelId != null;

        /// <summary>
        /// Gets and sets the property AssetModelLastUpdateDate. 
        /// <para>
        /// The date the asset model was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? AssetModelLastUpdateDate { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelLastUpdateDate property is set.
        /// </summary>
        internal bool IsSetAssetModelLastUpdateDate() => this.AssetModelLastUpdateDate.HasValue;

        /// <summary>
        /// Gets and sets the property AssetModelName. 
        /// <para>
        /// The name of the asset model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string AssetModelName { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelName property is set.
        /// </summary>
        internal bool IsSetAssetModelName() => this.AssetModelName != null;

        /// <summary>
        /// Gets and sets the property AssetModelProperties. 
        /// <para>
        /// The list of asset properties for the asset model.
        /// </para>
        ///  
        /// <para>
        /// This object doesn't include properties that you define in composite models. You can
        /// find composite model properties in the <c>assetModelCompositeModels</c> object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<AssetModelProperty> AssetModelProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<AssetModelProperty>() : null;

        /// <summary>
        /// Checks to see if the AssetModelProperties property is set.
        /// </summary>
        internal bool IsSetAssetModelProperties() => this.AssetModelProperties != null && (this.AssetModelProperties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AssetModelStatus. 
        /// <para>
        /// The current status of the asset model, which contains a state and any error message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AssetModelStatus AssetModelStatus { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelStatus property is set.
        /// </summary>
        internal bool IsSetAssetModelStatus() => this.AssetModelStatus != null;

        /// <summary>
        /// Gets and sets the property AssetModelType. 
        /// <para>
        /// The type of asset model.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ASSET_MODEL</b> – (default) An asset model that you can use to create assets.
        /// Can't be included as a component in another asset model.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>COMPONENT_MODEL</b> – A reusable component that you can include in the composite
        /// models of other asset models. You can't create assets directly from this type of asset
        /// model. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public AssetModelType AssetModelType { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelType property is set.
        /// </summary>
        internal bool IsSetAssetModelType() => this.AssetModelType != null;

        /// <summary>
        /// Gets and sets the property AssetModelVersion. 
        /// <para>
        /// The version of the asset model. See <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/model-active-version.html">
        /// Asset model versions</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public string AssetModelVersion { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelVersion property is set.
        /// </summary>
        internal bool IsSetAssetModelVersion() => this.AssetModelVersion != null;

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// The entity tag (ETag) is a hash of the retrieved version of the asset model. It's
        /// used to make concurrent updates safely to the resource. See <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/opt-locking-for-model.html">Optimistic
        /// locking for asset model writes</a> in the <i>IoT SiteWise User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// See <a href="https://docs.aws.amazon.com/iot-sitewise/latest/userguide/opt-locking-for-model.html">
        /// Optimistic locking for asset model writes</a> in the <i>IoT SiteWise User Guide</i>.
        /// </para>
        /// </summary>
        public string ETag { get; set; }

        /// <summary>
        /// Checks to see if the ETag property is set.
        /// </summary>
        internal bool IsSetETag() => this.ETag != null;

        /// <summary>
        /// Gets and sets the property InterfaceDetails. 
        /// <para>
        /// A list of interface details that describe the interfaces implemented by this asset
        /// model, including interface asset model IDs and property mappings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InterfaceRelationship> InterfaceDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<InterfaceRelationship>() : null;

        /// <summary>
        /// Checks to see if the InterfaceDetails property is set.
        /// </summary>
        internal bool IsSetInterfaceDetails() => this.InterfaceDetails != null && (this.InterfaceDetails.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
