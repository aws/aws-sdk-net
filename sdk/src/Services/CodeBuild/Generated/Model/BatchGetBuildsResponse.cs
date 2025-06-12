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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
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
namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// This is the response object from the BatchGetBuilds operation.
    /// </summary>
    public partial class BatchGetBuildsResponse : AmazonWebServiceResponse
    {
        private List<Build> _builds = AWSConfigs.InitializeCollections ? new List<Build>() : null;
        private List<string> _buildsNotFound = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Builds. 
        /// <para>
        /// Information about the requested builds.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Build> Builds
        {
            get { return this._builds; }
            set { this._builds = value; }
        }

        // Check to see if Builds property is set
        internal bool IsSetBuilds()
        {
            return this._builds != null && (this._builds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property BuildsNotFound. 
        /// <para>
        /// The IDs of builds for which information could not be found.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> BuildsNotFound
        {
            get { return this._buildsNotFound; }
            set { this._buildsNotFound = value; }
        }

        // Check to see if BuildsNotFound property is set
        internal bool IsSetBuildsNotFound()
        {
            return this._buildsNotFound != null && (this._buildsNotFound.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}