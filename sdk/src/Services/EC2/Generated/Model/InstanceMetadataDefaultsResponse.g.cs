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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The default instance metadata service (IMDS) settings that were set at the account
    /// level in the specified Amazon Web Services Region.
    /// </summary>
    public partial class InstanceMetadataDefaultsResponse
    {
        /// <summary>
        /// Gets and sets the property HttpEndpoint. 
        /// <para>
        /// Indicates whether the IMDS endpoint for an instance is enabled or disabled. When disabled,
        /// the instance metadata can't be accessed.
        /// </para>
        /// </summary>
        public InstanceMetadataEndpointState HttpEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the HttpEndpoint property is set.
        /// </summary>
        internal bool IsSetHttpEndpoint() => this.HttpEndpoint != null;

        /// <summary>
        /// Gets and sets the property HttpPutResponseHopLimit. 
        /// <para>
        /// The maximum number of hops that the metadata token can travel.
        /// </para>
        /// </summary>
        public int? HttpPutResponseHopLimit { get; set; }

        /// <summary>
        /// Checks to see if the HttpPutResponseHopLimit property is set.
        /// </summary>
        internal bool IsSetHttpPutResponseHopLimit() => this.HttpPutResponseHopLimit.HasValue;

        /// <summary>
        /// Gets and sets the property HttpTokens. 
        /// <para>
        /// Indicates whether IMDSv2 is required.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>optional</c> – IMDSv2 is optional, which means that you can use either IMDSv2
        /// or IMDSv1.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>required</c> – IMDSv2 is required, which means that IMDSv1 is disabled, and you
        /// must use IMDSv2.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public HttpTokensState HttpTokens { get; set; }

        /// <summary>
        /// Checks to see if the HttpTokens property is set.
        /// </summary>
        internal bool IsSetHttpTokens() => this.HttpTokens != null;

        /// <summary>
        /// Gets and sets the property HttpTokensEnforced. 
        /// <para>
        /// Indicates whether to enforce the requirement of IMDSv2 on an instance at the time
        /// of launch. When enforcement is enabled, the instance can't launch unless IMDSv2 (<c>HttpTokens</c>)
        /// is set to <c>required</c>.
        /// </para>
        /// </summary>
        public HttpTokensEnforcedState HttpTokensEnforced { get; set; }

        /// <summary>
        /// Checks to see if the HttpTokensEnforced property is set.
        /// </summary>
        internal bool IsSetHttpTokensEnforced() => this.HttpTokensEnforced != null;

        /// <summary>
        /// Gets and sets the property InstanceMetadataTags. 
        /// <para>
        /// Indicates whether access to instance tags from the instance metadata is enabled or
        /// disabled. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/work-with-tags-in-IMDS.html">View
        /// tags for your EC2 instances using instance metadata</a> in the <i>Amazon EC2 User
        /// Guide</i>.
        /// </para>
        /// </summary>
        public InstanceMetadataTagsState InstanceMetadataTags { get; set; }

        /// <summary>
        /// Checks to see if the InstanceMetadataTags property is set.
        /// </summary>
        internal bool IsSetInstanceMetadataTags() => this.InstanceMetadataTags != null;

        /// <summary>
        /// Gets and sets the property ManagedBy. 
        /// <para>
        /// The entity that manages the IMDS default settings. Possible values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>account</c> - The IMDS default settings are managed by the account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>declarative-policy</c> - The IMDS default settings are managed by a declarative
        /// policy and can't be modified by the account.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ManagedBy ManagedBy { get; set; }

        /// <summary>
        /// Checks to see if the ManagedBy property is set.
        /// </summary>
        internal bool IsSetManagedBy() => this.ManagedBy != null;

        /// <summary>
        /// Gets and sets the property ManagedExceptionMessage. 
        /// <para>
        /// The customized exception message that is specified in the declarative policy.
        /// </para>
        /// </summary>
        public string ManagedExceptionMessage { get; set; }

        /// <summary>
        /// Checks to see if the ManagedExceptionMessage property is set.
        /// </summary>
        internal bool IsSetManagedExceptionMessage() => this.ManagedExceptionMessage != null;
    }
}
