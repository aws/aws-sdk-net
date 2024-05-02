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
    /// This is the response object from the CreateAsset operation.
    /// </summary>
    public partial class CreateAssetResponse : AmazonWebServiceResponse
    {
        private string _assetArn;
        private string _assetId;
        private AssetStatus _assetStatus;

        /// <summary>
        /// Gets and sets the property AssetArn. 
        /// <para>
        /// The <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">ARN</a>
        /// of the asset, which has the following format.
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:${Partition}:iotsitewise:${Region}:${Account}:asset/${AssetId}</c> 
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
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the asset, in UUID format. This ID uniquely identifies the asset within
        /// IoT SiteWise and can be used with other IoT SiteWise API operations.
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
        /// Gets and sets the property AssetStatus. 
        /// <para>
        /// The status of the asset, which contains a state (<c>CREATING</c> after successfully
        /// calling this operation) and any error message.
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