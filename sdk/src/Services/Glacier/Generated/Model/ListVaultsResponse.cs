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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
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
namespace Amazon.Glacier.Model
{
    /// <summary>
    /// Contains the Amazon S3 Glacier response to your request.
    /// </summary>
    public partial class ListVaultsResponse : AmazonWebServiceResponse
    {
        private string _marker;
        private List<DescribeVaultOutput> _vaultList = AWSConfigs.InitializeCollections ? new List<DescribeVaultOutput>() : null;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The vault ARN at which to continue pagination of the results. You use the marker in
        /// another List Vaults request to obtain more vaults in the list.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property VaultList. 
        /// <para>
        /// List of vaults.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DescribeVaultOutput> VaultList
        {
            get { return this._vaultList; }
            set { this._vaultList = value; }
        }

        // Check to see if VaultList property is set
        internal bool IsSetVaultList()
        {
            return this._vaultList != null && (this._vaultList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}