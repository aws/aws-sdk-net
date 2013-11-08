/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticTranscoder.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePipelineNotifications operation.
    /// <para>With the UpdatePipelineNotifications operation, you can update Amazon Simple Notification Service (Amazon SNS) notifications for a
    /// pipeline.</para> <para>When you update notifications for a pipeline, Elastic Transcoder returns the values that you specified in the
    /// request.</para>
    /// </summary>
    public partial class UpdatePipelineNotificationsRequest : AmazonElasticTranscoderRequest
    {
        private string id;
        private Notifications notifications;


        /// <summary>
        /// The identifier of the pipeline for which you want to change notification settings.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>^\d{13}-\w{6}$</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }

        /// <summary>
        /// The topic ARN for the Amazon Simple Notification Service (Amazon SNS) topic that you want to notify to report job status. <important>To
        /// receive notifications, you must also subscribe to the new topic in the Amazon SNS console.</important> <ul> <li><b>Progressing</b>: The
        /// topic ARN for the Amazon Simple Notification Service (Amazon SNS) topic that you want to notify when Elastic Transcoder has started to
        /// process jobs that are added to this pipeline. This is the ARN that Amazon SNS returned when you created the topic.</li>
        /// <li><b>Completed</b>: The topic ARN for the Amazon SNS topic that you want to notify when Elastic Transcoder has finished processing a job.
        /// This is the ARN that Amazon SNS returned when you created the topic.</li> <li><b>Warning</b>: The topic ARN for the Amazon SNS topic that
        /// you want to notify when Elastic Transcoder encounters a warning condition. This is the ARN that Amazon SNS returned when you created the
        /// topic.</li> <li><b>Error</b>: The topic ARN for the Amazon SNS topic that you want to notify when Elastic Transcoder encounters an error
        /// condition. This is the ARN that Amazon SNS returned when you created the topic.</li> </ul>
        ///  
        /// </summary>
        public Notifications Notifications
        {
            get { return this.notifications; }
            set { this.notifications = value; }
        }

        // Check to see if Notifications property is set
        internal bool IsSetNotifications()
        {
            return this.notifications != null;
        }

    }
}
    
