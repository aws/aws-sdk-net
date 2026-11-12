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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSubdomain operation. Creates a Lightsail
    /// subdomain, such as <c>mysite</c>, with the web address <c>mysite.amazonlightsail.com</c>.
    /// After the subdomain is created, use the <c>UpdateSubdomainAssociation</c> action to
    /// associate it with a Lightsail resource. <para> When you create a nested subdomain,
    /// such as <c>blog.mysite</c>, and you don't already have the top-level subdomain (<c>mysite</c>),
    /// Lightsail adds the top-level subdomain to your account in the <c>IMPLICIT</c> state.
    /// </para> <para> You can have up to 30 subdomains in your account. Nested subdomains,
    /// subdomains in the <c>CREATE_FAILED</c> state, and deleted subdomains that other accounts
    /// can't create yet count toward this quota. Subdomains in the <c>IMPLICIT</c> state
    /// don't count toward this quota. </para>
    /// </summary>
    public partial class CreateSubdomainRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property SubdomainName. 
        /// <para>
        /// The subdomain to create (for example, <c>mysite</c> or <c>blog.mysite</c>).
        /// </para>
        ///  
        /// <para>
        /// A subdomain can contain one or two labels separated by a period (<c>.</c>). Each label
        /// must start and end with a lowercase letter or a number, and can contain only lowercase
        /// letters, numbers, and hyphens (<c>-</c>). The name can be up to 39 characters long,
        /// including periods. Labels that start with <c>xn--</c> aren't supported, and some names
        /// are reserved.
        /// </para>
        ///  
        /// <para>
        /// Specify only the subdomain. A web address, such as <c>mysite.amazonlightsail.com</c>,
        /// isn't accepted.
        /// </para>
        ///  
        /// <para>
        /// To create a nested subdomain, you must own the top-level subdomain or be able to create
        /// it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SubdomainName { get; set; }

        /// <summary>
        /// Checks to see if the SubdomainName property is set.
        /// </summary>
        internal bool IsSetSubdomainName() => this.SubdomainName != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values to add to the subdomain during create.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>TagResource</c> action to tag a resource after it's created.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
