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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Snowball.Model
{
    /// <summary>
    /// The Amazon Simple Notification Service (Amazon SNS) notification settings associated
    /// with a specific job. The <code>Notification</code> object is returned as a part of
    /// the response syntax of the <code>DescribeJob</code> action in the <code>JobMetadata</code>
    /// data type.
    /// 
    ///  
    /// <para>
    /// When the notification settings are defined during job creation, you can choose to
    /// notify based on a specific set of job states using the <code>JobStatesToNotify</code>
    /// array of strings, or you can specify that you want to have Amazon SNS notifications
    /// sent out for all job states with <code>NotifyAll</code> set to true.
    /// </para>
    /// </summary>
    public partial class Notification
    {
        private List<string> _jobStatesToNotify = new List<string>();
        private bool? _notifyAll;
        private string _snsTopicARN;

        /// <summary>
        /// Gets and sets the property JobStatesToNotify. 
        /// <para>
        /// The list of job states that will trigger a notification for this job.
        /// </para>
        /// </summary>
        public List<string> JobStatesToNotify
        {
            get { return this._jobStatesToNotify; }
            set { this._jobStatesToNotify = value; }
        }

        // Check to see if JobStatesToNotify property is set
        internal bool IsSetJobStatesToNotify()
        {
            return this._jobStatesToNotify != null && this._jobStatesToNotify.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NotifyAll. 
        /// <para>
        /// Any change in job state will trigger a notification for this job.
        /// </para>
        /// </summary>
        public bool NotifyAll
        {
            get { return this._notifyAll.GetValueOrDefault(); }
            set { this._notifyAll = value; }
        }

        // Check to see if NotifyAll property is set
        internal bool IsSetNotifyAll()
        {
            return this._notifyAll.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnsTopicARN. 
        /// <para>
        /// The new SNS <code>TopicArn</code> that you want to associate with this job. You can
        /// create Amazon Resource Names (ARNs) for topics by using the <a href="http://docs.aws.amazon.com/sns/latest/api/API_CreateTopic.html">CreateTopic</a>
        /// Amazon SNS API action.
        /// </para>
        ///  
        /// <para>
        /// Note that you can subscribe email addresses to an Amazon SNS topic through the AWS
        /// Management Console, or by using the <a href="http://docs.aws.amazon.com/sns/latest/api/API_Subscribe.html">Subscribe</a>
        /// AWS Simple Notification Service (SNS) API action.
        /// </para>
        /// </summary>
        public string SnsTopicARN
        {
            get { return this._snsTopicARN; }
            set { this._snsTopicARN = value; }
        }

        // Check to see if SnsTopicARN property is set
        internal bool IsSetSnsTopicARN()
        {
            return this._snsTopicARN != null;
        }

    }
}