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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// A parameter that has a different value for each cache node type it is applied to.
    /// For example, in a Valkey or Redis OSS cluster, a <c>cache.m1.large</c> cache node
    /// type would have a larger <c>maxmemory</c> value than a <c>cache.m1.small</c> type.
    /// </summary>
    public partial class CacheNodeTypeSpecificParameter
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public CacheNodeTypeSpecificParameter() { }

        /// <summary>
        /// Gets and sets the property AllowedValues. 
        /// <para>
        /// The valid range of values for the parameter.
        /// </para>
        /// </summary>
        public string AllowedValues { get; set; }

        /// <summary>
        /// Checks to see if the AllowedValues property is set.
        /// </summary>
        internal bool IsSetAllowedValues() => this.AllowedValues != null;

        /// <summary>
        /// Gets and sets the property CacheNodeTypeSpecificValues. 
        /// <para>
        /// A list of cache node types and their corresponding values for this parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CacheNodeTypeSpecificValue> CacheNodeTypeSpecificValues { get; set; } = AWSConfigs.InitializeCollections ? new List<CacheNodeTypeSpecificValue>() : null;

        /// <summary>
        /// Checks to see if the CacheNodeTypeSpecificValues property is set.
        /// </summary>
        internal bool IsSetCacheNodeTypeSpecificValues() => this.CacheNodeTypeSpecificValues != null && (this.CacheNodeTypeSpecificValues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ChangeType. 
        /// <para>
        /// Indicates whether a change to the parameter is applied immediately or requires a reboot
        /// for the change to be applied. You can force a reboot or wait until the next maintenance
        /// window's reboot. For more information, see <a href="https://docs.aws.amazon.com/AmazonElastiCache/latest/dg/Clusters.Rebooting.html">Rebooting
        /// a Cluster</a>.
        /// </para>
        /// </summary>
        public ChangeType ChangeType { get; set; }

        /// <summary>
        /// Checks to see if the ChangeType property is set.
        /// </summary>
        internal bool IsSetChangeType() => this.ChangeType != null;

        /// <summary>
        /// Gets and sets the property DataType. 
        /// <para>
        /// The valid data type for the parameter.
        /// </para>
        /// </summary>
        public string DataType { get; set; }

        /// <summary>
        /// Checks to see if the DataType property is set.
        /// </summary>
        internal bool IsSetDataType() => this.DataType != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the parameter.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property IsModifiable. 
        /// <para>
        /// Indicates whether (<c>true</c>) or not (<c>false</c>) the parameter can be modified.
        /// Some parameters have security or operational implications that prevent them from being
        /// changed.
        /// </para>
        /// </summary>
        public bool? IsModifiable { get; set; }

        /// <summary>
        /// Checks to see if the IsModifiable property is set.
        /// </summary>
        internal bool IsSetIsModifiable() => this.IsModifiable.HasValue;

        /// <summary>
        /// Gets and sets the property MinimumEngineVersion. 
        /// <para>
        /// The earliest cache engine version to which the parameter can apply.
        /// </para>
        /// </summary>
        public string MinimumEngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the MinimumEngineVersion property is set.
        /// </summary>
        internal bool IsSetMinimumEngineVersion() => this.MinimumEngineVersion != null;

        /// <summary>
        /// Gets and sets the property ParameterName. 
        /// <para>
        /// The name of the parameter.
        /// </para>
        /// </summary>
        public string ParameterName { get; set; }

        /// <summary>
        /// Checks to see if the ParameterName property is set.
        /// </summary>
        internal bool IsSetParameterName() => this.ParameterName != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the parameter value.
        /// </para>
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;
    }
}
