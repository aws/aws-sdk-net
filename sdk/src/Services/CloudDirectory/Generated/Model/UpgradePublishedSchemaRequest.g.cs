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

namespace Amazon.CloudDirectory.Model
{
    /// <summary>
    /// Container for the parameters to the UpgradePublishedSchema operation. Upgrades a published
    /// schema under a new minor version revision using the current contents of <c>DevelopmentSchemaArn</c>.
    /// </summary>
    public partial class UpgradePublishedSchemaRequest : AmazonCloudDirectoryRequest
    {
        /// <summary>
        /// Gets and sets the property DevelopmentSchemaArn. 
        /// <para>
        /// The ARN of the development schema with the changes used for the upgrade.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DevelopmentSchemaArn { get; set; }

        /// <summary>
        /// Checks to see if the DevelopmentSchemaArn property is set.
        /// </summary>
        internal bool IsSetDevelopmentSchemaArn() => this.DevelopmentSchemaArn != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Used for testing whether the Development schema provided is backwards compatible,
        /// or not, with the publish schema provided by the user to be upgraded. If schema compatibility
        /// fails, an exception would be thrown else the call would succeed. This parameter is
        /// optional and defaults to false.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property MinorVersion. 
        /// <para>
        /// Identifies the minor version of the published schema that will be created. This parameter
        /// is NOT optional.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public string MinorVersion { get; set; }

        /// <summary>
        /// Checks to see if the MinorVersion property is set.
        /// </summary>
        internal bool IsSetMinorVersion() => this.MinorVersion != null;

        /// <summary>
        /// Gets and sets the property PublishedSchemaArn. 
        /// <para>
        /// The ARN of the published schema to be upgraded.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PublishedSchemaArn { get; set; }

        /// <summary>
        /// Checks to see if the PublishedSchemaArn property is set.
        /// </summary>
        internal bool IsSetPublishedSchemaArn() => this.PublishedSchemaArn != null;
    }
}
