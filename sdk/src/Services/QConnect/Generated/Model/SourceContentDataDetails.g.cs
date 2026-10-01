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
    /// Details about the source content data.
    /// </summary>
    public partial class SourceContentDataDetails
    {
        /// <summary>
        /// Gets and sets the property CitationSpan. 
        /// <para>
        /// Contains information about where the text with a citation begins and ends in the generated
        /// output.
        /// </para>
        /// </summary>
        public CitationSpan CitationSpan { get; set; }

        /// <summary>
        /// Checks to see if the CitationSpan property is set.
        /// </summary>
        internal bool IsSetCitationSpan() => this.CitationSpan != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the source content.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property RankingData. 
        /// <para>
        /// Details about the source content ranking data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RankingData RankingData { get; set; }

        /// <summary>
        /// Checks to see if the RankingData property is set.
        /// </summary>
        internal bool IsSetRankingData() => this.RankingData != null;

        /// <summary>
        /// Gets and sets the property TextData. 
        /// <para>
        ///  Details about the source content text data.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TextData TextData { get; set; }

        /// <summary>
        /// Checks to see if the TextData property is set.
        /// </summary>
        internal bool IsSetTextData() => this.TextData != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the source content.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SourceContentType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
