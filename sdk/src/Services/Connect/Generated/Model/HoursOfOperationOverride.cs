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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about the hours of operations override.
    /// </summary>
    public partial class HoursOfOperationOverride
    {
        private List<HoursOfOperationOverrideConfig> _config = AWSConfigs.InitializeCollections ? new List<HoursOfOperationOverrideConfig>() : null;
        private string _description;
        private string _effectiveFrom;
        private string _effectiveTill;
        private string _hoursOfOperationArn;
        private string _hoursOfOperationId;
        private string _hoursOfOperationOverrideId;
        private string _name;

        /// <summary>
        /// Gets and sets the property Config. 
        /// <para>
        /// Configuration information for the hours of operation override: day, start time, and
        /// end time.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<HoursOfOperationOverrideConfig> Config
        {
            get { return this._config; }
            set { this._config = value; }
        }

        // Check to see if Config property is set
        internal bool IsSetConfig()
        {
            return this._config != null && (this._config.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the hours of operation override.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EffectiveFrom. 
        /// <para>
        /// The date from which the hours of operation override would be effective.
        /// </para>
        /// </summary>
        public string EffectiveFrom
        {
            get { return this._effectiveFrom; }
            set { this._effectiveFrom = value; }
        }

        // Check to see if EffectiveFrom property is set
        internal bool IsSetEffectiveFrom()
        {
            return this._effectiveFrom != null;
        }

        /// <summary>
        /// Gets and sets the property EffectiveTill. 
        /// <para>
        /// The date until the hours of operation override is effective.
        /// </para>
        /// </summary>
        public string EffectiveTill
        {
            get { return this._effectiveTill; }
            set { this._effectiveTill = value; }
        }

        // Check to see if EffectiveTill property is set
        internal bool IsSetEffectiveTill()
        {
            return this._effectiveTill != null;
        }

        /// <summary>
        /// Gets and sets the property HoursOfOperationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the hours of operation.
        /// </para>
        /// </summary>
        public string HoursOfOperationArn
        {
            get { return this._hoursOfOperationArn; }
            set { this._hoursOfOperationArn = value; }
        }

        // Check to see if HoursOfOperationArn property is set
        internal bool IsSetHoursOfOperationArn()
        {
            return this._hoursOfOperationArn != null;
        }

        /// <summary>
        /// Gets and sets the property HoursOfOperationId. 
        /// <para>
        /// The identifier for the hours of operation.
        /// </para>
        /// </summary>
        public string HoursOfOperationId
        {
            get { return this._hoursOfOperationId; }
            set { this._hoursOfOperationId = value; }
        }

        // Check to see if HoursOfOperationId property is set
        internal bool IsSetHoursOfOperationId()
        {
            return this._hoursOfOperationId != null;
        }

        /// <summary>
        /// Gets and sets the property HoursOfOperationOverrideId. 
        /// <para>
        /// The identifier for the hours of operation override.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
        public string HoursOfOperationOverrideId
        {
            get { return this._hoursOfOperationOverrideId; }
            set { this._hoursOfOperationOverrideId = value; }
        }

        // Check to see if HoursOfOperationOverrideId property is set
        internal bool IsSetHoursOfOperationOverrideId()
        {
            return this._hoursOfOperationOverrideId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the hours of operation override.
        /// </para>
        /// </summary>
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

    }
}