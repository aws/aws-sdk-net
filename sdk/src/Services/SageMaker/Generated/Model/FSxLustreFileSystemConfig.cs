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
    /// The settings for assigning a custom Amazon FSx for Lustre file system to a user profile
    /// or space for an Amazon SageMaker Domain.
    /// </summary>
    public partial class FSxLustreFileSystemConfig
    {
        private string _fileSystemId;
        private string _fileSystemPath;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The globally unique, 17-digit, ID of the file system, assigned by Amazon FSx for Lustre.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=11, Max=21)]
        public string FileSystemId
        {
            get { return this._fileSystemId; }
            set { this._fileSystemId = value; }
        }

        // Check to see if FileSystemId property is set
        internal bool IsSetFileSystemId()
        {
            return this._fileSystemId != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemPath. 
        /// <para>
        /// The path to the file system directory that is accessible in Amazon SageMaker Studio.
        /// Permitted users can access only this directory and below.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string FileSystemPath
        {
            get { return this._fileSystemPath; }
            set { this._fileSystemPath = value; }
        }

        // Check to see if FileSystemPath property is set
        internal bool IsSetFileSystemPath()
        {
            return this._fileSystemPath != null;
        }

    }
}