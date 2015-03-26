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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Contains the response to a <code>DescribeLoadBasedAutoScaling</code> request.
    /// </summary>
    public partial class DescribeLoadBasedAutoScalingResponse : AmazonWebServiceResponse
    {
        private List<LoadBasedAutoScalingConfiguration> _loadBasedAutoScalingConfigurations = new List<LoadBasedAutoScalingConfiguration>();

        /// <summary>
        /// Gets and sets the property LoadBasedAutoScalingConfigurations. 
        /// <para>
        /// An array of <code>LoadBasedAutoScalingConfiguration</code> objects that describe each
        /// layer's configuration.
        /// </para>
        /// </summary>
        public List<LoadBasedAutoScalingConfiguration> LoadBasedAutoScalingConfigurations
        {
            get { return this._loadBasedAutoScalingConfigurations; }
            set { this._loadBasedAutoScalingConfigurations = value; }
        }

        // Check to see if LoadBasedAutoScalingConfigurations property is set
        internal bool IsSetLoadBasedAutoScalingConfigurations()
        {
            return this._loadBasedAutoScalingConfigurations != null && this._loadBasedAutoScalingConfigurations.Count > 0; 
        }

    }
}