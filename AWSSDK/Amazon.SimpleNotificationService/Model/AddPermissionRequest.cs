/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2010-03-31
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Adds a statement to a topic's access control policy, granting access for the specified AWS accounts to the specified actions.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://sns.amazonaws.com/doc/2010-03-31/", IsNullable = false)]
    public class AddPermissionRequest : SNSRequest
    {    
        private string topicArnField;
        private string labelField;
        private List<string> AWSAccountIdsField;
        private List<string> actionNamesField;

        /// <summary>
        /// The ARN of the topic whose access control policy you wish to modify.
        /// </summary>
        [XmlElementAttribute(ElementName = "TopicArn")]
        public string TopicArn
        {
            get { return this.topicArnField; }
            set { this.topicArnField = value; }
        }

        /// <summary>
        /// Sets the ARN of the topic whose access control policy you wish to modify.
        /// </summary>
        /// <param name="topicArn">The ARN of the topic whose access control policy you wish to modify.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AddPermissionRequest WithTopicArn(string topicArn)
        {
            this.topicArnField = topicArn;
            return this;
        }

        /// <summary>
        /// Checks if TopicArn property is set
        /// </summary>
        /// <returns>true if TopicArn property is set</returns>
        public bool IsSetTopicArn()
        {
            return this.topicArnField != null;
        }

        /// <summary>
        /// A unique identifier for the new policy statement.
        /// </summary>
        [XmlElementAttribute(ElementName = "Label")]
        public string Label
        {
            get { return this.labelField; }
            set { this.labelField = value; }
        }

        /// <summary>
        /// Sets the unique identifier for the new policy statement.
        /// </summary>
        /// <param name="label">A unique identifier for the new policy statement.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AddPermissionRequest WithLabel(string label)
        {
            this.labelField = label;
            return this;
        }

        /// <summary>
        /// Checks if Label property is set
        /// </summary>
        /// <returns>true if Label property is set</returns>
        public bool IsSetLabel()
        {
            return this.labelField != null;
        }

        /// <summary>
        /// The AWS account IDs of the users (principals) who will be given access to the specified actions.
        /// </summary>
        /// <remarks>
        /// The users must have AWS accounts, but do not need to be signed up for this service.
        /// </remarks>
        [XmlElementAttribute(ElementName = "AWSAccountIds")]
        public List<string> AWSAccountIds
        {
            get
            {
                if (this.AWSAccountIdsField == null)
                {
                    this.AWSAccountIdsField = new List<string>();
                }
                return this.AWSAccountIdsField;
            }
            set { this.AWSAccountIdsField = value; }
        }

        /// <summary>
        /// Sets the AWS account IDs of the users (principals) who will be given access to the specified actions.
        /// </summary>
        /// <param name="list">The AWS account IDs of the users (principals) who will be given access to the specified
        /// actions.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AddPermissionRequest WithAWSAccountIds(params string[] list)
        {
            foreach (string item in list)
            {
                AWSAccountIds.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if AWSAccountIds property is set
        /// </summary>
        /// <returns>true if AWSAccountIds property is set</returns>
        public bool IsSetAWSAccountIds()
        {
            return (AWSAccountIds.Count > 0);
        }

        /// <summary>
        /// The action you want to allow for the specified principal(s).
        /// </summary>
        /// <remarks>
		/// Valid values: any Amazon SNS action name. Go to the 
		/// <a href="http://docs.amazonwebservices.com/sns/latest/api/API_Operations.html">Amazon SNS API docs</a> for a list of action names.
        /// </remarks>
        [XmlElementAttribute(ElementName = "ActionNames")]
        public List<string> ActionNames
        {
            get
            {
                if (this.actionNamesField == null)
                {
                    this.actionNamesField = new List<string>();
                }
                return this.actionNamesField;
            }
            set { this.actionNamesField = value; }
        }

        /// <summary>
        /// Sets the action you want to allow for the specified principal(s).
        /// </summary>
        /// <param name="list">The action you want to allow for the specified principal(s).</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AddPermissionRequest WithActionNames(params string[] list)
        {
            foreach (string item in list)
            {
                ActionNames.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if ActionNames property is set
        /// </summary>
        /// <returns>true if ActionNames property is set</returns>
        public bool IsSetActionNames()
        {
            return (ActionNames.Count > 0);
        }

    }
}
