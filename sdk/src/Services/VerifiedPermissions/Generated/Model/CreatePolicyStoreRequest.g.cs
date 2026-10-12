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

namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePolicyStore operation. Creates a policy
    /// store. A policy store is a container for policy resources. <note> <para> As of May
    /// 2026, Verified Permissions has aligned with Cedar and now supports multiple namespaces.
    /// </para> </note> <note> <para> Verified Permissions is <i> <a href="https://wikipedia.org/wiki/Eventual_consistency">eventually
    /// consistent</a> </i>. It can take a few seconds for a new or changed element to propagate
    /// through the service and be visible in the results of other Verified Permissions operations.
    /// </para> </note>
    /// </summary>
    public partial class CreatePolicyStoreRequest : AmazonVerifiedPermissionsRequest
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
        /// the retry fails with an <c>ConflictException</c> error.
        /// </para>
        ///  
        /// <para>
        /// Verified Permissions recognizes a <c>ClientToken</c> for eight hours. After eight
        /// hours, the next request with the same parameters performs the operation again regardless
        /// of the value of <c>ClientToken</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Specifies whether the policy store can be deleted. If enabled, the policy store can't
        /// be deleted.
        /// </para>
        ///  
        /// <para>
        /// The default state is <c>DISABLED</c>.
        /// </para>
        /// </summary>
        public DeletionProtection DeletionProtection { get; set; }

        /// <summary>
        /// Checks to see if the DeletionProtection property is set.
        /// </summary>
        internal bool IsSetDeletionProtection() => this.DeletionProtection != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Descriptive text that you can provide to help with identification of the current policy
        /// store.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 0, Max = 150)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EncryptionSettings. 
        /// <para>
        /// Specifies the encryption settings used to encrypt the policy store and their child
        /// resources. Allows for the ability to use a customer owned KMS key for encryption of
        /// data.
        /// </para>
        ///  
        /// <para>
        /// This is an optional field to be used when providing a customer-managed KMS key for
        /// encryption.
        /// </para>
        /// </summary>
        public EncryptionSettings EncryptionSettings { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionSettings property is set.
        /// </summary>
        internal bool IsSetEncryptionSettings() => this.EncryptionSettings != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of key-value pairs to associate with the policy store.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ValidationSettings. 
        /// <para>
        /// Specifies the validation setting for this policy store.
        /// </para>
        ///  
        /// <para>
        /// Currently, the only valid and required value is <c>Mode</c>.
        /// </para>
        ///  <important> 
        /// <para>
        /// We recommend that you turn on <c>STRICT</c> mode only after you define a schema. If
        /// a schema doesn't exist, then <c>STRICT</c> mode causes any policy to fail validation,
        /// and Verified Permissions rejects the policy. You can turn off validation by using
        /// the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_UpdatePolicyStore">UpdatePolicyStore</a>.
        /// Then, when you have a schema defined, use <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_UpdatePolicyStore">UpdatePolicyStore</a>
        /// again to turn validation back on.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required = true)]
        public ValidationSettings ValidationSettings { get; set; }

        /// <summary>
        /// Checks to see if the ValidationSettings property is set.
        /// </summary>
        internal bool IsSetValidationSettings() => this.ValidationSettings != null;
    }
}
