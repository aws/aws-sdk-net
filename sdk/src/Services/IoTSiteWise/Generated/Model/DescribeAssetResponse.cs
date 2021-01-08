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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the DescribeAsset operation.
    /// </summary>
    public partial class DescribeAssetResponse : AmazonWebServiceResponse
    {
        private string _assetArn;
        private List<AssetCompositeModel> _assetCompositeModels = new List<AssetCompositeModel>();
        private DateTime? _assetCreationDate;
        private List<AssetHierarchy> _assetHierarchies = new List<AssetHierarchy>();
        private string _assetId;
        private DateTime? _assetLastUpdateDate;
        private string _assetModelId;
        private string _assetName;
        private List<AssetProperty> _assetProperties = new List<AssetProperty>();
        private AssetStatus _assetStatus;

        /// <summary>
        /// Gets and sets the property AssetArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the asset, which has the following format.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:${Partition}:iotsitewise:${Region}:${Account}:asset/${AssetId}</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string AssetArn
        {
            get { return this._assetArn; }
            set { this._assetArn = value; }
        }

        // Check to see if AssetArn property is set
        internal bool IsSetAssetArn()
        {
            return this._assetArn != null;
        }

        /// <summary>
        /// Gets and sets the property AssetCompositeModels. 
        /// <para>
        /// The composite models for the asset.
        /// </para>
        /// </summary>
        public List<AssetCompositeModel> AssetCompositeModels
        {
            get { return this._assetCompositeModels; }
            set { this._assetCompositeModels = value; }
        }

        // Check to see if AssetCompositeModels property is set
        internal bool IsSetAssetCompositeModels()
        {
            return this._assetCompositeModels != null && this._assetCompositeModels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AssetCreationDate. 
        /// <para>
        /// The date the asset was created, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime AssetCreationDate
        {
            get { return this._assetCreationDate.GetValueOrDefault(); }
            set { this._assetCreationDate = value; }
        }

        // Check to see if AssetCreationDate property is set
        internal bool IsSetAssetCreationDate()
        {
            return this._assetCreationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AssetHierarchies. 
        /// <para>
        /// A list of asset hierarchies that each contain a <code>hierarchyId</code>. A hierarchy
        /// specifies allowed parent/child asset relationships.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AssetHierarchy> AssetHierarchies
        {
            get { return this._assetHierarchies; }
            set { this._assetHierarchies = value; }
        }

        // Check to see if AssetHierarchies property is set
        internal bool IsSetAssetHierarchies()
        {
            return this._assetHierarchies != null && this._assetHierarchies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AssetId
        {
            get { return this._assetId; }
            set { this._assetId = value; }
        }

        // Check to see if AssetId property is set
        internal bool IsSetAssetId()
        {
            return this._assetId != null;
        }

        /// <summary>
        /// Gets and sets the property AssetLastUpdateDate. 
        /// <para>
        /// The date the asset was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime AssetLastUpdateDate
        {
            get { return this._assetLastUpdateDate.GetValueOrDefault(); }
            set { this._assetLastUpdateDate = value; }
        }

        // Check to see if AssetLastUpdateDate property is set
        internal bool IsSetAssetLastUpdateDate()
        {
            return this._assetLastUpdateDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AssetModelId. 
        /// <para>
        /// The ID of the asset model that was used to create the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AssetModelId
        {
            get { return this._assetModelId; }
            set { this._assetModelId = value; }
        }

        // Check to see if AssetModelId property is set
        internal bool IsSetAssetModelId()
        {
            return this._assetModelId != null;
        }

        /// <summary>
        /// Gets and sets the property AssetName. 
        /// <para>
        /// The name of the asset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AssetName
        {
            get { return this._assetName; }
            set { this._assetName = value; }
        }

        // Check to see if AssetName property is set
        internal bool IsSetAssetName()
        {
            return this._assetName != null;
        }

        /// <summary>
        /// Gets and sets the property AssetProperties. 
        /// <para>
        /// The list of asset properties for the asset.
        /// </para>
        ///  
        /// <para>
        /// This object doesn't include properties that you define in composite models. You can
        /// find composite model properties in the <code>assetCompositeModels</code> object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AssetProperty> AssetProperties
        {
            get { return this._assetProperties; }
            set { this._assetProperties = value; }
        }

        // Check to see if AssetProperties property is set
        internal bool IsSetAssetProperties()
        {
            return this._assetProperties != null && this._assetProperties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AssetStatus. 
        /// <para>
        /// The current status of the asset, which contains a state and any error message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssetStatus AssetStatus
        {
            get { return this._assetStatus; }
            set { this._assetStatus = value; }
        }

        // Check to see if AssetStatus property is set
        internal bool IsSetAssetStatus()
        {
            return this._assetStatus != null;
        }

    }
}