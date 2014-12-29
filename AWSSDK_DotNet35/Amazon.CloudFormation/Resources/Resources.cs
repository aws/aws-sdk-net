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
using Amazon.CloudFormation.Model;

namespace Amazon.CloudFormation.Resources
{

    #region IEvent

    /// <summary>
    /// This interface represents the Event resource.
    /// </summary>
    public interface IEvent
    {
        /// <summary>
        /// Gets the value of the Id identifier for this resource. 
        /// </summary>        
        string Id { get; }

        /// <summary>
        /// Gets the value of the property LogicalResourceId. 
        /// <para>
        /// The logical name of the resource specified in the template.
        /// </para>
        /// </summary>
        string LogicalResourceId { get; }

        /// <summary>
        /// Gets the value of the property PhysicalResourceId. 
        /// <para>
        /// The name or unique identifier associated with the physical instance of the resource.
        /// </para>
        /// </summary>
        string PhysicalResourceId { get; }

        /// <summary>
        /// Gets the value of the property ResourceProperties. 
        /// <para>
        /// BLOB of the properties used to create the resource.
        /// </para>
        /// </summary>
        string ResourceProperties { get; }

        /// <summary>
        /// Gets the value of the property ResourceStatus. 
        /// <para>
        /// Current status of the resource.
        /// </para>
        /// </summary>
        ResourceStatus ResourceStatus { get; }

        /// <summary>
        /// Gets the value of the property ResourceStatusReason. 
        /// <para>
        /// Success/failure message associated with the resource.
        /// </para>
        /// </summary>
        string ResourceStatusReason { get; }

        /// <summary>
        /// Gets the value of the property ResourceType. 
        /// <para>
        /// Type of resource. (For more information, go to <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">
        /// AWS Resource Types Reference</a> in the AWS CloudFormation User Guide.)
        /// </para>
        /// </summary>
        string ResourceType { get; }

        /// <summary>
        /// Gets the value of the property StackId. 
        /// <para>
        /// The unique ID name of the instance of the stack.
        /// </para>
        /// </summary>
        string StackId { get; }

        /// <summary>
        /// Gets the value of the property StackName. 
        /// <para>
        /// The name associated with a stack.
        /// </para>
        /// </summary>
        string StackName { get; }

        /// <summary>
        /// Gets the value of the property Timestamp. 
        /// <para>
        /// Time the status was updated.
        /// </para>
        /// </summary>
        DateTime Timestamp { get; }


        #region Actions


        #endregion

    }    
    #endregion

    #region IStack

    /// <summary>
    /// This interface represents the Stack resource.
    /// </summary>
    public interface IStack
    {
        /// <summary>
        /// Gets the value of the Name identifier for this resource. 
        /// </summary>        
        string Name { get; }

        /// <summary>
        /// Gets the value of the property Capabilities. 
        /// <para>
        /// The capabilities allowed in the stack.
        /// </para>
        /// </summary>
        List<string> Capabilities { get; }

        /// <summary>
        /// Gets the value of the property CreationTime. 
        /// <para>
        /// Time at which the stack was created.
        /// </para>
        /// </summary>
        DateTime CreationTime { get; }

        /// <summary>
        /// Gets the value of the property Description. 
        /// <para>
        /// User defined description associated with the stack.
        /// </para>
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Gets the value of the property DisableRollback. 
        /// <para>
        /// Boolean to enable or disable rollback on stack creation failures:
        /// </para>
        ///  
        /// <para>
        ///  <ul> <li> <code>true</code>: disable rollback</li> <li> <code>false</code>: enable
        /// rollback</li> </ul> 
        /// </para>
        /// </summary>
        bool DisableRollback { get; }

        /// <summary>
        /// Gets the value of the property LastUpdatedTime. 
        /// <para>
        /// The time the stack was last updated. This field will only be returned if the stack
        /// has been updated at least once.
        /// </para>
        /// </summary>
        DateTime LastUpdatedTime { get; }

        /// <summary>
        /// Gets the value of the property NotificationARNs. 
        /// <para>
        /// SNS topic ARNs to which stack related events are published.
        /// </para>
        /// </summary>
        List<string> NotificationARNs { get; }

        /// <summary>
        /// Gets the value of the property Outputs. 
        /// <para>
        /// A list of output structures.
        /// </para>
        /// </summary>
        List<Output> Outputs { get; }

