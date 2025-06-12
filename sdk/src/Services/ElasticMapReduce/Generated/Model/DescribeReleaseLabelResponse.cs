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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// This is the response object from the DescribeReleaseLabel operation.
    /// </summary>
    public partial class DescribeReleaseLabelResponse : AmazonWebServiceResponse
    {
        private List<SimplifiedApplication> _applications = AWSConfigs.InitializeCollections ? new List<SimplifiedApplication>() : null;
        private List<OSRelease> _availableOSReleases = AWSConfigs.InitializeCollections ? new List<OSRelease>() : null;
        private string _nextToken;
        private string _releaseLabel;

        /// <summary>
        /// Gets and sets the property Applications. 
        /// <para>
        /// The list of applications available for the target release label. <c>Name</c> is the
        /// name of the application. <c>Version</c> is the concise version of the application.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SimplifiedApplication> Applications
        {
            get { return this._applications; }
            set { this._applications = value; }
        }

        // Check to see if Applications property is set
        internal bool IsSetApplications()
        {
            return this._applications != null && (this._applications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AvailableOSReleases. 
        /// <para>
        /// The list of available Amazon Linux release versions for an Amazon EMR release. Contains
        /// a Label field that is formatted as shown in <a href="https://docs.aws.amazon.com/AL2/latest/relnotes/relnotes-al2.html">
        /// <i>Amazon Linux 2 Release Notes</i> </a>. For example, <a href="https://docs.aws.amazon.com/AL2/latest/relnotes/relnotes-20220218.html">2.0.20220218.1</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OSRelease> AvailableOSReleases
        {
            get { return this._availableOSReleases; }
            set { this._availableOSReleases = value; }
        }

        // Check to see if AvailableOSReleases property is set
        internal bool IsSetAvailableOSReleases()
        {
            return this._availableOSReleases != null && (this._availableOSReleases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token. Reserved for future use. Currently set to null.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property ReleaseLabel. 
        /// <para>
        /// The target release label described in the response.
        /// </para>
        /// </summary>
        public string ReleaseLabel
        {
            get { return this._releaseLabel; }
            set { this._releaseLabel = value; }
        }

        // Check to see if ReleaseLabel property is set
        internal bool IsSetReleaseLabel()
        {
            return this._releaseLabel != null;
        }

    }
}