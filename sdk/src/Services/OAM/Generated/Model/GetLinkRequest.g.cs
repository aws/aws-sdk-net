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

namespace Amazon.OAM.Model
{
    /// <summary>
    /// Container for the parameters to the GetLink operation. Returns complete information
    /// about one link. <para> To use this operation, provide the link ARN. To retrieve a
    /// list of link ARNs, use <a href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_ListLinks.html">ListLinks</a>.
    /// </para>
    /// </summary>
    public partial class GetLinkRequest : AmazonOAMRequest
    {
        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The ARN of the link to retrieve information for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Identifier { get; set; }

        /// <summary>
        /// Checks to see if the Identifier property is set.
        /// </summary>
        internal bool IsSetIdentifier() => this.Identifier != null;

        /// <summary>
        /// Gets and sets the property IncludeTags. 
        /// <para>
        /// Specifies whether to include the tags associated with the link in the response. When
        /// <c>IncludeTags</c> is set to <c>true</c> and the caller has the required permission,
        /// <c>oam:ListTagsForResource</c>, the API will return the tags for the specified resource.
        /// If the caller doesn't have the required permission, <c>oam:ListTagsForResource</c>,
        /// the API will raise an exception.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? IncludeTags { get; set; }

        /// <summary>
        /// Checks to see if the IncludeTags property is set.
        /// </summary>
        internal bool IsSetIncludeTags() => this.IncludeTags.HasValue;
    }
}
