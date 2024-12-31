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
    /// Determines how the image is scaled
    /// </summary>
    public partial class SheetImageScalingConfiguration
    {
        private SheetImageScalingType _scalingType;

        /// <summary>
        /// Gets and sets the property ScalingType. 
        /// <para>
        /// The scaling option to use when fitting the image inside the container.
        /// </para>
        ///  
        /// <para>
        /// Valid values are defined as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SCALE_TO_WIDTH</c>: The image takes up the entire width of the container. The
        /// image aspect ratio is preserved.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SCALE_TO_HEIGHT</c>: The image takes up the entire height of the container. The
        /// image aspect ratio is preserved.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SCALE_TO_CONTAINER</c>: The image takes up the entire width and height of the
        /// container. The image aspect ratio is not preserved.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SCALE_NONE</c>: The image is displayed in its original size and is not scaled
        /// to the container.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SheetImageScalingType ScalingType
        {
            get { return this._scalingType; }
            set { this._scalingType = value; }
        }

        // Check to see if ScalingType property is set
        internal bool IsSetScalingType()
        {
            return this._scalingType != null;
        }

    }
}