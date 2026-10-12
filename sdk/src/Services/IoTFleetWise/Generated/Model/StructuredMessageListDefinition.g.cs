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

namespace Amazon.IoTFleetWise.Model
{
    /// <summary>
    /// Represents a list type node of the complex data structure.
    /// </summary>
    public partial class StructuredMessageListDefinition
    {
        /// <summary>
        /// Gets and sets the property Capacity. 
        /// <para>
        /// The capacity of the structured message list definition when the list type is <c>FIXED_CAPACITY</c>
        /// or <c>DYNAMIC_BOUNDED_CAPACITY</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public int? Capacity { get; set; }

        /// <summary>
        /// Checks to see if the Capacity property is set.
        /// </summary>
        internal bool IsSetCapacity() => this.Capacity.HasValue;

        /// <summary>
        /// Gets and sets the property ListType. 
        /// <para>
        /// The type of list of the structured message list definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StructuredMessageListType ListType { get; set; }

        /// <summary>
        /// Checks to see if the ListType property is set.
        /// </summary>
        internal bool IsSetListType() => this.ListType != null;

        /// <summary>
        /// Gets and sets the property MemberType. 
        /// <para>
        /// The member type of the structured message list definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StructuredMessage MemberType { get; set; }

        /// <summary>
        /// Checks to see if the MemberType property is set.
        /// </summary>
        internal bool IsSetMemberType() => this.MemberType != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the structured message list definition. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 150)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
