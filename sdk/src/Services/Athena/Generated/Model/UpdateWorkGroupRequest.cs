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
    /// Container for the parameters to the UpdateWorkGroup operation.
    /// Updates the workgroup with the specified name. The workgroup's name cannot be changed.
    /// Only <code>ConfigurationUpdates</code> can be specified.
    /// </summary>
    public partial class UpdateWorkGroupRequest : AmazonAthenaRequest
    {
        private WorkGroupConfigurationUpdates _configurationUpdates;
        private string _description;
        private WorkGroupState _state;
        private string _workGroup;

        /// <summary>
        /// Gets and sets the property ConfigurationUpdates. 
        /// <para>
        /// Contains configuration updates for an Athena SQL workgroup.
        /// </para>
        /// </summary>
        public WorkGroupConfigurationUpdates ConfigurationUpdates
        {
            get { return this._configurationUpdates; }
            set { this._configurationUpdates = value; }
        }

        // Check to see if ConfigurationUpdates property is set
        internal bool IsSetConfigurationUpdates()
        {
            return this._configurationUpdates != null;
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
        /// Gets and sets the property State. 
        /// <para>
        /// The workgroup state that will be updated for the given workgroup.
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

        /// <summary>
        /// Gets and sets the property WorkGroup. 
        /// <para>
        /// The specified workgroup that will be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string WorkGroup
        {
            get { return this._workGroup; }
            set { this._workGroup = value; }
        }

        // Check to see if WorkGroup property is set
        internal bool IsSetWorkGroup()
        {
            return this._workGroup != null;
        }

    }
}