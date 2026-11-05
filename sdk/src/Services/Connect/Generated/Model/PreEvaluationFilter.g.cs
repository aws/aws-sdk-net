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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// A single pre-evaluation filter condition. Specifies a resource type, filter type,
    /// key, value, and operator to match against a resource attribute.
    /// </summary>
    public partial class PreEvaluationFilter
    {
        /// <summary>
        /// Gets and sets the property FilterKey. 
        /// <para>
        /// The key of the attribute to filter on. For tag filters, this is the tag key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FilterKey { get; set; }

        /// <summary>
        /// Checks to see if the FilterKey property is set.
        /// </summary>
        internal bool IsSetFilterKey() => this.FilterKey != null;

        /// <summary>
        /// Gets and sets the property FilterType. 
        /// <para>
        /// The type of filter to apply. Valid values: <c>TAG</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PreEvaluationFilterType FilterType { get; set; }

        /// <summary>
        /// Checks to see if the FilterType property is set.
        /// </summary>
        internal bool IsSetFilterType() => this.FilterType != null;

        /// <summary>
        /// Gets and sets the property FilterValue. 
        /// <para>
        /// The value to match against. For tag filters, this is the tag value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FilterValue { get; set; }

        /// <summary>
        /// Checks to see if the FilterValue property is set.
        /// </summary>
        internal bool IsSetFilterValue() => this.FilterValue != null;

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The comparison operator for the filter condition. Valid values: <c>EQUALS</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public PreEvaluationFilterOperator Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource to filter on. Valid values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CONTACT</c> - Filter on attributes of the contact, such as tags assigned to the
        /// contact.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CONTACT_EVALUATION</c> - Filter on attributes of the contact evaluation, such
        /// as tags assigned to the contact evaluation, for rules triggered on the <c>OnContactEvaluationSubmit</c>
        /// event source.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public PreEvaluationFilterResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
