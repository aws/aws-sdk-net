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
        /// The layer's compatible <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html">function
        /// runtimes</a>.
        /// </para>
        ///  
        /// <para>
        /// The following list includes deprecated runtimes. For more information, see <a href="https://docs.aws.amazon.com/lambda/latest/dg/lambda-runtimes.html#runtime-support-policy">Runtime
        /// deprecation policy</a> in the <i>Lambda Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Array Members: Maximum number of 5 items.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <c>nodejs | nodejs4.3 | nodejs6.10 | nodejs8.10 | nodejs10.x | nodejs12.x
        /// | nodejs14.x | nodejs16.x | java8 | java8.al2 | java11 | python2.7 | python3.6 | python3.7
        /// | python3.8 | python3.9 | dotnetcore1.0 | dotnetcore2.0 | dotnetcore2.1 | dotnetcore3.1
        /// | dotnet6 | nodejs4.3-edge | go1.x | ruby2.5 | ruby2.7 | provided | provided.al2 |
        /// nodejs18.x | python3.10 | java17 | ruby3.2 | python3.11 | nodejs20.x | provided.al2023
        /// | python3.12 | java21</c> 
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
        /// This field accepts only the specified formats. Timestamps can end with <c>Z</c> or
        /// <c>("+" / "-") time-hour [":" time-minute]</c>. The time-secfrac after seconds is
        /// limited to a maximum of 9 digits. The offset is bounded by +/-18:00. Here are valid
        /// timestamp formats with examples:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SSZ</c> (for example, <c>2019-01-31T23:00:00Z</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS.mmmmmmmmmZ</c> (for example, <c>2019-01-31T23:00:00.123456789Z</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS+HH:MM</c> (for example, <c>2024-01-04T15:25:10+17:59</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS-HHMM</c> (for example, <c>2024-01-04T15:25:10-1759</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>YYYY-MM-DDTHH:MM:SS.mmmmmmmmm+HH:MM</c> (for example, <c>2024-01-04T15:25:10.123456789+17:59</c>)
        /// </para>
        ///  </li> </ul>
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
        public long Version
        {
            get { return this._version.GetValueOrDefault(); }
            set { this._version = value; }
        }

        // Check to see if Version property is set
        internal bool IsSetVersion()
        {
            return this._version.HasValue; 
        }

    }
}