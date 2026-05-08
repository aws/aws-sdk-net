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
    /// This is the response object from the CreateConfigurationBundle operation.
    /// </summary>
    public partial class CreateConfigurationBundleResponse : AmazonWebServiceResponse
    {
        private string _bundleArn;
        private string _bundleId;
        private DateTime? _createdAt;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property BundleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the created configuration bundle.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BundleArn
        {
            get { return this._bundleArn; }
            set { this._bundleArn = value; }
        }

        // Check to see if BundleArn property is set
        internal bool IsSetBundleArn()
        {
            return this._bundleArn != null;
        }

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The unique identifier of the created configuration bundle.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BundleId
        {
            get { return this._bundleId; }
            set { this._bundleId = value; }
        }

        // Check to see if BundleId property is set
        internal bool IsSetBundleId()
        {
            return this._bundleId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the configuration bundle was created.
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
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The initial version identifier of the configuration bundle.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}