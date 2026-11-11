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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Information about the volume initialization. For more information, see <a href="https://docs.aws.amazon.com/ebs/latest/userguide/initalize-volume.html">Initialize
    /// Amazon EBS volumes</a>.
    /// </summary>
    public partial class InitializationStatusDetails
    {
        /// <summary>
        /// Gets and sets the property EstimatedTimeToCompleteInSeconds. 
        /// <para>
        /// The estimated remaining time, in seconds, for volume initialization to complete. Returns
        /// <c>0</c> when volume initialization has completed.
        /// </para>
        ///  
        /// <para>
        /// Only available for volumes created with Amazon EBS Provisioned Rate for Volume Initialization.
        /// </para>
        /// </summary>
        public long? EstimatedTimeToCompleteInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedTimeToCompleteInSeconds property is set.
        /// </summary>
        internal bool IsSetEstimatedTimeToCompleteInSeconds() => this.EstimatedTimeToCompleteInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property InitializationType. 
        /// <para>
        /// The method used for volume initialization. Possible values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>default</c> - Volume initialized using the default volume initialization rate
        /// or fast snapshot restore.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>provisioned-rate</c> - Volume initialized using an Amazon EBS Provisioned Rate
        /// for Volume Initialization.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>volume-copy</c> - Volume copy initialized at the rate for volume copies.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InitializationType InitializationType { get; set; }

        /// <summary>
        /// Checks to see if the InitializationType property is set.
        /// </summary>
        internal bool IsSetInitializationType() => this.InitializationType != null;

        /// <summary>
        /// Gets and sets the property Progress. 
        /// <para>
        /// The current volume initialization progress as a percentage (0-100). Returns <c>100</c>
        /// when volume initialization has completed.
        /// </para>
        /// </summary>
        public long? Progress { get; set; }

        /// <summary>
        /// Checks to see if the Progress property is set.
        /// </summary>
        internal bool IsSetProgress() => this.Progress.HasValue;
    }
}
