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

namespace Amazon.DataExchange.Model
{
    /// <summary>
    /// Details about the origin of the data set.
    /// </summary>
    public partial class OriginDetails
    {
        /// <summary>
        /// Gets and sets the property DataGrantId. 
        /// <para>
        /// The ID of the data grant.
        /// </para>
        /// </summary>
        public string DataGrantId { get; set; }

        /// <summary>
        /// Checks to see if the DataGrantId property is set.
        /// </summary>
        internal bool IsSetDataGrantId() => this.DataGrantId != null;

        /// <summary>
        /// Gets and sets the property ProductId. 
        /// <para>
        /// The product ID of the origin of the data set.
        /// </para>
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// Checks to see if the ProductId property is set.
        /// </summary>
        internal bool IsSetProductId() => this.ProductId != null;
    }
}
