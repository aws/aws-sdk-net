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

namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// Container for the parameters to the ListServiceLevelObjectives operation. Returns
    /// a list of SLOs created in this account.
    /// </summary>
    public partial class ListServiceLevelObjectivesRequest : AmazonApplicationSignalsRequest
    {
        /// <summary>
        /// Gets and sets the property DependencyConfig. 
        /// <para>
        /// Identifies the dependency using the <c>DependencyKeyAttributes</c> and <c>DependencyOperationName</c>.
        /// 
        /// </para>
        /// </summary>
        public DependencyConfig DependencyConfig { get; set; }

        /// <summary>
        /// Checks to see if the DependencyConfig property is set.
        /// </summary>
        internal bool IsSetDependencyConfig() => this.DependencyConfig != null;

        /// <summary>
        /// Gets and sets the property IncludeLinkedAccounts. 
        /// <para>
        /// If you are using this operation in a monitoring account, specify <c>true</c> to include
        /// SLO from source accounts in the returned data. 
        /// </para>
        ///  
        /// <para>
        /// When you are monitoring an account, you can use Amazon Web Services account ID in
        /// <c>KeyAttribute</c> filter for service source account and <c>SloOwnerawsaccountID</c>
        /// for SLO source account with <c>IncludeLinkedAccounts</c> to filter the returned data
        /// to only a single source account. 
        /// </para>
        /// </summary>
        public bool? IncludeLinkedAccounts { get; set; }

        /// <summary>
        /// Checks to see if the IncludeLinkedAccounts property is set.
        /// </summary>
        internal bool IsSetIncludeLinkedAccounts() => this.IncludeLinkedAccounts.HasValue;

        /// <summary>
        /// Gets and sets the property KeyAttributes. 
        /// <para>
        /// You can use this optional field to specify which services you want to retrieve SLO
        /// information for.
        /// </para>
        ///  
        /// <para>
        /// This is a string-to-string map. It can include the following fields.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Type</c> designates the type of object this is.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ResourceType</c> specifies the type of the resource. This field is used only when
        /// the value of the <c>Type</c> field is <c>Resource</c> or <c>AWS::Resource</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Name</c> specifies the name of the object. This is used only if the value of the
        /// <c>Type</c> field is <c>Service</c>, <c>RemoteService</c>, or <c>AWS::Service</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Identifier</c> identifies the resource objects of this resource. This is used
        /// only if the value of the <c>Type</c> field is <c>Resource</c> or <c>AWS::Resource</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Environment</c> specifies the location where this object is hosted, or what it
        /// belongs to.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public Dictionary<string, string> KeyAttributes { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the KeyAttributes property is set.
        /// </summary>
        internal bool IsSetKeyAttributes() => this.KeyAttributes != null && (this.KeyAttributes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in one operation. If you omit this parameter,
        /// the default of 50 is used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MetricSource. 
        /// <para>
        /// Identifies the metric source to filter SLOs by.
        /// </para>
        /// </summary>
        public MetricSource MetricSource { get; set; }

        /// <summary>
        /// Checks to see if the MetricSource property is set.
        /// </summary>
        internal bool IsSetMetricSource() => this.MetricSource != null;

        /// <summary>
        /// Gets and sets the property MetricSourceTypes. 
        /// <para>
        /// Use this optional field to only include SLOs with the specified metric source types
        /// in the output. Supported types are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Service operation
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Service dependency
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Service
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CloudWatch metric
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AppMonitor
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Canary
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 3)]
        public List<string> MetricSourceTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MetricSourceTypes property is set.
        /// </summary>
        internal bool IsSetMetricSourceTypes() => this.MetricSourceTypes != null && (this.MetricSourceTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Include this value, if it was returned by the previous operation, to get the next
        /// set of service level objectives.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property OperationName. 
        /// <para>
        /// The name of the operation that this SLO is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string OperationName { get; set; }

        /// <summary>
        /// Checks to see if the OperationName property is set.
        /// </summary>
        internal bool IsSetOperationName() => this.OperationName != null;

        /// <summary>
        /// Gets and sets the property SloOwnerAwsAccountId. 
        /// <para>
        /// SLO's Amazon Web Services account ID.
        /// </para>
        /// </summary>
        public string SloOwnerAwsAccountId { get; set; }

        /// <summary>
        /// Checks to see if the SloOwnerAwsAccountId property is set.
        /// </summary>
        internal bool IsSetSloOwnerAwsAccountId() => this.SloOwnerAwsAccountId != null;
    }
}
