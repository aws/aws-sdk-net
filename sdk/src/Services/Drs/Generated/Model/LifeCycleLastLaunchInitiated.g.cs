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

namespace Amazon.Drs.Model
{
    /// <summary>
    /// An object containing information regarding the initiation of the last launch of a
    /// Source Server.
    /// </summary>
    public partial class LifeCycleLastLaunchInitiated
    {
        /// <summary>
        /// Gets and sets the property ApiCallDateTime. 
        /// <para>
        /// The date and time the last Source Server launch was initiated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 19, Max = 32)]
        public string ApiCallDateTime { get; set; }

        /// <summary>
        /// Checks to see if the ApiCallDateTime property is set.
        /// </summary>
        internal bool IsSetApiCallDateTime() => this.ApiCallDateTime != null;

        /// <summary>
        /// Gets and sets the property JobID. 
        /// <para>
        /// The ID of the Job that was used to last launch the Source Server.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 24, Max = 24)]
        public string JobID { get; set; }

        /// <summary>
        /// Checks to see if the JobID property is set.
        /// </summary>
        internal bool IsSetJobID() => this.JobID != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The Job type that was used to last launch the Source Server.
        /// </para>
        /// </summary>
        public LastLaunchType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
