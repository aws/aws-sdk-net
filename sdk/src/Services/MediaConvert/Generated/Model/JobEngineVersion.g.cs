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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Use Job engine versions to run jobs for your production workflow on one version, while
    /// you test and validate the latest version. Job engine versions are in a YYYY-MM-DD
    /// format.
    /// </summary>
    public partial class JobEngineVersion
    {
        /// <summary>
        /// Gets and sets the property ExpirationDate. The date that this Job engine version expires.
        /// Requests to create jobs with an expired version result in a regular job, as if no
        /// specific Job engine version was requested.
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationDate property is set.
        /// </summary>
        internal bool IsSetExpirationDate() => this.ExpirationDate.HasValue;

        /// <summary>
        /// Gets and sets the property Version. Use Job engine versions to run jobs for your production
        /// workflow on one version, while you test and validate the latest version. Job engine
        /// versions represent periodically grouped MediaConvert releases with new features, updates,
        /// improvements, and fixes. Job engine versions are in a YYYY-MM-DD format. Note that
        /// the Job engine version feature is not publicly available at this time. To request
        /// access, contact AWS support.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// Checks to see if the Version property is set.
        /// </summary>
        internal bool IsSetVersion() => this.Version != null;
    }
}
