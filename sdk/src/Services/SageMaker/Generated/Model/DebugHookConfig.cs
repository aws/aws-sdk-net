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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Configuration information for the debug hook parameters, collection configuration,
    /// and storage paths.
    /// </summary>
    public partial class DebugHookConfig
    {
        private List<CollectionConfiguration> _collectionConfigurations = new List<CollectionConfiguration>();
        private Dictionary<string, string> _hookParameters = new Dictionary<string, string>();
        private string _localPath;
        private string _s3OutputPath;

        /// <summary>
        /// Gets and sets the property CollectionConfigurations. 
        /// <para>
        /// Configuration information for tensor collections.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<CollectionConfiguration> CollectionConfigurations
        {
            get { return this._collectionConfigurations; }
            set { this._collectionConfigurations = value; }
        }

        // Check to see if CollectionConfigurations property is set
        internal bool IsSetCollectionConfigurations()
        {
            return this._collectionConfigurations != null && this._collectionConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HookParameters. 
        /// <para>
        /// Configuration information for the debug hook parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public Dictionary<string, string> HookParameters
        {
            get { return this._hookParameters; }
            set { this._hookParameters = value; }
        }

        // Check to see if HookParameters property is set
        internal bool IsSetHookParameters()
        {
            return this._hookParameters != null && this._hookParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LocalPath. 
        /// <para>
        /// Path to local storage location for tensors. Defaults to <code>/opt/ml/output/tensors/</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
        public string LocalPath
        {
            get { return this._localPath; }
            set { this._localPath = value; }
        }

        // Check to see if LocalPath property is set
        internal bool IsSetLocalPath()
        {
            return this._localPath != null;
        }

        /// <summary>
        /// Gets and sets the property S3OutputPath. 
        /// <para>
        /// Path to Amazon S3 storage location for tensors.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string S3OutputPath
        {
            get { return this._s3OutputPath; }
            set { this._s3OutputPath = value; }
        }

        // Check to see if S3OutputPath property is set
        internal bool IsSetS3OutputPath()
        {
            return this._s3OutputPath != null;
        }

    }
}