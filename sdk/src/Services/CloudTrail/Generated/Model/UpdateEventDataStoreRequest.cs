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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateEventDataStore operation.
    /// Updates an event data store. The required <code>EventDataStore</code> value is an
    /// ARN or the ID portion of the ARN. Other parameters are optional, but at least one
    /// optional parameter must be specified, or CloudTrail throws an error. <code>RetentionPeriod</code>
    /// is in days, and valid values are integers between 90 and 2555. By default, <code>TerminationProtection</code>
    /// is enabled. <code>AdvancedEventSelectors</code> includes or excludes management and
    /// data events in your event data store; for more information about <code>AdvancedEventSelectors</code>,
    /// see <a>PutEventSelectorsRequest$AdvancedEventSelectors</a>.
    /// </summary>
    public partial class UpdateEventDataStoreRequest : AmazonCloudTrailRequest
    {
        private List<AdvancedEventSelector> _advancedEventSelectors = new List<AdvancedEventSelector>();
        private string _eventDataStore;
        private bool? _multiRegionEnabled;
        private string _name;
        private bool? _organizationEnabled;
        private int? _retentionPeriod;
        private bool? _terminationProtectionEnabled;

        /// <summary>
        /// Gets and sets the property AdvancedEventSelectors. 
        /// <para>
        /// The advanced event selectors used to select events for the event data store.
        /// </para>
        /// </summary>
        public List<AdvancedEventSelector> AdvancedEventSelectors
        {
            get { return this._advancedEventSelectors; }
            set { this._advancedEventSelectors = value; }
        }

        // Check to see if AdvancedEventSelectors property is set
        internal bool IsSetAdvancedEventSelectors()
        {
            return this._advancedEventSelectors != null && this._advancedEventSelectors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EventDataStore. 
        /// <para>
        /// The ARN (or the ID suffix of the ARN) of the event data store that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=256)]
        public string EventDataStore
        {
            get { return this._eventDataStore; }
            set { this._eventDataStore = value; }
        }

        // Check to see if EventDataStore property is set
        internal bool IsSetEventDataStore()
        {
            return this._eventDataStore != null;
        }

        /// <summary>
        /// Gets and sets the property MultiRegionEnabled. 
        /// <para>
        /// Specifies whether an event data store collects events from all regions, or only from
        /// the region in which it was created.
        /// </para>
        /// </summary>
        public bool MultiRegionEnabled
        {
            get { return this._multiRegionEnabled.GetValueOrDefault(); }
            set { this._multiRegionEnabled = value; }
        }

        // Check to see if MultiRegionEnabled property is set
        internal bool IsSetMultiRegionEnabled()
        {
            return this._multiRegionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The event data store name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationEnabled. 
        /// <para>
        /// Specifies whether an event data store collects events logged for an organization in
        /// Organizations.
        /// </para>
        /// </summary>
        public bool OrganizationEnabled
        {
            get { return this._organizationEnabled.GetValueOrDefault(); }
            set { this._organizationEnabled = value; }
        }

        // Check to see if OrganizationEnabled property is set
        internal bool IsSetOrganizationEnabled()
        {
            return this._organizationEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetentionPeriod. 
        /// <para>
        /// The retention period, in days.
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=2555)]
        public int RetentionPeriod
        {
            get { return this._retentionPeriod.GetValueOrDefault(); }
            set { this._retentionPeriod = value; }
        }

        // Check to see if RetentionPeriod property is set
        internal bool IsSetRetentionPeriod()
        {
            return this._retentionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TerminationProtectionEnabled. 
        /// <para>
        /// Indicates that termination protection is enabled and the event data store cannot be
        /// automatically deleted.
        /// </para>
        /// </summary>
        public bool TerminationProtectionEnabled
        {
            get { return this._terminationProtectionEnabled.GetValueOrDefault(); }
            set { this._terminationProtectionEnabled = value; }
        }

        // Check to see if TerminationProtectionEnabled property is set
        internal bool IsSetTerminationProtectionEnabled()
        {
            return this._terminationProtectionEnabled.HasValue; 
        }

    }
}