        /// <summary>
        /// Gets the value of the property Parameters. 
        /// <para>
        /// A list of <code>Parameter</code> structures.
        /// </para>
        /// </summary>
        List<Parameter> Parameters { get; }

        /// <summary>
        /// Gets the value of the property StackId. 
        /// <para>
        /// Unique identifier of the stack.
        /// </para>
        /// </summary>
        string StackId { get; }

        /// <summary>
        /// Gets the value of the property StackStatus. 
        /// <para>
        /// Current status of the stack.
        /// </para>
        /// </summary>
        StackStatus StackStatus { get; }

        /// <summary>
        /// Gets the value of the property StackStatusReason. 
        /// <para>
        /// Success/failure message associated with the stack status.
        /// </para>
        /// </summary>
        string StackStatusReason { get; }

        /// <summary>
        /// Gets the value of the property Tags. 
        /// <para>
        /// A list of <code>Tag</code>s that specify cost allocation information for the stack.
        /// </para>
        /// </summary>
        List<Tag> Tags { get; }

        /// <summary>
        /// Gets the value of the property TimeoutInMinutes. 
        /// <para>
        /// The amount of time within which stack creation should complete.
        /// </para>
        /// </summary>
        int TimeoutInMinutes { get; }


        #region Actions

        /// <summary>
        /// Calls the CancelUpdate operation on the Stack resource.
        /// </summary>
        /// <para>
        /// This method internally calls the CancelUpdateStack operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the CancelUpdateStack operation.</param>
        void CancelUpdate(CancelUpdateStackRequest request);

        /// <summary>
        /// Calls the CancelUpdate operation on the Stack resource.
        /// </summary>
        /// <para>
        /// This method internally calls the CancelUpdateStack operation on the service.
        /// </para>
        void CancelUpdate();

        /// <summary>
        /// Calls the Delete operation on the Stack resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteStack operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStack operation.</param>
        void Delete(DeleteStackRequest request);

        /// <summary>
        /// Calls the Delete operation on the Stack resource.
        /// </summary>
        /// <para>
        /// This method internally calls the DeleteStack operation on the service.
        /// </para>
        void Delete();

        /// <summary>
        /// Calls the Update operation on the Stack resource.
        /// </summary>
        /// <para>
        /// This method internally calls the UpdateStack operation on the service.
        /// </para>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStack operation.</param>
        /// <returns>An instance of  resource.</returns>
        UpdateStackResponse Update(UpdateStackRequest request);


        #endregion

        #region Enumerable collections

        /// <summary>
        /// Gets the Events associated with this Stack.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackEventsEnumerator operation.</param>
        /// <returns>Returns an enumerable collection of Events.</returns>
        IEnumerable<IEvent> GetEvents(DescribeStackEventsRequest request);

        /// <summary>
        /// Gets the Events associated with this Stack.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <returns>Returns an enumerable collection of Events.</returns>
        IEnumerable<IEvent> GetEvents();

        /// <summary>
        /// Gets the ResourceSummaries associated with this Stack.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackResourcesEnumerator operation.</param>
        /// <returns>Returns an enumerable collection of ResourceSummaries.</returns>
        IEnumerable<IStackResourceSummary> GetResourceSummaries(ListStackResourcesRequest request);

        /// <summary>
        /// Gets the ResourceSummaries associated with this Stack.        
        /// <para>
        /// NOTE : This method calls a service operation that supports paging. Enumerating through the
        /// result of this method can potentially make multiple service operation calls.
        /// </para>
        /// </summary>
        /// <returns>Returns an enumerable collection of ResourceSummaries.</returns>
        IEnumerable<IStackResourceSummary> GetResourceSummaries();


        #endregion

        #region Subresources

        /// <summary>
        /// Gets a StackResource associated with this Stack resource using its identifier.
        /// <para>
        /// This method does not make a service call, it returns a resource instance
        /// only with its identifier properties initialized. Accessing any non-identifier 
        /// properties or operations on the resource that in turn access any non-identifier 
        /// properties will cause the resource to make a service call to load its data.
        /// </para>
        /// <para>
        /// NOTE : This method does not make a service call when the resource is initally
        /// constructed. If you pass invalid identifiers to this method, it will return a resource
        /// that may not exist on the server. In this case an exception will be thrown when 
        /// the resource tries to load itself due to conditions listed in the previous section.
        /// </para>
        /// </summary>
        /// <param name="logicalId">The logicalId of the StackResource.</param>
        /// <returns>Returns an instance of StackResource.</returns>
        IStackResource GetStackResourceByLogicalId(string logicalId);


