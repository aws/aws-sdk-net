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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
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
namespace Amazon.CodeDeploy.Model
{
    /// <summary>
    /// Container for the parameters to the ListOnPremisesInstances operation.
    /// Gets a list of names for one or more on-premises instances.
    /// 
    ///  
    /// <para>
    /// Unless otherwise specified, both registered and deregistered on-premises instance
    /// names are listed. To list only registered or deregistered on-premises instance names,
    /// use the registration status parameter.
    /// </para>
    /// </summary>
    public partial class ListOnPremisesInstancesRequest : AmazonCodeDeployRequest
    {
        private string _nextToken;
        private RegistrationStatus _registrationStatus;
        private List<TagFilter> _tagFilters = AWSConfigs.InitializeCollections ? new List<TagFilter>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An identifier returned from the previous list on-premises instances call. It can be
        /// used to return the next set of on-premises instances in the list.
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
        /// Gets and sets the property RegistrationStatus. 
        /// <para>
        /// The registration status of the on-premises instances:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Deregistered</c>: Include deregistered on-premises instances in the resulting
        /// list.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Registered</c>: Include registered on-premises instances in the resulting list.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public RegistrationStatus RegistrationStatus
        {
            get { return this._registrationStatus; }
            set { this._registrationStatus = value; }
        }

        // Check to see if RegistrationStatus property is set
        internal bool IsSetRegistrationStatus()
        {
            return this._registrationStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TagFilters. 
        /// <para>
        /// The on-premises instance tags that are used to restrict the on-premises instance names
        /// returned.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagFilter> TagFilters
        {
            get { return this._tagFilters; }
            set { this._tagFilters = value; }
        }

        // Check to see if TagFilters property is set
        internal bool IsSetTagFilters()
        {
            return this._tagFilters != null && (this._tagFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}