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

namespace Amazon.StepFunctions.Model
{
    /// <summary>
    /// Settings to configure server-side encryption. 
    /// 
    ///  
    /// <para>
    ///  For additional control over security, you can encrypt your data using a <b>customer-managed
    /// key</b> for Step Functions state machines and activities. You can configure a symmetric
    /// KMS key and data key reuse period when creating or updating a <b>State Machine</b>,
    /// and when creating an <b>Activity</b>. The execution history and state machine definition
    /// will be encrypted with the key applied to the State Machine. Activity inputs will
    /// be encrypted with the key applied to the Activity. 
    /// </para>
    ///  <note> 
    /// <para>
    ///  Step Functions automatically enables encryption at rest using Amazon Web Services
    /// owned keys at no charge. However, KMS charges apply when using a customer managed
    /// key. For more information about pricing, see <a href="https://aws.amazon.com/kms/pricing/">Key
    /// Management Service pricing</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// For more information on KMS, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/overview.html">What
    /// is Key Management Service?</a> 
    /// </para>
    /// </summary>
    public partial class EncryptionConfiguration
    {
        /// <summary>
        /// Gets and sets the property KmsDataKeyReusePeriodSeconds. 
        /// <para>
        /// Maximum duration that Step Functions will reuse data keys. When the period expires,
        /// Step Functions will call <c>GenerateDataKey</c>. Only applies to customer managed
        /// keys.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 60, Max = 900)]
        public int? KmsDataKeyReusePeriodSeconds { get; set; }

        /// <summary>
        /// Checks to see if the KmsDataKeyReusePeriodSeconds property is set.
        /// </summary>
        internal bool IsSetKmsDataKeyReusePeriodSeconds() => this.KmsDataKeyReusePeriodSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// An alias, alias ARN, key ID, or key ARN of a symmetric encryption KMS key to encrypt
        /// data. To specify a KMS key in a different Amazon Web Services account, you must use
        /// the key ARN or alias ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Encryption type
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EncryptionType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
