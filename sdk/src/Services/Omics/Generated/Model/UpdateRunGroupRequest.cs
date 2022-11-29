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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRunGroup operation.
    /// Updates a run group.
    /// </summary>
    public partial class UpdateRunGroupRequest : AmazonOmicsRequest
    {
        private string _id;
        private int? _maxCpus;
        private int? _maxDuration;
        private int? _maxRuns;
        private string _name;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The group's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=18)]
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
        /// Gets and sets the property MaxCpus. 
        /// <para>
        /// The maximum number of CPUs to use.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100000)]
        public int MaxCpus
        {
            get { return this._maxCpus.GetValueOrDefault(); }
            set { this._maxCpus = value; }
        }

        // Check to see if MaxCpus property is set
        internal bool IsSetMaxCpus()
        {
            return this._maxCpus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxDuration. 
        /// <para>
        /// The maximum amount of time to run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100000)]
        public int MaxDuration
        {
            get { return this._maxDuration.GetValueOrDefault(); }
            set { this._maxDuration = value; }
        }

        // Check to see if MaxDuration property is set
        internal bool IsSetMaxDuration()
        {
            return this._maxDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxRuns. 
        /// <para>
        /// The maximum number of concurrent runs for the group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100000)]
        public int MaxRuns
        {
            get { return this._maxRuns.GetValueOrDefault(); }
            set { this._maxRuns = value; }
        }

        // Check to see if MaxRuns property is set
        internal bool IsSetMaxRuns()
        {
            return this._maxRuns.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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