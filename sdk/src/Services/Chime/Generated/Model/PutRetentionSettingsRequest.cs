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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
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
    /// Container for the parameters to the PutRetentionSettings operation.
    /// Puts retention settings for the specified Amazon Chime Enterprise account. We recommend
    /// using AWS CloudTrail to monitor usage of this API for your account. For more information,
    /// see <a href="https://docs.aws.amazon.com/chime/latest/ag/cloudtrail.html">Logging
    /// Amazon Chime API Calls with AWS CloudTrail</a> in the <i>Amazon Chime Administration
    /// Guide</i>.
    /// 
    ///  
    /// <para>
    ///  To turn off existing retention settings, remove the number of days from the corresponding
    /// <b>RetentionDays</b> field in the <b>RetentionSettings</b> object. For more information
    /// about retention settings, see <a href="https://docs.aws.amazon.com/chime/latest/ag/chat-retention.html">Managing
    /// Chat Retention Policies</a> in the <i>Amazon Chime Administration Guide</i>.
    /// </para>
    /// </summary>
    public partial class PutRetentionSettingsRequest : AmazonChimeRequest
    {
        private string _accountId;
        private RetentionSettings _retentionSettings;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Chime account ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property RetentionSettings. 
        /// <para>
        /// The retention settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RetentionSettings RetentionSettings
        {
            get { return this._retentionSettings; }
            set { this._retentionSettings = value; }
        }

        // Check to see if RetentionSettings property is set
        internal bool IsSetRetentionSettings()
        {
            return this._retentionSettings != null;
        }

    }
}