        #endregion
    }    
    #endregion

    #region IStackResource

    /// <summary>
    /// This interface represents the StackResource resource.
    /// </summary>
    public interface IStackResource
    {
        /// <summary>
        /// Gets the value of the LogicalId identifier for this resource. 
        /// </summary>        
        string LogicalId { get; }

        /// <summary>
        /// Gets the value of the StackName identifier for this resource. 
        /// </summary>        
        string StackName { get; }

        /// <summary>
        /// Gets the value of the property Description. 
        /// <para>
        /// User defined description associated with the resource.
        /// </para>
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Gets the value of the property LastUpdatedTimestamp. 
        /// <para>
        /// Time the status was updated.
        /// </para>
        /// </summary>
        DateTime LastUpdatedTimestamp { get; }

        /// <summary>
        /// Gets the value of the property Metadata. 
        /// <para>
        /// The JSON format content of the <code>Metadata</code> attribute declared for the resource.
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-attribute-metadata.html">Metadata
        /// Attribute</a> in the AWS CloudFormation User Guide.
        /// </para>
        /// </summary>
        string Metadata { get; }

        /// <summary>
        /// Gets the value of the property PhysicalResourceId. 
        /// <para>
        /// The name or unique identifier that corresponds to a physical instance ID of a resource
        /// supported by AWS CloudFormation.
        /// </para>
        /// </summary>
        string PhysicalResourceId { get; }

        /// <summary>
        /// Gets the value of the property ResourceStatus. 
        /// <para>
        /// Current status of the resource.
        /// </para>
        /// </summary>
        ResourceStatus ResourceStatus { get; }

        /// <summary>
        /// Gets the value of the property ResourceStatusReason. 
        /// <para>
        /// Success/failure message associated with the resource.
        /// </para>
        /// </summary>
        string ResourceStatusReason { get; }

        /// <summary>
        /// Gets the value of the property ResourceType. 
        /// <para>
        /// Type of resource. ((For more information, go to <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">
        /// AWS Resource Types Reference</a> in the AWS CloudFormation User Guide.)
        /// </para>
        /// </summary>
        string ResourceType { get; }

        /// <summary>
        /// Gets the value of the property StackId. 
        /// <para>
        /// Unique identifier of the stack.
        /// </para>
        /// </summary>
        string StackId { get; }


        #region Actions


        #endregion

    }    
    #endregion

    #region IStackResourceSummary

    /// <summary>
    /// This interface represents the StackResourceSummary resource.
    /// </summary>
    public interface IStackResourceSummary
    {
        /// <summary>
        /// Gets the value of the LogicalId identifier for this resource. 
        /// </summary>        
        string LogicalId { get; }

        /// <summary>
        /// Gets the value of the StackName identifier for this resource. 
        /// </summary>        
        string StackName { get; }

        /// <summary>
        /// Gets the value of the property LastUpdatedTimestamp. 
        /// <para>
        /// Time the status was updated.
        /// </para>
        /// </summary>
        DateTime LastUpdatedTimestamp { get; }

        /// <summary>
        /// Gets the value of the property PhysicalResourceId. 
        /// <para>
        /// The name or unique identifier that corresponds to a physical instance ID of the resource.
        /// </para>
        /// </summary>
        string PhysicalResourceId { get; }

        /// <summary>
        /// Gets the value of the property ResourceStatus. 
        /// <para>
        /// Current status of the resource.
        /// </para>
        /// </summary>
        ResourceStatus ResourceStatus { get; }

        /// <summary>
        /// Gets the value of the property ResourceStatusReason. 
        /// <para>
        /// Success/failure message associated with the resource.
        /// </para>
        /// </summary>
        string ResourceStatusReason { get; }

        /// <summary>
        /// Gets the value of the property ResourceType. 
        /// <para>
        /// Type of resource. (For more information, go to <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html">
        /// AWS Resource Types Reference</a> in the AWS CloudFormation User Guide.)
        /// </para>
        /// </summary>
        string ResourceType { get; }


        #region Actions


        #endregion

    }    
    #endregion
}