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
 * Do not modify this file. This file is generated from the sagemaker-a2i-runtime-2019-11-07.normal.json service model.
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
namespace Amazon.AugmentedAIRuntime.Model
{
    /// <summary>
    /// Information about where the human output will be stored.
    /// </summary>
    public partial class HumanLoopOutput
    {
        private string _outputS3Uri;

        /// <summary>
        /// Gets and sets the property OutputS3Uri. 
        /// <para>
        /// The location of the Amazon S3 object where Amazon Augmented AI stores your human loop
        /// output.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OutputS3Uri
        {
            get { return this._outputS3Uri; }
            set { this._outputS3Uri = value; }
        }

        // Check to see if OutputS3Uri property is set
        internal bool IsSetOutputS3Uri()
        {
            return this._outputS3Uri != null;
        }

    }
}