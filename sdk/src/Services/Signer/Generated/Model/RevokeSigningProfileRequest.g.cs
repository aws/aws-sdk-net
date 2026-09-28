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

namespace Amazon.Signer.Model
{
    /// <summary>
    /// Container for the parameters to the RevokeSigningProfile operation. Changes the state
    /// of a signing profile to <c>REVOKED</c>. This indicates that signatures generated using
    /// the signing profile after an effective start date are no longer valid. A revoked profile
    /// is still viewable with the <c>ListSigningProfiles</c> operation, but it cannot perform
    /// new signing jobs. See <a href="https://docs.aws.amazon.com/signer/latest/developerguide/retention.html">Data
    /// Retention</a> for more information on scheduled deletion of a revoked signing profile.
    /// </summary>
    public partial class RevokeSigningProfileRequest : AmazonSignerRequest
    {
        /// <summary>
        /// Gets and sets the property EffectiveTime. 
        /// <para>
        /// A timestamp for when revocation of a Signing Profile should become effective. Signatures
        /// generated using the signing profile after this timestamp are not trusted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EffectiveTime { get; set; }

        /// <summary>
        /// Checks to see if the EffectiveTime property is set.
        /// </summary>
        internal bool IsSetEffectiveTime() => this.EffectiveTime.HasValue;

        /// <summary>
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// The name of the signing profile to be revoked.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 2, Max = 64)]
        public string ProfileName { get; set; }

        /// <summary>
        /// Checks to see if the ProfileName property is set.
        /// </summary>
        internal bool IsSetProfileName() => this.ProfileName != null;

        /// <summary>
        /// Gets and sets the property ProfileVersion. 
        /// <para>
        /// The version of the signing profile to be revoked.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 10)]
        public string ProfileVersion { get; set; }

        /// <summary>
        /// Checks to see if the ProfileVersion property is set.
        /// </summary>
        internal bool IsSetProfileVersion() => this.ProfileVersion != null;

        /// <summary>
        /// Gets and sets the property Reason. 
        /// <para>
        /// The reason for revoking a signing profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 500)]
        public string Reason { get; set; }

        /// <summary>
        /// Checks to see if the Reason property is set.
        /// </summary>
        internal bool IsSetReason() => this.Reason != null;
    }
}
