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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// The values to use to filter results from the <a>DescribeAffectedEntities</a> operation.
    /// </summary>
    public partial class EntityFilter
    {
        private List<string> _entityArns = new List<string>();
        private List<string> _entityValues = new List<string>();
        private List<string> _eventArns = new List<string>();
        private List<DateTimeRange> _lastUpdatedTimes = new List<DateTimeRange>();
        private List<string> _statusCodes = new List<string>();
        private List<Dictionary<string, string>> _tags = new List<Dictionary<string, string>>();

        /// <summary>
        /// Gets and sets the property EntityArns. 
        /// <para>
        /// A list of entity ARNs (unique identifiers).
        /// </para>
        /// </summary>
        public List<string> EntityArns
        {
            get { return this._entityArns; }
            set { this._entityArns = value; }
        }

        // Check to see if EntityArns property is set
        internal bool IsSetEntityArns()
        {
            return this._entityArns != null && this._entityArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EntityValues. 
        /// <para>
        /// A list of IDs for affected entities.
        /// </para>
        /// </summary>
        public List<string> EntityValues
        {
            get { return this._entityValues; }
            set { this._entityValues = value; }
        }

        // Check to see if EntityValues property is set
        internal bool IsSetEntityValues()
        {
            return this._entityValues != null && this._entityValues.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EventArns. 
        /// <para>
        /// A list of event ARNs (unique identifiers). For example: <code>"arn:aws:health:us-east-1::event/AWS_EC2_MAINTENANCE_5331",
        /// "arn:aws:health:us-west-1::event/AWS_EBS_LOST_VOLUME_xyz"</code> 
        /// </para>
        /// </summary>
        public List<string> EventArns
        {
            get { return this._eventArns; }
            set { this._eventArns = value; }
        }

        // Check to see if EventArns property is set
        internal bool IsSetEventArns()
        {
            return this._eventArns != null && this._eventArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTimes. 
        /// <para>
        /// A list of the most recent dates and times that the entity was updated.
        /// </para>
        /// </summary>
        public List<DateTimeRange> LastUpdatedTimes
        {
            get { return this._lastUpdatedTimes; }
            set { this._lastUpdatedTimes = value; }
        }

        // Check to see if LastUpdatedTimes property is set
        internal bool IsSetLastUpdatedTimes()
        {
            return this._lastUpdatedTimes != null && this._lastUpdatedTimes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StatusCodes. 
        /// <para>
        /// A list of entity status codes (<code>IMPAIRED</code>, <code>UNIMPAIRED</code>, or
        /// <code>UNKNOWN</code>).
        /// </para>
        /// </summary>
        public List<string> StatusCodes
        {
            get { return this._statusCodes; }
            set { this._statusCodes = value; }
        }

        // Check to see if StatusCodes property is set
        internal bool IsSetStatusCodes()
        {
            return this._statusCodes != null && this._statusCodes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of entity tags attached to the affected entity.
        /// </para>
        /// </summary>
        public List<Dictionary<string, string>> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}