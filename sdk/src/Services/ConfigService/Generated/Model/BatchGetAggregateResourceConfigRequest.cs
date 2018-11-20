/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetAggregateResourceConfig operation.
    /// Returns the current configuration items for resources that are present in your AWS
    /// Config aggregator. The operation also returns a list of resources that are not processed
    /// in the current request. If there are no unprocessed resources, the operation returns
    /// an empty <code>unprocessedResourceIdentifiers</code> list. 
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
        private List<AggregateResourceIdentifier> _resourceIdentifiers = new List<AggregateResourceIdentifier>();

        /// <summary>
        /// Gets and sets the property ConfigurationAggregatorName. 
        /// <para>
        /// The name of the configuration aggregator.
        /// </para>
        /// </summary>
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
        /// </summary>
        public List<AggregateResourceIdentifier> ResourceIdentifiers
        {
            get { return this._resourceIdentifiers; }
            set { this._resourceIdentifiers = value; }
        }

        // Check to see if ResourceIdentifiers property is set
        internal bool IsSetResourceIdentifiers()
        {
            return this._resourceIdentifiers != null && this._resourceIdentifiers.Count > 0; 
        }

    }
}