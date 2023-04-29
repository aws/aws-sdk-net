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
    /// A workgroup, which contains a name, description, creation time, state, and other configuration,
    /// listed under <a>WorkGroup$Configuration</a>. Each workgroup enables you to isolate
    /// queries for you or your group of users from other queries in the same account, to
    /// configure the query results location and the encryption configuration (known as workgroup
    /// settings), to enable sending query metrics to Amazon CloudWatch, and to establish
    /// per-query data usage control limits for all queries in a workgroup. The workgroup
    /// settings override is specified in <code>EnforceWorkGroupConfiguration</code> (true/false)
    /// in the <code>WorkGroupConfiguration</code>. See <a>WorkGroupConfiguration$EnforceWorkGroupConfiguration</a>.
    /// </summary>
    public partial class WorkGroup
    {
        private WorkGroupConfiguration _configuration;
        private DateTime? _creationTime;
        private string _description;
        private string _name;
        private WorkGroupState _state;

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// The configuration of the workgroup, which includes the location in Amazon S3 where
        /// query and calculation results are stored, the encryption configuration, if any, used
        /// for query and calculation results; whether the Amazon CloudWatch Metrics are enabled
        /// for the workgroup; whether workgroup settings override client-side settings; and the
        /// data usage limits for the amount of data scanned per query or per workgroup. The workgroup
        /// settings override is specified in <code>EnforceWorkGroupConfiguration</code> (true/false)
        /// in the <code>WorkGroupConfiguration</code>. See <a>WorkGroupConfiguration$EnforceWorkGroupConfiguration</a>.
        /// </para>
        /// </summary>
        public WorkGroupConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time the workgroup was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The workgroup description.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The workgroup name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the workgroup: ENABLED or DISABLED.
        /// </para>
        /// </summary>
        public WorkGroupState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}