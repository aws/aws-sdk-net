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
 * Do not modify this file. This file is generated from the mediatailor-2018-04-23.normal.json service model.
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
namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// The configuration for bumpers. Bumpers are short audio or video clips that play at
    /// the start or before the end of an ad break. To learn more about bumpers, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/bumpers.html">Bumpers</a>.
    /// </summary>
    public partial class Bumper
    {
        private string _endUrl;
        private string _startUrl;

        /// <summary>
        /// Gets and sets the property EndUrl. 
        /// <para>
        /// The URL for the end bumper asset.
        /// </para>
        /// </summary>
        public string EndUrl
        {
            get { return this._endUrl; }
            set { this._endUrl = value; }
        }

        // Check to see if EndUrl property is set
        internal bool IsSetEndUrl()
        {
            return this._endUrl != null;
        }

        /// <summary>
        /// Gets and sets the property StartUrl. 
        /// <para>
        /// The URL for the start bumper asset.
        /// </para>
        /// </summary>
        public string StartUrl
        {
            get { return this._startUrl; }
            set { this._startUrl = value; }
        }

        // Check to see if StartUrl property is set
        internal bool IsSetStartUrl()
        {
            return this._startUrl != null;
        }

    }
}