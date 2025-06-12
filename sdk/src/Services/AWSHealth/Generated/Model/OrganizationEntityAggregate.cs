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
    /// The aggregate results of entities affected by the specified event in your organization.
    /// The results are aggregated by the entity status codes for the specified set of accountsIDs.
    /// </summary>
    public partial class OrganizationEntityAggregate
    {
        private List<AccountEntityAggregate> _accounts = AWSConfigs.InitializeCollections ? new List<AccountEntityAggregate>() : null;
        private int? _count;
        private string _eventArn;
        private Dictionary<string, int> _statuses = AWSConfigs.InitializeCollections ? new Dictionary<string, int>() : null;

        /// <summary>
        /// Gets and sets the property Accounts. 
        /// <para>
        /// A list of entity aggregates for each of the specified accounts in your organization
        /// that are affected by a specific event. If there are no <c>awsAccountIds</c> provided
        /// in the request, this field will be empty in the response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AccountEntityAggregate> Accounts
        {
            get { return this._accounts; }
            set { this._accounts = value; }
        }

        // Check to see if Accounts property is set
        internal bool IsSetAccounts()
        {
            return this._accounts != null && (this._accounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of entities for the organization that match the filter criteria for the
        /// specified events.
        /// </para>
        /// </summary>
        public int? Count
        {
            get { return this._count; }
            set { this._count = value; }
        }

        // Check to see if Count property is set
        internal bool IsSetCount()
        {
            return this._count.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EventArn. 
        /// <para>
        /// A list of event ARNs (unique identifiers). For example: <c>"arn:aws:health:us-east-1::event/EC2/EC2_INSTANCE_RETIREMENT_SCHEDULED/EC2_INSTANCE_RETIREMENT_SCHEDULED_ABC123-CDE456",
        /// "arn:aws:health:us-west-1::event/EBS/AWS_EBS_LOST_VOLUME/AWS_EBS_LOST_VOLUME_CHI789_JKL101"</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Max=1600)]
        public string EventArn
        {
            get { return this._eventArn; }
            set { this._eventArn = value; }
        }

        // Check to see if EventArn property is set
        internal bool IsSetEventArn()
        {
            return this._eventArn != null;
        }

        /// <summary>
        /// Gets and sets the property Statuses. 
        /// <para>
        /// The number of affected entities aggregated by the entitiy status codes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, int> Statuses
        {
            get { return this._statuses; }
            set { this._statuses = value; }
        }

        // Check to see if Statuses property is set
        internal bool IsSetStatuses()
        {
            return this._statuses != null && (this._statuses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}