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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */

using System;
using System.IO;
using System.Collections.Generic;
using Amazon.Runtime.Resources;
using Amazon.CloudFormation.Model;

namespace Amazon.CloudFormation.Resources.Internal
{

    #region Event

    internal class Event : Resource<IAmazonCloudFormation>, IEvent
    {
        public string Id { get; private set; }

        private string _logicalResourceId;
        public string LogicalResourceId
        {
            get
            {
                this.CheckIfLoaded();
                return _logicalResourceId;
            }
        }

        private string _physicalResourceId;
        public string PhysicalResourceId
        {
            get
            {
                this.CheckIfLoaded();
                return _physicalResourceId;
            }
        }

        private string _resourceProperties;
        public string ResourceProperties
        {
            get
            {
                this.CheckIfLoaded();
                return _resourceProperties;
            }
        }

        private ResourceStatus _resourceStatus;
        public ResourceStatus ResourceStatus
        {
            get
            {
                this.CheckIfLoaded();
                return _resourceStatus;
            }
        }

        private string _resourceStatusReason;
        public string ResourceStatusReason
        {
            get
            {
                this.CheckIfLoaded();
                return _resourceStatusReason;
            }
        }

        private string _resourceType;
        public string ResourceType
        {
            get
            {
                this.CheckIfLoaded();
                return _resourceType;
            }
        }

        private string _stackId;
        public string StackId
        {
            get
            {
                this.CheckIfLoaded();
                return _stackId;
            }
        }

        private string _stackName;
        public string StackName
        {
            get
            {
                this.CheckIfLoaded();
                return _stackName;
            }
        }

        private DateTime _timestamp;
        public DateTime Timestamp
        {
            get
            {
                this.CheckIfLoaded();
                return _timestamp;
            }
        }

        public Event(Model.StackEvent model,
            IAmazonCloudFormation client)
            : base (client)
        {
            this.IsLoaded = true;
            this.Id = model.EventId;
            CopyFrom(model);
        }

        private void CopyFrom(Model.StackEvent model)
        {
            _logicalResourceId = model.LogicalResourceId;
            _physicalResourceId = model.PhysicalResourceId;
            _resourceProperties = model.ResourceProperties;
            _resourceStatus = model.ResourceStatus;
            _resourceStatusReason = model.ResourceStatusReason;
            _resourceType = model.ResourceType;
            _stackId = model.StackId;
            _stackName = model.StackName;
            _timestamp = model.Timestamp;
        }

        public Event(string id, IAmazonCloudFormation client)
            : base (client)
        {
            this.IsLoaded = false;
            this.Id = id;

        }

        #region Actions

        #endregion

    }

    #endregion

    #region Stack

    internal class Stack : Resource<IAmazonCloudFormation>, IStack
    {
        public string Name { get; private set; }

        private List<string> _capabilities;
        public List<string> Capabilities
        {
            get
            {
                this.CheckIfLoaded();
                return _capabilities;
            }
        }

        private DateTime _creationTime;
        public DateTime CreationTime
        {
            get
            {
                this.CheckIfLoaded();
                return _creationTime;
            }
        }

        private string _description;
        public string Description
        {
            get
            {
                this.CheckIfLoaded();
                return _description;
            }
        }

        private bool _disableRollback;
        public bool DisableRollback
        {
            get
            {
                this.CheckIfLoaded();
                return _disableRollback;
            }
        }

        private DateTime _lastUpdatedTime;
        public DateTime LastUpdatedTime
        {
            get
            {
                this.CheckIfLoaded();
                return _lastUpdatedTime;
            }
        }

        private List<string> _notificationARNs;
        public List<string> NotificationARNs
        {
            get
            {
                this.CheckIfLoaded();
                return _notificationARNs;
            }
        }

        private List<Output> _outputs;
        public List<Output> Outputs
        {
            get
            {
                this.CheckIfLoaded();
                return _outputs;
            }
        }

        private List<Parameter> _parameters;
        public List<Parameter> Parameters
        {
            get
            {
                this.CheckIfLoaded();
                return _parameters;
            }
        }

        private string _stackId;
        public string StackId
        {
            get
            {
                this.CheckIfLoaded();
                return _stackId;
            }
        }

        private StackStatus _stackStatus;
        public StackStatus StackStatus
        {
            get
            {
                this.CheckIfLoaded();
                return _stackStatus;
            }
        }

