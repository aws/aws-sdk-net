/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */

using System;
using System.IO;
using System.Collections.Generic;
using Amazon.Runtime.Resources;
using Amazon.SQS.Model;

namespace Amazon.SQS.Resources.Internal
{

    #region Message

    internal class Message : Resource<IAmazonSQS>, IMessage
    {
        public string QueueUrl { get; private set; }

        public string ReceiptHandle { get; private set; }

        private Dictionary<string, string> _attributes;
        public Dictionary<string, string> Attributes
        {
            get
            {
                this.CheckIfLoaded();
                return _attributes;
            }
        }

        private string _body;
        public string Body
        {
            get
            {
                this.CheckIfLoaded();
                return _body;
            }
        }

        private string _md5OfBody;
        public string MD5OfBody
        {
            get
            {
                this.CheckIfLoaded();
                return _md5OfBody;
            }
        }

        private string _md5OfMessageAttributes;
        public string MD5OfMessageAttributes
        {
            get
            {
                this.CheckIfLoaded();
                return _md5OfMessageAttributes;
            }
        }

        private Dictionary<string, MessageAttributeValue> _messageAttributes;
        public Dictionary<string, MessageAttributeValue> MessageAttributes
        {
            get
            {
                this.CheckIfLoaded();
                return _messageAttributes;
            }
        }

        private string _messageId;
        public string MessageId
        {
            get
            {
                this.CheckIfLoaded();
                return _messageId;
            }
        }

        public Message(Model.Message model,
            string queueUrl,
            IAmazonSQS client)
            : base (client)
        {
            this.IsLoaded = true;
            this.QueueUrl = queueUrl;
            this.ReceiptHandle = model.ReceiptHandle;
            CopyFrom(model);
        }

        private void CopyFrom(Model.Message model)
        {
            _attributes = model.Attributes;
            _body = model.Body;
            _md5OfBody = model.MD5OfBody;
            _md5OfMessageAttributes = model.MD5OfMessageAttributes;
            _messageAttributes = model.MessageAttributes;
            _messageId = model.MessageId;
        }

        public Message(string queueUrl, string receiptHandle, IAmazonSQS client)
            : base (client)
        {
            this.IsLoaded = false;
            this.QueueUrl = queueUrl;
            this.ReceiptHandle = receiptHandle;

        }

        #region Actions

        public void ChangeVisibility(ChangeMessageVisibilityRequest request)
        {
            request.QueueUrl = this.QueueUrl;
            request.ReceiptHandle = this.ReceiptHandle;
            ResourcesUtilities.Invoke(request, this.Client.ChangeMessageVisibility, "ChangeVisibility");
        }

        public void ChangeVisibility(int visibilityTimeout)
        {
            var request = new ChangeMessageVisibilityRequest();
            request.VisibilityTimeout = visibilityTimeout;
            ChangeVisibility(request);
        }

        public void Delete(DeleteMessageRequest request)
        {
            request.QueueUrl = this.QueueUrl;
            request.ReceiptHandle = this.ReceiptHandle;
            ResourcesUtilities.Invoke(request, this.Client.DeleteMessage, "Delete");
        }

        public void Delete()
        {
            var request = new DeleteMessageRequest();
            Delete(request);
        }

        #endregion

    }

    #endregion

    #region Queue

    internal class Queue : Resource<IAmazonSQS>, IQueue
    {
        public string Url { get; private set; }

        private Dictionary<string, string> _attributes;
        public Dictionary<string, string> Attributes
        {
            get
            {
                this.CheckIfLoaded();
                return _attributes;
            }
        }

        public Queue(Model.GetQueueAttributesResult model,
            string url,
            IAmazonSQS client)
            : base (client)
        {
            this.IsLoaded = true;
            this.Url = url;
            CopyFrom(model);
        }

        private void CopyFrom(Model.GetQueueAttributesResult model)
        {
            _attributes = model.Attributes;
        }

        private void CopyFrom(Model.GetQueueAttributesResponse model)
        {
            _attributes = model.Attributes;
        }

      
        protected override void LoadResource()
        {
            var request = new GetQueueAttributesRequest();
            request.QueueUrl = this.Url;
            request.AttributeNames.Add("All");

            var response = this.Client.GetQueueAttributes(request);
            this.CopyFrom(response);
        }

        public Queue(string url, IAmazonSQS client)
            : base (client)
        {
            this.IsLoaded = false;
            this.Url = url;

        }

        #region Actions

        public void AddPermission(AddPermissionRequest request)
        {
            request.QueueUrl = this.Url;
            ResourcesUtilities.Invoke(request, this.Client.AddPermission, "AddPermission");
        }

        public void AddPermission(List<string> actions, List<string> awsAccountIds, string label)
        {
            var request = new AddPermissionRequest();
            request.Actions = actions;
            request.AWSAccountIds = awsAccountIds;
            request.Label = label;
            AddPermission(request);
        }

        public ChangeMessageVisibilityBatchResponse ChangeMessageVisibilityBatch(ChangeMessageVisibilityBatchRequest request)
        {
            request.QueueUrl = this.Url;
            var response = ResourcesUtilities.Invoke(request, this.Client.ChangeMessageVisibilityBatch, "ChangeMessageVisibilityBatch");
           return response;
        }

