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
 * Do not modify this file. This file is generated from the accessanalyzer-2019-11-01.normal.json service model.
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
namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// The proposed access control configuration for an Amazon EFS file system. You can propose
    /// a configuration for a new Amazon EFS file system or an existing Amazon EFS file system
    /// that you own by specifying the Amazon EFS policy. For more information, see <a href="https://docs.aws.amazon.com/efs/latest/ug/using-fs.html">Using
    /// file systems in Amazon EFS</a>.
    /// 
    ///  <ul> <li> 
    /// <para>
    /// If the configuration is for an existing Amazon EFS file system and you do not specify
    /// the Amazon EFS policy, then the access preview uses the existing Amazon EFS policy
    /// for the file system.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the access preview is for a new resource and you do not specify the policy, then
    /// the access preview assumes an Amazon EFS file system without a policy.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To propose deletion of an existing Amazon EFS file system policy, you can specify
    /// an empty string for the Amazon EFS policy.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class EfsFileSystemConfiguration
    {
        private string _fileSystemPolicy;

        /// <summary>
        /// Gets and sets the property FileSystemPolicy. 
        /// <para>
        /// The JSON policy definition to apply to the Amazon EFS file system. For more information
        /// on the elements that make up a file system policy, see <a href="https://docs.aws.amazon.com/efs/latest/ug/access-control-overview.html#access-control-manage-access-intro-resource-policies">Amazon
        /// EFS Resource-based policies</a>.
        /// </para>
        /// </summary>
        public string FileSystemPolicy
        {
            get { return this._fileSystemPolicy; }
            set { this._fileSystemPolicy = value; }
        }

        // Check to see if FileSystemPolicy property is set
        internal bool IsSetFileSystemPolicy()
        {
            return this._fileSystemPolicy != null;
        }

    }
}