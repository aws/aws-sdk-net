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
    /// Represents an input or output artifact of a trial component. You specify <c>TrialComponentArtifact</c>
    /// as part of the <c>InputArtifacts</c> and <c>OutputArtifacts</c> parameters in the
    /// <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrialComponent.html">CreateTrialComponent</a>
    /// request.
    /// 
    ///  
    /// <para>
    /// Examples of input artifacts are datasets, algorithms, hyperparameters, source code,
    /// and instance types. Examples of output artifacts are metrics, snapshots, logs, and
    /// images.
    /// </para>
    /// </summary>
    public partial class TrialComponentArtifact
    {
        private string _mediaType;
        private string _value;

        /// <summary>
        /// Gets and sets the property MediaType. 
        /// <para>
        /// The media type of the artifact, which indicates the type of data in the artifact file.
        /// The media type consists of a <i>type</i> and a <i>subtype</i> concatenated with a
        /// slash (/) character, for example, text/csv, image/jpeg, and s3/uri. The type specifies
        /// the category of the media. The subtype specifies the kind of data.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=64)]
        public string MediaType
        {
            get { return this._mediaType; }
            set { this._mediaType = value; }
        }

        // Check to see if MediaType property is set
        internal bool IsSetMediaType()
        {
            return this._mediaType != null;
        }

        /// <summary>
        /// Gets and sets the property Value. 
        /// <para>
        /// The location of the artifact.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        // Check to see if Value property is set
        internal bool IsSetValue()
        {
            return this._value != null;
        }

    }
}