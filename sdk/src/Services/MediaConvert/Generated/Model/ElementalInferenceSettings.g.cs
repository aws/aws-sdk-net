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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// The Elemental Inference settings used in this job.
    /// </summary>
    public partial class ElementalInferenceSettings
    {
        /// <summary>
        /// Gets and sets the property FeedConfigurationSource. Optional. The source of your Elemental
        /// Inference Feed configuration. MediaConvert will reference this configuration source
        /// when you specify job settings which use Elemental Inference.
        /// </summary>
        public ElementalInferenceFeedConfigurationSource FeedConfigurationSource { get; set; }

        /// <summary>
        /// Checks to see if the FeedConfigurationSource property is set.
        /// </summary>
        internal bool IsSetFeedConfigurationSource() => this.FeedConfigurationSource != null;
    }
}
