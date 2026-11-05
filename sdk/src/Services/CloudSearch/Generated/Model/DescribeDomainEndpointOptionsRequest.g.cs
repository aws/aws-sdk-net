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

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeDomainEndpointOptions operation. Returns
    /// the domain's endpoint options, specifically whether all requests to the domain must
    /// arrive over HTTPS. For more information, see <a href="http://docs.aws.amazon.com/cloudsearch/latest/developerguide/configuring-domain-endpoint-options.html"
    /// target="_blank">Configuring Domain Endpoint Options</a> in the <i>Amazon CloudSearch
    /// Developer Guide</i>.
    /// </summary>
    public partial class DescribeDomainEndpointOptionsRequest : AmazonCloudSearchRequest
    {
        /// <summary>
        /// Gets and sets the property Deployed. 
        /// <para>
        /// Whether to retrieve the latest configuration (which might be in a Processing state)
        /// or the current, active configuration. Defaults to <c>false</c>.
        /// </para>
        /// </summary>
        public bool? Deployed { get; set; }

        /// <summary>
        /// Checks to see if the Deployed property is set.
        /// </summary>
        internal bool IsSetDeployed() => this.Deployed.HasValue;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// A string that represents the name of a domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 28)]
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;
    }
}
