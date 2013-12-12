/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// <para>Contains the response to a <c>DescribeLoadBasedAutoScaling</c> request.</para>
    /// </summary>
    public partial class DescribeLoadBasedAutoScalingResult : AmazonWebServiceResponse
    {
        
        private List<LoadBasedAutoScalingConfiguration> loadBasedAutoScalingConfigurations = new List<LoadBasedAutoScalingConfiguration>();


        /// <summary>
        /// An array of <c>LoadBasedAutoScalingConfiguration</c> objects that describe each layer's configuration.
        ///  
        /// </summary>
        public List<LoadBasedAutoScalingConfiguration> LoadBasedAutoScalingConfigurations
        {
            get { return this.loadBasedAutoScalingConfigurations; }
            set { this.loadBasedAutoScalingConfigurations = value; }
        }

        // Check to see if LoadBasedAutoScalingConfigurations property is set
        internal bool IsSetLoadBasedAutoScalingConfigurations()
        {
            return this.loadBasedAutoScalingConfigurations.Count > 0;
        }
    }
}
