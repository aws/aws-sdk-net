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
 *  API Version: 2012-11-05
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// Adds the specified permission(s) to a queue for the specified principal(s).
    /// </summary>
    /// <remarks>
    /// This allows for sharing access to the queue.
    /// </remarks>
    [XmlRootAttribute(Namespace = "http://queue.amazonaws.com/doc/2012-11-05/", IsNullable = false)]
    public class AddPermissionRequest : SQSRequest
    {    
        private string queueUrlField;
        private string labelField;
        private List<string> AWSAccountIdField;
        private List<string> actionNameField;

        /// <summary>
        /// The URL associated with the Amazon SQS queue.
        /// </summary>
        [XmlElementAttribute(ElementName = "QueueUrl")]
        public string QueueUrl
        {
            get { return this.queueUrlField; }
            set { this.queueUrlField = value; }
        }

        /// <summary>
        /// Sets the URL associated with the Amazon SQS queue.
        /// </summary>
        /// <param name="queueUrl">The URL associated with the Amazon SQS queue.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AddPermissionRequest WithQueueUrl(string queueUrl)
        {
            this.queueUrlField = queueUrl;
            return this;
        }

        /// <summary>
        /// Checks if QueueUrl property is set
        /// </summary>
        /// <returns>true if QueueUrl property is set</returns>
        public bool IsSetQueueUrl()
        {
            return this.queueUrlField != null;
        }

        /// <summary>
        /// The unique identification of the permission you're setting.
        /// <remarks>
        /// Maximum 80 characters; alphanumeric characters, hyphens (-), and underscores (_) are allowed.
        /// </remarks>
        /// </summary>
        [XmlElementAttribute(ElementName = "Label")]
        public string Label
        {
            get { return this.labelField; }
            set { this.labelField = value; }
        }

        /// <summary>
        /// Sets the unique identification of the permission you're setting.
        /// <remarks>
        /// Maximum 80 characters; alphanumeric characters, hyphens (-), and underscores (_) are allowed.
        /// </remarks>
        /// </summary>
        /// <param name="label">The unique identification of the permission you're setting.</param>
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
        /// The AWS account number of the principal who will be given permission.
        /// </summary>
        /// <remarks>
        /// The principal must have an AWS account, but does not need to be signed up for Amazon SQS.
        /// </remarks>
        [XmlElementAttribute(ElementName = "AWSAccountId")]
        public List<string> AWSAccountId
        {
            get
            {
                if (this.AWSAccountIdField == null)
                {
                    this.AWSAccountIdField = new List<string>();
                }
                return this.AWSAccountIdField;
            }
            set { this.AWSAccountIdField = value; }
        }

        /// <summary>
        /// Set the AWS account number of the principal who will be given permission.
        /// </summary>
        /// <remarks>
        /// The principal must have an AWS account, but does not need to be signed up for Amazon SQS.
        /// </remarks>
        /// <param name="list">The AWS account number of the principal who will be given permission.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AddPermissionRequest WithAWSAccountId(params string[] list)
        {
            foreach (string item in list)
            {
                AWSAccountId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if AWSAccountId property is set
        /// </summary>
        /// <returns>true if AWSAccountId property is set</returns>
        public bool IsSetAWSAccountId()
        {
            return (AWSAccountId.Count > 0);
        }

        /// <summary>
        /// The action you want to allow for the specified principal.
        /// Valid values are: * | SendMessage | ReceiveMessage | DeleteMessage | ChangeMessageVisibility | GetQueueAttributes
        /// </summary>
        /// <remarks>
        /// For more information about these actions, see Understanding Permissions in the Amazon SQS Developer Guide.
        /// </remarks>
        [XmlElementAttribute(ElementName = "ActionName")]
        public List<string> ActionName
        {
            get
            {
                if (this.actionNameField == null)
                {
                    this.actionNameField = new List<string>();
                }
                return this.actionNameField;
            }
            set { this.actionNameField = value; }
        }

        /// <summary>
        /// Sets the action you want to allow for the specified principal.
        /// Valid values are: * | SendMessage | ReceiveMessage | DeleteMessage | ChangeMessageVisibility | GetQueueAttributes
        /// </summary>
        /// <remarks>
        /// For more information about these actions, see Understanding Permissions in the Amazon SQS Developer Guide.
        /// </remarks>
        /// <param name="list">The action you want to allow for the specified principal.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public AddPermissionRequest WithActionName(params string[] list)
        {
            foreach (string item in list)
            {
                ActionName.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if ActionName property is set
        /// </summary>
        /// <returns>true if ActionName property is set</returns>
        public bool IsSetActionName()
        {
            return (ActionName.Count > 0);
        }

    }
}
