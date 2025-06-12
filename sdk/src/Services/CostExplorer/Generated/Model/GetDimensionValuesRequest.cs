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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
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
namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the GetDimensionValues operation.
    /// Retrieves all available filter values for a specified filter over a period of time.
    /// You can search the dimension values for an arbitrary string.
    /// </summary>
    public partial class GetDimensionValuesRequest : AmazonCostExplorerRequest
    {
        private string _billingViewArn;
        private Context _context;
        private Dimension _dimension;
        private Expression _filter;
        private int? _maxResults;
        private string _nextPageToken;
        private string _searchString;
        private List<SortDefinition> _sortBy = AWSConfigs.InitializeCollections ? new List<SortDefinition>() : null;
        private DateInterval _timePeriod;

        /// <summary>
        /// Gets and sets the property BillingViewArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) that uniquely identifies a specific billing view. The
        /// ARN is used to specify which particular billing view you want to interact with or
        /// retrieve information from when making API calls related to Amazon Web Services Billing
        /// and Cost Management features. The BillingViewArn can be retrieved by calling the ListBillingViews
        /// API.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string BillingViewArn
        {
            get { return this._billingViewArn; }
            set { this._billingViewArn = value; }
        }

        // Check to see if BillingViewArn property is set
        internal bool IsSetBillingViewArn()
        {
            return this._billingViewArn != null;
        }

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// The context for the call to <c>GetDimensionValues</c>. This can be <c>RESERVATIONS</c>
        /// or <c>COST_AND_USAGE</c>. The default value is <c>COST_AND_USAGE</c>. If the context
        /// is set to <c>RESERVATIONS</c>, the resulting dimension values can be used in the <c>GetReservationUtilization</c>
        /// operation. If the context is set to <c>COST_AND_USAGE</c>, the resulting dimension
        /// values can be used in the <c>GetCostAndUsage</c> operation.
        /// </para>
        ///  
        /// <para>
        /// If you set the context to <c>COST_AND_USAGE</c>, you can use the following dimensions
        /// for searching:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AZ - The Availability Zone. An example is <c>us-east-1a</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// BILLING_ENTITY - The Amazon Web Services seller that your account is with. Possible
        /// values are the following:
        /// </para>
        ///  
        /// <para>
        /// - Amazon Web Services(Amazon Web Services): The entity that sells Amazon Web Services
        /// services.
        /// </para>
        ///  
        /// <para>
        /// - AISPL (Amazon Internet Services Pvt. Ltd.): The local Indian entity that's an acting
        /// reseller for Amazon Web Services services in India.
        /// </para>
        ///  
        /// <para>
        /// - Amazon Web Services Marketplace: The entity that supports the sale of solutions
        /// that are built on Amazon Web Services by third-party software providers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CACHE_ENGINE - The Amazon ElastiCache operating system. Examples are Windows or Linux.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DEPLOYMENT_OPTION - The scope of Amazon Relational Database Service deployments. Valid
        /// values are <c>SingleAZ</c> and <c>MultiAZ</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DATABASE_ENGINE - The Amazon Relational Database Service database. Examples are Aurora
        /// or MySQL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INSTANCE_TYPE - The type of Amazon EC2 instance. An example is <c>m4.xlarge</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INSTANCE_TYPE_FAMILY - A family of instance types optimized to fit different use cases.
        /// Examples are <c>Compute Optimized</c> (for example, <c>C4</c>, <c>C5</c>, <c>C6g</c>,
        /// and <c>C7g</c>), <c>Memory Optimization</c> (for example, <c>R4</c>, <c>R5n</c>, <c>R5b</c>,
        /// and <c>R6g</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INVOICING_ENTITY - The name of the entity that issues the Amazon Web Services invoice.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LEGAL_ENTITY_NAME - The name of the organization that sells you Amazon Web Services
        /// services, such as Amazon Web Services.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LINKED_ACCOUNT - The description in the attribute map that includes the full name
        /// of the member account. The value field contains the Amazon Web Services ID of the
        /// member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OPERATING_SYSTEM - The operating system. Examples are Windows or Linux.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OPERATION - The action performed. Examples include <c>RunInstance</c> and <c>CreateBucket</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PLATFORM - The Amazon EC2 operating system. Examples are Windows or Linux.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PURCHASE_TYPE - The reservation type of the purchase that this usage is related to.
        /// Examples include On-Demand Instances and Standard Reserved Instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RESERVATION_ID - The unique identifier for an Amazon Web Services Reservation Instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SAVINGS_PLAN_ARN - The unique identifier for your Savings Plans.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SAVINGS_PLANS_TYPE - Type of Savings Plans (EC2 Instance or Compute).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE - The Amazon Web Services service such as Amazon DynamoDB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TENANCY - The tenancy of a resource. Examples are shared or dedicated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// USAGE_TYPE - The type of usage. An example is DataTransfer-In-Bytes. The response
        /// for the <c>GetDimensionValues</c> operation includes a unit attribute. Examples include
        /// GB and Hrs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// USAGE_TYPE_GROUP - The grouping of common usage types. An example is Amazon EC2: CloudWatch
        /// – Alarms. The response for this operation includes a unit attribute.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// REGION - The Amazon Web Services Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RECORD_TYPE - The different types of charges such as Reserved Instance (RI) fees,
        /// usage costs, tax refunds, and credits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RESOURCE_ID - The unique identifier of the resource. ResourceId is an opt-in feature
        /// only available for last 14 days for EC2-Compute Service.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you set the context to <c>RESERVATIONS</c>, you can use the following dimensions
        /// for searching:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AZ - The Availability Zone. An example is <c>us-east-1a</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CACHE_ENGINE - The Amazon ElastiCache operating system. Examples are Windows or Linux.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DEPLOYMENT_OPTION - The scope of Amazon Relational Database Service deployments. Valid
        /// values are <c>SingleAZ</c> and <c>MultiAZ</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INSTANCE_TYPE - The type of Amazon EC2 instance. An example is <c>m4.xlarge</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LINKED_ACCOUNT - The description in the attribute map that includes the full name
        /// of the member account. The value field contains the Amazon Web Services ID of the
        /// member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PLATFORM - The Amazon EC2 operating system. Examples are Windows or Linux.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// REGION - The Amazon Web Services Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SCOPE (Utilization only) - The scope of a Reserved Instance (RI). Values are regional
        /// or a single Availability Zone.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG (Coverage only) - The tags that are associated with a Reserved Instance (RI).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TENANCY - The tenancy of a resource. Examples are shared or dedicated.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you set the context to <c>SAVINGS_PLANS</c>, you can use the following dimensions
        /// for searching:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// SAVINGS_PLANS_TYPE - Type of Savings Plans (EC2 Instance or Compute)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PAYMENT_OPTION - The payment option for the given Savings Plans (for example, All
        /// Upfront)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// REGION - The Amazon Web Services Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INSTANCE_TYPE_FAMILY - The family of instances (For example, <c>m5</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LINKED_ACCOUNT - The description in the attribute map that includes the full name
        /// of the member account. The value field contains the Amazon Web Services ID of the
        /// member account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SAVINGS_PLAN_ARN - The unique identifier for your Savings Plans.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Context Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null;
        }

        /// <summary>
        /// Gets and sets the property Dimension. 
        /// <para>
        /// The name of the dimension. Each <c>Dimension</c> is available for a different <c>Context</c>.
        /// For more information, see <c>Context</c>. <c>LINK_ACCOUNT_NAME</c> and <c>SERVICE_CODE</c>
        /// can only be used in <a href="https://docs.aws.amazon.com/aws-cost-management/latest/APIReference/AAPI_CostCategoryRule.html">CostCategoryRule</a>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dimension Dimension
        {
            get { return this._dimension; }
            set { this._dimension = value; }
        }

        // Check to see if Dimension property is set
        internal bool IsSetDimension()
        {
            return this._dimension != null;
        }

        /// <summary>
        /// Gets and sets the property Filter.
        /// </summary>
        public Expression Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// This field is only used when SortBy is provided in the request. The maximum number
        /// of objects that are returned for this request. If MaxResults isn't specified with
        /// SortBy, the request returns 1000 results as the default value for this parameter.
        /// </para>
        ///  
        /// <para>
        /// For <c>GetDimensionValues</c>, MaxResults has an upper limit of 1000.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token to retrieve the next set of results. Amazon Web Services provides the token
        /// when the response from a previous call has more results than the maximum page size.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string NextPageToken
        {
            get { return this._nextPageToken; }
            set { this._nextPageToken = value; }
        }

        // Check to see if NextPageToken property is set
        internal bool IsSetNextPageToken()
        {
            return this._nextPageToken != null;
        }

        /// <summary>
        /// Gets and sets the property SearchString. 
        /// <para>
        /// The value that you want to search the filter values for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string SearchString
        {
            get { return this._searchString; }
            set { this._searchString = value; }
        }

        // Check to see if SearchString property is set
        internal bool IsSetSearchString()
        {
            return this._searchString != null;
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The value that you want to sort the data by.
        /// </para>
        ///  
        /// <para>
        /// The key represents cost and usage metrics. The following values are supported:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>BlendedCost</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UnblendedCost</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AmortizedCost</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NetAmortizedCost</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NetUnblendedCost</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UsageQuantity</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NormalizedUsageAmount</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The supported values for the <c>SortOrder</c> key are <c>ASCENDING</c> or <c>DESCENDING</c>.
        /// </para>
        ///  
        /// <para>
        /// When you specify a <c>SortBy</c> paramater, the context must be <c>COST_AND_USAGE</c>.
        /// Further, when using <c>SortBy</c>, <c>NextPageToken</c> and <c>SearchString</c> aren't
        /// supported.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<SortDefinition> SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null && (this._sortBy.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TimePeriod. 
        /// <para>
        /// The start date and end date for retrieving the dimension values. The start date is
        /// inclusive, but the end date is exclusive. For example, if <c>start</c> is <c>2017-01-01</c>
        /// and <c>end</c> is <c>2017-05-01</c>, then the cost and usage data is retrieved from
        /// <c>2017-01-01</c> up to and including <c>2017-04-30</c> but not including <c>2017-05-01</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateInterval TimePeriod
        {
            get { return this._timePeriod; }
            set { this._timePeriod = value; }
        }

        // Check to see if TimePeriod property is set
        internal bool IsSetTimePeriod()
        {
            return this._timePeriod != null;
        }

    }
}