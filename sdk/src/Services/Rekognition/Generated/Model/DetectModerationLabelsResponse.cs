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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// This is the response object from the DetectModerationLabels operation.
    /// </summary>
    public partial class DetectModerationLabelsResponse : AmazonWebServiceResponse
    {
        private List<ModerationLabel> _moderationLabels = new List<ModerationLabel>();

        /// <summary>
        /// Gets and sets the property ModerationLabels. 
        /// <para>
        /// Array of detected Moderation labels and the time, in millseconds from the start of
        /// the video, they were detected.
        /// </para>
        /// </summary>
        public List<ModerationLabel> ModerationLabels
        {
            get { return this._moderationLabels; }
            set { this._moderationLabels = value; }
        }

        // Check to see if ModerationLabels property is set
        internal bool IsSetModerationLabels()
        {
            return this._moderationLabels != null && this._moderationLabels.Count > 0; 
        }

    }
}