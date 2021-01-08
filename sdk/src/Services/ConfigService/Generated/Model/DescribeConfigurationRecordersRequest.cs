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
    /// Container for the parameters to the DescribeConfigurationRecorders operation.
    /// Returns the details for the specified configuration recorders. If the configuration
    /// recorder is not specified, this action returns the details for all configuration recorders
    /// associated with the account.
    /// 
    ///  <note> 
    /// <para>
    /// Currently, you can specify only one configuration recorder per region in your account.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeConfigurationRecordersRequest : AmazonConfigServiceRequest
    {
        private List<string> _configurationRecorderNames = new List<string>();

        /// <summary>
        /// Gets and sets the property ConfigurationRecorderNames. 
        /// <para>
        /// A list of configuration recorder names.
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