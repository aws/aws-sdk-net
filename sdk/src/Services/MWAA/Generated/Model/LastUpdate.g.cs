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

namespace Amazon.MWAA.Model
{
    /// <summary>
    /// Describes the status of the last update on the environment, and any errors that were
    /// encountered.
    /// </summary>
    public partial class LastUpdate
    {
        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The day and time of the last update on the environment.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The error that was encountered during the last update of the environment.
        /// </para>
        /// </summary>
        public UpdateError Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the last update to the environment. Includes internal processes by Amazon
        /// MWAA, such as an environment maintenance update.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the last update on the environment.
        /// </para>
        /// </summary>
        public UpdateStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property WorkerReplacementStrategy. 
        /// <para>
        /// The worker replacement strategy used in the last update of the environment.
        /// </para>
        /// </summary>
        public WorkerReplacementStrategy WorkerReplacementStrategy { get; set; }

        /// <summary>
        /// Checks to see if the WorkerReplacementStrategy property is set.
        /// </summary>
        internal bool IsSetWorkerReplacementStrategy() => this.WorkerReplacementStrategy != null;
    }
}
