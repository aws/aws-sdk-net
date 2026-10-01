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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.IoTDeviceAdvisor.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSuiteDefinition operation. Updates a Device
    /// Advisor test suite. <para> Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">UpdateSuiteDefinition</a>
    /// action. </para>
    /// </summary>
    public partial class UpdateSuiteDefinitionRequest : AmazonIoTDeviceAdvisorRequest
    {
        /// <summary>
        /// Gets and sets the property SuiteDefinitionConfiguration. 
        /// <para>
        /// Updates a Device Advisor test suite with suite definition configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SuiteDefinitionConfiguration SuiteDefinitionConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SuiteDefinitionConfiguration property is set.
        /// </summary>
        internal bool IsSetSuiteDefinitionConfiguration() => this.SuiteDefinitionConfiguration != null;

        /// <summary>
        /// Gets and sets the property SuiteDefinitionId. 
        /// <para>
        /// Suite definition ID of the test suite to be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 12, Max = 36)]
        public string SuiteDefinitionId { get; set; }

        /// <summary>
        /// Checks to see if the SuiteDefinitionId property is set.
        /// </summary>
        internal bool IsSetSuiteDefinitionId() => this.SuiteDefinitionId != null;
    }
}
