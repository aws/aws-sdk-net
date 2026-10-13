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

namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTrustedTokenIssuer operation. Creates a
    /// connection to a trusted token issuer in an instance of IAM Identity Center. A trusted
    /// token issuer enables trusted identity propagation to be used with applications that
    /// authenticate outside of Amazon Web Services. <para> This trusted token issuer describes
    /// an external identity provider (IdP) that can generate claims or assertions in the
    /// form of access tokens for a user. Applications enabled for IAM Identity Center can
    /// use these tokens for authentication. </para>
    /// </summary>
    public partial class CreateTrustedTokenIssuerRequest : AmazonSSOAdminRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Specifies a unique, case-sensitive ID that you provide to ensure the idempotency of
        /// the request. This lets you safely retry the request without accidentally performing
        /// the same operation a second time. Passing the same value to a later call to an operation
        /// requires that you also pass the same value for all other parameters. We recommend
        /// that you use a <a href="https://wikipedia.org/wiki/Universally_unique_identifier">UUID
        /// type of value.</a>.
        /// </para>
        ///  
        /// <para>
        /// If you don't provide this value, then Amazon Web Services generates a random one for
        /// you.
        /// </para>
        ///  
        /// <para>
        /// If you retry the operation with the same <c>ClientToken</c>, but with different parameters,
        /// the retry fails with an <c>IdempotentParameterMismatch</c> error.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// Specifies the ARN of the instance of IAM Identity Center to contain the new trusted
        /// token issuer configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 1224)]
        public string InstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the InstanceArn property is set.
        /// </summary>
        internal bool IsSetInstanceArn() => this.InstanceArn != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the name of the new trusted token issuer configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies tags to be attached to the new trusted token issuer configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 75)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrustedTokenIssuerConfiguration. 
        /// <para>
        /// Specifies settings that apply to the new trusted token issuer configuration. The settings
        /// that are available depend on what <c>TrustedTokenIssuerType</c> you specify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrustedTokenIssuerConfiguration TrustedTokenIssuerConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TrustedTokenIssuerConfiguration property is set.
        /// </summary>
        internal bool IsSetTrustedTokenIssuerConfiguration() => this.TrustedTokenIssuerConfiguration != null;

        /// <summary>
        /// Gets and sets the property TrustedTokenIssuerType. 
        /// <para>
        /// Specifies the type of the new trusted token issuer.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrustedTokenIssuerType TrustedTokenIssuerType { get; set; }

        /// <summary>
        /// Checks to see if the TrustedTokenIssuerType property is set.
        /// </summary>
        internal bool IsSetTrustedTokenIssuerType() => this.TrustedTokenIssuerType != null;
    }
}
