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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A structure that represents a named entity.
    /// </summary>
    public partial class NamedEntityDefinition
    {
        /// <summary>
        /// Gets and sets the property FieldName. 
        /// <para>
        /// The name of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string FieldName { get; set; }

        /// <summary>
        /// Checks to see if the FieldName property is set.
        /// </summary>
        internal bool IsSetFieldName() => this.FieldName != null;

        /// <summary>
        /// Gets and sets the property IsHidden. 
        /// <para>
        /// A Boolean value that indicates whether the named entity definition is hidden.
        /// </para>
        /// </summary>
        public bool? IsHidden { get; set; }

        /// <summary>
        /// Checks to see if the IsHidden property is set.
        /// </summary>
        internal bool IsSetIsHidden() => this.IsHidden.HasValue;

        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// The definition of a metric.
        /// </para>
        /// </summary>
        public NamedEntityDefinitionMetric Metric { get; set; }

        /// <summary>
        /// Checks to see if the Metric property is set.
        /// </summary>
        internal bool IsSetMetric() => this.Metric != null;

        /// <summary>
        /// Gets and sets the property PresentationOrder. 
        /// <para>
        /// The presentation order of the named entity definition.
        /// </para>
        /// </summary>
        public int? PresentationOrder { get; set; }

        /// <summary>
        /// Checks to see if the PresentationOrder property is set.
        /// </summary>
        internal bool IsSetPresentationOrder() => this.PresentationOrder.HasValue;

        /// <summary>
        /// Gets and sets the property PropertyName. 
        /// <para>
        /// The property name to be used for the named entity.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string PropertyName { get; set; }

        /// <summary>
        /// Checks to see if the PropertyName property is set.
        /// </summary>
        internal bool IsSetPropertyName() => this.PropertyName != null;

        /// <summary>
        /// Gets and sets the property PropertyRole. 
        /// <para>
        /// The property role. Valid values for this structure are <c>PRIMARY</c> and <c>ID</c>.
        /// </para>
        /// </summary>
        public PropertyRole PropertyRole { get; set; }

        /// <summary>
        /// Checks to see if the PropertyRole property is set.
        /// </summary>
        internal bool IsSetPropertyRole() => this.PropertyRole != null;

        /// <summary>
        /// Gets and sets the property PropertyUsage. 
        /// <para>
        /// The property usage. Valid values for this structure are <c>INHERIT</c>, <c>DIMENSION</c>,
        /// and <c>MEASURE</c>.
        /// </para>
        /// </summary>
        public PropertyUsage PropertyUsage { get; set; }

        /// <summary>
        /// Checks to see if the PropertyUsage property is set.
        /// </summary>
        internal bool IsSetPropertyUsage() => this.PropertyUsage != null;

        /// <summary>
        /// Gets and sets the property RankOrder. 
        /// <para>
        /// The rank order of the named entity definition.
        /// </para>
        /// </summary>
        public int? RankOrder { get; set; }

        /// <summary>
        /// Checks to see if the RankOrder property is set.
        /// </summary>
        internal bool IsSetRankOrder() => this.RankOrder.HasValue;
    }
}
