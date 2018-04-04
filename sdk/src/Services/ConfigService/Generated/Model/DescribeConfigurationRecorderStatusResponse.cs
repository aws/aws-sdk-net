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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// The output for the <a>DescribeConfigurationRecorderStatus</a> action, in JSON format.
    /// </summary>
    public partial class DescribeConfigurationRecorderStatusResponse : AmazonWebServiceResponse
    {
        private List<ConfigurationRecorderStatus> _configurationRecordersStatus = new List<ConfigurationRecorderStatus>();

        /// <summary>
        /// Gets and sets the property ConfigurationRecordersStatus. 
        /// <para>
        /// A list that contains status of the specified recorders.
        /// </para>
        /// </summary>
        public List<ConfigurationRecorderStatus> ConfigurationRecordersStatus
        {
            get { return this._configurationRecordersStatus; }
            set { this._configurationRecordersStatus = value; }
        }

        // Check to see if ConfigurationRecordersStatus property is set
        internal bool IsSetConfigurationRecordersStatus()
        {
            return this._configurationRecordersStatus != null && this._configurationRecordersStatus.Count > 0; 
        }

    }
}