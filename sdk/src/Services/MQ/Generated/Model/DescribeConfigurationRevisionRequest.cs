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
 * Do not modify this file. This file is generated from the mq-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MQ.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeConfigurationRevision operation.
    /// Returns the specified configuration revision for the specified configuration.
    /// </summary>
    public partial class DescribeConfigurationRevisionRequest : AmazonMQRequest
    {
        private string _configurationId;
        private string _configurationRevision;

        /// <summary>
        /// Gets and sets the property ConfigurationId. The unique ID that Amazon MQ generates
        /// for the configuration.
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConfigurationId
        {
            get { return this._configurationId; }
            set { this._configurationId = value; }
        }

        // Check to see if ConfigurationId property is set
        internal bool IsSetConfigurationId()
        {
            return this._configurationId != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationRevision. The revision of the configuration.
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConfigurationRevision
        {
            get { return this._configurationRevision; }
            set { this._configurationRevision = value; }
        }

        // Check to see if ConfigurationRevision property is set
        internal bool IsSetConfigurationRevision()
        {
            return this._configurationRevision != null;
        }

    }
}