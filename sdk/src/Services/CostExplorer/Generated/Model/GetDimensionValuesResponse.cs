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
    /// This is the response object from the GetDimensionValues operation.
    /// </summary>
    public partial class GetDimensionValuesResponse : AmazonWebServiceResponse
    {
        private List<DimensionValuesWithAttributes> _dimensionValues = AWSConfigs.InitializeCollections ? new List<DimensionValuesWithAttributes>() : null;
        private string _nextPageToken;
        private int? _returnSize;
        private int? _totalSize;

        /// <summary>
        /// Gets and sets the property DimensionValues. 
        /// <para>
        /// The filters that you used to filter your request. Some dimensions are available only
        /// for a specific context.
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
        /// DATABASE_ENGINE - The Amazon Relational Database Service database. Examples are Aurora
        /// or MySQL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INSTANCE_TYPE - The type of Amazon EC2 instance. An example is <c>m4.xlarge</c>.
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
        /// PURCHASE_TYPE - The reservation type of the purchase to which this usage is related.
        /// Examples include On-Demand Instances and Standard Reserved Instances.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE - The Amazon Web Services service such as Amazon DynamoDB.
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
        /// RECORD_TYPE - The different types of charges such as RI fees, usage costs, tax refunds,
        /// and credits.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RESOURCE_ID - The unique identifier of the resource. ResourceId is an opt-in feature
        /// only available for last 14 days for EC2-Compute Service. You can opt-in by enabling
        /// <c>Hourly</c> and <c>Resource Level Data</c> in Cost Management Console preferences.
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
        /// PAYMENT_OPTION - Payment option for the given Savings Plans (for example, All Upfront)
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
        /// SAVINGS_PLAN_ARN - The unique identifier for your Savings Plan
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DimensionValuesWithAttributes> DimensionValues
        {
            get { return this._dimensionValues; }
            set { this._dimensionValues = value; }
        }

        // Check to see if DimensionValues property is set
        internal bool IsSetDimensionValues()
        {
            return this._dimensionValues != null && (this._dimensionValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextPageToken. 
        /// <para>
        /// The token for the next set of retrievable results. Amazon Web Services provides the
        /// token when the response from a previous call has more results than the maximum page
        /// size.
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
        /// Gets and sets the property ReturnSize. 
        /// <para>
        /// The number of results that Amazon Web Services returned at one time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? ReturnSize
        {
            get { return this._returnSize; }
            set { this._returnSize = value; }
        }

        // Check to see if ReturnSize property is set
        internal bool IsSetReturnSize()
        {
            return this._returnSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalSize. 
        /// <para>
        /// The total number of search results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? TotalSize
        {
            get { return this._totalSize; }
            set { this._totalSize = value; }
        }

        // Check to see if TotalSize property is set
        internal bool IsSetTotalSize()
        {
            return this._totalSize.HasValue; 
        }

    }
}