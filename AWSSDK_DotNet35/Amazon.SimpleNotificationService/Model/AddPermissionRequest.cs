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

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Container for the parameters to the AddPermission operation.
    /// <para>The <c>AddPermission</c> action adds a statement to a topic's access control policy, granting access for the specified AWS accounts to
    /// the specified actions.</para>
    /// </summary>
    public partial class AddPermissionRequest : AmazonSimpleNotificationServiceRequest
    {
        private string topicArn;
        private string label;
        private List<string> aWSAccountId = new List<string>();
        private List<string> actionName = new List<string>();

        /// <summary>
        /// Default constructor for a new AddPermissionRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public AddPermissionRequest() {}
    
        /// <summary>
        /// Constructs a new AddPermissionRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="topicArn"> The ARN of the topic whose access control policy you wish to modify. </param>
        /// <param name="label"> A unique identifier for the new policy statement. </param>
        /// <param name="aWSAccountId"> The AWS account IDs of the users (principals) who will be given access to the specified actions. The users must
        /// have AWS accounts, but do not need to be signed up for this service. </param>
        /// <param name="actionName"> The action you want to allow for the specified principal(s). Valid values: any Amazon SNS action name. </param>
        public AddPermissionRequest(string topicArn, string label, List<string> aWSAccountId, List<string> actionName)
        {
            this.topicArn = topicArn;
            this.label = label;
            this.aWSAccountId = aWSAccountId;
            this.actionName = actionName;
        }
    

        /// <summary>
        /// The ARN of the topic whose access control policy you wish to modify.
        ///  
        /// </summary>
        public string TopicArn
        {
            get { return this.topicArn; }
            set { this.topicArn = value; }
        }

        // Check to see if TopicArn property is set
        internal bool IsSetTopicArn()
        {
            return this.topicArn != null;
        }

        /// <summary>
        /// A unique identifier for the new policy statement.
        ///  
        /// </summary>
        public string Label
        {
            get { return this.label; }
            set { this.label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this.label != null;
        }

        /// <summary>
        /// The AWS account IDs of the users (principals) who will be given access to the specified actions. The users must have AWS accounts, but do
        /// not need to be signed up for this service.
        ///  
        /// </summary>
        public List<string> AWSAccountId
        {
            get { return this.aWSAccountId; }
            set { this.aWSAccountId = value; }
        }

        // Check to see if AWSAccountId property is set
        internal bool IsSetAWSAccountId()
        {
            return this.aWSAccountId.Count > 0;
        }

        /// <summary>
        /// The action you want to allow for the specified principal(s). Valid values: any Amazon SNS action name.
        ///  
        /// </summary>
        public List<string> ActionName
        {
            get { return this.actionName; }
            set { this.actionName = value; }
        }

        // Check to see if ActionName property is set
        internal bool IsSetActionName()
        {
            return this.actionName.Count > 0;
        }

    }
}
    
