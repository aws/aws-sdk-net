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
 * Do not modify this file. This file is generated from the nimble-2020-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NimbleStudio.Model
{
    /// <summary>
    /// This is the response object from the GetLaunchProfileDetails operation.
    /// </summary>
    public partial class GetLaunchProfileDetailsResponse : AmazonWebServiceResponse
    {
        private LaunchProfile _launchProfile;
        private List<StreamingImage> _streamingImages = new List<StreamingImage>();
        private List<StudioComponentSummary> _studioComponentSummaries = new List<StudioComponentSummary>();

        /// <summary>
        /// Gets and sets the property LaunchProfile. 
        /// <para>
        /// The launch profile.
        /// </para>
        /// </summary>
        public LaunchProfile LaunchProfile
        {
            get { return this._launchProfile; }
            set { this._launchProfile = value; }
        }

        // Check to see if LaunchProfile property is set
        internal bool IsSetLaunchProfile()
        {
            return this._launchProfile != null;
        }

        /// <summary>
        /// Gets and sets the property StreamingImages. 
        /// <para>
        /// A collection of streaming images.
        /// </para>
        /// </summary>
        public List<StreamingImage> StreamingImages
        {
            get { return this._streamingImages; }
            set { this._streamingImages = value; }
        }

        // Check to see if StreamingImages property is set
        internal bool IsSetStreamingImages()
        {
            return this._streamingImages != null && this._streamingImages.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StudioComponentSummaries. 
        /// <para>
        /// A collection of studio component summaries.
        /// </para>
        /// </summary>
        public List<StudioComponentSummary> StudioComponentSummaries
        {
            get { return this._studioComponentSummaries; }
            set { this._studioComponentSummaries = value; }
        }

        // Check to see if StudioComponentSummaries property is set
        internal bool IsSetStudioComponentSummaries()
        {
            return this._studioComponentSummaries != null && this._studioComponentSummaries.Count > 0; 
        }

    }
}