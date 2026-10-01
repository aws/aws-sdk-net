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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Data sources that are associated with an OpenSearch application.
    /// </summary>
    public partial class DataSource
    {
        /// <summary>
        /// Gets and sets the property DataSourceArn.
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string DataSourceArn { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceArn property is set.
        /// </summary>
        internal bool IsSetDataSourceArn() => this.DataSourceArn != null;

        /// <summary>
        /// Gets and sets the property DataSourceDescription. 
        /// <para>
        /// Detailed description of a data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000)]
        public string DataSourceDescription { get; set; }

        /// <summary>
        /// Checks to see if the DataSourceDescription property is set.
        /// </summary>
        internal bool IsSetDataSourceDescription() => this.DataSourceDescription != null;

        /// <summary>
        /// Gets and sets the property IamRoleForDataSourceArn. 
        /// <para>
        /// The ARN of the IAM role to be used for cross account/region data source association.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string IamRoleForDataSourceArn { get; set; }

        /// <summary>
        /// Checks to see if the IamRoleForDataSourceArn property is set.
        /// </summary>
        internal bool IsSetIamRoleForDataSourceArn() => this.IamRoleForDataSourceArn != null;
    }
}
