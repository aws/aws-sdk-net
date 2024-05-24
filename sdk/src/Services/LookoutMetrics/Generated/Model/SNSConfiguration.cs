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
 * Do not modify this file. This file is generated from the lookoutmetrics-2017-07-25.normal.json service model.
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
namespace Amazon.LookoutMetrics.Model
{
    /// <summary>
    /// Contains information about the SNS topic to which you want to send your alerts and
    /// the IAM role that has access to that topic.
    /// </summary>
    public partial class SNSConfiguration
    {
        private string _roleArn;
        private SnsFormat _snsFormat;
        private string _snsTopicArn;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that has access to the target SNS topic.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SnsFormat. 
        /// <para>
        /// The format of the SNS topic.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>JSON</c> – Send JSON alerts with an anomaly ID and a link to the anomaly detail
        /// page. This is the default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LONG_TEXT</c> – Send human-readable alerts with information about the impacted
        /// timeseries and a link to the anomaly detail page. We recommend this for email.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SHORT_TEXT</c> – Send human-readable alerts with a link to the anomaly detail
        /// page. We recommend this for SMS.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SnsFormat SnsFormat
        {
            get { return this._snsFormat; }
            set { this._snsFormat = value; }
        }

        // Check to see if SnsFormat property is set
        internal bool IsSetSnsFormat()
        {
            return this._snsFormat != null;
        }

        /// <summary>
        /// Gets and sets the property SnsTopicArn. 
        /// <para>
        /// The ARN of the target SNS topic.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
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