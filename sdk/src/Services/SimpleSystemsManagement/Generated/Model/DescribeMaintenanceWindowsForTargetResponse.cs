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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// This is the response object from the DescribeMaintenanceWindowsForTarget operation.
    /// </summary>
    public partial class DescribeMaintenanceWindowsForTargetResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<MaintenanceWindowIdentityForTarget> _windowIdentities = AWSConfigs.InitializeCollections ? new List<MaintenanceWindowIdentityForTarget>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of items to return. (You use this token in the next call.)
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
        /// Gets and sets the property WindowIdentities. 
        /// <para>
        /// Information about the maintenance window targets and tasks a managed node is associated
        /// with.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MaintenanceWindowIdentityForTarget> WindowIdentities
        {
            get { return this._windowIdentities; }
            set { this._windowIdentities = value; }
        }

        // Check to see if WindowIdentities property is set
        internal bool IsSetWindowIdentities()
        {
            return this._windowIdentities != null && (this._windowIdentities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}