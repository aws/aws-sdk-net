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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The parameters for S3.
    /// </summary>
    public partial class S3Parameters
    {
        /// <summary>
        /// Gets and sets the property ManifestFileLocation. 
        /// <para>
        /// Location of the Amazon S3 manifest file. This is NULL if the manifest file was uploaded
        /// into Quick Sight.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ManifestFileLocation ManifestFileLocation { get; set; }

        /// <summary>
        /// Checks to see if the ManifestFileLocation property is set.
        /// </summary>
        internal bool IsSetManifestFileLocation() => this.ManifestFileLocation != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// Use the <c>RoleArn</c> structure to override an account-wide role for a specific S3
        /// data source. For example, say an account administrator has turned off all S3 access
        /// with an account-wide role. The administrator can then use <c>RoleArn</c> to bypass
        /// the account-wide role and allow S3 access for the single S3 data source that is specified
        /// in the structure, even if the account-wide role forbidding S3 access is still active.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
