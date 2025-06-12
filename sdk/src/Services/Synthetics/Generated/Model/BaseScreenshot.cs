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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
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
namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// A structure representing a screenshot that is used as a baseline during visual monitoring
    /// comparisons made by the canary.
    /// </summary>
    public partial class BaseScreenshot
    {
        private List<string> _ignoreCoordinates = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _screenshotName;

        /// <summary>
        /// Gets and sets the property IgnoreCoordinates. 
        /// <para>
        /// Coordinates that define the part of a screen to ignore during screenshot comparisons.
        /// To obtain the coordinates to use here, use the CloudWatch console to draw the boundaries
        /// on the screen. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/synthetics_canaries_deletion.html">
        /// Editing or deleting a canary</a> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<string> IgnoreCoordinates
        {
            get { return this._ignoreCoordinates; }
            set { this._ignoreCoordinates = value; }
        }

        // Check to see if IgnoreCoordinates property is set
        internal bool IsSetIgnoreCoordinates()
        {
            return this._ignoreCoordinates != null && (this._ignoreCoordinates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ScreenshotName. 
        /// <para>
        /// The name of the screenshot. This is generated the first time the canary is run after
        /// the <c>UpdateCanary</c> operation that specified for this canary to perform visual
        /// monitoring.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ScreenshotName
        {
            get { return this._screenshotName; }
            set { this._screenshotName = value; }
        }

        // Check to see if ScreenshotName property is set
        internal bool IsSetScreenshotName()
        {
            return this._screenshotName != null;
        }

    }
}