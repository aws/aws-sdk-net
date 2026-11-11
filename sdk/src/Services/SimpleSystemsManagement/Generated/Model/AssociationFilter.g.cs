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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Describes a filter.
    /// </summary>
    public partial class AssociationFilter
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public AssociationFilter() { }

        /// <summary>
        /// Instantiates AssociationFilter with the parameterized properties
        /// </summary>
        /// <param name="key">The name of the filter.   <note>         <c>InstanceId</c> has been deprecated.   </note></param>
        /// <param name="value">The filter value.</param>
        public AssociationFilter(AssociationFilterKey key, string value)
        {
            this.Key = key;
            this.Value = value;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The name of the filter.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>InstanceId</c> has been deprecated.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public AssociationFilterKey Key { get; set; }

        /// <summary>
        /// Checks to see if the Key property is set.
        /// </summary>
        internal bool IsSetKey() => this.Key != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The filter value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
