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
 * Do not modify this file. This file is generated from the location-2020-11-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LocationService.Model
{
    /// <summary>
    /// Specifies the political view for the style.
    /// </summary>
    public partial class MapConfigurationUpdate
    {
        private string _politicalView;

        /// <summary>
        /// Gets and sets the property PoliticalView. 
        /// <para>
        /// Specifies the political view for the style. Set to an empty string to not use a political
        /// view, or, for styles that support specific political views, you can choose a view,
        /// such as <code>IND</code> for the Indian view.
        /// </para>
        ///  <note> 
        /// <para>
        /// Not all map resources or styles support political view styles. See <a href="https://docs.aws.amazon.com/location/latest/developerguide/map-concepts.html#political-views">Political
        /// views</a> for more information.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public string PoliticalView
        {
            get { return this._politicalView; }
            set { this._politicalView = value; }
        }

        // Check to see if PoliticalView property is set
        internal bool IsSetPoliticalView()
        {
            return this._politicalView != null;
        }

    }
}