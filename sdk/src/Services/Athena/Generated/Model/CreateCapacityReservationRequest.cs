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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCapacityReservation operation.
    /// Creates a capacity reservation with the specified name and number of requested data
    /// processing units.
    /// </summary>
    public partial class CreateCapacityReservationRequest : AmazonAthenaRequest
    {
        private string _name;
        private List<Tag> _tags = new List<Tag>();
        private int? _targetDpus;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the capacity reservation to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// The tags for the capacity reservation.
        /// </para>
        /// </summary>
        public List<Tag> Tags
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
        /// Gets and sets the property TargetDpus. 
        /// <para>
        /// The number of requested data processing units.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=24)]
        public int TargetDpus
        {
            get { return this._targetDpus.GetValueOrDefault(); }
            set { this._targetDpus = value; }
        }

        // Check to see if TargetDpus property is set
        internal bool IsSetTargetDpus()
        {
            return this._targetDpus.HasValue; 
        }

    }
}