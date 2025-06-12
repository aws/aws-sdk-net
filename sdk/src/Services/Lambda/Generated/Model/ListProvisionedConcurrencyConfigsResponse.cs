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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
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
namespace Amazon.Lambda.Model
{
    /// <summary>
    /// This is the response object from the ListProvisionedConcurrencyConfigs operation.
    /// </summary>
    public partial class ListProvisionedConcurrencyConfigsResponse : AmazonWebServiceResponse
    {
        private string _nextMarker;
        private List<ProvisionedConcurrencyConfigListItem> _provisionedConcurrencyConfigs = AWSConfigs.InitializeCollections ? new List<ProvisionedConcurrencyConfigListItem>() : null;

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// The pagination token that's included if more results are available.
        /// </para>
        /// </summary>
        public string NextMarker
        {
            get { return this._nextMarker; }
            set { this._nextMarker = value; }
        }

        // Check to see if NextMarker property is set
        internal bool IsSetNextMarker()
        {
            return this._nextMarker != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedConcurrencyConfigs. 
        /// <para>
        /// A list of provisioned concurrency configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ProvisionedConcurrencyConfigListItem> ProvisionedConcurrencyConfigs
        {
            get { return this._provisionedConcurrencyConfigs; }
            set { this._provisionedConcurrencyConfigs = value; }
        }

        // Check to see if ProvisionedConcurrencyConfigs property is set
        internal bool IsSetProvisionedConcurrencyConfigs()
        {
            return this._provisionedConcurrencyConfigs != null && (this._provisionedConcurrencyConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}