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

namespace Amazon.Shield.Model
{
    /// <summary>
    /// A contributor to the attack and their contribution.
    /// </summary>
    public partial class Contributor
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the contributor. The type of name that you'll find here depends on the
        /// <c>AttackPropertyIdentifier</c> setting in the <c>AttackProperty</c> where this contributor
        /// is defined. For example, if the <c>AttackPropertyIdentifier</c> is <c>SOURCE_COUNTRY</c>,
        /// the <c>Name</c> could be <c>United States</c>.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The contribution of this contributor expressed in <a>Protection</a> units. For example
        /// <c>10,000</c>.
        /// </para>
        /// </summary>
        public long? Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value.HasValue;
    }
}
