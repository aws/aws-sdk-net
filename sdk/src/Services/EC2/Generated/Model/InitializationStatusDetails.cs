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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private long? _estimatedTimeToCompleteInSeconds;
        private InitializationType _initializationType;
        private long? _progress;

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
        public long? EstimatedTimeToCompleteInSeconds
        {
            get { return this._estimatedTimeToCompleteInSeconds; }
            set { this._estimatedTimeToCompleteInSeconds = value; }
        }

        // Check to see if EstimatedTimeToCompleteInSeconds property is set
        internal bool IsSetEstimatedTimeToCompleteInSeconds()
        {
            return this._estimatedTimeToCompleteInSeconds.HasValue; 
        }

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
        ///  </li> </ul>
        /// </summary>
        public InitializationType InitializationType
        {
            get { return this._initializationType; }
            set { this._initializationType = value; }
        }

        // Check to see if InitializationType property is set
        internal bool IsSetInitializationType()
        {
            return this._initializationType != null;
        }

        /// <summary>
        /// Gets and sets the property Progress. 
        /// <para>
        /// The current volume initialization progress as a percentage (0-100). Returns <c>100</c>
        /// when volume initialization has completed.
        /// </para>
        /// </summary>
        public long? Progress
        {
            get { return this._progress; }
            set { this._progress = value; }
        }

        // Check to see if Progress property is set
        internal bool IsSetProgress()
        {
            return this._progress.HasValue; 
        }

    }
}