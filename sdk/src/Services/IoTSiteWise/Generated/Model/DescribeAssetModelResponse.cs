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
    /// This is the response object from the DescribeAssetModel operation.
    /// </summary>
    public partial class DescribeAssetModelResponse : AmazonWebServiceResponse
    {
        private string _assetModelArn;
        private List<AssetModelCompositeModel> _assetModelCompositeModels = new List<AssetModelCompositeModel>();
        private DateTime? _assetModelCreationDate;
        private string _assetModelDescription;
        private List<AssetModelHierarchy> _assetModelHierarchies = new List<AssetModelHierarchy>();
        private string _assetModelId;
        private DateTime? _assetModelLastUpdateDate;
        private string _assetModelName;
        private List<AssetModelProperty> _assetModelProperties = new List<AssetModelProperty>();
        private AssetModelStatus _assetModelStatus;

        /// <summary>
        /// Gets and sets the property AssetModelArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the asset model, which has the following format.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:${Partition}:iotsitewise:${Region}:${Account}:asset-model/${AssetModelId}</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string AssetModelArn
        {
            get { return this._assetModelArn; }
            set { this._assetModelArn = value; }
        }

        // Check to see if AssetModelArn property is set
        internal bool IsSetAssetModelArn()
        {
            return this._assetModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property AssetModelCompositeModels. 
        /// <para>
        /// The list of composite asset models for the asset model.
        /// </para>
        /// </summary>
        public List<AssetModelCompositeModel> AssetModelCompositeModels
        {
            get { return this._assetModelCompositeModels; }
            set { this._assetModelCompositeModels = value; }
        }

        // Check to see if AssetModelCompositeModels property is set
        internal bool IsSetAssetModelCompositeModels()
        {
            return this._assetModelCompositeModels != null && this._assetModelCompositeModels.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AssetModelCreationDate. 
        /// <para>
        /// The date the asset model was created, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime AssetModelCreationDate
        {
            get { return this._assetModelCreationDate.GetValueOrDefault(); }
            set { this._assetModelCreationDate = value; }
        }

        // Check to see if AssetModelCreationDate property is set
        internal bool IsSetAssetModelCreationDate()
        {
            return this._assetModelCreationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AssetModelDescription. 
        /// <para>
        /// The asset model's description.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string AssetModelDescription
        {
            get { return this._assetModelDescription; }
            set { this._assetModelDescription = value; }
        }

        // Check to see if AssetModelDescription property is set
        internal bool IsSetAssetModelDescription()
        {
            return this._assetModelDescription != null;
        }

        /// <summary>
        /// Gets and sets the property AssetModelHierarchies. 
        /// <para>
        /// A list of asset model hierarchies that each contain a <code>childAssetModelId</code>
        /// and a <code>hierarchyId</code> (named <code>id</code>). A hierarchy specifies allowed
        /// parent/child asset relationships for an asset model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AssetModelHierarchy> AssetModelHierarchies
        {
            get { return this._assetModelHierarchies; }
            set { this._assetModelHierarchies = value; }
        }

        // Check to see if AssetModelHierarchies property is set
        internal bool IsSetAssetModelHierarchies()
        {
            return this._assetModelHierarchies != null && this._assetModelHierarchies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AssetModelId. 
        /// <para>
        /// The ID of the asset model.
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
        /// Gets and sets the property AssetModelLastUpdateDate. 
        /// <para>
        /// The date the asset model was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime AssetModelLastUpdateDate
        {
            get { return this._assetModelLastUpdateDate.GetValueOrDefault(); }
            set { this._assetModelLastUpdateDate = value; }
        }

        // Check to see if AssetModelLastUpdateDate property is set
        internal bool IsSetAssetModelLastUpdateDate()
        {
            return this._assetModelLastUpdateDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AssetModelName. 
        /// <para>
        /// The name of the asset model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AssetModelName
        {
            get { return this._assetModelName; }
            set { this._assetModelName = value; }
        }

        // Check to see if AssetModelName property is set
        internal bool IsSetAssetModelName()
        {
            return this._assetModelName != null;
        }

        /// <summary>
        /// Gets and sets the property AssetModelProperties. 
        /// <para>
        /// The list of asset properties for the asset model.
        /// </para>
        ///  
        /// <para>
        /// This object doesn't include properties that you define in composite models. You can
        /// find composite model properties in the <code>assetModelCompositeModels</code> object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AssetModelProperty> AssetModelProperties
        {
            get { return this._assetModelProperties; }
            set { this._assetModelProperties = value; }
        }

        // Check to see if AssetModelProperties property is set
        internal bool IsSetAssetModelProperties()
        {
            return this._assetModelProperties != null && this._assetModelProperties.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AssetModelStatus. 
        /// <para>
        /// The current status of the asset model, which contains a state and any error message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AssetModelStatus AssetModelStatus
        {
            get { return this._assetModelStatus; }
            set { this._assetModelStatus = value; }
        }

        // Check to see if AssetModelStatus property is set
        internal bool IsSetAssetModelStatus()
        {
            return this._assetModelStatus != null;
        }

    }
}