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
using System.Collections.Generic;

using Amazon.Runtime.Internal;
using Amazon.CloudFormation.Model;

namespace Amazon.CloudFormation
{
    public partial class AmazonCloudFormationClient
    {

        #region DescribeStackEventsEnumerator

        /// <summary>
        /// Initiates paginated execution of the DescribeStackEvents operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackEvents operation on AmazonCloudFormationClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;StackEvent&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<StackEvent> DescribeStackEventsEnumerator(DescribeStackEventsRequest request)
        {
            return Paginator.Paginate<StackEvent, DescribeStackEventsRequest, DescribeStackEventsResponse>(request, this.DescribeStackEvents);
        }
      
        #endregion

        #region DescribeStacksEnumerator

        /// <summary>
        /// Initiates paginated execution of the DescribeStacks operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks operation on AmazonCloudFormationClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;Stack&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<Stack> DescribeStacksEnumerator(DescribeStacksRequest request)
        {
            return Paginator.Paginate<Stack, DescribeStacksRequest, DescribeStacksResponse>(request, this.DescribeStacks);
        }
      
        #endregion

        #region ListStackResourcesEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListStackResources operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackResources operation on AmazonCloudFormationClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;StackResourceSummary&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<StackResourceSummary> ListStackResourcesEnumerator(ListStackResourcesRequest request)
        {
            return Paginator.Paginate<StackResourceSummary, ListStackResourcesRequest, ListStackResourcesResponse>(request, this.ListStackResources);
        }
      
        #endregion

        #region ListStacksEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListStacks operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStacks operation on AmazonCloudFormationClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;StackSummary&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        public IEnumerable<StackSummary> ListStacksEnumerator(ListStacksRequest request)
        {
            return Paginator.Paginate<StackSummary, ListStacksRequest, ListStacksResponse>(request, this.ListStacks);
        }
      
        #endregion

 
    }

    public partial interface IAmazonCloudFormation
    {
        #region DescribeStackEventsEnumerator

        /// <summary>
        /// Initiates paginated execution of the DescribeStackEvents operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStackEvents operation on AmazonCloudFormationClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;StackEvent&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<StackEvent> DescribeStackEventsEnumerator(DescribeStackEventsRequest request);
      
        #endregion

        #region DescribeStacksEnumerator

        /// <summary>
        /// Initiates paginated execution of the DescribeStacks operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStacks operation on AmazonCloudFormationClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;Stack&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<Stack> DescribeStacksEnumerator(DescribeStacksRequest request);
      
        #endregion

        #region ListStackResourcesEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListStackResources operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStackResources operation on AmazonCloudFormationClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;StackResourceSummary&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<StackResourceSummary> ListStackResourcesEnumerator(ListStackResourcesRequest request);
      
        #endregion

        #region ListStacksEnumerator

        /// <summary>
        /// Initiates paginated execution of the ListStacks operation.
        /// <seealso cref="Amazon.CloudFormation.IAmazonCloudFormation"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStacks operation on AmazonCloudFormationClient.</param>
        /// 
        /// <returns>An IEnumerable&lt;StackSummary&gt; that can be used to to enumerate items in the responses potentially
        ///          across multiple requests.</returns>
        IEnumerable<StackSummary> ListStacksEnumerator(ListStacksRequest request);
      
        #endregion

 
    }
}