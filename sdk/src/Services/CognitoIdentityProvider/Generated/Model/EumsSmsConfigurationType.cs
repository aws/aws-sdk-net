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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
    /// The configuration that Amazon Cognito uses to send SMS messages through Amazon Web
    /// Services End User Messaging SMS. Provide this structure in the <c>EumsSms</c> member
    /// of <c>SmsConfigurationType</c> to use Amazon Web Services End User Messaging SMS instead
    /// of Amazon SNS.
    /// </summary>
    public partial class EumsSmsConfigurationType
    {
        private string _callerArn;
        private string _configurationSetName;
        private string _externalId;
        private string _inEntityId;
        private string _inTemplateId;
        private string _originationIdentity;
        private string _region;

        /// <summary>
        /// Gets and sets the property CallerArn. 
        /// <para>
        /// The ARN of the IAM role that Amazon Cognito assumes to send SMS messages through Amazon
        /// Web Services End User Messaging SMS. The role must grant permission to call the <c>sms-voice:SendTextMessage</c>
        /// operation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string CallerArn
        {
            get { return this._callerArn; }
            set { this._callerArn = value; }
        }

        // Check to see if CallerArn property is set
        internal bool IsSetCallerArn()
        {
            return this._callerArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// The name of the Amazon Web Services End User Messaging SMS configuration set that
        /// Amazon Cognito applies to messages, for logging and event destinations. If you omit
        /// this member, Amazon Cognito sends messages without applying a configuration set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=131072)]
        public string ConfigurationSetName
        {
            get { return this._configurationSetName; }
            set { this._configurationSetName = value; }
        }

        // Check to see if ConfigurationSetName property is set
        internal bool IsSetConfigurationSetName()
        {
            return this._configurationSetName != null;
        }

        /// <summary>
        /// Gets and sets the property ExternalId. 
        /// <para>
        /// The external ID that Amazon Cognito includes when it assumes the <c>CallerArn</c>
        /// role. Use this value as a condition in the role trust policy to prevent the confused
        /// deputy problem.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=131072)]
        public string ExternalId
        {
            get { return this._externalId; }
            set { this._externalId = value; }
        }

        // Check to see if ExternalId property is set
        internal bool IsSetExternalId()
        {
            return this._externalId != null;
        }

        /// <summary>
        /// Gets and sets the property InEntityId. 
        /// <para>
        /// The principal entity ID required by India's Distributed Ledger Technology (DLT) regulations
        /// for SMS messages.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=131072)]
        public string InEntityId
        {
            get { return this._inEntityId; }
            set { this._inEntityId = value; }
        }

        // Check to see if InEntityId property is set
        internal bool IsSetInEntityId()
        {
            return this._inEntityId != null;
        }

        /// <summary>
        /// Gets and sets the property InTemplateId. 
        /// <para>
        /// The registered template ID for the message template required by India's DLT regulations
        /// for SMS messages.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=131072)]
        public string InTemplateId
        {
            get { return this._inTemplateId; }
            set { this._inTemplateId = value; }
        }

        // Check to see if InTemplateId property is set
        internal bool IsSetInTemplateId()
        {
            return this._inTemplateId != null;
        }

        /// <summary>
        /// Gets and sets the property OriginationIdentity. 
        /// <para>
        /// The origination identity that Amazon Web Services End User Messaging SMS uses to send
        /// messages to your users. This value can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A phone number – A long code, toll-free number, or short code that is assigned to
        /// your account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A sender ID – An alphabetic name that identifies the message sender in supported countries.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A phone pool – A group of phone numbers that Amazon Web Services End User Messaging
        /// SMS selects from when it sends messages.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can provide an E.164 phone number or the ARN of the phone number, sender ID, or
        /// phone pool. Amazon Web Services End User Messaging SMS evaluates IAM authorization
        /// with the value that you provide. If the permissions policy of your <c>CallerArn</c>
        /// role scopes the <c>sms-voice:SendTextMessage</c> resource to a specific ARN, provide
        /// that same ARN. If the formats do not match, requests fail with an <c>InvalidSmsRoleAccessPolicyException</c>.
        /// </para>
        ///  
        /// <para>
        /// Depending on the destination country, you must provide an origination identity. For
        /// country-specific requirements, see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/phone-numbers-sms-by-country.html">Supported
        /// countries and regions for SMS messaging</a> in the Amazon Web Services End User Messaging
        /// SMS User Guide.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=131072)]
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
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region of the Amazon Web Services End User Messaging SMS resources
        /// that Amazon Cognito uses to send messages. Amazon Web Services End User Messaging
        /// SMS must be available in your user pool's Region.
        /// </para>
        ///  
        /// <para>
        /// If you omit this parameter, Amazon Cognito uses the same Region as your user pool.
        /// You can also set this parameter to your user pool's Region explicitly. Amazon Cognito
        /// rejects any other value with an <c>InvalidParameterException</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=32)]
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

    }
}