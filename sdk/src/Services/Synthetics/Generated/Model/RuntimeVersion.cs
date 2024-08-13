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
 * Do not modify this file. This file is generated from the synthetics-2017-10-11.normal.json service model.
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
        private DateTime? _deprecationDate;
        private string _description;
        private DateTime? _releaseDate;
        private string _versionName;

        /// <summary>
        /// Gets and sets the property DeprecationDate. 
        /// <para>
        /// If this runtime version is deprecated, this value is the date of deprecation.
        /// </para>
        /// </summary>
        public DateTime? DeprecationDate
        {
            get { return this._deprecationDate; }
            set { this._deprecationDate = value; }
        }

        // Check to see if DeprecationDate property is set
        internal bool IsSetDeprecationDate()
        {
            return this._deprecationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the runtime version, created by Amazon.
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
        /// Gets and sets the property ReleaseDate. 
        /// <para>
        /// The date that the runtime version was released.
        /// </para>
        /// </summary>
        public DateTime? ReleaseDate
        {
            get { return this._releaseDate; }
            set { this._releaseDate = value; }
        }

        // Check to see if ReleaseDate property is set
        internal bool IsSetReleaseDate()
        {
            return this._releaseDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VersionName. 
        /// <para>
        /// The name of the runtime version. For a list of valid runtime versions, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch_Synthetics_Canaries_Library.html">
        /// Canary Runtime Versions</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string VersionName
        {
            get { return this._versionName; }
            set { this._versionName = value; }
        }

        // Check to see if VersionName property is set
        internal bool IsSetVersionName()
        {
            return this._versionName != null;
        }

    }
}