/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// The code for the Lambda function.
    /// </summary>
    public partial class FunctionCode
    {
        private MemoryStream _zipFile;

        /// <summary>
        /// Gets and sets the property ZipFile. 
        /// <para>
        /// A base64-encoded .zip file containing your packaged source code. For more information
        /// about creating a .zip file, go to <a href="http://http://docs.aws.amazon.com/lambda/latest/dg/intro-permission-model.html#lambda-intro-execution-role.html">Execution
        /// Permissions</a> in the <i>AWS Lambda Developer Guide</i>. 
        /// </para>
        /// </summary>
        public MemoryStream ZipFile
        {
            get { return this._zipFile; }
            set { this._zipFile = value; }
        }

        // Check to see if ZipFile property is set
        internal bool IsSetZipFile()
        {
            return this._zipFile != null;
        }

    }
}