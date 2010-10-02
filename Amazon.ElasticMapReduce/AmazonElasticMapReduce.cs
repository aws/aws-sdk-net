/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2009-03-31
 */

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Amazon.ElasticMapReduce.Model;

namespace Amazon.ElasticMapReduce
{
    /// <summary>
    /// Amazon Elastic MapReduce is a web service that enables businesses, researchers,
    /// data analysts, and developers to easily and cost-effectively process vast amounts
    /// of data. It utilizes a hosted Hadoop framework running on the web-scale infrastructure
    /// of Amazon Elastic Compute Cloud (Amazon EC2) and Amazon Simple Storage Service (Amazon S3).
    /// </summary>
    public interface AmazonElasticMapReduce : IDisposable
    {
        /// <summary>
        /// Add Job Flow Steps
        /// </summary>
        /// <param name="request">Add Job Flow Steps  request</param>
        /// <returns>Add Job Flow Steps  Response from the service</returns>
        AddJobFlowStepsResponse AddJobFlowSteps(AddJobFlowStepsRequest request);

        /// <summary>
        /// Terminate Job Flows
        /// </summary>
        /// <param name="request">Terminate Job Flows  request</param>
        /// <returns>Terminate Job Flows  Response from the service</returns>
        TerminateJobFlowsResponse TerminateJobFlows(TerminateJobFlowsRequest request);

        /// <summary>
        /// Describe Job Flows
        /// </summary>
        /// <param name="request">Describe Job Flows  request</param>
        /// <returns>Describe Job Flows  Response from the service</returns>
        DescribeJobFlowsResponse DescribeJobFlows(DescribeJobFlowsRequest request);

        /// <summary>
        /// Run Job Flow
        /// </summary>
        /// <param name="request">Run Job Flow  request</param>
        /// <returns>Run Job Flow  Response from the service</returns>
        RunJobFlowResponse RunJobFlow(RunJobFlowRequest request);

    }
}
