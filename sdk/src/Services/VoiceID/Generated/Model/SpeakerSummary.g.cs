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

namespace Amazon.VoiceID.Model
{
    /// <summary>
    /// Contains a summary of information about a speaker.
    /// </summary>
    public partial class SpeakerSummary
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// A timestamp showing the speaker's creation time. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CustomerSpeakerId. 
        /// <para>
        /// The client-provided identifier for the speaker.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 256)]
        public string CustomerSpeakerId { get; set; }

        /// <summary>
        /// Checks to see if the CustomerSpeakerId property is set.
        /// </summary>
        internal bool IsSetCustomerSpeakerId() => this.CustomerSpeakerId != null;

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// The identifier of the domain that contains the speaker.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 22)]
        public string DomainId { get; set; }

        /// <summary>
        /// Checks to see if the DomainId property is set.
        /// </summary>
        internal bool IsSetDomainId() => this.DomainId != null;

        /// <summary>
        /// Gets and sets the property GeneratedSpeakerId. 
        /// <para>
        /// The service-generated identifier for the speaker. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 25, Max = 25)]
        public string GeneratedSpeakerId { get; set; }

        /// <summary>
        /// Checks to see if the GeneratedSpeakerId property is set.
        /// </summary>
        internal bool IsSetGeneratedSpeakerId() => this.GeneratedSpeakerId != null;

        /// <summary>
        /// Gets and sets the property LastAccessedAt. 
        /// <para>
        /// The timestamp when the speaker was last accessed for enrollment, re-enrollment or
        /// a successful authentication. This timestamp is accurate to one hour.
        /// </para>
        /// </summary>
        public DateTime? LastAccessedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastAccessedAt property is set.
        /// </summary>
        internal bool IsSetLastAccessedAt() => this.LastAccessedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the speaker.
        /// </para>
        /// </summary>
        public SpeakerStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// A timestamp showing the speaker's last update.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
