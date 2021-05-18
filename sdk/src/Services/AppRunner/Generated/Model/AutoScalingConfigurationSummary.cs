/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Provides summary information about an AWS App Runner automatic scaling configuration
    /// resource.
    /// 
    ///  
    /// <para>
    /// This type contains limited information about an auto scaling configuration. It includes
    /// only identification information, without configuration details. It's returned by the
    /// <a>ListAutoScalingConfigurations</a> action. Complete configuration information is
    /// returned by the <a>CreateAutoScalingConfiguration</a>, <a>DescribeAutoScalingConfiguration</a>,
    /// and <a>DeleteAutoScalingConfiguration</a> actions using the <a>AutoScalingConfiguration</a>
    /// type.
    /// </para>
    /// </summary>
    public partial class AutoScalingConfigurationSummary
    {
        private string _autoScalingConfigurationArn;
        private string _autoScalingConfigurationName;
        private int? _autoScalingConfigurationRevision;

        /// <summary>
        /// Gets and sets the property AutoScalingConfigurationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of this auto scaling configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string AutoScalingConfigurationArn
        {
            get { return this._autoScalingConfigurationArn; }
            set { this._autoScalingConfigurationArn = value; }
        }

        // Check to see if AutoScalingConfigurationArn property is set
        internal bool IsSetAutoScalingConfigurationArn()
        {
            return this._autoScalingConfigurationArn != null;
        }

        /// <summary>
        /// Gets and sets the property AutoScalingConfigurationName. 
        /// <para>
        /// The customer-provided auto scaling configuration name. It can be used in multiple
        /// revisions of a configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=32)]
        public string AutoScalingConfigurationName
        {
            get { return this._autoScalingConfigurationName; }
            set { this._autoScalingConfigurationName = value; }
        }

        // Check to see if AutoScalingConfigurationName property is set
        internal bool IsSetAutoScalingConfigurationName()
        {
            return this._autoScalingConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property AutoScalingConfigurationRevision. 
        /// <para>
        /// The revision of this auto scaling configuration. It's unique among all the active
        /// configurations (<code>"Status": "ACTIVE"</code>) with the same <code>AutoScalingConfigurationName</code>.
        /// </para>
        /// </summary>
        public int AutoScalingConfigurationRevision
        {
            get { return this._autoScalingConfigurationRevision.GetValueOrDefault(); }
            set { this._autoScalingConfigurationRevision = value; }
        }

        // Check to see if AutoScalingConfigurationRevision property is set
        internal bool IsSetAutoScalingConfigurationRevision()
        {
            return this._autoScalingConfigurationRevision.HasValue; 
        }

    }
}