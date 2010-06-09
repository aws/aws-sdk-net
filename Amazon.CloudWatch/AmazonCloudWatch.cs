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
 *  API Version: 2009-05-15
 */

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Amazon.CloudWatch.Model;

namespace Amazon.CloudWatch
{
    /// <summary>
    /// Amazon CloudWatch is a web service that provides monitoring for AWS cloud resources, starting
    /// with Amazon EC2. It provides you with visibility into resource utilization, operational performance,
    /// and overall demand patterns—including metrics such as CPU utilization, disk reads and writes, and
    /// network traffic. To use Amazon CloudWatch, simply select the Amazon EC2 instances that you’d like
    /// to monitor; within minutes, Amazon CloudWatch will begin aggregating and storing monitoring data
    /// that can be accessed using web service APIs or Command Line Tools.
    /// </summary>
    public interface AmazonCloudWatch
    {
        /// <summary>
        /// List Metrics
        /// </summary>
        /// <param name="request">List Metrics  request</param>
        /// <returns>List Metrics  Response from the service</returns>
        ListMetricsResponse ListMetrics(ListMetricsRequest request);

        /// <summary>
        /// Get Metric Statistics
        /// </summary>
        /// <param name="request">Get Metric Statistics  request</param>
        /// <returns>Get Metric Statistics  Response from the service</returns>
        GetMetricStatisticsResponse GetMetricStatistics(GetMetricStatisticsRequest request);

    }
}
