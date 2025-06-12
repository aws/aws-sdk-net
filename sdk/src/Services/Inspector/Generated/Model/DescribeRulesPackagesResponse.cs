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
 * Do not modify this file. This file is generated from the inspector-2016-02-16.normal.json service model.
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
namespace Amazon.Inspector.Model
{
    /// <summary>
    /// This is the response object from the DescribeRulesPackages operation.
    /// </summary>
    public partial class DescribeRulesPackagesResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, FailedItemDetails> _failedItems = AWSConfigs.InitializeCollections ? new Dictionary<string, FailedItemDetails>() : null;
        private List<RulesPackage> _rulesPackages = AWSConfigs.InitializeCollections ? new List<RulesPackage>() : null;

        /// <summary>
        /// Gets and sets the property FailedItems. 
        /// <para>
        /// Rules package details that cannot be described. An error code is provided for each
        /// failed item.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, FailedItemDetails> FailedItems
        {
            get { return this._failedItems; }
            set { this._failedItems = value; }
        }

        // Check to see if FailedItems property is set
        internal bool IsSetFailedItems()
        {
            return this._failedItems != null && (this._failedItems.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RulesPackages. 
        /// <para>
        /// Information about the rules package.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=10)]
        public List<RulesPackage> RulesPackages
        {
            get { return this._rulesPackages; }
            set { this._rulesPackages = value; }
        }

        // Check to see if RulesPackages property is set
        internal bool IsSetRulesPackages()
        {
            return this._rulesPackages != null && (this._rulesPackages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}