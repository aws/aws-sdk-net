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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The settings for assigning a custom file system to a user profile or space for an
    /// Amazon SageMaker Domain. Permitted users can access this file system in Amazon SageMaker
    /// Studio.
    /// </summary>
    public partial class CustomFileSystemConfig
    {
        private EFSFileSystemConfig _efsFileSystemConfig;

        /// <summary>
        /// Gets and sets the property EFSFileSystemConfig. 
        /// <para>
        /// The settings for a custom Amazon EFS file system.
        /// </para>
        /// </summary>
        public EFSFileSystemConfig EFSFileSystemConfig
        {
            get { return this._efsFileSystemConfig; }
            set { this._efsFileSystemConfig = value; }
        }

        // Check to see if EFSFileSystemConfig property is set
        internal bool IsSetEFSFileSystemConfig()
        {
            return this._efsFileSystemConfig != null;
        }

    }
}