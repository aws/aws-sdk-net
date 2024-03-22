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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details about a Lambda layer version.
    /// </summary>
    public partial class AwsLambdaLayerVersionDetails
    {
        private List<string> _compatibleRuntimes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _createdDate;
        private long? _version;

        /// <summary>
        /// Gets and sets the property CompatibleRuntimes. 
        /// <para>
        /// The layer's compatible runtimes. Maximum number of five items.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>nodejs10.x</c> | <c>nodejs12.x</c> | <c>java8</c> | <c>java11</c>
        /// | <c>python2.7</c> | <c>python3.6</c> | <c>python3.7</c> | <c>python3.8</c> | <c>dotnetcore1.0</c>
        /// | <c>dotnetcore2.1</c> | <c>go1.x</c> | <c>ruby2.5</c> | <c>provided</c> 
        /// </para>
        /// </summary>
        public List<string> CompatibleRuntimes
        {
            get { return this._compatibleRuntimes; }
            set { this._compatibleRuntimes = value; }
        }

        // Check to see if CompatibleRuntimes property is set
        internal bool IsSetCompatibleRuntimes()
        {
            return this._compatibleRuntimes != null && (this._compatibleRuntimes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// Indicates when the version was created.
        /// </para>
        ///  
        /// <para>
        /// Uses the <c>date-time</c> format specified in <a href="https://tools.ietf.org/html/rfc3339#section-5.6">RFC
        /// 3339 section 5.6, Internet Date/Time Format</a>. The value cannot contain spaces,
        /// and date and time should be separated by <c>T</c>. For example, <c>2020-03-22T13:22:13.933Z</c>.
        /// </para>
        /// </summary>
        public string CreatedDate
        {
            get { return this._createdDate; }
            set { this._createdDate = value; }
        }

        // Check to see if CreatedDate property is set
        internal bool IsSetCreatedDate()
        {
            return this._createdDate != null;
        }

        /// <summary>
        /// Gets and sets the property Version. 
        /// <para>
        /// The version number.
        /// </para>
        /// </summary>
        public long? Version
        {
            get { return this._version; }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}