/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// This is the response object from the GetNotificationChannel operation.
    /// </summary>
    public partial class GetNotificationChannelResponse : AmazonWebServiceResponse
    {
        private string _snsRoleName;
        private string _snsTopicArn;

        /// <summary>
        /// Gets and sets the property SnsRoleName. 
        /// <para>
        /// The IAM role that is used by AWS Firewall Manager to record activity to SNS.
        /// </para>
        /// </summary>
        public string SnsRoleName
        {
            get { return this._snsRoleName; }
            set { this._snsRoleName = value; }
        }

        // Check to see if SnsRoleName property is set
        internal bool IsSetSnsRoleName()
        {
            return this._snsRoleName != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// The SNS topic that records AWS Firewall Manager activity. 
        /// </para>
        /// </summary>
        public string SnsTopicArn
        {
            get { return this._snsTopicArn; }
            set { this._snsTopicArn = value; }
        }

        // Check to see if SnsTopicArn property is set
        internal bool IsSetSnsTopicArn()
        {
            return this._snsTopicArn != null;
        }

    }
}