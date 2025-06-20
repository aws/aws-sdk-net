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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// This is the response object from the ListReportPlans operation.
    /// </summary>
    public partial class ListReportPlansResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ReportPlan> _reportPlans = AWSConfigs.InitializeCollections ? new List<ReportPlan>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An identifier that was returned from the previous call to this operation, which can
        /// be used to return the next set of items in the list.
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
        /// Gets and sets the property ReportPlans. 
        /// <para>
        /// The report plans with detailed information for each plan. This information includes
        /// the Amazon Resource Name (ARN), report plan name, description, settings, delivery
        /// channel, deployment status, creation time, and last times the report plan attempted
        /// to and successfully ran.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ReportPlan> ReportPlans
        {
            get { return this._reportPlans; }
            set { this._reportPlans = value; }
        }

        // Check to see if ReportPlans property is set
        internal bool IsSetReportPlans()
        {
            return this._reportPlans != null && (this._reportPlans.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}