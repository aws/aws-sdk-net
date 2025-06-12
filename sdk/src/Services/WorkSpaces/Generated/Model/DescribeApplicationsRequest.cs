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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeApplications operation.
    /// Describes the specified applications by filtering based on their compute types, license
    /// availability, operating systems, and owners.
    /// </summary>
    public partial class DescribeApplicationsRequest : AmazonWorkSpacesRequest
    {
        private List<string> _applicationIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _computeTypeNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private WorkSpaceApplicationLicenseType _licenseType;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _operatingSystemNames = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _owner;

        /// <summary>
        /// Gets and sets the property ApplicationIds. 
        /// <para>
        /// The identifiers of one or more applications.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public List<string> ApplicationIds
        {
            get { return this._applicationIds; }
            set { this._applicationIds = value; }
        }

        // Check to see if ApplicationIds property is set
        internal bool IsSetApplicationIds()
        {
            return this._applicationIds != null && (this._applicationIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ComputeTypeNames. 
        /// <para>
        /// The compute types supported by the applications.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ComputeTypeNames
        {
            get { return this._computeTypeNames; }
            set { this._computeTypeNames = value; }
        }

        // Check to see if ComputeTypeNames property is set
        internal bool IsSetComputeTypeNames()
        {
            return this._computeTypeNames != null && (this._computeTypeNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LicenseType. 
        /// <para>
        /// The license availability for the applications.
        /// </para>
        /// </summary>
        public WorkSpaceApplicationLicenseType LicenseType
        {
            get { return this._licenseType; }
            set { this._licenseType = value; }
        }

        // Check to see if LicenseType property is set
        internal bool IsSetLicenseType()
        {
            return this._licenseType != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of applications to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If you received a <c>NextToken</c> from a previous call that was paginated, provide
        /// this token to receive the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property OperatingSystemNames. 
        /// <para>
        /// The operating systems supported by the applications.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> OperatingSystemNames
        {
            get { return this._operatingSystemNames; }
            set { this._operatingSystemNames = value; }
        }

        // Check to see if OperatingSystemNames property is set
        internal bool IsSetOperatingSystemNames()
        {
            return this._operatingSystemNames != null && (this._operatingSystemNames.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of the applications.
        /// </para>
        /// </summary>
        public string Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

    }
}