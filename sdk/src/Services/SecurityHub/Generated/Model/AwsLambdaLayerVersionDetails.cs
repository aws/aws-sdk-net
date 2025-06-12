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

#pragma warning disable CS0612,CS0618,CS1570
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
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