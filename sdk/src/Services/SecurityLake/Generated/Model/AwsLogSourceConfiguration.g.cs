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

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// To add a natively-supported Amazon Web Services service as a log source, use these
    /// parameters to specify the configuration settings for the log source.
    /// </summary>
    public partial class AwsLogSourceConfiguration
    {
        /// <summary>
        /// Gets and sets the property Accounts. 
        /// <para>
        /// Specify the Amazon Web Services account information where you want to enable Security
        /// Lake.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Accounts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Accounts property is set.
        /// </summary>
        internal bool IsSetAccounts() => this.Accounts != null && (this.Accounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Regions. 
        /// <para>
        /// Specify the Regions where you want to enable Security Lake.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<string> Regions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Regions property is set.
        /// </summary>
        internal bool IsSetRegions() => this.Regions != null && (this.Regions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourceName. 
        /// <para>
        /// The name for a Amazon Web Services source. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AwsLogSourceName SourceName { get; set; }

        /// <summary>
        /// Checks to see if the SourceName property is set.
        /// </summary>
        internal bool IsSetSourceName() => this.SourceName != null;

        /// <summary>
        /// Gets and sets the property SourceVersion. 
        /// <para>
        /// The version for a Amazon Web Services source. 
        /// </para>
        /// </summary>
        public string SourceVersion { get; set; }

        /// <summary>
        /// Checks to see if the SourceVersion property is set.
        /// </summary>
        internal bool IsSetSourceVersion() => this.SourceVersion != null;
    }
}
