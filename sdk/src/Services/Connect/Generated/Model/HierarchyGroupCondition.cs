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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
    /// A leaf node condition which can be used to specify a hierarchy group condition.
    /// </summary>
    public partial class HierarchyGroupCondition
    {
        private HierarchyGroupMatchType _hierarchyGroupMatchType;
        private string _value;

        /// <summary>
        /// Gets and sets the property HierarchyGroupMatchType. 
        /// <para>
        /// The type of hierarchy group match.
        /// </para>
        /// </summary>
        public HierarchyGroupMatchType HierarchyGroupMatchType
        {
            get { return this._hierarchyGroupMatchType; }
            set { this._hierarchyGroupMatchType = value; }
        }

        // Check to see if HierarchyGroupMatchType property is set
        internal bool IsSetHierarchyGroupMatchType()
        {
            return this._hierarchyGroupMatchType != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value in the hierarchy group condition.
        /// </para>
        /// </summary>
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