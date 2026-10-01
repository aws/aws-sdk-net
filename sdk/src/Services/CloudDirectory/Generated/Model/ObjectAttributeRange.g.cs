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

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// A range of attributes.
    /// </summary>
    public partial class ObjectAttributeRange
    {
        /// <summary>
        /// Gets and sets the property AttributeKey. 
        /// <para>
        /// The key of the attribute that the attribute range covers.
        /// </para>
        /// </summary>
        public AttributeKey AttributeKey { get; set; }

        /// <summary>
        /// Checks to see if the AttributeKey property is set.
        /// </summary>
        internal bool IsSetAttributeKey() => this.AttributeKey != null;

        /// <summary>
        /// Gets and sets the property Range. 
        /// <para>
        /// The range of attribute values being selected.
        /// </para>
        /// </summary>
        public TypedAttributeValueRange Range { get; set; }

        /// <summary>
        /// Checks to see if the Range property is set.
        /// </summary>
        internal bool IsSetRange() => this.Range != null;
    }
}
