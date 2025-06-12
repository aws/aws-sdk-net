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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetAggregateResourceConfig operation.
    /// Returns the current configuration items for resources that are present in your Config
    /// aggregator. The operation also returns a list of resources that are not processed
    /// in the current request. If there are no unprocessed resources, the operation returns
    /// an empty <c>unprocessedResourceIdentifiers</c> list. 
    /// 
    ///  <note> <ul> <li> 
    /// <para>
    /// The API does not return results for deleted resources.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  The API does not return tags and relationships.
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class BatchGetAggregateResourceConfigRequest : AmazonConfigServiceRequest
    {
        private string _configurationAggregatorName;
        private List<AggregateResourceIdentifier> _resourceIdentifiers = AWSConfigs.InitializeCollections ? new List<AggregateResourceIdentifier>() : null;

        /// <summary>
        /// Gets and sets the property ConfigurationAggregatorName. 
        /// <para>
        /// The name of the configuration aggregator.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string ConfigurationAggregatorName
        {
            get { return this._configurationAggregatorName; }
            set { this._configurationAggregatorName = value; }
        }

        // Check to see if ConfigurationAggregatorName property is set
        internal bool IsSetConfigurationAggregatorName()
        {
            return this._configurationAggregatorName != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceIdentifiers. 
        /// <para>
        /// A list of aggregate ResourceIdentifiers objects. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public List<AggregateResourceIdentifier> ResourceIdentifiers
        {
            get { return this._resourceIdentifiers; }
            set { this._resourceIdentifiers = value; }
        }

        // Check to see if ResourceIdentifiers property is set
        internal bool IsSetResourceIdentifiers()
        {
            return this._resourceIdentifiers != null && (this._resourceIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}