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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Summary information about a published dataset version.
    /// </summary>
    public partial class DatasetVersionSummary
    {
        private DateTime? _createdAt;
        private string _datasetVersion;
        private long? _exampleCount;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        ///  The timestamp when this version was published. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DatasetVersion.
        /// </summary>
        [AWSProperty(Required=true)]
        public string DatasetVersion
        {
            get { return this._datasetVersion; }
            set { this._datasetVersion = value; }
        }

        // Check to see if DatasetVersion property is set
        internal bool IsSetDatasetVersion()
        {
            return this._datasetVersion != null;
        }

        /// <summary>
        /// Gets and sets the property ExampleCount. 
        /// <para>
        ///  The number of examples in this version. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? ExampleCount
        {
            get { return this._exampleCount; }
            set { this._exampleCount = value; }
        }

        // Check to see if ExampleCount property is set
        internal bool IsSetExampleCount()
        {
            return this._exampleCount.HasValue; 
        }

    }
}