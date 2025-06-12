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
    /// This is the response object from the GetSuiteDefinition operation.
    /// </summary>
    public partial class GetSuiteDefinitionResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private DateTime? _lastModifiedAt;
        private string _latestVersion;
        private string _suiteDefinitionArn;
        private SuiteDefinitionConfiguration _suiteDefinitionConfiguration;
        private string _suiteDefinitionId;
        private string _suiteDefinitionVersion;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Date (in Unix epoch time) when the suite definition was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedAt. 
        /// <para>
        /// Date (in Unix epoch time) when the suite definition was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedAt
        {
            get { return this._lastModifiedAt; }
            set { this._lastModifiedAt = value; }
        }

        // Check to see if LastModifiedAt property is set
        internal bool IsSetLastModifiedAt()
        {
            return this._lastModifiedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestVersion. 
        /// <para>
        /// Latest suite definition version of the suite definition.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=255)]
        public string LatestVersion
        {
            get { return this._latestVersion; }
            set { this._latestVersion = value; }
        }

        // Check to see if LatestVersion property is set
        internal bool IsSetLatestVersion()
        {
            return this._latestVersion != null;
        }

        /// <summary>
        /// Gets and sets the property SuiteDefinitionArn. 
        /// <para>
        /// The ARN of the suite definition.
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
        /// Gets and sets the property SuiteDefinitionConfiguration. 
        /// <para>
        /// Suite configuration of the suite definition.
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
        /// Gets and sets the property SuiteDefinitionId. 
        /// <para>
        /// Suite definition ID of the suite definition.
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
        /// Gets and sets the property SuiteDefinitionVersion. 
        /// <para>
        /// Suite definition version of the suite definition.
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags attached to the suite definition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}