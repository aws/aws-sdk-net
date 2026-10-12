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
    /// Provides information about the specified version of the registration.
    /// </summary>
    public partial class RegistrationVersionInformation
    {
        /// <summary>
        /// Gets and sets the property DeniedReasons. 
        /// <para>
        /// An array of RegistrationDeniedReasonInformation objects. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RegistrationDeniedReasonInformation> DeniedReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<RegistrationDeniedReasonInformation>() : null;

        /// <summary>
        /// Checks to see if the DeniedReasons property is set.
        /// </summary>
        internal bool IsSetDeniedReasons() => this.DeniedReasons != null && (this.DeniedReasons.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Feedback. 
        /// <para>
        /// Generative AI feedback information provided during the registration review process.
        /// This includes comments, suggestions, or additional requirements.
        /// </para>
        /// </summary>
        public string Feedback { get; set; }

        /// <summary>
        /// Checks to see if the Feedback property is set.
        /// </summary>
        internal bool IsSetFeedback() => this.Feedback != null;

        /// <summary>
        /// Gets and sets the property RegistrationVersionStatus. 
        /// <para>
        /// The status of the registration.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>APPROVED</c>: Your registration has been approved.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ARCHIVED</c>: Your previously approved registration version moves into this status
        /// when a more recently submitted version is approved.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DENIED</c>: You must fix your registration and resubmit it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISCARDED</c>: You've abandon this version of their registration to start over
        /// with a new version. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DRAFT</c>: The initial status of a registration version after it’s created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REQUIRES_AUTHENTICATION</c>: You need to complete email authentication.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REVIEWING</c>: Your registration has been accepted and is being reviewed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REVOKED</c>: Your previously approved registration has been revoked.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUBMITTED</c>: Your registration has been submitted.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public RegistrationVersionStatus RegistrationVersionStatus { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationVersionStatus property is set.
        /// </summary>
        internal bool IsSetRegistrationVersionStatus() => this.RegistrationVersionStatus != null;

        /// <summary>
        /// Gets and sets the property RegistrationVersionStatusHistory. 
        /// <para>
        /// The <b>RegistrationVersionStatusHistory</b> object contains the time stamps for when
        /// the reservations status changes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RegistrationVersionStatusHistory RegistrationVersionStatusHistory { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationVersionStatusHistory property is set.
        /// </summary>
        internal bool IsSetRegistrationVersionStatusHistory() => this.RegistrationVersionStatusHistory != null;

        /// <summary>
        /// Gets and sets the property VersionNumber. 
        /// <para>
        /// The version number of the registration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100000)]
        public long? VersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the VersionNumber property is set.
        /// </summary>
        internal bool IsSetVersionNumber() => this.VersionNumber.HasValue;
    }
}
