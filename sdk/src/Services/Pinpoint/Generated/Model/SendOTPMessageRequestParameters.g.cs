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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Send OTP message request parameters.
    /// </summary>
    public partial class SendOTPMessageRequestParameters
    {
        /// <summary>
        /// Gets and sets the property AllowedAttempts. 
        /// <para>
        /// The attempts allowed to validate an OTP.
        /// </para>
        /// </summary>
        public int? AllowedAttempts { get; set; }

        /// <summary>
        /// Checks to see if the AllowedAttempts property is set.
        /// </summary>
        internal bool IsSetAllowedAttempts() => this.AllowedAttempts.HasValue;

        /// <summary>
        /// Gets and sets the property BrandName. 
        /// <para>
        /// The brand name that will be substituted into the OTP message body. Should be owned
        /// by calling AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BrandName { get; set; }

        /// <summary>
        /// Checks to see if the BrandName property is set.
        /// </summary>
        internal bool IsSetBrandName() => this.BrandName != null;

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// Channel type for the OTP message. Supported values: [SMS].
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Channel { get; set; }

        /// <summary>
        /// Checks to see if the Channel property is set.
        /// </summary>
        internal bool IsSetChannel() => this.Channel != null;

        /// <summary>
        /// Gets and sets the property CodeLength. 
        /// <para>
        /// The number of characters in the generated OTP.
        /// </para>
        /// </summary>
        public int? CodeLength { get; set; }

        /// <summary>
        /// Checks to see if the CodeLength property is set.
        /// </summary>
        internal bool IsSetCodeLength() => this.CodeLength.HasValue;

        /// <summary>
        /// Gets and sets the property DestinationIdentity. 
        /// <para>
        /// The destination identity to send OTP to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DestinationIdentity { get; set; }

        /// <summary>
        /// Checks to see if the DestinationIdentity property is set.
        /// </summary>
        internal bool IsSetDestinationIdentity() => this.DestinationIdentity != null;

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// A unique Entity ID received from DLT after entity registration is approved.
        /// </para>
        /// </summary>
        public string EntityId { get; set; }

        /// <summary>
        /// Checks to see if the EntityId property is set.
        /// </summary>
        internal bool IsSetEntityId() => this.EntityId != null;

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The language to be used for the outgoing message body containing the OTP.
        /// </para>
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// Checks to see if the Language property is set.
        /// </summary>
        internal bool IsSetLanguage() => this.Language != null;

        /// <summary>
        /// Gets and sets the property OriginationIdentity. 
        /// <para>
        /// The origination identity used to send OTP from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OriginationIdentity { get; set; }

        /// <summary>
        /// Checks to see if the OriginationIdentity property is set.
        /// </summary>
        internal bool IsSetOriginationIdentity() => this.OriginationIdentity != null;

        /// <summary>
        /// Gets and sets the property ReferenceId. 
        /// <para>
        /// Developer-specified reference identifier. Required to match during OTP verification.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ReferenceId { get; set; }

        /// <summary>
        /// Checks to see if the ReferenceId property is set.
        /// </summary>
        internal bool IsSetReferenceId() => this.ReferenceId != null;

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// A unique Template ID received from DLT after entity registration is approved.
        /// </para>
        /// </summary>
        public string TemplateId { get; set; }

        /// <summary>
        /// Checks to see if the TemplateId property is set.
        /// </summary>
        internal bool IsSetTemplateId() => this.TemplateId != null;

        /// <summary>
        /// Gets and sets the property ValidityPeriod. 
        /// <para>
        /// The time in minutes before the OTP is no longer valid.
        /// </para>
        /// </summary>
        public int? ValidityPeriod { get; set; }

        /// <summary>
        /// Checks to see if the ValidityPeriod property is set.
        /// </summary>
        internal bool IsSetValidityPeriod() => this.ValidityPeriod.HasValue;
    }
}
