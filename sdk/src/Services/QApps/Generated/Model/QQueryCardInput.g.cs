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

namespace Amazon.QApps.Model
{
    /// <summary>
    /// The input shape for defining a query card in an Amazon Q App.
    /// </summary>
    public partial class QQueryCardInput
    {
        /// <summary>
        /// Gets and sets the property AttributeFilter. 
        /// <para>
        /// Turns on filtering of responses based on document attributes or metadata fields.
        /// </para>
        /// </summary>
        public AttributeFilter AttributeFilter { get; set; }

        /// <summary>
        /// Checks to see if the AttributeFilter property is set.
        /// </summary>
        internal bool IsSetAttributeFilter() => this.AttributeFilter != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the query card.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property OutputSource. 
        /// <para>
        /// The source or type of output to generate for the query card.
        /// </para>
        /// </summary>
        public CardOutputSource OutputSource { get; set; }

        /// <summary>
        /// Checks to see if the OutputSource property is set.
        /// </summary>
        internal bool IsSetOutputSource() => this.OutputSource != null;

        /// <summary>
        /// Gets and sets the property Prompt. 
        /// <para>
        /// The prompt or instructions displayed for the query card.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 50000)]
        public string Prompt { get; set; }

        /// <summary>
        /// Checks to see if the Prompt property is set.
        /// </summary>
        internal bool IsSetPrompt() => this.Prompt != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title or label of the query card.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the card.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CardType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
