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
    /// The list of types of related items and their parameters to use for filtering.
    /// </summary>
    public partial class RelatedItemTypeFilter
    {
        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// A filter for related items of type <c>Comment</c>.
        /// </para>
        /// </summary>
        public CommentFilter Comment { get; set; }

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
        public ConnectCaseFilter ConnectCase { get; set; }

        /// <summary>
        /// Checks to see if the ConnectCase property is set.
        /// </summary>
        internal bool IsSetConnectCase() => this.ConnectCase != null;

        /// <summary>
        /// Gets and sets the property Contact. 
        /// <para>
        /// A filter for related items of type <c>Contact</c>.
        /// </para>
        /// </summary>
        public ContactFilter Contact { get; set; }

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
        public CustomFilter Custom { get; set; }

        /// <summary>
        /// Checks to see if the Custom property is set.
        /// </summary>
        internal bool IsSetCustom() => this.Custom != null;

        /// <summary>
        /// Gets and sets the property File. 
        /// <para>
        /// A filter for related items of this type of <c>File</c>.
        /// </para>
        /// </summary>
        public FileFilter File { get; set; }

        /// <summary>
        /// Checks to see if the File property is set.
        /// </summary>
        internal bool IsSetFile() => this.File != null;

        /// <summary>
        /// Gets and sets the property Sla. 
        /// <para>
        ///  Filter for related items of type <c>SLA</c>.
        /// </para>
        /// </summary>
        public SlaFilter Sla { get; set; }

        /// <summary>
        /// Checks to see if the Sla property is set.
        /// </summary>
        internal bool IsSetSla() => this.Sla != null;
    }
}
