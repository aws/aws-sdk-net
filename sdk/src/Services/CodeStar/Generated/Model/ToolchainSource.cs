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
 * Do not modify this file. This file is generated from the codestar-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeStar.Model
{
    /// <summary>
    /// The Amazon S3 location where the toolchain template file provided with the project
    /// request is stored. AWS CodeStar retrieves the file during project creation.
    /// </summary>
    public partial class ToolchainSource
    {
        private S3Location _s3;

        /// <summary>
        /// Gets and sets the property S3. 
        /// <para>
        /// The Amazon S3 bucket where the toolchain template file provided with the project request
        /// is stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3Location S3
        {
            get { return this._s3; }
            set { this._s3 = value; }
        }

        // Check to see if S3 property is set
        internal bool IsSetS3()
        {
            return this._s3 != null;
        }

    }
}