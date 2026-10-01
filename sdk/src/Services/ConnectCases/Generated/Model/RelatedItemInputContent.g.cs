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

namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// Represents the content of a related item to be created.
    /// </summary>
    public partial class RelatedItemInputContent
    {
        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// Represents the content of a comment to be returned to agents.
        /// </para>
        /// </summary>
        public CommentContent Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property ConnectCase. 
        /// <para>
        /// Represents the Amazon Connect case to be created as a related item.
        /// </para>
        /// </summary>
        public ConnectCaseInputContent ConnectCase { get; set; }

        /// <summary>
        /// Checks to see if the ConnectCase property is set.
        /// </summary>
        internal bool IsSetConnectCase() => this.ConnectCase != null;

        /// <summary>
        /// Gets and sets the property Contact. 
        /// <para>
        /// Object representing a contact in Amazon Connect as an API request field.
        /// </para>
        /// </summary>
        public Contact Contact { get; set; }

        /// <summary>
        /// Checks to see if the Contact property is set.
        /// </summary>
        internal bool IsSetContact() => this.Contact != null;

        /// <summary>
        /// Gets and sets the property Custom. 
        /// <para>
        /// Represents the content of a <c>Custom</c> type related item.
        /// </para>
        /// </summary>
        public CustomInputContent Custom { get; set; }

        /// <summary>
        /// Checks to see if the Custom property is set.
        /// </summary>
        internal bool IsSetCustom() => this.Custom != null;

        /// <summary>
        /// Gets and sets the property File. 
        /// <para>
        /// A file of related items.
        /// </para>
        /// </summary>
        public FileContent File { get; set; }

        /// <summary>
        /// Checks to see if the File property is set.
        /// </summary>
        internal bool IsSetFile() => this.File != null;

        /// <summary>
        /// Gets and sets the property Sla. 
        /// <para>
        /// Represents the content of an SLA to be created.
        /// </para>
        /// </summary>
        public SlaInputContent Sla { get; set; }

        /// <summary>
        /// Checks to see if the Sla property is set.
        /// </summary>
        internal bool IsSetSla() => this.Sla != null;
    }
}
