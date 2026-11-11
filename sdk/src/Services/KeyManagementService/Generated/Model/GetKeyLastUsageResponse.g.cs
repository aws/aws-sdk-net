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

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// This is the response object from the GetKeyLastUsage operation.
    /// </summary>
    public partial class GetKeyLastUsageResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property KeyCreationDate. 
        /// <para>
        /// The date and time when the KMS key was created.
        /// </para>
        /// </summary>
        public DateTime? KeyCreationDate { get; set; }

        /// <summary>
        /// Checks to see if the KeyCreationDate property is set.
        /// </summary>
        internal bool IsSetKeyCreationDate() => this.KeyCreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// The globally unique identifier for the KMS key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KeyId { get; set; }

        /// <summary>
        /// Checks to see if the KeyId property is set.
        /// </summary>
        internal bool IsSetKeyId() => this.KeyId != null;

        /// <summary>
        /// Gets and sets the property KeyLastUsage. 
        /// <para>
        /// Contains usage information about the last time the KMS key was used for a successful
        /// cryptographic operation. If the key has not been used since tracking began, this response
        /// element is an empty object.
        /// </para>
        /// </summary>
        public KeyLastUsageData KeyLastUsage { get; set; }

        /// <summary>
        /// Checks to see if the KeyLastUsage property is set.
        /// </summary>
        internal bool IsSetKeyLastUsage() => this.KeyLastUsage != null;

        /// <summary>
        /// Gets and sets the property TrackingStartDate. 
        /// <para>
        /// The date from which KMS began recording cryptographic activity for this key, or the
        /// date the KMS key was created, whichever is later.
        /// </para>
        /// </summary>
        public DateTime? TrackingStartDate { get; set; }

        /// <summary>
        /// Checks to see if the TrackingStartDate property is set.
        /// </summary>
        internal bool IsSetTrackingStartDate() => this.TrackingStartDate.HasValue;
    }
}
