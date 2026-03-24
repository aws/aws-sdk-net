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
 * Do not modify this file. This file is generated from the rest-json-protocol-2019-12-16.normal.json service model.
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
namespace Amazon.RestJsonProtocol.Model
{
    /// <summary>
    /// Container for the parameters to the SparseJsonLists operation.
    /// 
    /// </summary>
    public partial class SparseJsonListsRequest : AmazonRestJsonProtocolRequest
    {
        private List<int?> _sparseShortList = AWSConfigs.InitializeCollections ? new List<int?>() : null;
        private List<string> _sparseStringList = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property SparseShortList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int?> SparseShortList
        {
            get { return this._sparseShortList; }
            set { this._sparseShortList = value; }
        }

        // Check to see if SparseShortList property is set
        internal bool IsSetSparseShortList()
        {
            return this._sparseShortList != null && (this._sparseShortList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SparseStringList.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SparseStringList
        {
            get { return this._sparseStringList; }
            set { this._sparseStringList = value; }
        }

        // Check to see if SparseStringList property is set
        internal bool IsSetSparseStringList()
        {
            return this._sparseStringList != null && (this._sparseStringList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}