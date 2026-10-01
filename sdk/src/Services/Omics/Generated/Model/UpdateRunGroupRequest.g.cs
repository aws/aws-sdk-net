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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateRunGroup operation. Updates the settings
    /// of a run group and returns a response with no body if the operation is successful.
    /// <para> You can update the following settings with <c>UpdateRunGroup</c>: </para> <ul>
    /// <li> <para> Maximum number of CPUs </para> </li> <li> <para> Run time (measured in
    /// minutes) </para> </li> <li> <para> Number of GPUs </para> </li> <li> <para> Number
    /// of concurrent runs </para> </li> <li> <para> Group name </para> </li> </ul> <para>
    /// To confirm that the settings have been successfully updated, use the <c>ListRunGroups</c>
    /// or <c>GetRunGroup</c> API operations to verify that the desired changes have been
    /// made. </para>
    /// </summary>
    public partial class UpdateRunGroupRequest : AmazonOmicsRequest
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The group's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 18)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property MaxCpus. 
        /// <para>
        /// The maximum number of CPUs to use.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100000)]
        public int? MaxCpus { get; set; }

        /// <summary>
        /// Checks to see if the MaxCpus property is set.
        /// </summary>
        internal bool IsSetMaxCpus() => this.MaxCpus.HasValue;

        /// <summary>
        /// Gets and sets the property MaxDuration. 
        /// <para>
        /// A maximum run time for the group in minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100000)]
        public int? MaxDuration { get; set; }

        /// <summary>
        /// Checks to see if the MaxDuration property is set.
        /// </summary>
        internal bool IsSetMaxDuration() => this.MaxDuration.HasValue;

        /// <summary>
        /// Gets and sets the property MaxGpus. 
        /// <para>
        /// The maximum GPUs that can be used by a run group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100000)]
        public int? MaxGpus { get; set; }

        /// <summary>
        /// Checks to see if the MaxGpus property is set.
        /// </summary>
        internal bool IsSetMaxGpus() => this.MaxGpus.HasValue;

        /// <summary>
        /// Gets and sets the property MaxRuns. 
        /// <para>
        /// The maximum number of concurrent runs for the group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100000)]
        public int? MaxRuns { get; set; }

        /// <summary>
        /// Checks to see if the MaxRuns property is set.
        /// </summary>
        internal bool IsSetMaxRuns() => this.MaxRuns.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
