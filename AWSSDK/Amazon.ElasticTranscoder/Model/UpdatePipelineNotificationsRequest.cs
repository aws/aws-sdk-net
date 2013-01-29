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
    /// <para>To update Amazon Simple Notification Service (Amazon SNS) notifications for a pipeline, send a POST request to the
    /// <c>/2012-09-25/pipelines/[pipelineId]/notifications</c> resource.</para> <para>When you update notifications for a pipeline, Elastic
    /// Transcoder returns the values that you specified in the request.</para>
    /// </summary>
    /// <seealso cref="Amazon.ElasticTranscoder.AmazonElasticTranscoder.UpdatePipelineNotifications"/>
    public class UpdatePipelineNotificationsRequest : AmazonWebServiceRequest
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

        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">The value to set for the Id property </param>
        /// <returns>this instance</returns>
        public UpdatePipelineNotificationsRequest WithId(string id)
        {
            this.id = id;
            return this;
        }
            

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }

        /// <summary>
        /// The Amazon Simple Notification Service (Amazon SNS) topic that you want to notify to report job status. <important>To receive notifications,
        /// you must also subscribe to the new topic in the Amazon SNS console.</important> <ul> <li><b>Progressing</b>: The Amazon Simple Notification
        /// Service (Amazon SNS) topic that you want to notify when Elastic Transcoder has started to process the job.</li> <li><b>Completed</b>: The
        /// Amazon SNS topic that you want to notify when Elastic Transcoder has finished processing the job.</li> <li><b>Warning</b>: The Amazon SNS
        /// topic that you want to notify when Elastic Transcoder encounters a warning condition.</li> <li><b>Error</b>: The Amazon SNS topic that you
        /// want to notify when Elastic Transcoder encounters an error condition.</li> </ul>
        ///  
        /// </summary>
        public Notifications Notifications
        {
            get { return this.notifications; }
            set { this.notifications = value; }
        }

        /// <summary>
        /// Sets the Notifications property
        /// </summary>
        /// <param name="notifications">The value to set for the Notifications property </param>
        /// <returns>this instance</returns>
        public UpdatePipelineNotificationsRequest WithNotifications(Notifications notifications)
        {
            this.notifications = notifications;
            return this;
        }
            

        // Check to see if Notifications property is set
        internal bool IsSetNotifications()
        {
            return this.notifications != null;
        }
    }
}
    
