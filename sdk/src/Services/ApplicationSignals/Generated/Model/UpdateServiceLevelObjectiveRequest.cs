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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateServiceLevelObjective operation.
    /// Updates an existing service level objective (SLO). If you omit parameters, the previous
    /// values of those parameters are retained.
    /// </summary>
    public partial class UpdateServiceLevelObjectiveRequest : AmazonApplicationSignalsRequest
    {
        private string _description;
        private Goal _goal;
        private string _id;
        private ServiceLevelIndicatorConfig _sliConfig;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the SLO.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property Goal. 
        /// <para>
        /// A structure that contains the attributes that determine the goal of the SLO. This
        /// includes the time period for evaluation and the attainment threshold.
        /// </para>
        /// </summary>
        public Goal Goal
        {
            get { return this._goal; }
            set { this._goal = value; }
        }

        // Check to see if Goal property is set
        internal bool IsSetGoal()
        {
            return this._goal != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The Amazon Resource Name (ARN) or name of the service level objective that you want
        /// to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SliConfig. 
        /// <para>
        /// A structure that contains information about what performance metric this SLO will
        /// monitor.
        /// </para>
        /// </summary>
        public ServiceLevelIndicatorConfig SliConfig
        {
            get { return this._sliConfig; }
            set { this._sliConfig = value; }
        }

        // Check to see if SliConfig property is set
        internal bool IsSetSliConfig()
        {
            return this._sliConfig != null;
        }

    }
}