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

namespace Amazon.CloudTrail.Model
{
    /// <summary>
    /// A widget on a CloudTrail Lake dashboard.
    /// </summary>
    public partial class Widget
    {
        /// <summary>
        /// Gets and sets the property QueryAlias. 
        /// <para>
        /// The query alias used to identify the query for the widget. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string QueryAlias { get; set; }

        /// <summary>
        /// Checks to see if the QueryAlias property is set.
        /// </summary>
        internal bool IsSetQueryAlias() => this.QueryAlias != null;

        /// <summary>
        /// Gets and sets the property QueryParameters. 
        /// <para>
        ///  The query parameters for the widget. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> QueryParameters { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the QueryParameters property is set.
        /// </summary>
        internal bool IsSetQueryParameters() => this.QueryParameters != null && (this.QueryParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property QueryStatement. 
        /// <para>
        ///  The SQL query statement for the widget. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 10000)]
        public string QueryStatement { get; set; }

        /// <summary>
        /// Checks to see if the QueryStatement property is set.
        /// </summary>
        internal bool IsSetQueryStatement() => this.QueryStatement != null;

        /// <summary>
        /// Gets and sets the property ViewProperties. 
        /// <para>
        ///  The view properties for the widget. For more information about view properties, see
        /// <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/lake-widget-properties.html">
        /// View properties for widgets </a> in the <i>CloudTrail User Guide</i>.. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> ViewProperties { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the ViewProperties property is set.
        /// </summary>
        internal bool IsSetViewProperties() => this.ViewProperties != null && (this.ViewProperties.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
