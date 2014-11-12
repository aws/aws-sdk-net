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

using System;
using Amazon.Runtime;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Returns information about the DescribeNotificationConfigurationsResult response and response metadata.
    /// </summary>
    public class DescribeNotificationConfigurationsResponse : AmazonWebServiceResponse
    {
        private DescribeNotificationConfigurationsResult _describeNotificationConfigurationsResult;

        /// <summary>
        /// Gets and sets the DescribeNotificationConfigurationsResult property.
        /// Represents the output of a DescribeNotificationConfigurations operation.
        /// </summary>
        public DescribeNotificationConfigurationsResult DescribeNotificationConfigurationsResult
        {
            get
            {
                if(this._describeNotificationConfigurationsResult == null)
                {
                    this._describeNotificationConfigurationsResult = new DescribeNotificationConfigurationsResult();
                }
                return this._describeNotificationConfigurationsResult;
            }
            set { this._describeNotificationConfigurationsResult = value; }
        }
    }
}