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
    /// Specifies which types of related items to move from the secondary case to the primary
    /// case when you merge cases. Moved related items keep their related item ID, creator,
    /// association time, and tags.
    /// </summary>
    public partial class RelatedItemsConfiguration
    {
        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// Whether to move Comment related items to the primary case.
        /// </para>
        /// </summary>
        public bool? Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment.HasValue;

        /// <summary>
        /// Gets and sets the property ConnectCase. 
        /// <para>
        /// Whether to move Case related items to the primary case. If the primary case already
        /// links to the same case, the secondary case's link is removed instead of moved.
        /// </para>
        /// </summary>
        public bool? ConnectCase { get; set; }

        /// <summary>
        /// Checks to see if the ConnectCase property is set.
        /// </summary>
        internal bool IsSetConnectCase() => this.ConnectCase.HasValue;

        /// <summary>
        /// Gets and sets the property Contact. 
        /// <para>
        /// Whether to move Contact related items to the primary case. If the same contact is
        /// related to both cases, the primary case keeps its related item and gets any tag keys
        /// that only the secondary case's related item has.
        /// </para>
        /// </summary>
        public bool? Contact { get; set; }

        /// <summary>
        /// Checks to see if the Contact property is set.
        /// </summary>
        internal bool IsSetContact() => this.Contact.HasValue;

        /// <summary>
        /// Gets and sets the property Custom. 
        /// <para>
        /// Whether to move Custom related items to the primary case.
        /// </para>
        /// </summary>
        public bool? Custom { get; set; }

        /// <summary>
        /// Checks to see if the Custom property is set.
        /// </summary>
        internal bool IsSetCustom() => this.Custom.HasValue;
    }
}
