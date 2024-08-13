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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
        private int? _allowedAttempts;
        private string _brandName;
        private string _channel;
        private int? _codeLength;
        private string _destinationIdentity;
        private string _entityId;
        private string _language;
        private string _originationIdentity;
        private string _referenceId;
        private string _templateId;
        private int? _validityPeriod;

        /// <summary>
        /// Gets and sets the property AllowedAttempts. 
        /// <para>
        /// The attempts allowed to validate an OTP.
        /// </para>
        /// </summary>
        public int? AllowedAttempts
        {
            get { return this._allowedAttempts; }
            set { this._allowedAttempts = value; }
        }

        // Check to see if AllowedAttempts property is set
        internal bool IsSetAllowedAttempts()
        {
            return this._allowedAttempts.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BrandName. 
        /// <para>
        /// The brand name that will be substituted into the OTP message body. Should be owned
        /// by calling AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BrandName
        {
            get { return this._brandName; }
            set { this._brandName = value; }
        }

        // Check to see if BrandName property is set
        internal bool IsSetBrandName()
        {
            return this._brandName != null;
        }

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// Channel type for the OTP message. Supported values: [SMS].
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Channel
        {
            get { return this._channel; }
            set { this._channel = value; }
        }

        // Check to see if Channel property is set
        internal bool IsSetChannel()
        {
            return this._channel != null;
        }

        /// <summary>
        /// Gets and sets the property CodeLength. 
        /// <para>
        /// The number of characters in the generated OTP.
        /// </para>
        /// </summary>
        public int? CodeLength
        {
            get { return this._codeLength; }
            set { this._codeLength = value; }
        }

        // Check to see if CodeLength property is set
        internal bool IsSetCodeLength()
        {
            return this._codeLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DestinationIdentity. 
        /// <para>
        /// The destination identity to send OTP to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DestinationIdentity
        {
            get { return this._destinationIdentity; }
            set { this._destinationIdentity = value; }
        }

        // Check to see if DestinationIdentity property is set
        internal bool IsSetDestinationIdentity()
        {
            return this._destinationIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property EntityId. 
        /// <para>
        /// A unique Entity ID received from DLT after entity registration is approved.
        /// </para>
        /// </summary>
        public string EntityId
        {
            get { return this._entityId; }
            set { this._entityId = value; }
        }

        // Check to see if EntityId property is set
        internal bool IsSetEntityId()
        {
            return this._entityId != null;
        }

        /// <summary>
        /// Gets and sets the property Language. 
        /// <para>
        /// The language to be used for the outgoing message body containing the OTP.
        /// </para>
        /// </summary>
        public string Language
        {
            get { return this._language; }
            set { this._language = value; }
        }

        // Check to see if Language property is set
        internal bool IsSetLanguage()
        {
            return this._language != null;
        }

        /// <summary>
        /// Gets and sets the property OriginationIdentity. 
        /// <para>
        /// The origination identity used to send OTP from.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OriginationIdentity
        {
            get { return this._originationIdentity; }
            set { this._originationIdentity = value; }
        }

        // Check to see if OriginationIdentity property is set
        internal bool IsSetOriginationIdentity()
        {
            return this._originationIdentity != null;
        }

        /// <summary>
        /// Gets and sets the property ReferenceId. 
        /// <para>
        /// Developer-specified reference identifier. Required to match during OTP verification.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ReferenceId
        {
            get { return this._referenceId; }
            set { this._referenceId = value; }
        }

        // Check to see if ReferenceId property is set
        internal bool IsSetReferenceId()
        {
            return this._referenceId != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// A unique Template ID received from DLT after entity registration is approved.
        /// </para>
        /// </summary>
        public string TemplateId
        {
            get { return this._templateId; }
            set { this._templateId = value; }
        }

        // Check to see if TemplateId property is set
        internal bool IsSetTemplateId()
        {
            return this._templateId != null;
        }

        /// <summary>
        /// Gets and sets the property ValidityPeriod. 
        /// <para>
        /// The time in minutes before the OTP is no longer valid.
        /// </para>
        /// </summary>
        public int? ValidityPeriod
        {
            get { return this._validityPeriod; }
            set { this._validityPeriod = value; }
        }

        // Check to see if ValidityPeriod property is set
        internal bool IsSetValidityPeriod()
        {
            return this._validityPeriod.HasValue; 
        }

    }
}