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

namespace Amazon.Chime.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateAccountSettings operation. Updates the settings
    /// for the specified Amazon Chime account. You can update settings for remote control
    /// of shared screens, or for the dial-out option. For more information about these settings,
    /// see <a href="https://docs.aws.amazon.com/chime/latest/ag/policies.html">Use the Policies
    /// Page</a> in the <i>Amazon Chime Administration Guide</i>.
    /// </summary>
    public partial class UpdateAccountSettingsRequest : AmazonChimeRequest
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Chime account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AccountSettings. 
        /// <para>
        /// The Amazon Chime account settings to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AccountSettings AccountSettings { get; set; }

        /// <summary>
        /// Checks to see if the AccountSettings property is set.
        /// </summary>
        internal bool IsSetAccountSettings() => this.AccountSettings != null;
    }
}
