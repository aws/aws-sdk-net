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

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// This is the response object from the DescribeCustomDomains operation.
    /// </summary>
    public partial class DescribeCustomDomainsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CustomDomains. 
        /// <para>
        /// A list of descriptions of custom domain names that are associated with the service.
        /// In a paginated request, the request returns up to <c>MaxResults</c> records per call.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<CustomDomain> CustomDomains { get; set; } = AWSConfigs.InitializeCollections ? new List<CustomDomain>() : null;

        /// <summary>
        /// Checks to see if the CustomDomains property is set.
        /// </summary>
        internal bool IsSetCustomDomains() => this.CustomDomains != null && (this.CustomDomains.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DNSTarget. 
        /// <para>
        /// The App Runner subdomain of the App Runner service. The associated custom domain names
        /// are mapped to this target name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 51200)]
        public string DNSTarget { get; set; }

        /// <summary>
        /// Checks to see if the DNSTarget property is set.
        /// </summary>
        internal bool IsSetDNSTarget() => this.DNSTarget != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token that you can pass in a subsequent request to get the next result page. It's
        /// returned in a paginated request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 51200)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ServiceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the App Runner service whose associated custom domain
        /// names you want to describe.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1011)]
        public string ServiceArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceArn property is set.
        /// </summary>
        internal bool IsSetServiceArn() => this.ServiceArn != null;

        /// <summary>
        /// Gets and sets the property VpcDNSTargets. 
        /// <para>
        /// DNS Target records for the custom domains of this Amazon VPC. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<VpcDNSTarget> VpcDNSTargets { get; set; } = AWSConfigs.InitializeCollections ? new List<VpcDNSTarget>() : null;

        /// <summary>
        /// Checks to see if the VpcDNSTargets property is set.
        /// </summary>
        internal bool IsSetVpcDNSTargets() => this.VpcDNSTargets != null && (this.VpcDNSTargets.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
