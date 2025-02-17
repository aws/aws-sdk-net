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
    /// Details about the location of the input to the batch inference job.
    /// </summary>
    public partial class ModelInvocationJobInputDataConfig
    {
        private ModelInvocationJobS3InputDataConfig _s3InputDataConfig;

        /// <summary>
        /// Gets and sets the property S3InputDataConfig. 
        /// <para>
        /// Contains the configuration of the S3 location of the input data.
        /// </para>
        /// </summary>
        public ModelInvocationJobS3InputDataConfig S3InputDataConfig
        {
            get { return this._s3InputDataConfig; }
            set { this._s3InputDataConfig = value; }
        }

        // Check to see if S3InputDataConfig property is set
        internal bool IsSetS3InputDataConfig()
        {
            return this._s3InputDataConfig != null;
        }

    }
}