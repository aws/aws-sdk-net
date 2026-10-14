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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// The <b>RegistrationVersionStatusHistory</b> object contains the time stamps for when
    /// the reservations status changes.
    /// </summary>
    public partial class RegistrationVersionStatusHistory
    {
        /// <summary>
        /// Gets and sets the property ApprovedTimestamp. 
        /// <para>
        /// The time when the registration was in the approved state, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime? ApprovedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ApprovedTimestamp property is set.
        /// </summary>
        internal bool IsSetApprovedTimestamp() => this.ApprovedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ArchivedTimestamp. 
        /// <para>
        /// The time when the registration was in the archived state, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime? ArchivedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ArchivedTimestamp property is set.
        /// </summary>
        internal bool IsSetArchivedTimestamp() => this.ArchivedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property AwsReviewingTimestamp. 
        /// <para>
        /// The time when the registration was in the AWS reviewing state, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime? AwsReviewingTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the AwsReviewingTimestamp property is set.
        /// </summary>
        internal bool IsSetAwsReviewingTimestamp() => this.AwsReviewingTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property DeniedTimestamp. 
        /// <para>
        /// The time when the registration was in the denied state, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime? DeniedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the DeniedTimestamp property is set.
        /// </summary>
        internal bool IsSetDeniedTimestamp() => this.DeniedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property DiscardedTimestamp. 
        /// <para>
        /// The time when the registration was in the discarded state, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime? DiscardedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the DiscardedTimestamp property is set.
        /// </summary>
        internal bool IsSetDiscardedTimestamp() => this.DiscardedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property DraftTimestamp. 
        /// <para>
        /// The time when the registration was in the draft state, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? DraftTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the DraftTimestamp property is set.
        /// </summary>
        internal bool IsSetDraftTimestamp() => this.DraftTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property RequiresAuthenticationTimestamp. 
        /// <para>
        /// The time when the registration was in the requires authentication state, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime? RequiresAuthenticationTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the RequiresAuthenticationTimestamp property is set.
        /// </summary>
        internal bool IsSetRequiresAuthenticationTimestamp() => this.RequiresAuthenticationTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property ReviewingTimestamp. 
        /// <para>
        /// The time when the registration was in the reviewing state, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime? ReviewingTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the ReviewingTimestamp property is set.
        /// </summary>
        internal bool IsSetReviewingTimestamp() => this.ReviewingTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property RevokedTimestamp. 
        /// <para>
        /// The time when the registration was in the revoked state, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime? RevokedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the RevokedTimestamp property is set.
        /// </summary>
        internal bool IsSetRevokedTimestamp() => this.RevokedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property SubmittedTimestamp. 
        /// <para>
        /// The time when the registration was in the submitted state, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        public DateTime? SubmittedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the SubmittedTimestamp property is set.
        /// </summary>
        internal bool IsSetSubmittedTimestamp() => this.SubmittedTimestamp.HasValue;
    }
}