        private string _stackStatusReason;
        public string StackStatusReason
        {
            get
            {
                this.CheckIfLoaded();
                return _stackStatusReason;
            }
        }

        private List<Tag> _tags;
        public List<Tag> Tags
        {
            get
            {
                this.CheckIfLoaded();
                return _tags;
            }
        }

        private int _timeoutInMinutes;
        public int TimeoutInMinutes
        {
            get
            {
                this.CheckIfLoaded();
                return _timeoutInMinutes;
            }
        }

        public Stack(Model.Stack model,
            IAmazonCloudFormation client)
            : base (client)
        {
            this.IsLoaded = true;
            this.Name = model.StackName;
            CopyFrom(model);
        }

        private void CopyFrom(Model.Stack model)
        {
            _capabilities = model.Capabilities;
            _creationTime = model.CreationTime;
            _description = model.Description;
            _disableRollback = model.DisableRollback;
            _lastUpdatedTime = model.LastUpdatedTime;
            _notificationARNs = model.NotificationARNs;
            _outputs = model.Outputs;
            _parameters = model.Parameters;
            _stackId = model.StackId;
            _stackStatus = model.StackStatus;
            _stackStatusReason = model.StackStatusReason;
            _tags = model.Tags;
            _timeoutInMinutes = model.TimeoutInMinutes;
        }

      
        protected override void LoadResource()
        {
            var request = new DescribeStacksRequest();
            request.StackName = this.Name;

            var response = this.Client.DescribeStacks(request);
            this.CopyFrom(response.Stacks[0]);
        }

        public Stack(string name, IAmazonCloudFormation client)
            : base (client)
        {
            this.IsLoaded = false;
            this.Name = name;

        }

        #region Actions

        public void CancelUpdate(CancelUpdateStackRequest request)
        {
            request.StackName = this.Name;
            ResourcesUtilities.Invoke(request, this.Client.CancelUpdateStack, "CancelUpdate");
        }

        public void CancelUpdate()
        {
            var request = new CancelUpdateStackRequest();
            CancelUpdate(request);
         }

        public void Delete(DeleteStackRequest request)
        {
            request.StackName = this.Name;
            ResourcesUtilities.Invoke(request, this.Client.DeleteStack, "Delete");
        }

        public void Delete()
        {
            var request = new DeleteStackRequest();
            Delete(request);
         }

        public void Update(UpdateStackRequest request)
        {
            request.StackName = this.Name;
            ResourcesUtilities.Invoke(request, this.Client.UpdateStack, "Update");
        }

        #endregion

