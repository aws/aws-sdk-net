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
    /// This is the response object from the UpdateSuiteDefinition operation.
    /// </summary>
    public partial class UpdateSuiteDefinitionResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private DateTime? _lastUpdatedAt;
        private string _suiteDefinitionArn;
        private string _suiteDefinitionId;
        private string _suiteDefinitionName;
        private string _suiteDefinitionVersion;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Timestamp of when the test suite was created.
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
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// Timestamp of when the test suite was updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedAt
        {
            get { return this._lastUpdatedAt.GetValueOrDefault(); }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SuiteDefinitionArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the updated test suite.
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
        /// Suite definition ID of the updated test suite.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=36)]
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
        /// Updates the suite definition name. This is a required parameter.
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

        /// <summary>
        /// Gets and sets the property SuiteDefinitionVersion. 
        /// <para>
        /// Suite definition version of the updated test suite.
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