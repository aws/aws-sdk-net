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
 * Do not modify this file. This file is generated from the snowball-2016-06-30.normal.json service model.
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
namespace Amazon.Snowball.Model
{
    /// <summary>
    /// The Amazon Simple Notification Service (Amazon SNS) notification settings associated
    /// with a specific job. The <c>Notification</c> object is returned as a part of the response
    /// syntax of the <c>DescribeJob</c> action in the <c>JobMetadata</c> data type.
    /// 
    ///  
    /// <para>
    /// When the notification settings are defined during job creation, you can choose to
    /// notify based on a specific set of job states using the <c>JobStatesToNotify</c> array
    /// of strings, or you can specify that you want to have Amazon SNS notifications sent
    /// out for all job states with <c>NotifyAll</c> set to true.
    /// </para>
    /// </summary>
    public partial class Notification
    {
        private string _devicePickupSnsTopicARN;
        private List<string> _jobStatesToNotify = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _notifyAll;
        private string _snsTopicARN;

        /// <summary>
        /// Gets and sets the property DevicePickupSnsTopicARN. 
        /// <para>
        /// Used to send SNS notifications for the person picking up the device (identified during
        /// job creation).
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
        public string DevicePickupSnsTopicARN
        {
            get { return this._devicePickupSnsTopicARN; }
            set { this._devicePickupSnsTopicARN = value; }
        }

        // Check to see if DevicePickupSnsTopicARN property is set
        internal bool IsSetDevicePickupSnsTopicARN()
        {
            return this._devicePickupSnsTopicARN != null;
        }

        /// <summary>
        /// Gets and sets the property JobStatesToNotify. 
        /// <para>
        /// The list of job states that will trigger a notification for this job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> JobStatesToNotify
        {
            get { return this._jobStatesToNotify; }
            set { this._jobStatesToNotify = value; }
        }

        // Check to see if JobStatesToNotify property is set
        internal bool IsSetJobStatesToNotify()
        {
            return this._jobStatesToNotify != null && (this._jobStatesToNotify.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NotifyAll. 
        /// <para>
        /// Any change in job state will trigger a notification for this job.
        /// </para>
        /// </summary>
        public bool? NotifyAll
        {
            get { return this._notifyAll; }
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
        /// The new SNS <c>TopicArn</c> that you want to associate with this job. You can create
        /// Amazon Resource Names (ARNs) for topics by using the <a href="https://docs.aws.amazon.com/sns/latest/api/API_CreateTopic.html">CreateTopic</a>
        /// Amazon SNS API action.
        /// </para>
        ///  
        /// <para>
        /// You can subscribe email addresses to an Amazon SNS topic through the Amazon Web Services
        /// Management Console, or by using the <a href="https://docs.aws.amazon.com/sns/latest/api/API_Subscribe.html">Subscribe</a>
        /// Amazon Simple Notification Service (Amazon SNS) API action.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
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