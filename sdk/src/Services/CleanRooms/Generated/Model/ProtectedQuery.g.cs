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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// The parameters for an Clean Rooms protected query.
    /// </summary>
    public partial class ProtectedQuery
    {
        /// <summary>
        /// Gets and sets the property ComputeConfiguration. 
        /// <para>
        ///  The compute configuration for the protected query.
        /// </para>
        /// </summary>
        public ComputeConfiguration ComputeConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ComputeConfiguration property is set.
        /// </summary>
        internal bool IsSetComputeConfiguration() => this.ComputeConfiguration != null;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The time at which the protected query was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreateTime property is set.
        /// </summary>
        internal bool IsSetCreateTime() => this.CreateTime.HasValue;

        /// <summary>
        /// Gets and sets the property DifferentialPrivacy. 
        /// <para>
        /// The sensitivity parameters of the differential privacy results of the protected query.
        /// </para>
        /// </summary>
        public DifferentialPrivacyParameters DifferentialPrivacy { get; set; }

        /// <summary>
        /// Checks to see if the DifferentialPrivacy property is set.
        /// </summary>
        internal bool IsSetDifferentialPrivacy() => this.DifferentialPrivacy != null;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// An error thrown by the protected query.
        /// </para>
        /// </summary>
        public ProtectedQueryError Error { get; set; }

        /// <summary>
        /// Checks to see if the Error property is set.
        /// </summary>
        internal bool IsSetError() => this.Error != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier for a protected query instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property MembershipArn. 
        /// <para>
        /// The ARN of the membership.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 100)]
        public string MembershipArn { get; set; }

        /// <summary>
        /// Checks to see if the MembershipArn property is set.
        /// </summary>
        internal bool IsSetMembershipArn() => this.MembershipArn != null;

        /// <summary>
        /// Gets and sets the property MembershipId. 
        /// <para>
        /// The identifier for the membership.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 36, Max = 36)]
        public string MembershipId { get; set; }

        /// <summary>
        /// Checks to see if the MembershipId property is set.
        /// </summary>
        internal bool IsSetMembershipId() => this.MembershipId != null;

        /// <summary>
        /// Gets and sets the property QueryComputePayerAccountId. 
        /// <para>
        /// The account ID of the member that pays for the query compute costs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string QueryComputePayerAccountId { get; set; }

        /// <summary>
        /// Checks to see if the QueryComputePayerAccountId property is set.
        /// </summary>
        internal bool IsSetQueryComputePayerAccountId() => this.QueryComputePayerAccountId != null;

        /// <summary>
        /// Gets and sets the property Result. 
        /// <para>
        /// The result of the protected query.
        /// </para>
        /// </summary>
        public ProtectedQueryResult Result { get; set; }

        /// <summary>
        /// Checks to see if the Result property is set.
        /// </summary>
        internal bool IsSetResult() => this.Result != null;

        /// <summary>
        /// Gets and sets the property ResultConfiguration. 
        /// <para>
        /// Contains any details needed to write the query results.
        /// </para>
        /// </summary>
        public ProtectedQueryResultConfiguration ResultConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ResultConfiguration property is set.
        /// </summary>
        internal bool IsSetResultConfiguration() => this.ResultConfiguration != null;

        /// <summary>
        /// Gets and sets the property SqlParameters. 
        /// <para>
        /// The protected query SQL parameters.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public ProtectedQuerySQLParameters SqlParameters { get; set; }

        /// <summary>
        /// Checks to see if the SqlParameters property is set.
        /// </summary>
        internal bool IsSetSqlParameters() => this.SqlParameters != null;

        /// <summary>
        /// Gets and sets the property Statistics. 
        /// <para>
        /// Statistics about protected query execution.
        /// </para>
        /// </summary>
        public ProtectedQueryStatistics Statistics { get; set; }

        /// <summary>
        /// Checks to see if the Statistics property is set.
        /// </summary>
        internal bool IsSetStatistics() => this.Statistics != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the query.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProtectedQueryStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
