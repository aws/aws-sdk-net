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

namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// The message object that provides the message text and its type.
    /// </summary>
    public partial class Message
    {
        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The text of the message.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string Content { get; set; }

        /// <summary>
        /// Checks to see if the Content property is set.
        /// </summary>
        internal bool IsSetContent() => this.Content != null;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content type of the message string.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ContentType ContentType { get; set; }

        /// <summary>
        /// Checks to see if the ContentType property is set.
        /// </summary>
        internal bool IsSetContentType() => this.ContentType != null;

        /// <summary>
        /// Gets and sets the property GroupNumber. 
        /// <para>
        /// Identifies the message group that the message belongs to. When a group is assigned
        /// to a message, Amazon Lex returns one message from each group in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public int? GroupNumber { get; set; }

        /// <summary>
        /// Checks to see if the GroupNumber property is set.
        /// </summary>
        internal bool IsSetGroupNumber() => this.GroupNumber.HasValue;
    }
}
