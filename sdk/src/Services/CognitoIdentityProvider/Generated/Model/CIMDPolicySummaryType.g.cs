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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// A summary of a Client ID Metadata Document (CIMD) policy, returned by .
    /// </summary>
    public partial class CIMDPolicySummaryType
    {
        /// <summary>
        /// Gets and sets the property CIMDPolicyId. 
        /// <para>
        /// The ID of the CIMD policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string CIMDPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the CIMDPolicyId property is set.
        /// </summary>
        internal bool IsSetCIMDPolicyId() => this.CIMDPolicyId != null;

        /// <summary>
        /// Gets and sets the property CacheDuration. 
        /// <para>
        /// The length of time, in seconds, that Amazon Cognito caches a client metadata document
        /// that it retrieved from a URL that matches the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 86400, Max = 31556952)]
        public int? CacheDuration { get; set; }

        /// <summary>
        /// Checks to see if the CacheDuration property is set.
        /// </summary>
        internal bool IsSetCacheDuration() => this.CacheDuration.HasValue;

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The ID of the app client that the CIMD policy is associated with. Amazon Cognito omits
        /// this value when the app client no longer exists.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 128)]
        public string ClientId { get; set; }

        /// <summary>
        /// Checks to see if the ClientId property is set.
        /// </summary>
        internal bool IsSetClientId() => this.ClientId != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time when the CIMD policy was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedDate. 
        /// <para>
        /// The date and time when the CIMD policy was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedDate { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedDate property is set.
        /// </summary>
        internal bool IsSetLastModifiedDate() => this.LastModifiedDate.HasValue;

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The friendly name of the CIMD policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string PolicyName { get; set; }

        /// <summary>
        /// Checks to see if the PolicyName property is set.
        /// </summary>
        internal bool IsSetPolicyName() => this.PolicyName != null;
    }
}
