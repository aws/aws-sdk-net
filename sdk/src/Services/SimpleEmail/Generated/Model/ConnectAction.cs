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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
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
namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// When included in a receipt rule, this action parses the received message and starts
    /// an email contact in Amazon Connect on your behalf.
    /// 
    ///  <note> 
    /// <para>
    /// When you receive emails, the maximum email size (including headers) is 40 MB. Additionally,
    /// emails may only have up to 10 attachments. Emails larger than 40 MB or with more than
    /// 10 attachments will be bounced.
    /// </para>
    ///  </note> 
    /// <para>
    /// We recommend that you configure this action via Amazon Connect.
    /// </para>
    /// </summary>
    public partial class ConnectAction
    {
        private string _iamRoleARN;
        private string _instanceARN;

        /// <summary>
        /// Gets and sets the property IAMRoleARN. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the IAM role to be used by Amazon Simple Email
        /// Service while starting email contacts to the Amazon Connect instance. This role should
        /// have permission to invoke <c>connect:StartEmailContact</c> for the given Amazon Connect
        /// instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string IAMRoleARN
        {
            get { return this._iamRoleARN; }
            set { this._iamRoleARN = value; }
        }

        // Check to see if IAMRoleARN property is set
        internal bool IsSetIAMRoleARN()
        {
            return this._iamRoleARN != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the Amazon Connect instance that Amazon SES integrates
        /// with for starting email contacts.
        /// </para>
        ///  
        /// <para>
        /// For more information about Amazon Connect instances, see the <a href="https://docs.aws.amazon.com/connect/latest/adminguide/amazon-connect-instances.html">Amazon
        /// Connect Administrator Guide</a> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceARN
        {
            get { return this._instanceARN; }
            set { this._instanceARN = value; }
        }

        // Check to see if InstanceARN property is set
        internal bool IsSetInstanceARN()
        {
            return this._instanceARN != null;
        }

    }
}