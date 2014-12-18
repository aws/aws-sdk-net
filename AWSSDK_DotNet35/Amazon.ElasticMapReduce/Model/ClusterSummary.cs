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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// The summary description of the cluster.
    /// </summary>
    public partial class ClusterSummary
    {
        private string _id;
        private string _name;
        private int? _normalizedInstanceHours;
        private ClusterStatus _status;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the cluster.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the cluster.
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

        /// <summary>
        /// Gets and sets the property NormalizedInstanceHours. 
        /// <para>
        /// An approximation of the cost of the job flow, represented in m1.small/hours. This
        /// value is incremented one time for every hour an m1.small instance runs. Larger instances
        /// are weighted more, so an EC2 instance that is roughly four times more expensive would
        /// result in the normalized instance hours being incremented by four. This result is
        /// only an approximation and does not reflect the actual billing rate.
        /// </para>
        /// </summary>
        public int NormalizedInstanceHours
        {
            get { return this._normalizedInstanceHours.GetValueOrDefault(); }
            set { this._normalizedInstanceHours = value; }
        }

        // Check to see if NormalizedInstanceHours property is set
        internal bool IsSetNormalizedInstanceHours()
        {
            return this._normalizedInstanceHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The details about the current status of the cluster.
        /// </para>
        /// </summary>
        public ClusterStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}