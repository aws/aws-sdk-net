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

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// Container for the parameters to the SendCustomVerificationEmail operation. Adds an
    /// email address to the list of identities for your Amazon SES account in the current
    /// Amazon Web Services Region and attempts to verify it. As a result of executing this
    /// operation, a customized verification email is sent to the specified address. <para>
    /// To use this operation, you must first create a custom verification email template.
    /// For more information about creating and using custom verification email templates,
    /// see <a href="https://docs.aws.amazon.com/ses/latest/dg/creating-identities.html#send-email-verify-address-custom">Using
    /// custom verification email templates</a> in the <i>Amazon SES Developer Guide</i>.
    /// </para> <para> You can execute this operation no more than once per second. </para>
    /// </summary>
    public partial class SendCustomVerificationEmailRequest : AmazonSimpleEmailServiceV2Request
    {
        /// <summary>
        /// Gets and sets the property ConfigurationSetName. 
        /// <para>
        /// Name of a configuration set to use when sending the verification email.
        /// </para>
        /// </summary>
        public string ConfigurationSetName { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationSetName property is set.
        /// </summary>
        internal bool IsSetConfigurationSetName() => this.ConfigurationSetName != null;

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The email address to verify.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the EmailAddress property is set.
        /// </summary>
        internal bool IsSetEmailAddress() => this.EmailAddress != null;

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the custom verification email template to use when sending the verification
        /// email.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string TemplateName { get; set; }

        /// <summary>
        /// Checks to see if the TemplateName property is set.
        /// </summary>
        internal bool IsSetTemplateName() => this.TemplateName != null;
    }
}
