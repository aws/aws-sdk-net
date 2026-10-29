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
    /// A leaf node condition which can be used to specify a hierarchy group condition.
    /// </summary>
    public partial class HierarchyGroupCondition
    {
        /// <summary>
        /// Gets and sets the property HierarchyGroupMatchType. 
        /// <para>
        /// The type of hierarchy group match.
        /// </para>
        /// </summary>
        public HierarchyGroupMatchType HierarchyGroupMatchType { get; set; }

        /// <summary>
        /// Checks to see if the HierarchyGroupMatchType property is set.
        /// </summary>
        internal bool IsSetHierarchyGroupMatchType() => this.HierarchyGroupMatchType != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value in the hierarchy group condition.
        /// </para>
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
