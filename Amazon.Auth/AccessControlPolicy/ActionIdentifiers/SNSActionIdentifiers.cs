/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Text;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
    /// <summary>
    /// The available AWS access control policy actions for Amazon Simple
    /// Notification Service.
    /// </summary>
    /// <see cref="Amazon.Auth.AccessControlPolicy.Statement.Actions"/>
    public class SNSActionIdentifiers
    {
        /// <summary>
        /// Action for the AddPermission operation on Amazon SNS.
        /// </summary>
        /// <see cref="Amazon.SimpleNotificationService.Model.AddPermissionRequest"/>
        public static readonly ActionIdentifier AddPermission = new ActionIdentifier("sns:AddPermission");

        /// <summary>
        /// Action for the AddPermission operation on Amazon SNS.
        /// </summary>
        /// <see cref="Amazon.SimpleNotificationService.Model.AddPermissionRequest"/>
        public static readonly ActionIdentifier DeleteTopic = new ActionIdentifier("sns:DeleteTopic");

        /// <summary>
        /// Action for the GetTopicAttributes operation on Amazon SNS.
        /// </summary>
        /// <see cref="Amazon.SimpleNotificationService.Model.GetTopicAttributesRequest"/>
        public static readonly ActionIdentifier GetTopicAttributes = new ActionIdentifier("sns:GetTopicAttributes");

        /// <summary>
        /// Action for the ListSubscriptionsByTopic operation on Amazon SNS.
        /// </summary>
        /// <see cref="Amazon.SimpleNotificationService.Model.ListSubscriptionsByTopicRequest"/>
        public static readonly ActionIdentifier ListSubscriptionsByTopic = new ActionIdentifier("sns:ListSubscriptionsByTopic");

        /// <summary>
        /// Action for the Publish operation on Amazon SNS.
        /// </summary>
        /// <see cref="Amazon.SimpleNotificationService.Model.PublishRequest"/>
        public static readonly ActionIdentifier Publish = new ActionIdentifier("sns:Publish");

        /// <summary>
        /// Action for the RemovePermission operation on Amazon SNS.
        /// </summary>
        /// <see cref="Amazon.SimpleNotificationService.Model.RemovePermissionRequest"/>
        public static readonly ActionIdentifier RemovePermission = new ActionIdentifier("sns:RemovePermission");

        /// <summary>
        /// Action for the SetTopicAttributes operation on Amazon SNS.
        /// </summary>
        /// <see cref="Amazon.SimpleNotificationService.Model.SetTopicAttributesRequest"/>
        public static readonly ActionIdentifier SetTopicAttributes = new ActionIdentifier("sns:SetTopicAttributes");

        /// <summary>
        /// Action for the Subscribe operation on Amazon SNS.
        /// </summary>
        /// <see cref="Amazon.SimpleNotificationService.Model.SubscribeRequest"/>
        public static readonly ActionIdentifier Subscribe = new ActionIdentifier("sns:Subscribe");

        private SNSActionIdentifiers() 
        {
        }
    }
}
