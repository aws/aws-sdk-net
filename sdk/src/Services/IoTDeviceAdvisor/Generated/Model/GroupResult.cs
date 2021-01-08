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
    /// Show Group Result.
    /// </summary>
    public partial class GroupResult
    {
        private string _groupId;
        private string _groupName;
        private List<TestCaseRun> _tests = new List<TestCaseRun>();

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// Show Group Result Id.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// Show Group Result Name.
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property Tests. 
        /// <para>
        /// Show Group Result.
        /// </para>
        /// </summary>
        public List<TestCaseRun> Tests
        {
            get { return this._tests; }
            set { this._tests = value; }
        }

        // Check to see if Tests property is set
        internal bool IsSetTests()
        {
            return this._tests != null && this._tests.Count > 0; 
        }

    }
}