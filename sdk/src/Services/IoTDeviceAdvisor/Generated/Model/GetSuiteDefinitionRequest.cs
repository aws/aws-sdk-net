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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.IoTDeviceAdvisor.Model
{
    /// <summary>
    /// Container for the parameters to the GetSuiteDefinition operation.
    /// Gets information about a Device Advisor test suite.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">GetSuiteDefinition</a>
    /// action.
    /// </para>
    /// </summary>
    public partial class GetSuiteDefinitionRequest : AmazonIoTDeviceAdvisorRequest
    {
        private string _suiteDefinitionId;
        private string _suiteDefinitionVersion;

        /// <summary>
        /// Gets and sets the property SuiteDefinitionId. 
        /// <para>
        /// Suite definition ID of the test suite to get.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=36)]
        public string SuiteDefinitionId
        {
            get { return this._suiteDefinitionId; }
            set { this._suiteDefinitionId = value; }
        }

        // Check to see if SuiteDefinitionId property is set
        internal bool IsSetSuiteDefinitionId()
        {
            return this._suiteDefinitionId != null;
        }

        /// <summary>
        /// Gets and sets the property SuiteDefinitionVersion. 
        /// <para>
        /// Suite definition version of the test suite to get.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=255)]
        public string SuiteDefinitionVersion
        {
            get { return this._suiteDefinitionVersion; }
            set { this._suiteDefinitionVersion = value; }
        }

        // Check to see if SuiteDefinitionVersion property is set
        internal bool IsSetSuiteDefinitionVersion()
        {
            return this._suiteDefinitionVersion != null;
        }

    }
}