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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Contains the configuration of the S3 location of the output data.
    /// </summary>
    public partial class ModelInvocationJobOutputDataConfig
    {
        private ModelInvocationJobS3OutputDataConfig _s3OutputDataConfig;

        /// <summary>
        /// Gets and sets the property S3OutputDataConfig. 
        /// <para>
        /// Contains the configuration of the S3 location of the output data.
        /// </para>
        /// </summary>
        public ModelInvocationJobS3OutputDataConfig S3OutputDataConfig
        {
            get { return this._s3OutputDataConfig; }
            set { this._s3OutputDataConfig = value; }
        }

        // Check to see if S3OutputDataConfig property is set
        internal bool IsSetS3OutputDataConfig()
        {
            return this._s3OutputDataConfig != null;
        }

    }
}