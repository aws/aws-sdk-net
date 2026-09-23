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
    /// Container for the parameters to the UpdateLink operation. Use this operation to change
    /// what types of data are shared from a source account to its linked monitoring account
    /// sink. You can't change the sink or change the monitoring account with this operation.
    /// <para> When you update a link, you can optionally specify filters that specify which
    /// metric namespaces and which log groups are shared from the source account to the monitoring
    /// account. </para> <para> To update the list of tags associated with the sink, use <a
    /// href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_TagResource.html">TagResource</a>.
    /// </para>
    /// </summary>
    public partial class UpdateLinkRequest : AmazonOAMRequest
    {
        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The ARN of the link that you want to update.
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
        /// Specifies whether to include the tags associated with the link in the response after
        /// the update operation. When <c>IncludeTags</c> is set to <c>true</c> and the caller
        /// has the required permission, <c>oam:ListTagsForResource</c>, the API will return the
        /// tags for the specified resource. If the caller doesn't have the required permission,
        /// <c>oam:ListTagsForResource</c>, the API will raise an exception. 
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

        /// <summary>
        /// Gets and sets the property LinkConfiguration. 
        /// <para>
        /// Use this structure to filter which metric namespaces and which log groups are to be
        /// shared from the source account to the monitoring account.
        /// </para>
        /// </summary>
        public LinkConfiguration LinkConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LinkConfiguration property is set.
        /// </summary>
        internal bool IsSetLinkConfiguration() => this.LinkConfiguration != null;

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// An array of strings that define which types of data that the source account will send
        /// to the monitoring account.
        /// </para>
        ///  
        /// <para>
        /// Your input here replaces the current set of data types that are shared.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public List<string> ResourceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ResourceTypes property is set.
        /// </summary>
        internal bool IsSetResourceTypes() => this.ResourceTypes != null && (this.ResourceTypes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
