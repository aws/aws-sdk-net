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
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
 */

using System;
using System.IO;
using System.Collections.Generic;
using Amazon.Runtime.Resources;
using Amazon.SimpleNotificationService.Model;

namespace Amazon.SimpleNotificationService.Resources.Internal
{

    #region PlatformApplication

    internal class PlatformApplication : Resource<IAmazonSimpleNotificationService>, IPlatformApplication
    {
        public string Arn { get; private set; }

        private Dictionary<string, string> _attributes;
        public Dictionary<string, string> Attributes
        {
            get
            {
                this.CheckIfLoaded();
                return _attributes;
            }
        }

        public PlatformApplication(Model.GetPlatformApplicationAttributesResponse model,
            string arn,
            IAmazonSimpleNotificationService client)
            : base (client)
        {
            this.IsLoaded = true;
            this.Arn = arn;
            CopyFrom(model);
        }

        private void CopyFrom(Model.GetPlatformApplicationAttributesResponse model)
        {
            _attributes = model.Attributes;
        }

      
        protected override void LoadResource()
        {
            var request = new GetPlatformApplicationAttributesRequest();
            request.PlatformApplicationArn = this.Arn;

            var response = this.Client.GetPlatformApplicationAttributes(request);
            this.CopyFrom(response);
        }

        public PlatformApplication(string arn, IAmazonSimpleNotificationService client)
            : base (client)
        {
            this.IsLoaded = false;
            this.Arn = arn;

        }

        #region Actions

        public IPlatformEndpoint CreatePlatformEndpoint(CreatePlatformEndpointRequest request)
        {
            request.PlatformApplicationArn = this.Arn;
            var response = ResourcesUtilities.Invoke(request, this.Client.CreatePlatformEndpoint, "CreatePlatformEndpoint");
            return new Internal.PlatformEndpoint(arn : response.EndpointArn, client : this.Client);
            
        }

        public IPlatformEndpoint CreatePlatformEndpoint(string token)
        {
            var request = new CreatePlatformEndpointRequest();
            request.Token = token;
            return CreatePlatformEndpoint(request);
        }

        public void Delete(DeletePlatformApplicationRequest request)
        {
            request.PlatformApplicationArn = this.Arn;
            ResourcesUtilities.Invoke(request, this.Client.DeletePlatformApplication, "Delete");
        }

        public void Delete()
        {
            var request = new DeletePlatformApplicationRequest();
            Delete(request);
        }

        public void SetAttributes(SetPlatformApplicationAttributesRequest request)
        {
            request.PlatformApplicationArn = this.Arn;
            ResourcesUtilities.Invoke(request, this.Client.SetPlatformApplicationAttributes, "SetAttributes");
        }

        public void SetAttributes(Dictionary<string, string> attributes)
        {
            var request = new SetPlatformApplicationAttributesRequest();
            request.Attributes = attributes;
            SetAttributes(request);
        }

        #endregion

