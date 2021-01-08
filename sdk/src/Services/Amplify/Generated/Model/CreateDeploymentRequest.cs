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
 * Do not modify this file. This file is generated from the amplify-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Amplify.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDeployment operation.
    /// Creates a deployment for a manually deployed Amplify app. Manually deployed apps
    /// are not connected to a repository.
    /// </summary>
    public partial class CreateDeploymentRequest : AmazonAmplifyRequest
    {
        private string _appId;
        private string _branchName;
        private Dictionary<string, string> _fileMap = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AppId. 
        /// <para>
        ///  The unique ID for an Amplify app. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string AppId
        {
            get { return this._appId; }
            set { this._appId = value; }
        }

        // Check to see if AppId property is set
        internal bool IsSetAppId()
        {
            return this._appId != null;
        }

        /// <summary>
        /// Gets and sets the property BranchName. 
        /// <para>
        ///  The name for the branch, for the job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string BranchName
        {
            get { return this._branchName; }
            set { this._branchName = value; }
        }

        // Check to see if BranchName property is set
        internal bool IsSetBranchName()
        {
            return this._branchName != null;
        }

        /// <summary>
        /// Gets and sets the property FileMap. 
        /// <para>
        ///  An optional file map that contains the file name as the key and the file content
        /// md5 hash as the value. If this argument is provided, the service will generate a unique
        /// upload URL per file. Otherwise, the service will only generate a single upload URL
        /// for the zipped files. 
        /// </para>
        /// </summary>
        public Dictionary<string, string> FileMap
        {
            get { return this._fileMap; }
            set { this._fileMap = value; }
        }

        // Check to see if FileMap property is set
        internal bool IsSetFileMap()
        {
            return this._fileMap != null && this._fileMap.Count > 0; 
        }

    }
}