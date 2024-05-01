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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// This is the response object from the CreateAssetModel operation.
    /// </summary>
    public partial class CreateAssetModelResponse : AmazonWebServiceResponse
    {
        private string _assetModelArn;
        private string _assetModelId;
        private AssetModelStatus _assetModelStatus;

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
        /// Gets and sets the property AssetModelId. 
        /// <para>
        /// The ID of the asset model, in UUID format. You can use this ID when you call other
        /// IoT SiteWise API operations.
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
        /// Gets and sets the property AssetModelStatus. 
        /// <para>
        /// The status of the asset model, which contains a state (<c>CREATING</c> after successfully
        /// calling this operation) and any error message.
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