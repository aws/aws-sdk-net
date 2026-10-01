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

namespace Amazon.QConnect.Model
{
    /// <summary>
    /// A single result from a content retrieval operation.
    /// </summary>
    public partial class RetrieveResult
    {
        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The identifier of the assistant association for the retrieved result.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AssociationId { get; set; }

        /// <summary>
        /// Checks to see if the AssociationId property is set.
        /// </summary>
        internal bool IsSetAssociationId() => this.AssociationId != null;

        /// <summary>
        /// Gets and sets the property ContentText. 
        /// <para>
        /// The text content of the retrieved result.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string ContentText { get; set; }

        /// <summary>
        /// Checks to see if the ContentText property is set.
        /// </summary>
        internal bool IsSetContentText() => this.ContentText != null;

        /// <summary>
        /// Gets and sets the property ReferenceType. 
        /// <para>
        /// A type to define the KB origin of a retrieved content.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReferenceType ReferenceType { get; set; }

        /// <summary>
        /// Checks to see if the ReferenceType property is set.
        /// </summary>
        internal bool IsSetReferenceType() => this.ReferenceType != null;

        /// <summary>
        /// Gets and sets the property SourceId. 
        /// <para>
        /// The URL, URI, or ID of the retrieved content when available, or a UUID when unavailable.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string SourceId { get; set; }

        /// <summary>
        /// Checks to see if the SourceId property is set.
        /// </summary>
        internal bool IsSetSourceId() => this.SourceId != null;
    }
}
