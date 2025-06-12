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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
    /// Settings related to teletext captions. Set up teletext captions in the same output
    /// as your video. For more information, see https://docs.aws.amazon.com/mediaconvert/latest/ug/teletext-output-captions.html.
    /// </summary>
    public partial class TeletextDestinationSettings
    {
        private string _pageNumber;
        private List<string> _pageTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property PageNumber. Set pageNumber to the Teletext page number
        /// for the destination captions for this output. This value must be a three-digit hexadecimal
        /// string; strings ending in -FF are invalid. If you are passing through the entire set
        /// of Teletext data, do not use this field.
        /// </summary>
        [AWSProperty(Min=3, Max=3)]
        public string PageNumber
        {
            get { return this._pageNumber; }
            set { this._pageNumber = value; }
        }

        // Check to see if PageNumber property is set
        internal bool IsSetPageNumber()
        {
            return this._pageNumber != null;
        }

        /// <summary>
        /// Gets and sets the property PageTypes. Specify the page types for this Teletext page.
        /// If you don't specify a value here, the service sets the page type to the default value
        /// Subtitle. If you pass through the entire set of Teletext data, don't use this field.
        /// When you pass through a set of Teletext pages, your output has the same page types
        /// as your input.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PageTypes
        {
            get { return this._pageTypes; }
            set { this._pageTypes = value; }
        }

        // Check to see if PageTypes property is set
        internal bool IsSetPageTypes()
        {
            return this._pageTypes != null && (this._pageTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}