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
    /// This is the response object from the DeleteAssetModelInterfaceRelationship operation.
    /// </summary>
    public partial class DeleteAssetModelInterfaceRelationshipResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AssetModelArn. 
        /// <para>
        /// The ARN of the asset model, which has the following format. <c>arn:${Partition}:iotsitewise:${Region}:${Account}:asset-model/${AssetModelId}</c>
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
        /// Gets and sets the property AssetModelId. 
        /// <para>
        /// The ID of the asset model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string AssetModelId { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelId property is set.
        /// </summary>
        internal bool IsSetAssetModelId() => this.AssetModelId != null;

        /// <summary>
        /// Gets and sets the property AssetModelStatus.
        /// </summary>
        [AWSProperty(Required = true)]
        public AssetModelStatus AssetModelStatus { get; set; }

        /// <summary>
        /// Checks to see if the AssetModelStatus property is set.
        /// </summary>
        internal bool IsSetAssetModelStatus() => this.AssetModelStatus != null;

        /// <summary>
        /// Gets and sets the property InterfaceAssetModelId. 
        /// <para>
        /// The ID of the interface asset model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string InterfaceAssetModelId { get; set; }

        /// <summary>
        /// Checks to see if the InterfaceAssetModelId property is set.
        /// </summary>
        internal bool IsSetInterfaceAssetModelId() => this.InterfaceAssetModelId != null;
    }
}
