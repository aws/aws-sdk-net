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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Container for the parameters to the GetReferenceMetadata operation. Retrieves metadata
    /// for a reference genome. This operation returns the number of parts, part size, and
    /// MD5 of an entire file. This operation does not return tags. To retrieve the list of
    /// tags for a read set, use the <c>ListTagsForResource</c> API operation.
    /// </summary>
    public partial class GetReferenceMetadataRequest : AmazonOmicsRequest
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The reference's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property ReferenceStoreId. 
        /// <para>
        /// The reference's reference store ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 36)]
        public string ReferenceStoreId { get; set; }

        /// <summary>
        /// Checks to see if the ReferenceStoreId property is set.
        /// </summary>
        internal bool IsSetReferenceStoreId() => this.ReferenceStoreId != null;
    }
}
