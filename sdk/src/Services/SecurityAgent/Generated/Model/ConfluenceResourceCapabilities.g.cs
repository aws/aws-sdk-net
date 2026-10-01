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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Capabilities for an integrated Confluence space.
    /// </summary>
    public partial class ConfluenceResourceCapabilities
    {
        /// <summary>
        /// Gets and sets the property CreateDocument. 
        /// <para>
        /// Whether to create documents in this space.
        /// </para>
        /// </summary>
        public bool? CreateDocument { get; set; }

        /// <summary>
        /// Checks to see if the CreateDocument property is set.
        /// </summary>
        internal bool IsSetCreateDocument() => this.CreateDocument.HasValue;

        /// <summary>
        /// Gets and sets the property FetchDocument. 
        /// <para>
        /// Whether to fetch documents from this space.
        /// </para>
        /// </summary>
        public bool? FetchDocument { get; set; }

        /// <summary>
        /// Checks to see if the FetchDocument property is set.
        /// </summary>
        internal bool IsSetFetchDocument() => this.FetchDocument.HasValue;

        /// <summary>
        /// Gets and sets the property UpdateDocument. 
        /// <para>
        /// Whether to update documents in this space.
        /// </para>
        /// </summary>
        public bool? UpdateDocument { get; set; }

        /// <summary>
        /// Checks to see if the UpdateDocument property is set.
        /// </summary>
        internal bool IsSetUpdateDocument() => this.UpdateDocument.HasValue;
    }
}
