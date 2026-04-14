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
    /// Defines the data boundary for a resources query. Scopes determine which organizational
    /// units or organizations to retrieve data from.
    /// </summary>
    public partial class ResourceScopes
    {
        private List<AwsOrganizationScope> _awsOrganizations = AWSConfigs.InitializeCollections ? new List<AwsOrganizationScope>() : null;

        /// <summary>
        /// Gets and sets the property AwsOrganizations. 
        /// <para>
        /// A list of Organizations scopes to include in the query results. Each entry in the
        /// list specifies an organization or organizational unit to include for the delegated
        /// administrator's account. If the list specifies multiple entries, the entries are combined
        /// using OR logic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsOrganizationScope> AwsOrganizations
        {
            get { return this._awsOrganizations; }
            set { this._awsOrganizations = value; }
        }

        // Check to see if AwsOrganizations property is set
        internal bool IsSetAwsOrganizations()
        {
            return this._awsOrganizations != null && (this._awsOrganizations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}