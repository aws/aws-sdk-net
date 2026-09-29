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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The URL configuration for a table field.
    /// </summary>
    public partial class TableFieldURLConfiguration
    {
        /// <summary>
        /// Gets and sets the property ImageConfiguration. 
        /// <para>
        /// The image configuration of a table field URL.
        /// </para>
        /// </summary>
        public TableFieldImageConfiguration ImageConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ImageConfiguration property is set.
        /// </summary>
        internal bool IsSetImageConfiguration() => this.ImageConfiguration != null;

        /// <summary>
        /// Gets and sets the property LinkConfiguration. 
        /// <para>
        /// The link configuration of a table field URL.
        /// </para>
        /// </summary>
        public TableFieldLinkConfiguration LinkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LinkConfiguration property is set.
        /// </summary>
        internal bool IsSetLinkConfiguration() => this.LinkConfiguration != null;
    }
}
