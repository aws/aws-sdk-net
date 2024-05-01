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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
        private string _fieldName;
        private NamedEntityDefinitionMetric _metric;
        private string _propertyName;
        private PropertyRole _propertyRole;
        private PropertyUsage _propertyUsage;

        /// <summary>
        /// Gets and sets the property FieldName. 
        /// <para>
        /// The name of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string FieldName
        {
            get { return this._fieldName; }
            set { this._fieldName = value; }
        }

        // Check to see if FieldName property is set
        internal bool IsSetFieldName()
        {
            return this._fieldName != null;
        }

        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// The definition of a metric.
        /// </para>
        /// </summary>
        public NamedEntityDefinitionMetric Metric
        {
            get { return this._metric; }
            set { this._metric = value; }
        }

        // Check to see if Metric property is set
        internal bool IsSetMetric()
        {
            return this._metric != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyName. 
        /// <para>
        /// The property name to be used for the named entity.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string PropertyName
        {
            get { return this._propertyName; }
            set { this._propertyName = value; }
        }

        // Check to see if PropertyName property is set
        internal bool IsSetPropertyName()
        {
            return this._propertyName != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyRole. 
        /// <para>
        /// The property role. Valid values for this structure are <c>PRIMARY</c> and <c>ID</c>.
        /// </para>
        /// </summary>
        public PropertyRole PropertyRole
        {
            get { return this._propertyRole; }
            set { this._propertyRole = value; }
        }

        // Check to see if PropertyRole property is set
        internal bool IsSetPropertyRole()
        {
            return this._propertyRole != null;
        }

        /// <summary>
        /// Gets and sets the property PropertyUsage. 
        /// <para>
        /// The property usage. Valid values for this structure are <c>INHERIT</c>, <c>DIMENSION</c>,
        /// and <c>MEASURE</c>.
        /// </para>
        /// </summary>
        public PropertyUsage PropertyUsage
        {
            get { return this._propertyUsage; }
            set { this._propertyUsage = value; }
        }

        // Check to see if PropertyUsage property is set
        internal bool IsSetPropertyUsage()
        {
            return this._propertyUsage != null;
        }

    }
}