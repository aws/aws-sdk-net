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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Filter criteria for ListAlerts. All members are optional; each omitted member is unconstrained.
    /// At most one of {@code names}, {@code namePrefix}, {@code ids} may be provided (mutually
    /// exclusive; the service rejects more than one). The remaining members combine with
    /// AND.
    /// </summary>
    public partial class AlertFilterCriteria
    {
        private List<string> _ids = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _namePrefix;
        private List<string> _names = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _notificationsEnabled;
        private List<string> _stateValue = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Ids. 
        /// <para>
        /// Filter to alerts whose {@link AlertId} exactly matches any entry (OR semantics). Mutually
        /// exclusive with {@code names} and {@code namePrefix}.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> Ids
        {
            get { return this._ids; }
            set { this._ids = value; }
        }

        // Check to see if Ids property is set
        internal bool IsSetIds()
        {
            return this._ids != null && (this._ids.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NamePrefix. 
        /// <para>
        /// Filter to alerts whose name starts with this prefix. Mutually exclusive with {@code
        /// names} and {@code ids}.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string NamePrefix
        {
            get { return this._namePrefix; }
            set { this._namePrefix = value; }
        }

        // Check to see if NamePrefix property is set
        internal bool IsSetNamePrefix()
        {
            return this._namePrefix != null;
        }

        /// <summary>
        /// Gets and sets the property Names. 
        /// <para>
        /// Filter to alerts whose name exactly matches any entry (OR semantics). Mutually exclusive
        /// with {@code namePrefix} and {@code ids}.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<string> Names
        {
            get { return this._names; }
            set { this._names = value; }
        }

        // Check to see if Names property is set
        internal bool IsSetNames()
        {
            return this._names != null && (this._names.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NotificationsEnabled. 
        /// <para>
        /// Filter to alerts by whether notifications are enabled.
        /// </para>
        /// </summary>
        public bool? NotificationsEnabled
        {
            get { return this._notificationsEnabled; }
            set { this._notificationsEnabled = value; }
        }

        // Check to see if NotificationsEnabled property is set
        internal bool IsSetNotificationsEnabled()
        {
            return this._notificationsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StateValue. 
        /// <para>
        /// Filter to alerts currently in any of these states (OR semantics).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=4)]
        public List<string> StateValue
        {
            get { return this._stateValue; }
            set { this._stateValue = value; }
        }

        // Check to see if StateValue property is set
        internal bool IsSetStateValue()
        {
            return this._stateValue != null && (this._stateValue.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}