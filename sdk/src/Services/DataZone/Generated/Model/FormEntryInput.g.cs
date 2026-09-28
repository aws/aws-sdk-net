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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// The details of the form entry.
    /// </summary>
    public partial class FormEntryInput
    {
        /// <summary>
        /// Gets and sets the property Required. 
        /// <para>
        /// Specifies whether a form entry is required.
        /// </para>
        /// </summary>
        public bool? Required { get; set; }

        /// <summary>
        /// Checks to see if the Required property is set.
        /// </summary>
        internal bool IsSetRequired() => this.Required.HasValue;

        /// <summary>
        /// Gets and sets the property TypeIdentifier. 
        /// <para>
        /// The type ID of the form entry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 385)]
        public string TypeIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the TypeIdentifier property is set.
        /// </summary>
        internal bool IsSetTypeIdentifier() => this.TypeIdentifier != null;

        /// <summary>
        /// Gets and sets the property TypeRevision. 
        /// <para>
        /// The type revision of the form entry.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string TypeRevision { get; set; }

        /// <summary>
        /// Checks to see if the TypeRevision property is set.
        /// </summary>
        internal bool IsSetTypeRevision() => this.TypeRevision != null;
    }
}
