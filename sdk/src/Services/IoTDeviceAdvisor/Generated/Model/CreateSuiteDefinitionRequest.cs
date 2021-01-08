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
 * Do not modify this file. This file is generated from the iotdeviceadvisor-2020-09-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTDeviceAdvisor.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSuiteDefinition operation.
    /// Creates a Device Advisor test suite.
    /// </summary>
    public partial class CreateSuiteDefinitionRequest : AmazonIoTDeviceAdvisorRequest
    {
        private SuiteDefinitionConfiguration _suiteDefinitionConfiguration;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property SuiteDefinitionConfiguration. 
        /// <para>
        /// Creates a Device Advisor test suite with suite definition configuration.
        /// </para>
        /// </summary>
        public SuiteDefinitionConfiguration SuiteDefinitionConfiguration
        {
            get { return this._suiteDefinitionConfiguration; }
            set { this._suiteDefinitionConfiguration = value; }
        }

        // Check to see if SuiteDefinitionConfiguration property is set
        internal bool IsSetSuiteDefinitionConfiguration()
        {
            return this._suiteDefinitionConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to be attached to the suite definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}