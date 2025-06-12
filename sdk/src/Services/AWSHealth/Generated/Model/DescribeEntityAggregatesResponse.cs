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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
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
namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// This is the response object from the DescribeEntityAggregates operation.
    /// </summary>
    public partial class DescribeEntityAggregatesResponse : AmazonWebServiceResponse
    {
        private List<EntityAggregate> _entityAggregates = AWSConfigs.InitializeCollections ? new List<EntityAggregate>() : null;

        /// <summary>
        /// Gets and sets the property EntityAggregates. 
        /// <para>
        /// The number of entities that are affected by each of the specified events.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EntityAggregate> EntityAggregates
        {
            get { return this._entityAggregates; }
            set { this._entityAggregates = value; }
        }

        // Check to see if EntityAggregates property is set
        internal bool IsSetEntityAggregates()
        {
            return this._entityAggregates != null && (this._entityAggregates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}