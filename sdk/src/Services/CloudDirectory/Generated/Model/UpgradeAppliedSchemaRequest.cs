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
    /// Container for the parameters to the UpgradeAppliedSchema operation.
    /// Upgrades a single directory in-place using the <c>PublishedSchemaArn</c> with schema
    /// updates found in <c>MinorVersion</c>. Backwards-compatible minor version upgrades
    /// are instantaneously available for readers on all objects in the directory. Note: This
    /// is a synchronous API call and upgrades only one schema on a given directory per call.
    /// To upgrade multiple directories from one schema, you would need to call this API on
    /// each directory.
    /// </summary>
    public partial class UpgradeAppliedSchemaRequest : AmazonCloudDirectoryRequest
    {
        private string _directoryArn;
        private bool? _dryRun;
        private string _publishedSchemaArn;

        /// <summary>
        /// Gets and sets the property DirectoryArn. 
        /// <para>
        /// The ARN for the directory to which the upgraded schema will be applied.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryArn
        {
            get { return this._directoryArn; }
            set { this._directoryArn = value; }
        }

        // Check to see if DirectoryArn property is set
        internal bool IsSetDirectoryArn()
        {
            return this._directoryArn != null;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Used for testing whether the major version schemas are backward compatible or not.
        /// If schema compatibility fails, an exception would be thrown else the call would succeed
        /// but no changes will be saved. This parameter is optional.
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
        /// Gets and sets the property PublishedSchemaArn. 
        /// <para>
        /// The revision of the published schema to upgrade the directory to.
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