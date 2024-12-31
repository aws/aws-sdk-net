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
    /// The general image interactions setup for image publish options.
    /// </summary>
    public partial class ImageInteractionOptions
    {
        private ImageMenuOption _imageMenuOption;

        /// <summary>
        /// Gets and sets the property ImageMenuOption. 
        /// <para>
        /// The menu options for the image.
        /// </para>
        /// </summary>
        public ImageMenuOption ImageMenuOption
        {
            get { return this._imageMenuOption; }
            set { this._imageMenuOption = value; }
        }

        // Check to see if ImageMenuOption property is set
        internal bool IsSetImageMenuOption()
        {
            return this._imageMenuOption != null;
        }

    }
}