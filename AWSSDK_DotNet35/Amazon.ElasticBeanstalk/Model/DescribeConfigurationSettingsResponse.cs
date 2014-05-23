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

namespace Amazon.ElasticBeanstalk.Model
{
    /// <summary>
    /// Configuration for accessing Amazon DescribeConfigurationSettings service
    /// </summary>
    public partial class DescribeConfigurationSettingsResponse : DescribeConfigurationSettingsResult
    {
        /// <summary>
        /// Gets and sets the DescribeConfigurationSettingsResult property.
        /// Represents the output of a DescribeConfigurationSettings operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the DescribeConfigurationSettingsResult class are now available on the DescribeConfigurationSettingsResponse class. You should use the properties on DescribeConfigurationSettingsResponse instead of accessing them through DescribeConfigurationSettingsResult.")]
        public DescribeConfigurationSettingsResult DescribeConfigurationSettingsResult
        {
            get
            {
                return this;
            }
        }
    }
}