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

namespace Amazon.Appflow.Model
{
    /// <summary>
    /// The high-level entity that can be queried in Amazon AppFlow. For example, a Salesforce
    /// entity might be an <i>Account</i> or <i>Opportunity</i>, whereas a ServiceNow entity
    /// might be an <i>Incident</i>.
    /// </summary>
    public partial class ConnectorEntity
    {
        /// <summary>
        /// Gets and sets the property HasNestedEntities. 
        /// <para>
        ///  Specifies whether the connector entity is a parent or a category and has more entities
        /// nested underneath it. If another call is made with <c>entitiesPath = "the_current_entity_name_with_hasNestedEntities_true"</c>,
        /// then it returns the nested entities underneath it. This provides a way to retrieve
        /// all supported entities in a recursive fashion. 
        /// </para>
        /// </summary>
        public bool? HasNestedEntities { get; set; }

        /// <summary>
        /// Checks to see if the HasNestedEntities property is set.
        /// </summary>
        internal bool IsSetHasNestedEntities() => this.HasNestedEntities.HasValue;

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        ///  The label applied to the connector entity. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Label { get; set; }

        /// <summary>
        /// Checks to see if the Label property is set.
        /// </summary>
        internal bool IsSetLabel() => this.Label != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the connector entity. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
