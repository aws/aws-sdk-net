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
    /// This is the response object from the DeleteRegistration operation.
    /// </summary>
    public partial class DeleteRegistrationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AdditionalAttributes. 
        /// <para>
        /// Metadata about a given registration which is specific to that registration type.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AdditionalAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the AdditionalAttributes property is set.
        /// </summary>
        internal bool IsSetAdditionalAttributes() => this.AdditionalAttributes != null && (this.AdditionalAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ApprovedVersionNumber. 
        /// <para>
        /// The version number of the registration that was approved.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100000)]
        public long? ApprovedVersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the ApprovedVersionNumber property is set.
        /// </summary>
        internal bool IsSetApprovedVersionNumber() => this.ApprovedVersionNumber.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The time when the registration was created, in <a href="https://www.epochconverter.com/">UNIX
        /// epoch time</a> format.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentVersionNumber. 
        /// <para>
        /// The current version number of the registration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100000)]
        public long? CurrentVersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the CurrentVersionNumber property is set.
        /// </summary>
        internal bool IsSetCurrentVersionNumber() => this.CurrentVersionNumber.HasValue;

        /// <summary>
        /// Gets and sets the property LatestDeniedVersionNumber. 
        /// <para>
        /// The latest version number of the registration that was denied.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100000)]
        public long? LatestDeniedVersionNumber { get; set; }

        /// <summary>
        /// Checks to see if the LatestDeniedVersionNumber property is set.
        /// </summary>
        internal bool IsSetLatestDeniedVersionNumber() => this.LatestDeniedVersionNumber.HasValue;

        /// <summary>
        /// Gets and sets the property RegistrationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the registration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RegistrationArn { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationArn property is set.
        /// </summary>
        internal bool IsSetRegistrationArn() => this.RegistrationArn != null;

        /// <summary>
        /// Gets and sets the property RegistrationId. 
        /// <para>
        /// The unique identifier for the registration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RegistrationId { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationId property is set.
        /// </summary>
        internal bool IsSetRegistrationId() => this.RegistrationId != null;

        /// <summary>
        /// Gets and sets the property RegistrationStatus. 
        /// <para>
        /// The status of the registration.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CLOSED</c>: The phone number or sender ID has been deleted and you must also delete
        /// the registration for the number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATED</c>: Your registration is created but not submitted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COMPLETE</c>: Your registration has been approved and your origination identity
        /// has been created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETED</c>: The registration has been deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PROVISIONING</c>: Your registration has been approved and your origination identity
        /// is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REQUIRES_AUTHENTICATION</c>: You need to complete email authentication.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REQUIRES_UPDATES</c>: You must fix your registration and resubmit it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REVIEWING</c>: Your registration has been accepted and is being reviewed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUBMITTED</c>: Your registration has been submitted and is awaiting review.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public RegistrationStatus RegistrationStatus { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationStatus property is set.
        /// </summary>
        internal bool IsSetRegistrationStatus() => this.RegistrationStatus != null;

        /// <summary>
        /// Gets and sets the property RegistrationType. 
        /// <para>
        /// The type of registration form. The list of <b>RegistrationTypes</b> can be found using
        /// the <a>DescribeRegistrationTypeDefinitions</a> action.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string RegistrationType { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationType property is set.
        /// </summary>
        internal bool IsSetRegistrationType() => this.RegistrationType != null;
    }
}
