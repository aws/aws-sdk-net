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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The ThingTypeMetadata contains additional information about the thing type including:
    /// creation date and time, a value indicating whether the thing type is deprecated, and
    /// a date and time when time was deprecated.
    /// </summary>
    public partial class ThingTypeMetadata
    {
        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the thing type was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property Deprecated. 
        /// <para>
        /// Whether the thing type is deprecated. If <b>true</b>, no new things could be associated
        /// with this type.
        /// </para>
        /// </summary>
        public bool? Deprecated { get; set; }

        /// <summary>
        /// Checks to see if the Deprecated property is set.
        /// </summary>
        internal bool IsSetDeprecated() => this.Deprecated.HasValue;

        /// <summary>
        /// Gets and sets the property DeprecationDate. 
        /// <para>
        /// The date and time when the thing type was deprecated.
        /// </para>
        /// </summary>
        public DateTime? DeprecationDate { get; set; }

        /// <summary>
        /// Checks to see if the DeprecationDate property is set.
        /// </summary>
        internal bool IsSetDeprecationDate() => this.DeprecationDate.HasValue;
    }
}
