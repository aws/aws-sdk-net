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
 * Do not modify this file. This file is generated from the clouddirectory-2017-01-11.normal.json service model.
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
    /// Container for the parameters to the UpgradePublishedSchema operation.
    /// Upgrades a published schema under a new minor version revision using the current contents
    /// of <c>DevelopmentSchemaArn</c>.
    /// </summary>
    public partial class UpgradePublishedSchemaRequest : AmazonCloudDirectoryRequest
    {
        private string _developmentSchemaArn;
        private bool? _dryRun;
        private string _minorVersion;
        private string _publishedSchemaArn;

        /// <summary>
        /// Gets and sets the property DevelopmentSchemaArn. 
        /// <para>
        /// The ARN of the development schema with the changes used for the upgrade.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DevelopmentSchemaArn
        {
            get { return this._developmentSchemaArn; }
            set { this._developmentSchemaArn = value; }
        }

        // Check to see if DevelopmentSchemaArn property is set
        internal bool IsSetDevelopmentSchemaArn()
        {
            return this._developmentSchemaArn != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Used for testing whether the Development schema provided is backwards compatible,
        /// or not, with the publish schema provided by the user to be upgraded. If schema compatibility
        /// fails, an exception would be thrown else the call would succeed. This parameter is
        /// optional and defaults to false.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinorVersion. 
        /// <para>
        /// Identifies the minor version of the published schema that will be created. This parameter
        /// is NOT optional.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public string MinorVersion
        {
            get { return this._minorVersion; }
            set { this._minorVersion = value; }
        }

        // Check to see if MinorVersion property is set
        internal bool IsSetMinorVersion()
        {
            return this._minorVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PublishedSchemaArn. 
        /// <para>
        /// The ARN of the published schema to be upgraded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PublishedSchemaArn
        {
            get { return this._publishedSchemaArn; }
            set { this._publishedSchemaArn = value; }
        }

        // Check to see if PublishedSchemaArn property is set
        internal bool IsSetPublishedSchemaArn()
        {
            return this._publishedSchemaArn != null;
        }

    }
}