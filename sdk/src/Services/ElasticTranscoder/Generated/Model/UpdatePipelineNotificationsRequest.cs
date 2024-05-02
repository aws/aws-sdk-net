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
 * Do not modify this file. This file is generated from the elastictranscoder-2012-09-25.normal.json service model.
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
namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePipelineNotifications operation.
    /// With the UpdatePipelineNotifications operation, you can update Amazon Simple Notification
    /// Service (Amazon SNS) notifications for a pipeline.
    /// 
    ///  
    /// <para>
    /// When you update notifications for a pipeline, Elastic Transcoder returns the values
    /// that you specified in the request.
    /// </para>
    /// </summary>
    public partial class UpdatePipelineNotificationsRequest : AmazonElasticTranscoderRequest
    {
        private string _id;
        private Notifications _notifications;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier of the pipeline for which you want to change notification settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Notifications. 
        /// <para>
        /// The topic ARN for the Amazon Simple Notification Service (Amazon SNS) topic that you
        /// want to notify to report job status.
        /// </para>
        ///  <important> 
        /// <para>
        /// To receive notifications, you must also subscribe to the new topic in the Amazon SNS
        /// console.
        /// </para>
        ///  </important> <ul> <li> 
        /// <para>
        ///  <b>Progressing</b>: The topic ARN for the Amazon Simple Notification Service (Amazon
        /// SNS) topic that you want to notify when Elastic Transcoder has started to process
        /// jobs that are added to this pipeline. This is the ARN that Amazon SNS returned when
        /// you created the topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Complete</b>: The topic ARN for the Amazon SNS topic that you want to notify when
        /// Elastic Transcoder has finished processing a job. This is the ARN that Amazon SNS
        /// returned when you created the topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Warning</b>: The topic ARN for the Amazon SNS topic that you want to notify when
        /// Elastic Transcoder encounters a warning condition. This is the ARN that Amazon SNS
        /// returned when you created the topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Error</b>: The topic ARN for the Amazon SNS topic that you want to notify when
        /// Elastic Transcoder encounters an error condition. This is the ARN that Amazon SNS
        /// returned when you created the topic.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public Notifications Notifications
        {
            get { return this._notifications; }
            set { this._notifications = value; }
        }

        // Check to see if Notifications property is set
        internal bool IsSetNotifications()
        {
            return this._notifications != null;
        }

    }
}