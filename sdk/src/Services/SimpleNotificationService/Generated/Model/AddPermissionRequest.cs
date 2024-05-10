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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
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
namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Container for the parameters to the AddPermission operation.
    /// Adds a statement to a topic's access control policy, granting access for the specified
    /// Amazon Web Services accounts to the specified actions.
    /// 
    ///  <note> 
    /// <para>
    /// To remove the ability to change topic permissions, you must deny permissions to the
    /// <c>AddPermission</c>, <c>RemovePermission</c>, and <c>SetTopicAttributes</c> actions
    /// in your IAM policy.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AddPermissionRequest : AmazonSimpleNotificationServiceRequest
    {
        private List<string> _actionName = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _awsAccountId = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _label;
        private string _topicArn;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public AddPermissionRequest() { }

        /// <summary>
        /// Instantiates AddPermissionRequest with the parameterized properties
        /// </summary>
        /// <param name="topicArn">The ARN of the topic whose access control policy you wish to modify.</param>
        /// <param name="label">A unique identifier for the new policy statement.</param>
        /// <param name="awsAccountId">The Amazon Web Services account IDs of the users (principals) who will be given access to the specified actions. The users must have Amazon Web Services account, but do not need to be signed up for this service.</param>
        /// <param name="actionName">The action you want to allow for the specified principal(s). Valid values: Any Amazon SNS action name, for example <c>Publish</c>.</param>
        public AddPermissionRequest(string topicArn, string label, List<string> awsAccountId, List<string> actionName)
        {
            _topicArn = topicArn;
            _label = label;
            _awsAccountId = awsAccountId;
            _actionName = actionName;
        }

        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        /// The action you want to allow for the specified principal(s).
        /// </para>
        ///  
        /// <para>
        /// Valid values: Any Amazon SNS action name, for example <c>Publish</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ActionName
        {
            get { return this._actionName; }
            set { this._actionName = value; }
        }

        // Check to see if ActionName property is set
        internal bool IsSetActionName()
        {
            return this._actionName != null && (this._actionName.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AWSAccountId. 
        /// <para>
        /// The Amazon Web Services account IDs of the users (principals) who will be given access
        /// to the specified actions. The users must have Amazon Web Services account, but do
        /// not need to be signed up for this service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AWSAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AWSAccountId property is set
        internal bool IsSetAWSAccountId()
        {
            return this._awsAccountId != null && (this._awsAccountId.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// A unique identifier for the new policy statement.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

        /// <summary>
        /// Gets and sets the property TopicArn. 
        /// <para>
        /// The ARN of the topic whose access control policy you wish to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TopicArn
        {
            get { return this._topicArn; }
            set { this._topicArn = value; }
        }

        // Check to see if TopicArn property is set
        internal bool IsSetTopicArn()
        {
            return this._topicArn != null;
        }

    }
}