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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Contains an image that is available at a URL.
    /// </summary>
    public partial class Image
    {
        private DateTime? _lastUpdateDate;
        private string _locationUrl;

        /// <summary>
        /// Gets and sets the property LastUpdateDate. 
        /// <para>
        /// The date the image was last updated, in Unix epoch time.
        /// </para>
        /// </summary>
        public DateTime LastUpdateDate
        {
            get { return this._lastUpdateDate.GetValueOrDefault(); }
            set { this._lastUpdateDate = value; }
        }

        // Check to see if LastUpdateDate property is set
        internal bool IsSetLastUpdateDate()
        {
            return this._lastUpdateDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocationUrl. 
        /// <para>
        /// A URL at which the image is available. The URL is valid for 15 minutes for you to
        /// view and download the image.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string LocationUrl
        {
            get { return this._locationUrl; }
            set { this._locationUrl = value; }
        }

        // Check to see if LocationUrl property is set
        internal bool IsSetLocationUrl()
        {
            return this._locationUrl != null;
        }

    }
}