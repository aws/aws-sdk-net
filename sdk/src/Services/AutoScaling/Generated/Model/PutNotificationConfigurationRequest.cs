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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the PutNotificationConfiguration operation.
    /// Configures an Auto Scaling group to send notifications when specified events take
    /// place. Subscribers to the specified topic can have messages delivered to an endpoint
    /// such as a web server or an email address.
    /// 
    ///  
    /// <para>
    /// This configuration overwrites any existing configuration.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-sns-notifications.html">Amazon
    /// SNS notification options for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto
    /// Scaling User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If you exceed your maximum limit of SNS topics, which is 10 per Auto Scaling group,
    /// the call fails.
    /// </para>
    /// </summary>
    public partial class PutNotificationConfigurationRequest : AmazonAutoScalingRequest
    {
        private string _autoScalingGroupName;
        private List<string> _notificationTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _topicARN;

        /// <summary>
        /// Gets and sets the property AutoScalingGroupName. 
        /// <para>
        /// The name of the Auto Scaling group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AutoScalingGroupName
        {
            get { return this._autoScalingGroupName; }
            set { this._autoScalingGroupName = value; }
        }

        // Check to see if AutoScalingGroupName property is set
        internal bool IsSetAutoScalingGroupName()
        {
            return this._autoScalingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property NotificationTypes. 
        /// <para>
        /// The type of event that causes the notification to be sent. To query the notification
        /// types supported by Amazon EC2 Auto Scaling, call the <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAutoScalingNotificationTypes.html">DescribeAutoScalingNotificationTypes</a>
        /// API.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> NotificationTypes
        {
            get { return this._notificationTypes; }
            set { this._notificationTypes = value; }
        }

        // Check to see if NotificationTypes property is set
        internal bool IsSetNotificationTypes()
        {
            return this._notificationTypes != null && (this._notificationTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TopicARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string TopicARN
        {
            get { return this._topicARN; }
            set { this._topicARN = value; }
        }

        // Check to see if TopicARN property is set
        internal bool IsSetTopicARN()
        {
            return this._topicARN != null;
        }

    }
}