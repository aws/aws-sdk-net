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
    /// The available AWS access control policy actions for Amazon Simple Queue
    /// Service.
    /// </summary>
    /// <see cref="Amazon.Auth.AccessControlPolicy.Statement.Actions"/>
    public class SQSActionIdentifiers
    {
        /// <summary>
        /// Represents any action being taken on Amazon SQS.
        /// </summary>
        public static readonly ActionIdentifier AllSqsActions = new ActionIdentifier("sqs:*");

        /// <summary>
        /// Action for the AddPermission operation on Amazon SQS.
        /// </summary>
        /// <see cref="Amazon.SQS.Model.AddPermissionRequest"/>
        public static readonly ActionIdentifier AddPermission = new ActionIdentifier("sqs:AddPermission");

        /// <summary>
        /// Action for the ChangeMessageVisibility operation on Amazon SQS.
        /// </summary>
        /// <see cref="Amazon.SQS.Model.ChangeMessageVisibilityRequest"/>
        public static readonly ActionIdentifier ChangeMessageVisibility = new ActionIdentifier("sqs:ChangeMessageVisibility");

        /// <summary>
        /// Action for the CreateQueue operation on Amazon SQS.
        /// </summary>
        /// <see cref="Amazon.SQS.Model.CreateQueueRequest"/>
        public static readonly ActionIdentifier CreateQueue = new ActionIdentifier("sqs:CreateQueue");

        /// <summary>
        /// Action for the DeleteMessage operation on Amazon SQS.
        /// </summary>
        /// <see cref="Amazon.SQS.Model.DeleteMessageRequest"/>
        public static readonly ActionIdentifier DeleteMessage = new ActionIdentifier("sqs:DeleteMessage");

        /// <summary>
        /// Action for the DeleteQueue operation on Amazon SQS.
        /// </summary>
        /// <see cref="Amazon.SQS.Model.DeleteQueueRequest"/>
        public static readonly ActionIdentifier DeleteQueue = new ActionIdentifier("sqs:DeleteQueue");

        /// <summary>
        /// Action for the GetQueueAttributes operation on Amazon SQS.
        /// </summary>
        /// <see cref="Amazon.SQS.Model.GetQueueAttributesRequest"/>
        public static readonly ActionIdentifier GetQueueAttributes = new ActionIdentifier("sqs:GetQueueAttributes");

        /// <summary>
        /// Action for the ListQueues operation on Amazon SQS.
        /// </summary>
        /// <see cref="Amazon.SQS.Model.ListQueuesRequest"/>
        public static readonly ActionIdentifier ListQueues = new ActionIdentifier("sqs:ListQueues");

        /// <summary>
        /// Action for the ReceiveMessage operation on Amazon SQS.
        /// </summary>
        /// <see cref="Amazon.SQS.Model.ReceiveMessageRequest"/>
        public static readonly ActionIdentifier ReceiveMessage = new ActionIdentifier("sqs:ReceiveMessage");

        /// <summary>
        /// Action for the RemovePermission operation on Amazon SQS.
        /// </summary>
        /// <see cref="Amazon.SQS.Model.RemovePermissionRequest"/>
        public static readonly ActionIdentifier RemovePermission = new ActionIdentifier("sqs:RemovePermission");

        /// <summary>
        /// Action for the SendMessage operation on Amazon SQS.
        /// </summary>
        /// <see cref="Amazon.SQS.Model.SendMessageRequest"/>
        public static readonly ActionIdentifier SendMessage = new ActionIdentifier("sqs:SendMessage");

        /// <summary>
        /// Action for the SetQueueAttributes operation on Amazon SQS.
        /// </summary>
        /// <see cref="Amazon.SQS.Model.SetQueueAttributesRequest"/>
        public static readonly ActionIdentifier SetQueueAttributes = new ActionIdentifier("sqs:SetQueueAttributes");

        private SQSActionIdentifiers() 
        {
        }
    }
}
