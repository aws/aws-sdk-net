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
    /// This is the response object from the CreateAsset operation.
    /// </summary>
    public partial class CreateAssetResponse : AmazonWebServiceResponse
    {
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
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string AssetArn { get; set; }

        /// <summary>
        /// Checks to see if the AssetArn property is set.
        /// </summary>
        internal bool IsSetAssetArn() => this.AssetArn != null;

        /// <summary>
        /// Gets and sets the property AssetId. 
        /// <para>
        /// The ID of the asset, in UUID format. This ID uniquely identifies the asset within
        /// IoT SiteWise and can be used with other IoT SiteWise API operations.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string AssetId { get; set; }

        /// <summary>
        /// Checks to see if the AssetId property is set.
        /// </summary>
        internal bool IsSetAssetId() => this.AssetId != null;

        /// <summary>
        /// Gets and sets the property AssetStatus. 
        /// <para>
        /// The status of the asset, which contains a state (<c>CREATING</c> after successfully
        /// calling this operation) and any error message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AssetStatus AssetStatus { get; set; }

        /// <summary>
        /// Checks to see if the AssetStatus property is set.
        /// </summary>
        internal bool IsSetAssetStatus() => this.AssetStatus != null;
    }
}
