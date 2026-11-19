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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.WellArchitected.Model
{
    /// <summary>
    /// Container for the parameters to the PutAgentPreferences operation. Creates or replaces
    /// the caller's Well-Architected Agent preferences. Each supplied update sets the desired
    /// state of one preference. Preferences not named in the request are left unchanged.
    /// Enabling or disabling is performed synchronously, so a failure to reach the requested
    /// state is returned as a modeled exception rather than a FAILED status. On success the
    /// operation returns an empty response. Call GetAgentPreferences to read the resulting
    /// state. The account the preferences belong to is inferred from the caller's authorization
    /// context.
    /// </summary>
    public partial class PutAgentPreferencesRequest : AmazonWellArchitectedRequest
    {
        /// <summary>
        /// Gets and sets the property Preferences. 
        /// <para>
        /// Preference updates to apply. A given preference key may appear at most once.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 50)]
        public List<PreferenceUpdate> Preferences { get; set; } = AWSConfigs.InitializeCollections ? new List<PreferenceUpdate>() : null;

        /// <summary>
        /// Checks to see if the Preferences property is set.
        /// </summary>
        internal bool IsSetPreferences() => this.Preferences != null && (this.Preferences.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
