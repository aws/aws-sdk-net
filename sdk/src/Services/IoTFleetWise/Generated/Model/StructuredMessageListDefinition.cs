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
 * Do not modify this file. This file is generated from the iotfleetwise-2021-06-17.normal.json service model.
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
        private int? _capacity;
        private StructuredMessageListType _listType;
        private StructuredMessage _memberType;
        private string _name;

        /// <summary>
        /// Gets and sets the property Capacity. 
        /// <para>
        /// The capacity of the structured message list definition when the list type is <c>FIXED_CAPACITY</c>
        /// or <c>DYNAMIC_BOUNDED_CAPACITY</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int? Capacity
        {
            get { return this._capacity; }
            set { this._capacity = value; }
        }

        // Check to see if Capacity property is set
        internal bool IsSetCapacity()
        {
            return this._capacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ListType. 
        /// <para>
        /// The type of list of the structured message list definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StructuredMessageListType ListType
        {
            get { return this._listType; }
            set { this._listType = value; }
        }

        // Check to see if ListType property is set
        internal bool IsSetListType()
        {
            return this._listType != null;
        }

        /// <summary>
        /// Gets and sets the property MemberType. 
        /// <para>
        /// The member type of the structured message list definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StructuredMessage MemberType
        {
            get { return this._memberType; }
            set { this._memberType = value; }
        }

        // Check to see if MemberType property is set
        internal bool IsSetMemberType()
        {
            return this._memberType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the structured message list definition. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=150)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}