        #region HasMany
        public IEnumerable<IPlatformEndpoint> GetEndpoints(ListEndpointsByPlatformApplicationRequest request)
        {
            request.PlatformApplicationArn = this.Arn;
        
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListEndpointsByPlatformApplicationEnumerator, "Endpoints"))
            {            
                yield return new Internal.PlatformEndpoint(arn : item.EndpointArn, client : this.Client);    
            }

        }

        public IEnumerable<IPlatformEndpoint> GetEndpoints()
        {
            var request = new ListEndpointsByPlatformApplicationRequest();
            return GetEndpoints(request);
        }


        #endregion
    }

    #endregion

    #region PlatformEndpoint

    internal class PlatformEndpoint : Resource<IAmazonSimpleNotificationService>, IPlatformEndpoint
    {
        public string Arn { get; private set; }

        private Dictionary<string, string> _attributes;
        public Dictionary<string, string> Attributes
        {
            get
            {
                this.CheckIfLoaded();
                return _attributes;
            }
        }

        public PlatformEndpoint(Model.GetEndpointAttributesResponse model,
            string arn,
            IAmazonSimpleNotificationService client)
            : base (client)
        {
            this.IsLoaded = true;
            this.Arn = arn;
            CopyFrom(model);
        }

        private void CopyFrom(Model.GetEndpointAttributesResponse model)
        {
            _attributes = model.Attributes;
        }

      
        protected override void LoadResource()
        {
            var request = new GetEndpointAttributesRequest();
            request.EndpointArn = this.Arn;

            var response = this.Client.GetEndpointAttributes(request);
            this.CopyFrom(response);
        }

        public PlatformEndpoint(string arn, IAmazonSimpleNotificationService client)
            : base (client)
        {
            this.IsLoaded = false;
            this.Arn = arn;

        }

        #region Actions

        public void Delete(DeleteEndpointRequest request)
        {
            request.EndpointArn = this.Arn;
            ResourcesUtilities.Invoke(request, this.Client.DeleteEndpoint, "Delete");
        }

        public void Delete()
        {
            var request = new DeleteEndpointRequest();
            Delete(request);
        }

        public PublishResponse Publish(PublishRequest request)
        {
            request.TargetArn = this.Arn;
            var response = ResourcesUtilities.Invoke(request, this.Client.Publish, "Publish");
           return response;
        }

        public PublishResponse Publish(string message, string topicArn)
        {
            var request = new PublishRequest();
            request.Message = message;
            request.TopicArn = topicArn;
            return Publish(request);
        }

        public PublishResponse Publish(string message, string subject, string topicArn)
        {
            var request = new PublishRequest();
            request.Message = message;
            request.Subject = subject;
            request.TopicArn = topicArn;
            return Publish(request);
        }

        public void SetAttributes(SetEndpointAttributesRequest request)
        {
            request.EndpointArn = this.Arn;
            ResourcesUtilities.Invoke(request, this.Client.SetEndpointAttributes, "SetAttributes");
        }

        public void SetAttributes(Dictionary<string, string> attributes)
        {
            var request = new SetEndpointAttributesRequest();
            request.Attributes = attributes;
            SetAttributes(request);
        }

        #endregion

    }

    #endregion

    #region Subscription

    internal class Subscription : Resource<IAmazonSimpleNotificationService>, ISubscription
    {
        public string Arn { get; private set; }

        private Dictionary<string, string> _attributes;
        public Dictionary<string, string> Attributes
        {
            get
            {
                this.CheckIfLoaded();
                return _attributes;
            }
        }

        public Subscription(Model.GetSubscriptionAttributesResponse model,
            string arn,
            IAmazonSimpleNotificationService client)
            : base (client)
        {
            this.IsLoaded = true;
            this.Arn = arn;
            CopyFrom(model);
        }

        private void CopyFrom(Model.GetSubscriptionAttributesResponse model)
        {
            _attributes = model.Attributes;
        }

      
        protected override void LoadResource()
        {
            var request = new GetSubscriptionAttributesRequest();
            request.SubscriptionArn = this.Arn;

            var response = this.Client.GetSubscriptionAttributes(request);
            this.CopyFrom(response);
        }

        public Subscription(string arn, IAmazonSimpleNotificationService client)
            : base (client)
        {
            this.IsLoaded = false;
            this.Arn = arn;

        }

        #region Actions

        public void Delete(UnsubscribeRequest request)
        {
            request.SubscriptionArn = this.Arn;
            ResourcesUtilities.Invoke(request, this.Client.Unsubscribe, "Delete");
        }

        public void Delete()
        {
            var request = new UnsubscribeRequest();
            Delete(request);
        }

        public void SetAttributes(SetSubscriptionAttributesRequest request)
        {
            request.SubscriptionArn = this.Arn;
            ResourcesUtilities.Invoke(request, this.Client.SetSubscriptionAttributes, "SetAttributes");
        }

        public void SetAttributes(string attributeName, string attributeValue)
        {
            var request = new SetSubscriptionAttributesRequest();
            request.AttributeName = attributeName;
            request.AttributeValue = attributeValue;
            SetAttributes(request);
        }

        #endregion

    }

    #endregion

    #region Topic

    internal class Topic : Resource<IAmazonSimpleNotificationService>, ITopic
    {
        public string Arn { get; private set; }

        private Dictionary<string, string> _attributes;
        public Dictionary<string, string> Attributes
        {
            get
            {
                this.CheckIfLoaded();
                return _attributes;
            }
        }

        public Topic(Model.GetTopicAttributesResponse model,
            string arn,
            IAmazonSimpleNotificationService client)
            : base (client)
        {
            this.IsLoaded = true;
            this.Arn = arn;
            CopyFrom(model);
        }

        private void CopyFrom(Model.GetTopicAttributesResponse model)
        {
            _attributes = model.Attributes;
        }

      
        protected override void LoadResource()
        {
            var request = new GetTopicAttributesRequest();
            request.TopicArn = this.Arn;

            var response = this.Client.GetTopicAttributes(request);
            this.CopyFrom(response);
        }

        public Topic(string arn, IAmazonSimpleNotificationService client)
            : base (client)
        {
            this.IsLoaded = false;
            this.Arn = arn;

        }

        #region Actions

        public void AddPermission(AddPermissionRequest request)
        {
            request.TopicArn = this.Arn;
            ResourcesUtilities.Invoke(request, this.Client.AddPermission, "AddPermission");
        }

        public void AddPermission(List<string> actionName, List<string> awsAccountId, string label)
        {
            var request = new AddPermissionRequest();
            request.ActionName = actionName;
            request.AWSAccountId = awsAccountId;
            request.Label = label;
            AddPermission(request);
        }

        public ISubscription ConfirmSubscription(ConfirmSubscriptionRequest request)
        {
            request.TopicArn = this.Arn;
            var response = ResourcesUtilities.Invoke(request, this.Client.ConfirmSubscription, "ConfirmSubscription");
            return new Internal.Subscription(arn : response.SubscriptionArn, client : this.Client);
            
        }

        public ISubscription ConfirmSubscription(string token)
        {
            var request = new ConfirmSubscriptionRequest();
            request.Token = token;
            return ConfirmSubscription(request);
        }

        public ISubscription ConfirmSubscription(string authenticateOnUnsubscribe, string token)
        {
            var request = new ConfirmSubscriptionRequest();
            request.AuthenticateOnUnsubscribe = authenticateOnUnsubscribe;
            request.Token = token;
            return ConfirmSubscription(request);
        }

        public void Delete(DeleteTopicRequest request)
        {
            request.TopicArn = this.Arn;
            ResourcesUtilities.Invoke(request, this.Client.DeleteTopic, "Delete");
        }

        public void Delete()
        {
            var request = new DeleteTopicRequest();
            Delete(request);
        }

        public PublishResponse Publish(PublishRequest request)
        {
            request.TopicArn = this.Arn;
            var response = ResourcesUtilities.Invoke(request, this.Client.Publish, "Publish");
           return response;
        }

        public PublishResponse Publish(string message)
        {
            var request = new PublishRequest();
            request.Message = message;
            return Publish(request);
        }

        public PublishResponse Publish(string message, string subject)
        {
            var request = new PublishRequest();
            request.Message = message;
            request.Subject = subject;
            return Publish(request);
        }

        public void RemovePermission(RemovePermissionRequest request)
        {
            request.TopicArn = this.Arn;
            ResourcesUtilities.Invoke(request, this.Client.RemovePermission, "RemovePermission");
        }

        public void RemovePermission(string label)
        {
            var request = new RemovePermissionRequest();
            request.Label = label;
            RemovePermission(request);
        }

        public void SetAttributes(SetTopicAttributesRequest request)
        {
            request.TopicArn = this.Arn;
            ResourcesUtilities.Invoke(request, this.Client.SetTopicAttributes, "SetAttributes");
        }

        public void SetAttributes(string attributeName, string attributeValue)
        {
            var request = new SetTopicAttributesRequest();
            request.AttributeName = attributeName;
            request.AttributeValue = attributeValue;
            SetAttributes(request);
        }

        public ISubscription Subscribe(SubscribeRequest request)
        {
            request.TopicArn = this.Arn;
            var response = ResourcesUtilities.Invoke(request, this.Client.Subscribe, "Subscribe");
            return new Internal.Subscription(arn : response.SubscriptionArn, client : this.Client);
            
        }

        public ISubscription Subscribe(string endpoint, string protocol)
        {
            var request = new SubscribeRequest();
            request.Endpoint = endpoint;
            request.Protocol = protocol;
            return Subscribe(request);
        }

        #endregion

        #region HasMany
        public IEnumerable<ISubscription> GetSubscriptions(ListSubscriptionsByTopicRequest request)
        {
            request.TopicArn = this.Arn;
        
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListSubscriptionsByTopicEnumerator, "Subscriptions"))
            {            
                yield return new Internal.Subscription(arn : item.SubscriptionArn, client : this.Client);    
            }

        }

        public IEnumerable<ISubscription> GetSubscriptions()
        {
            var request = new ListSubscriptionsByTopicRequest();
            return GetSubscriptions(request);
        }


        #endregion
    }

    #endregion
}