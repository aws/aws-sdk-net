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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
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
namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// Container for the parameters to the StartDashboardRefresh operation.
    /// Starts a refresh of the specified dashboard. 
    /// 
    ///  
    /// <para>
    ///  Each time a dashboard is refreshed, CloudTrail runs queries to populate the dashboard's
    /// widgets. CloudTrail must be granted permissions to run the <c>StartQuery</c> operation
    /// on your behalf. To provide permissions, run the <c>PutResourcePolicy</c> operation
    /// to attach a resource-based policy to each event data store. For more information,
    /// see <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/security_iam_resource-based-policy-examples.html#security_iam_resource-based-policy-examples-eds-dashboard">Example:
    /// Allow CloudTrail to run queries to populate a dashboard</a> in the <i>CloudTrail User
    /// Guide</i>. 
    /// </para>
    /// </summary>
    public partial class StartDashboardRefreshRequest : AmazonCloudTrailRequest
    {
        private string _dashboardId;
        private Dictionary<string, string> _queryParameterValues = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property DashboardId. 
        /// <para>
        ///  The name or ARN of the dashboard. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DashboardId
        {
            get { return this._dashboardId; }
            set { this._dashboardId = value; }
        }

        // Check to see if DashboardId property is set
        internal bool IsSetDashboardId()
        {
            return this._dashboardId != null;
        }

        /// <summary>
        /// Gets and sets the property QueryParameterValues. 
        /// <para>
        ///  The query parameter values for the dashboard 
        /// </para>
        ///  
        /// <para>
        /// For custom dashboards, the following query parameters are valid: <c>$StartTime$</c>,
        /// <c>$EndTime$</c>, and <c>$Period$</c>.
        /// </para>
        ///  
        /// <para>
        /// For managed dashboards, the following query parameters are valid: <c>$StartTime$</c>,
        /// <c>$EndTime$</c>, <c>$Period$</c>, and <c>$EventDataStoreId$</c>. The <c>$EventDataStoreId$</c>
        /// query parameter is required.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> QueryParameterValues
        {
            get { return this._queryParameterValues; }
            set { this._queryParameterValues = value; }
        }

        // Check to see if QueryParameterValues property is set
        internal bool IsSetQueryParameterValues()
        {
            return this._queryParameterValues != null && (this._queryParameterValues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}