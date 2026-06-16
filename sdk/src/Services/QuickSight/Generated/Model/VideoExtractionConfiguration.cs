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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// The configuration for video extraction from knowledge base documents.
    /// </summary>
    public partial class VideoExtractionConfiguration
    {
        private VideoExtractionStatus _videoExtractionStatus;
        private VideoExtractionType _videoExtractionType;

        /// <summary>
        /// Gets and sets the property VideoExtractionStatus. 
        /// <para>
        /// The status of video extraction. Valid values are ENABLED and DISABLED.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VideoExtractionStatus VideoExtractionStatus
        {
            get { return this._videoExtractionStatus; }
            set { this._videoExtractionStatus = value; }
        }

        // Check to see if VideoExtractionStatus property is set
        internal bool IsSetVideoExtractionStatus()
        {
            return this._videoExtractionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property VideoExtractionType. 
        /// <para>
        /// The type of video extraction to perform.
        /// </para>
        /// </summary>
        public VideoExtractionType VideoExtractionType
        {
            get { return this._videoExtractionType; }
            set { this._videoExtractionType = value; }
        }

        // Check to see if VideoExtractionType property is set
        internal bool IsSetVideoExtractionType()
        {
            return this._videoExtractionType != null;
        }

    }
}