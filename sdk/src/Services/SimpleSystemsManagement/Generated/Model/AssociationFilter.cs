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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
        private AssociationFilterKey _key;
        private string _value;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public AssociationFilter() { }

        /// <summary>
        /// Instantiates AssociationFilter with the parameterized properties
        /// </summary>
        /// <param name="key">The name of the filter. <note>  <c>InstanceId</c> has been deprecated. </note></param>
        /// <param name="value">The filter value.</param>
        public AssociationFilter(AssociationFilterKey key, string value)
        {
            _key = key;
            _value = value;
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
        [AWSProperty(Required=true)]
        public AssociationFilterKey Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The filter value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}