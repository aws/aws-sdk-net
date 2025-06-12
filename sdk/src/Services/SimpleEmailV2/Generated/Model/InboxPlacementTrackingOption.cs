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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
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
namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// An object that contains information about the inbox placement data settings for a
    /// verified domain that’s associated with your Amazon Web Services account. This data
    /// is available only if you enabled the Deliverability dashboard for the domain.
    /// </summary>
    public partial class InboxPlacementTrackingOption
    {
        private bool? _global;
        private List<string> _trackedIsps = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Global. 
        /// <para>
        /// Specifies whether inbox placement data is being tracked for the domain.
        /// </para>
        /// </summary>
        public bool? Global
        {
            get { return this._global; }
            set { this._global = value; }
        }

        // Check to see if Global property is set
        internal bool IsSetGlobal()
        {
            return this._global.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrackedIsps. 
        /// <para>
        /// An array of strings, one for each major email provider that the inbox placement data
        /// applies to.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TrackedIsps
        {
            get { return this._trackedIsps; }
            set { this._trackedIsps = value; }
        }

        // Check to see if TrackedIsps property is set
        internal bool IsSetTrackedIsps()
        {
            return this._trackedIsps != null && (this._trackedIsps.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}