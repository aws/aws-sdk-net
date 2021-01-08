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
    /// This is the response object from the CreateSuiteDefinition operation.
    /// </summary>
    public partial class CreateSuiteDefinitionResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private string _suiteDefinitionArn;
        private string _suiteDefinitionId;
        private string _suiteDefinitionName;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Creates a Device Advisor test suite with TimeStamp of when it was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SuiteDefinitionArn. 
        /// <para>
        /// Creates a Device Advisor test suite with Amazon Resource name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string SuiteDefinitionArn
        {
            get { return this._suiteDefinitionArn; }
            set { this._suiteDefinitionArn = value; }
        }

        // Check to see if SuiteDefinitionArn property is set
        internal bool IsSetSuiteDefinitionArn()
        {
            return this._suiteDefinitionArn != null;
        }

        /// <summary>
        /// Gets and sets the property SuiteDefinitionId. 
        /// <para>
        /// Creates a Device Advisor test suite with suite UUID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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
        /// Gets and sets the property SuiteDefinitionName. 
        /// <para>
        /// Creates a Device Advisor test suite with suite definition name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string SuiteDefinitionName
        {
            get { return this._suiteDefinitionName; }
            set { this._suiteDefinitionName = value; }
        }

        // Check to see if SuiteDefinitionName property is set
        internal bool IsSetSuiteDefinitionName()
        {
            return this._suiteDefinitionName != null;
        }

    }
}