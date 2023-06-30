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

namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePolicyStore operation.
    /// Creates a policy store. A policy store is a container for policy resources.
    /// 
    ///  <note> 
    /// <para>
    /// Although <a href="https://docs.cedarpolicy.com/schema.html#namespace">Cedar supports
    /// multiple namespaces</a>, Verified Permissions currently supports only one namespace
    /// per policy store.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreatePolicyStoreRequest : AmazonVerifiedPermissionsRequest
    {
        private string _clientToken;
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
        /// If you retry the operation with the same <code>ClientToken</code>, but with different
        /// parameters, the retry fails with an <code>IdempotentParameterMismatch</code> error.
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
        /// Gets and sets the property ValidationSettings. 
        /// <para>
        /// Specifies the validation setting for this policy store.
        /// </para>
        ///  
        /// <para>
        /// Currently, the only valid and required value is <code>Mode</code>.
        /// </para>
        ///  <important> 
        /// <para>
        /// We recommend that you turn on <code>STRICT</code> mode only after you define a schema.
        /// If a schema doesn't exist, then <code>STRICT</code> mode causes any policy to fail
        /// validation, and Verified Permissions rejects the policy. You can turn off validation
        /// by using the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_UpdatePolicyStore">UpdatePolicyStore</a>.
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