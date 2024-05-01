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
    /// This is the response object from the DeleteAssetModel operation.
    /// </summary>
    public partial class DeleteAssetModelResponse : AmazonWebServiceResponse
    {
        private AssetModelStatus _assetModelStatus;

        /// <summary>
        /// Gets and sets the property AssetModelStatus. 
        /// <para>
        /// The status of the asset model, which contains a state (<c>DELETING</c> after successfully
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