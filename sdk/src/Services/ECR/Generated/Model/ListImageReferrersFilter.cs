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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
namespace Amazon.ECR.Model
{
    /// <summary>
    /// An object representing a filter on a <a>ListImageReferrers</a> operation.
    /// </summary>
    public partial class ListImageReferrersFilter
    {
        private ArtifactStatusFilter _artifactStatus;
        private List<string> _artifactTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ArtifactStatus. 
        /// <para>
        /// The artifact status with which to filter your <a>ListImageReferrers</a> results. Valid
        /// values are <c>ACTIVE</c>, <c>ARCHIVED</c>, <c>ACTIVATING</c>, or <c>ANY</c>. If not
        /// specified, only artifacts with <c>ACTIVE</c> status are returned.
        /// </para>
        /// </summary>
        public ArtifactStatusFilter ArtifactStatus
        {
            get { return this._artifactStatus; }
            set { this._artifactStatus = value; }
        }

        // Check to see if ArtifactStatus property is set
        internal bool IsSetArtifactStatus()
        {
            return this._artifactStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ArtifactTypes. 
        /// <para>
        /// The artifact types with which to filter your <a>ListImageReferrers</a> results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<string> ArtifactTypes
        {
            get { return this._artifactTypes; }
            set { this._artifactTypes = value; }
        }

        // Check to see if ArtifactTypes property is set
        internal bool IsSetArtifactTypes()
        {
            return this._artifactTypes != null && (this._artifactTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}