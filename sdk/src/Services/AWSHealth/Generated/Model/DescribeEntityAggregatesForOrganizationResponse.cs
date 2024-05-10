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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
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
namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// This is the response object from the DescribeEntityAggregatesForOrganization operation.
    /// </summary>
    public partial class DescribeEntityAggregatesForOrganizationResponse : AmazonWebServiceResponse
    {
        private List<OrganizationEntityAggregate> _organizationEntityAggregates = AWSConfigs.InitializeCollections ? new List<OrganizationEntityAggregate>() : null;

        /// <summary>
        /// Gets and sets the property OrganizationEntityAggregates. 
        /// <para>
        /// The list of entity aggregates for each of the specified accounts that are affected
        /// by each of the specified events.
        /// </para>
        /// </summary>
        public List<OrganizationEntityAggregate> OrganizationEntityAggregates
        {
            get { return this._organizationEntityAggregates; }
            set { this._organizationEntityAggregates = value; }
        }

        // Check to see if OrganizationEntityAggregates property is set
        internal bool IsSetOrganizationEntityAggregates()
        {
            return this._organizationEntityAggregates != null && (this._organizationEntityAggregates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}