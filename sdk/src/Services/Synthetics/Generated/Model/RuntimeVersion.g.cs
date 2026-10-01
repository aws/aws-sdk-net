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

namespace Amazon.Synthetics.Model
{
    /// <summary>
    /// This structure contains information about one canary runtime version. For more information
    /// about runtime versions, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_Library.html">
    /// Canary Runtime Versions</a>.
    /// </summary>
    public partial class RuntimeVersion
    {
        /// <summary>
        /// Gets and sets the property DeprecationDate. 
        /// <para>
        /// If this runtime version is deprecated, this value is the date of deprecation.
        /// </para>
        /// </summary>
        public DateTime? DeprecationDate { get; set; }

        /// <summary>
        /// Checks to see if the DeprecationDate property is set.
        /// </summary>
        internal bool IsSetDeprecationDate() => this.DeprecationDate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the runtime version, created by Amazon.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ReleaseDate. 
        /// <para>
        /// The date that the runtime version was released.
        /// </para>
        /// </summary>
        public DateTime? ReleaseDate { get; set; }

        /// <summary>
        /// Checks to see if the ReleaseDate property is set.
        /// </summary>
        internal bool IsSetReleaseDate() => this.ReleaseDate.HasValue;

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        /// The name of the runtime version. For a list of valid runtime versions, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_Library.html">
        /// Canary Runtime Versions</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string VersionName { get; set; }

        /// <summary>
        /// Checks to see if the VersionName property is set.
        /// </summary>
        internal bool IsSetVersionName() => this.VersionName != null;
    }
}