        #region HasMany
        public IEnumerable<IEvent> GetEvents(DescribeStackEventsRequest request)
        {
            request.StackName = this.Name;
        
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.DescribeStackEventsEnumerator, "Events"))
            {            
                yield return new Internal.Event(model : item, client : this.Client);    
            }

        }

        public IEnumerable<IEvent> GetEvents()
        {
            var request = new DescribeStackEventsRequest();
            return GetEvents(request);
         }

        public IEnumerable<IStackResourceSummary> GetResourceSummaries(ListStackResourcesRequest request)
        {
            request.StackName = this.Name;
        
            foreach (var item in ResourcesUtilities.InvokePaginator(request, this.Client.ListStackResourcesEnumerator, "ResourceSummaries"))
            {            
                yield return new Internal.StackResourceSummary(model : item, stackName : request.StackName, client : this.Client);    
            }

        }

        public IEnumerable<IStackResourceSummary> GetResourceSummaries()
        {
            var request = new ListStackResourcesRequest();
            return GetResourceSummaries(request);
         }


        #endregion

        #region Subresource

        public IStackResource GetStackResourceByLogicalId(string logicalId)
        {
            return new Internal.StackResource(logicalId : logicalId, stackName : this.Name, client : this.Client);
        }

        #endregion
    }

    #endregion

    #region StackResource

    internal class StackResource : Resource<IAmazonCloudFormation>, IStackResource
    {
        public string LogicalId { get; private set; }

        public string StackName { get; private set; }

        private string _description;
        public string Description
        {
            get
            {
                this.CheckIfLoaded();
                return _description;
            }
        }

        private DateTime _lastUpdatedTimestamp;
        public DateTime LastUpdatedTimestamp
        {
            get
            {
                this.CheckIfLoaded();
                return _lastUpdatedTimestamp;
            }
        }

        private string _metadata;
        public string Metadata
        {
            get
            {
                this.CheckIfLoaded();
                return _metadata;
            }
        }

        private string _physicalResourceId;
        public string PhysicalResourceId
        {
            get
            {
                this.CheckIfLoaded();
                return _physicalResourceId;
            }
        }

        private ResourceStatus _resourceStatus;
        public ResourceStatus ResourceStatus
        {
            get
            {
                this.CheckIfLoaded();
                return _resourceStatus;
            }
        }

        private string _resourceStatusReason;
        public string ResourceStatusReason
        {
            get
            {
                this.CheckIfLoaded();
                return _resourceStatusReason;
            }
        }

        private string _resourceType;
        public string ResourceType
        {
            get
            {
                this.CheckIfLoaded();
                return _resourceType;
            }
        }

        private string _stackId;
        public string StackId
        {
            get
            {
                this.CheckIfLoaded();
                return _stackId;
            }
        }

        public StackResource(Model.StackResourceDetail model,
            IAmazonCloudFormation client)
            : base (client)
        {
            this.IsLoaded = true;
            this.LogicalId = model.LogicalResourceId;
            this.StackName = model.StackName;
            CopyFrom(model);
        }

        private void CopyFrom(Model.StackResourceDetail model)
        {
            _description = model.Description;
            _lastUpdatedTimestamp = model.LastUpdatedTimestamp;
            _metadata = model.Metadata;
            _physicalResourceId = model.PhysicalResourceId;
            _resourceStatus = model.ResourceStatus;
            _resourceStatusReason = model.ResourceStatusReason;
            _resourceType = model.ResourceType;
            _stackId = model.StackId;
        }

      
        protected override void LoadResource()
        {
            var request = new DescribeStackResourceRequest();
            request.LogicalResourceId = this.LogicalId;
            request.StackName = this.StackName;

            var response = this.Client.DescribeStackResource(request);
            this.CopyFrom(response.StackResourceDetail);
        }

        public StackResource(string logicalId, string stackName, IAmazonCloudFormation client)
            : base (client)
        {
            this.IsLoaded = false;
            this.LogicalId = logicalId;
            this.StackName = stackName;

        }

        #region Actions

        #endregion

    }

    #endregion

    #region StackResourceSummary

    internal class StackResourceSummary : Resource<IAmazonCloudFormation>, IStackResourceSummary
    {
        public string LogicalId { get; private set; }

        public string StackName { get; private set; }

        private DateTime _lastUpdatedTimestamp;
        public DateTime LastUpdatedTimestamp
        {
            get
            {
                this.CheckIfLoaded();
                return _lastUpdatedTimestamp;
            }
        }

        private string _physicalResourceId;
        public string PhysicalResourceId
        {
            get
            {
                this.CheckIfLoaded();
                return _physicalResourceId;
            }
        }

        private ResourceStatus _resourceStatus;
        public ResourceStatus ResourceStatus
        {
            get
            {
                this.CheckIfLoaded();
                return _resourceStatus;
            }
        }

        private string _resourceStatusReason;
        public string ResourceStatusReason
        {
            get
            {
                this.CheckIfLoaded();
                return _resourceStatusReason;
            }
        }

        private string _resourceType;
        public string ResourceType
        {
            get
            {
                this.CheckIfLoaded();
                return _resourceType;
            }
        }

        public StackResourceSummary(Model.StackResourceSummary model,
            string stackName,
            IAmazonCloudFormation client)
            : base (client)
        {
            this.IsLoaded = true;
            this.LogicalId = model.LogicalResourceId;
            this.StackName = stackName;
            CopyFrom(model);
        }

        private void CopyFrom(Model.StackResourceSummary model)
        {
            _lastUpdatedTimestamp = model.LastUpdatedTimestamp;
            _physicalResourceId = model.PhysicalResourceId;
            _resourceStatus = model.ResourceStatus;
            _resourceStatusReason = model.ResourceStatusReason;
            _resourceType = model.ResourceType;
        }

        public StackResourceSummary(string logicalId, string stackName, IAmazonCloudFormation client)
            : base (client)
        {
            this.IsLoaded = false;
            this.LogicalId = logicalId;
            this.StackName = stackName;

        }

        #region Actions

        #endregion

    }

    #endregion
}