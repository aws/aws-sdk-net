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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A set of filters to narrow the set of lineage entities connected to the <c>StartArn</c>(s)
    /// returned by the <c>QueryLineage</c> API action.
    /// </summary>
    public partial class QueryFilters
    {
        /// <summary>
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// Filter the lineage entities connected to the <c>StartArn</c>(s) after the create date.
        /// </para>
        /// </summary>
        public DateTime? CreatedAfter { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAfter property is set.
        /// </summary>
        internal bool IsSetCreatedAfter() => this.CreatedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBefore. 
        /// <para>
        /// Filter the lineage entities connected to the <c>StartArn</c>(s) by created date.
        /// </para>
        /// </summary>
        public DateTime? CreatedBefore { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBefore property is set.
        /// </summary>
        internal bool IsSetCreatedBefore() => this.CreatedBefore.HasValue;

        /// <summary>
        /// Gets and sets the property LineageTypes. 
        /// <para>
        /// Filter the lineage entities connected to the <c>StartArn</c>(s) by the type of the
        /// lineage entity.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 4)]
        public List<string> LineageTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the LineageTypes property is set.
        /// </summary>
        internal bool IsSetLineageTypes() => this.LineageTypes != null && (this.LineageTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ModifiedAfter. 
        /// <para>
        /// Filter the lineage entities connected to the <c>StartArn</c>(s) after the last modified
        /// date.
        /// </para>
        /// </summary>
        public DateTime? ModifiedAfter { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedAfter property is set.
        /// </summary>
        internal bool IsSetModifiedAfter() => this.ModifiedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property ModifiedBefore. 
        /// <para>
        /// Filter the lineage entities connected to the <c>StartArn</c>(s) before the last modified
        /// date.
        /// </para>
        /// </summary>
        public DateTime? ModifiedBefore { get; set; }

        /// <summary>
        /// Checks to see if the ModifiedBefore property is set.
        /// </summary>
        internal bool IsSetModifiedBefore() => this.ModifiedBefore.HasValue;

        /// <summary>
        /// Gets and sets the property Properties. 
        /// <para>
        /// Filter the lineage entities connected to the <c>StartArn</c>(s) by a set if property
        /// key value pairs. If multiple pairs are provided, an entity is included in the results
        /// if it matches any of the provided pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public Dictionary<string, string> Properties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Properties property is set.
        /// </summary>
        internal bool IsSetProperties() => this.Properties != null && (this.Properties.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Types. 
        /// <para>
        /// Filter the lineage entities connected to the <c>StartArn</c> by type. For example:
        /// <c>DataSet</c>, <c>Model</c>, <c>Endpoint</c>, or <c>ModelDeployment</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> Types { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Types property is set.
        /// </summary>
        internal bool IsSetTypes() => this.Types != null && (this.Types.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
