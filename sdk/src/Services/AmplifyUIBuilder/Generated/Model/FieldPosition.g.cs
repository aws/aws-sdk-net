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

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Describes the field position.
    /// </summary>
    public partial class FieldPosition
    {
        /// <summary>
        /// Gets and sets the property Below. 
        /// <para>
        /// The field position is below the field specified by the string.
        /// </para>
        /// </summary>
        public string Below { get; set; }

        /// <summary>
        /// Checks to see if the Below property is set.
        /// </summary>
        internal bool IsSetBelow() => this.Below != null;

        /// <summary>
        /// Gets and sets the property Fixed. 
        /// <para>
        /// The field position is fixed and doesn't change in relation to other fields.
        /// </para>
        /// </summary>
        public FixedPosition Fixed { get; set; }

        /// <summary>
        /// Checks to see if the Fixed property is set.
        /// </summary>
        internal bool IsSetFixed() => this.Fixed != null;

        /// <summary>
        /// Gets and sets the property RightOf. 
        /// <para>
        /// The field position is to the right of the field specified by the string.
        /// </para>
        /// </summary>
        public string RightOf { get; set; }

        /// <summary>
        /// Checks to see if the RightOf property is set.
        /// </summary>
        internal bool IsSetRightOf() => this.RightOf != null;
    }
}
