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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Configuration for Moderation Labels Detection.
    /// </summary>
    public partial class MediaAnalysisDetectModerationLabelsConfig
    {
        /// <summary>
        /// Gets and sets the property MinConfidence. 
        /// <para>
        /// Specifies the minimum confidence level for the moderation labels to return. Amazon
        /// Rekognition doesn't return any labels with a confidence level lower than this specified
        /// value. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? MinConfidence { get; set; }

        /// <summary>
        /// Checks to see if the MinConfidence property is set.
        /// </summary>
        internal bool IsSetMinConfidence() => this.MinConfidence.HasValue;

        /// <summary>
        /// Gets and sets the property ProjectVersion. 
        /// <para>
        /// Specifies the custom moderation model to be used during the label detection job. If
        /// not provided the pre-trained model is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ProjectVersion { get; set; }

        /// <summary>
        /// Checks to see if the ProjectVersion property is set.
        /// </summary>
        internal bool IsSetProjectVersion() => this.ProjectVersion != null;
    }
}
