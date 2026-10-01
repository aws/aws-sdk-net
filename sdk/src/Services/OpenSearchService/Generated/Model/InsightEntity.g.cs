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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Specifies the entity for which to retrieve insights. An entity can be an Amazon OpenSearch
    /// Service domain or an Amazon Web Services account.
    /// </summary>
    public partial class InsightEntity
    {
        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the entity. Possible values are <c>Account</c> and <c>DomainName</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InsightEntityType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The value of the entity. For <c>DomainName</c>, this is the domain name. For <c>Account</c>,
        /// this is the Amazon Web Services account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 28)]
        public string Value { get; set; }

        /// <summary>
        /// Checks to see if the Value property is set.
        /// </summary>
        internal bool IsSetValue() => this.Value != null;
    }
}
