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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The content quality analysis configuration for the router input.
    /// 
    ///  <important> 
    /// <para>
    /// The content quality analysis feature only monitors the first video stream and the
    /// first audio stream it encounters within the router input source.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class RouterContentQualityAnalysisConfiguration
    {
        private ContentQualityAnalysisFeatureConfiguration _contentLevel;

        /// <summary>
        /// Gets and sets the property ContentLevel. 
        /// <para>
        /// The content quality analysis configuration.
        /// </para>
        /// </summary>
        public ContentQualityAnalysisFeatureConfiguration ContentLevel
        {
            get { return this._contentLevel; }
            set { this._contentLevel = value; }
        }

        // Check to see if ContentLevel property is set
        internal bool IsSetContentLevel()
        {
            return this._contentLevel != null;
        }

    }
}