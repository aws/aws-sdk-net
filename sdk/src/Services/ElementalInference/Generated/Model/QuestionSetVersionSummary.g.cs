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

namespace Amazon.ElementalInference.Model
{
    /// <summary>
    /// Contains summary information about one version of a question set. Used in the ListQuestionSetVersions
    /// response.
    /// </summary>
    public partial class QuestionSetVersionSummary
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description that you specified when you published this version. Elemental Inference
        /// doesn't return this property for DRAFT, or for a version that you published without
        /// a description. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property LastModifiedAt. 
        /// <para>
        /// For DRAFT, the time when you created the question set or last updated DRAFT. For a
        /// published version, the time when you published it. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedAt property is set.
        /// </summary>
        internal bool IsSetLastModifiedAt() => this.LastModifiedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Sha256. 
        /// <para>
        /// The SHA-256 hash of this version, as 64 lowercase hexadecimal characters. The hash
        /// covers the name of the question set and its questions at this version. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Sha256 { get; set; }

        /// <summary>
        /// Checks to see if the Sha256 property is set.
        /// </summary>
        internal bool IsSetSha256() => this.Sha256 != null;

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version: DRAFT or the number of a published version.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
