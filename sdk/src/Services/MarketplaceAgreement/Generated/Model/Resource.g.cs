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

namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// The list of resources involved in the agreement.
    /// </summary>
    public partial class Resource
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the resource.
        /// </para>
        ///  <note> 
        /// <para>
        /// We mention the term resource, which is most commonly a product, so a <c>resourceId</c>
        /// is also a <c>productId</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of the resource, which is the product (for example, <c>SaaSProduct</c>, <c>AmiProduct</c>,
        /// <c>ContainerProduct</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
