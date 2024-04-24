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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
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
namespace Amazon.Detective.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDatasourcePackages operation.
    /// Starts a data source packages for the behavior graph.
    /// </summary>
    public partial class UpdateDatasourcePackagesRequest : AmazonDetectiveRequest
    {
        private List<string> _datasourcePackages = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _graphArn;

        /// <summary>
        /// Gets and sets the property DatasourcePackages. 
        /// <para>
        /// The data source package start for the behavior graph.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=25)]
        public List<string> DatasourcePackages
        {
            get { return this._datasourcePackages; }
            set { this._datasourcePackages = value; }
        }

        // Check to see if DatasourcePackages property is set
        internal bool IsSetDatasourcePackages()
        {
            return this._datasourcePackages != null && (this._datasourcePackages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property GraphArn. 
        /// <para>
        /// The ARN of the behavior graph.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GraphArn
        {
            get { return this._graphArn; }
            set { this._graphArn = value; }
        }

        // Check to see if GraphArn property is set
        internal bool IsSetGraphArn()
        {
            return this._graphArn != null;
        }

    }
}