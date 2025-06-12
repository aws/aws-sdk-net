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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
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
    /// Container for the parameters to the CreatePolicyStore operation.
    /// Creates a policy store. A policy store is a container for policy resources.
    /// 
    ///  <note> 
    /// <para>
    /// Although <a href="https://docs.cedarpolicy.com/schema/schema.html#namespace">Cedar
    /// supports multiple namespaces</a>, Verified Permissions currently supports only one
    /// namespace per policy store.
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// Verified Permissions is <i> <a href="https://wikipedia.org/wiki/Eventual_consistency">eventually
    /// consistent</a> </i>. It can take a few seconds for a new or changed element to propagate
    /// through the service and be visible in the results of other Verified Permissions operations.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreatePolicyStoreRequest : AmazonVerifiedPermissionsRequest
    {
        private string _clientToken;
        private DeletionProtection _deletionProtection;
        private string _description;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ValidationSettings _validationSettings;

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
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

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
        public DeletionProtection DeletionProtection
        {
            get { return this._deletionProtection; }
            set { this._deletionProtection = value; }
        }

        // Check to see if DeletionProtection property is set
        internal bool IsSetDeletionProtection()
        {
            return this._deletionProtection != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Descriptive text that you can provide to help with identification of the current policy
        /// store.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=150)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of key-value pairs to associate with the policy store.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        [AWSProperty(Required=true)]
        public ValidationSettings ValidationSettings
        {
            get { return this._validationSettings; }
            set { this._validationSettings = value; }
        }

        // Check to see if ValidationSettings property is set
        internal bool IsSetValidationSettings()
        {
            return this._validationSettings != null;
        }

    }
}