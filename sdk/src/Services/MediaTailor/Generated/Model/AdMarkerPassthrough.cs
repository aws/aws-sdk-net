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
    /// For HLS, when set to <c>true</c>, MediaTailor passes through <c>EXT-X-CUE-IN</c>,
    /// <c>EXT-X-CUE-OUT</c>, and <c>EXT-X-SPLICEPOINT-SCTE35</c> ad markers from the origin
    /// manifest to the MediaTailor personalized manifest.
    /// 
    ///  
    /// <para>
    /// No logic is applied to these ad markers. For example, if <c>EXT-X-CUE-OUT</c> has
    /// a value of <c>60</c>, but no ads are filled for that ad break, MediaTailor will not
    /// set the value to <c>0</c>.
    /// </para>
    /// </summary>
    public partial class AdMarkerPassthrough
    {
        private bool? _enabled;

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Enables ad marker passthrough for your configuration.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

    }
}