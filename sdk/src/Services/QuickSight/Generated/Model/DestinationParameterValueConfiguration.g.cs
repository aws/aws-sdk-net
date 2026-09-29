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
    /// The configuration of destination parameter values.
    /// 
    ///  
    /// <para>
    /// This is a union type structure. For this structure to be valid, only one of the attributes
    /// can be defined.
    /// </para>
    /// </summary>
    public partial class DestinationParameterValueConfiguration
    {
        /// <summary>
        /// Gets and sets the property CustomValuesConfiguration. 
        /// <para>
        /// The configuration of custom values for destination parameter in <c>DestinationParameterValueConfiguration</c>.
        /// </para>
        /// </summary>
        public CustomValuesConfiguration CustomValuesConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the CustomValuesConfiguration property is set.
        /// </summary>
        internal bool IsSetCustomValuesConfiguration() => this.CustomValuesConfiguration != null;

        /// <summary>
        /// Gets and sets the property SelectAllValueOptions. 
        /// <para>
        /// The configuration that selects all options.
        /// </para>
        /// </summary>
        public SelectAllValueOptions SelectAllValueOptions { get; set; }

        /// <summary>
        /// Checks to see if the SelectAllValueOptions property is set.
        /// </summary>
        internal bool IsSetSelectAllValueOptions() => this.SelectAllValueOptions != null;

        /// <summary>
        /// Gets and sets the property SourceColumn.
        /// </summary>
        public ColumnIdentifier SourceColumn { get; set; }

        /// <summary>
        /// Checks to see if the SourceColumn property is set.
        /// </summary>
        internal bool IsSetSourceColumn() => this.SourceColumn != null;

        /// <summary>
        /// Gets and sets the property SourceField. 
        /// <para>
        /// The source field ID of the destination parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string SourceField { get; set; }

        /// <summary>
        /// Checks to see if the SourceField property is set.
        /// </summary>
        internal bool IsSetSourceField() => this.SourceField != null;

        /// <summary>
        /// Gets and sets the property SourceParameterName. 
        /// <para>
        /// The source parameter name of the destination parameter.
        /// </para>
        /// </summary>
        public string SourceParameterName { get; set; }

        /// <summary>
        /// Checks to see if the SourceParameterName property is set.
        /// </summary>
        internal bool IsSetSourceParameterName() => this.SourceParameterName != null;
    }
}
