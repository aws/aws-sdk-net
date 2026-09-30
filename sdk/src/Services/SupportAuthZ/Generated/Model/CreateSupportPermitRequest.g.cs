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

namespace Amazon.SupportAuthZ.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSupportPermit operation. Creates a support
    /// permit that authorizes an AWS support operator to perform specified actions on specified
    /// resources. The permit is cryptographically signed using a customer-managed AWS KMS
    /// key (ECC_NIST_P384, SIGN_VERIFY) to ensure non-repudiation.
    /// </summary>
    public partial class CreateSupportPermitRequest : AmazonSupportAuthZRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the operation completes no more
        /// than one time. If this token matches a previous request, the service returns the existing
        /// permit without creating a duplicate.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable description of why this permit is being created. Maximum length of
        /// 1024 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A customer-chosen name for the support permit. Must be between 1 and 256 alphanumeric
        /// characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Permit. 
        /// <para>
        /// The permit definition specifying the actions, resources, and time-window conditions
        /// that the support operator is authorized to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Permit Permit { get; set; }

        /// <summary>
        /// Checks to see if the Permit property is set.
        /// </summary>
        internal bool IsSetPermit() => this.Permit != null;

        /// <summary>
        /// Gets and sets the property SigningKeyInfo. 
        /// <para>
        /// The signing key information used to sign the permit. Must reference an AWS KMS key
        /// with key usage SIGN_VERIFY and key spec ECC_NIST_P384.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SigningKeyInfo SigningKeyInfo { get; set; }

        /// <summary>
        /// Checks to see if the SigningKeyInfo property is set.
        /// </summary>
        internal bool IsSetSigningKeyInfo() => this.SigningKeyInfo != null;

        /// <summary>
        /// Gets and sets the property SupportCaseDisplayId. 
        /// <para>
        /// The display identifier of the AWS Support case associated with this permit.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string SupportCaseDisplayId { get; set; }

        /// <summary>
        /// Checks to see if the SupportCaseDisplayId property is set.
        /// </summary>
        internal bool IsSetSupportCaseDisplayId() => this.SupportCaseDisplayId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to associate with the support permit on creation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
