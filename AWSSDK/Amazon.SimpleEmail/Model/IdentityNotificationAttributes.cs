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

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// <para>Represents the notification attributes of an identity, including whether a bounce or complaint topic are set, and whether feedback
    /// forwarding is enabled.</para>
    /// </summary>
    public class IdentityNotificationAttributes  
    {
        
        private string bounceTopic;
        private string complaintTopic;
        private bool? forwardingEnabled;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service (SNS) topic where Amazon SES will publish bounce notifications.
        ///  
        /// </summary>
        public string BounceTopic
        {
            get { return this.bounceTopic; }
            set { this.bounceTopic = value; }
        }

        /// <summary>
        /// Sets the BounceTopic property
        /// </summary>
        /// <param name="bounceTopic">The value to set for the BounceTopic property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public IdentityNotificationAttributes WithBounceTopic(string bounceTopic)
        {
            this.bounceTopic = bounceTopic;
            return this;
        }
            

        // Check to see if BounceTopic property is set
        internal bool IsSetBounceTopic()
        {
            return this.bounceTopic != null;       
        }

        /// <summary>
        /// The Amazon Resource Name (ARN) of the Amazon Simple Notification Service (SNS) topic where Amazon SES will publish complaint notifications.
        ///  
        /// </summary>
        public string ComplaintTopic
        {
            get { return this.complaintTopic; }
            set { this.complaintTopic = value; }
        }

        /// <summary>
        /// Sets the ComplaintTopic property
        /// </summary>
        /// <param name="complaintTopic">The value to set for the ComplaintTopic property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public IdentityNotificationAttributes WithComplaintTopic(string complaintTopic)
        {
            this.complaintTopic = complaintTopic;
            return this;
        }
            

        // Check to see if ComplaintTopic property is set
        internal bool IsSetComplaintTopic()
        {
            return this.complaintTopic != null;       
        }

        /// <summary>
        /// Describes whether Amazon SES will forward feedback as email. <c>true</c> indicates that Amazon SES will forward feedback as email, while
        /// <c>false</c> indicates that feedback will be published only to the specified Bounce and Complaint topics.
        ///  
        /// </summary>
        public bool ForwardingEnabled
        {
            get { return this.forwardingEnabled ?? default(bool); }
            set { this.forwardingEnabled = value; }
        }

        /// <summary>
        /// Sets the ForwardingEnabled property
        /// </summary>
        /// <param name="forwardingEnabled">The value to set for the ForwardingEnabled property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public IdentityNotificationAttributes WithForwardingEnabled(bool forwardingEnabled)
        {
            this.forwardingEnabled = forwardingEnabled;
            return this;
        }
            

        // Check to see if ForwardingEnabled property is set
        internal bool IsSetForwardingEnabled()
        {
            return this.forwardingEnabled.HasValue;       
        }
    }
}
