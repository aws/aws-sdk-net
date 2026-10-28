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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// A single field that differs between the source and target copies of an item.
    /// </summary>
    public partial class DivergentField
    {
        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The location of the field within the item.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// How the comparison treats this field.
        /// </para>
        /// </summary>
        public DiffFieldPolicy Policy { get; set; }

        /// <summary>
        /// Checks to see if the Policy property is set.
        /// </summary>
        internal bool IsSetPolicy() => this.Policy != null;

        /// <summary>
        /// Gets and sets the property SourceValue. 
        /// <para>
        /// The field's value on the source domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10240)]
        public string SourceValue { get; set; }

        /// <summary>
        /// Checks to see if the SourceValue property is set.
        /// </summary>
        internal bool IsSetSourceValue() => this.SourceValue != null;

        /// <summary>
        /// Gets and sets the property TargetValue. 
        /// <para>
        /// The field's value on the target domain.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10240)]
        public string TargetValue { get; set; }

        /// <summary>
        /// Checks to see if the TargetValue property is set.
        /// </summary>
        internal bool IsSetTargetValue() => this.TargetValue != null;
    }
}
