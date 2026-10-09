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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Athena.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateWorkGroup operation. Updates the workgroup
    /// with the specified name. The workgroup's name cannot be changed. Only <c>ConfigurationUpdates</c>
    /// can be specified.
    /// </summary>
    public partial class UpdateWorkGroupRequest : AmazonAthenaRequest
    {
        /// <summary>
        /// Gets and sets the property ConfigurationUpdates. 
        /// <para>
        /// Contains configuration updates for an Athena SQL workgroup.
        /// </para>
        /// </summary>
        public WorkGroupConfigurationUpdates ConfigurationUpdates { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationUpdates property is set.
        /// </summary>
        internal bool IsSetConfigurationUpdates() => this.ConfigurationUpdates != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The workgroup description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The workgroup state that will be updated for the given workgroup.
        /// </para>
        /// </summary>
        public WorkGroupState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property WorkGroup. 
        /// <para>
        /// The specified workgroup that will be updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string WorkGroup { get; set; }

        /// <summary>
        /// Checks to see if the WorkGroup property is set.
        /// </summary>
        internal bool IsSetWorkGroup() => this.WorkGroup != null;
    }
}
