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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// Evidence that is uploaded to AWS Audit Manager manually.
    /// </summary>
    public partial class ManualEvidence
    {
        private string _s3ResourcePath;

        /// <summary>
        /// Gets and sets the property S3ResourcePath. 
        /// <para>
        ///  The Amazon S3 URL that points to a manual evidence object. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string S3ResourcePath
        {
            get { return this._s3ResourcePath; }
            set { this._s3ResourcePath = value; }
        }

        // Check to see if S3ResourcePath property is set
        internal bool IsSetS3ResourcePath()
        {
            return this._s3ResourcePath != null;
        }

    }
}