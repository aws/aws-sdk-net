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
    /// Contains information about a widget on a CloudTrail Lake dashboard.
    /// </summary>
    public partial class RequestWidget
    {
        private List<string> _queryParameters = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _queryStatement;
        private Dictionary<string, string> _viewProperties = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property QueryParameters. 
        /// <para>
        ///  The optional query parameters. The following query parameters are valid: <c>$StartTime$</c>,
        /// <c>$EndTime$</c>, and <c>$Period$</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<string> QueryParameters
        {
            get { return this._queryParameters; }
            set { this._queryParameters = value; }
        }

        // Check to see if QueryParameters property is set
        internal bool IsSetQueryParameters()
        {
            return this._queryParameters != null && (this._queryParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property QueryStatement. 
        /// <para>
        ///  The query statement for the widget. For custom dashboard widgets, you can query across
        /// multiple event data stores as long as all event data stores exist in your account.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// When a query uses <c>?</c> with <c>eventTime</c>, <c>?</c> must be surrounded by single
        /// quotes as follows: <c>'?'</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10000)]
        public string QueryStatement
        {
            get { return this._queryStatement; }
            set { this._queryStatement = value; }
        }

        // Check to see if QueryStatement property is set
        internal bool IsSetQueryStatement()
        {
            return this._queryStatement != null;
        }

        /// <summary>
        /// Gets and sets the property ViewProperties. 
        /// <para>
        ///  The view properties for the widget. For more information about view properties, see
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/lake-widget-properties.html">
        /// View properties for widgets </a> in the <i>CloudTrail User Guide</i>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> ViewProperties
        {
            get { return this._viewProperties; }
            set { this._viewProperties = value; }
        }

        // Check to see if ViewProperties property is set
        internal bool IsSetViewProperties()
        {
            return this._viewProperties != null && (this._viewProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}