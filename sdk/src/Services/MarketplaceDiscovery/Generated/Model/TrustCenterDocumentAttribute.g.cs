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

namespace Amazon.MarketplaceDiscovery.Model
{
    /// <summary>
    /// A trust center document associated with a listing.
    /// </summary>
    public partial class TrustCenterDocumentAttribute
    {
        /// <summary>
        /// Gets and sets the property AccessType. 
        /// <para>
        /// How the document can be accessed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrustCenterDocumentAccessType AccessType { get; set; }

        /// <summary>
        /// Checks to see if the AccessType property is set.
        /// </summary>
        internal bool IsSetAccessType() => this.AccessType != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The format of the document resource value.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceContentType ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property DisplayName. 
        /// <para>
        /// The document name displayed to you.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Checks to see if the DisplayName property is set.
        /// </summary>
        internal bool IsSetDisplayName() => this.DisplayName != null;

        /// <summary>
        /// Gets and sets the property SubjectArea. 
        /// <para>
        /// The subject area of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string SubjectArea { get; set; }

        /// <summary>
        /// Checks to see if the SubjectArea property is set.
        /// </summary>
        internal bool IsSetSubjectArea() => this.SubjectArea != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The URL used to download, view, or request access to the document.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 8192)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
