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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Information about of the hours of operation.
    /// </summary>
    public partial class HoursOfOperation
    {
        private List<HoursOfOperationConfig> _config = new List<HoursOfOperationConfig>();
        private string _description;
        private string _hoursOfOperationArn;
        private string _hoursOfOperationId;
        private string _name;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _timeZone;

        /// <summary>
        /// Gets and sets the property Config. 
        /// <para>
        /// Configuration information for the hours of operation.
        /// </para>
        /// </summary>
        public List<HoursOfOperationConfig> Config
        {
            get { return this._config; }
            set { this._config = value; }
        }

        // Check to see if Config property is set
        internal bool IsSetConfig()
        {
            return this._config != null && this._config.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the hours of operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=250)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name for the hours of operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TimeZone. 
        /// <para>
        /// The time zone for the hours of operation.
        /// </para>
        /// </summary>
        public string TimeZone
        {
            get { return this._timeZone; }
            set { this._timeZone = value; }
        }

        // Check to see if TimeZone property is set
        internal bool IsSetTimeZone()
        {
            return this._timeZone != null;
        }

    }
}