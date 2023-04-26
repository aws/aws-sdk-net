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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeConfigurationRecorderStatus operation.
    /// Returns the current status of the specified configuration recorder as well as the
    /// status of the last recording event for the recorder. If a configuration recorder is
    /// not specified, this action returns the status of all configuration recorders associated
    /// with the account.
    /// 
    ///  <note> 
    /// <para>
    /// Currently, you can specify only one configuration recorder per region in your account.
    /// For a detailed status of recording events over time, add your Config events to Amazon
    /// CloudWatch metrics and use CloudWatch metrics.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeConfigurationRecorderStatusRequest : AmazonConfigServiceRequest
    {
        private List<string> _configurationRecorderNames = new List<string>();

        /// <summary>
        /// Gets and sets the property ConfigurationRecorderNames. 
        /// <para>
        /// The name(s) of the configuration recorder. If the name is not specified, the action
        /// returns the current status of all the configuration recorders associated with the
        /// account.
        /// </para>
        /// </summary>
        public List<string> ConfigurationRecorderNames
        {
            get { return this._configurationRecorderNames; }
            set { this._configurationRecorderNames = value; }
        }

        // Check to see if ConfigurationRecorderNames property is set
        internal bool IsSetConfigurationRecorderNames()
        {
            return this._configurationRecorderNames != null && this._configurationRecorderNames.Count > 0; 
        }

    }
}