        public ChangeMessageVisibilityBatchResponse ChangeMessageVisibilityBatch(List<ChangeMessageVisibilityBatchRequestEntry> entries)
        {
            var request = new ChangeMessageVisibilityBatchRequest();
            request.Entries = entries;
            return ChangeMessageVisibilityBatch(request);
        }

        public void Delete(DeleteQueueRequest request)
        {
            request.QueueUrl = this.Url;
            ResourcesUtilities.Invoke(request, this.Client.DeleteQueue, "Delete");
        }

        public void Delete()
        {
            var request = new DeleteQueueRequest();
            Delete(request);
        }

        public DeleteMessageBatchResponse DeleteMessages(DeleteMessageBatchRequest request)
        {
            request.QueueUrl = this.Url;
            var response = ResourcesUtilities.Invoke(request, this.Client.DeleteMessageBatch, "DeleteMessages");
           return response;
        }

        public DeleteMessageBatchResponse DeleteMessages(List<DeleteMessageBatchRequestEntry> entries)
        {
            var request = new DeleteMessageBatchRequest();
            request.Entries = entries;
            return DeleteMessages(request);
        }

        public void Purge(PurgeQueueRequest request)
        {
            request.QueueUrl = this.Url;
            ResourcesUtilities.Invoke(request, this.Client.PurgeQueue, "Purge");
        }

        public void Purge()
        {
            var request = new PurgeQueueRequest();
            Purge(request);
        }

        public IEnumerable<IMessage> ReceiveMessages(ReceiveMessageRequest request)
        {
            request.QueueUrl = this.Url;
            var response = ResourcesUtilities.Invoke(request, this.Client.ReceiveMessage, "ReceiveMessages");
            var items = new List<IMessage>();
            foreach (var item in response.Messages)
            {
                items.Add(new Internal.Message(model : item, queueUrl : this.Url, client : this.Client));
            }
            return items;
        }

        public IEnumerable<IMessage> ReceiveMessages()
        {
            var request = new ReceiveMessageRequest();
            return ReceiveMessages(request);
        }

        public IEnumerable<IMessage> ReceiveMessages(int maxNumberOfMessages)
        {
            var request = new ReceiveMessageRequest();
            request.MaxNumberOfMessages = maxNumberOfMessages;
            return ReceiveMessages(request);
        }

        public void RemovePermission(RemovePermissionRequest request)
        {
            request.QueueUrl = this.Url;
            ResourcesUtilities.Invoke(request, this.Client.RemovePermission, "RemovePermission");
        }

        public void RemovePermission(string label)
        {
            var request = new RemovePermissionRequest();
            request.Label = label;
            RemovePermission(request);
        }

        public SendMessageResponse SendMessage(SendMessageRequest request)
        {
            request.QueueUrl = this.Url;
            var response = ResourcesUtilities.Invoke(request, this.Client.SendMessage, "SendMessage");
           return response;
        }

        public SendMessageResponse SendMessage(string messageBody)
        {
            var request = new SendMessageRequest();
            request.MessageBody = messageBody;
            return SendMessage(request);
        }

        public SendMessageBatchResponse SendMessages(SendMessageBatchRequest request)
        {
            request.QueueUrl = this.Url;
            var response = ResourcesUtilities.Invoke(request, this.Client.SendMessageBatch, "SendMessages");
           return response;
        }

        public SendMessageBatchResponse SendMessages(List<SendMessageBatchRequestEntry> entries)
        {
            var request = new SendMessageBatchRequest();
            request.Entries = entries;
            return SendMessages(request);
        }

        public void SetAttributes(SetQueueAttributesRequest request)
        {
            request.QueueUrl = this.Url;
            ResourcesUtilities.Invoke(request, this.Client.SetQueueAttributes, "SetAttributes");
        }

        public void SetAttributes(Dictionary<string, string> attributes)
        {
            var request = new SetQueueAttributesRequest();
            request.Attributes = attributes;
            SetAttributes(request);
        }

        #endregion

        #region HasMany
        public IEnumerable<IQueue> GetDeadLetterSourceQueues(ListDeadLetterSourceQueuesRequest request)
        {
            request.QueueUrl = this.Url;
        
            var items = new List<IQueue>();
            foreach (var item in ResourcesUtilities.Invoke(request, this.Client.ListDeadLetterSourceQueues, "DeadLetterSourceQueues").QueueUrls)
            {        
                items.Add(new Internal.Queue(url : item, client : this.Client));
            }
            return items;

        }

        public IEnumerable<IQueue> GetDeadLetterSourceQueues()
        {
            var request = new ListDeadLetterSourceQueuesRequest();
            return GetDeadLetterSourceQueues(request);
        }


        #endregion

        #region Subresource

        public IMessage GetMessageByReceiptHandle(string receiptHandle)
        {
            return new Internal.Message(queueUrl : this.Url, receiptHandle : receiptHandle, client : this.Client);
        }

        #endregion
    }

    #endregion
}