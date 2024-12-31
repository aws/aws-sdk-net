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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the EnableHttpEndpoint operation.
    /// Enables the HTTP endpoint for the DB cluster. By default, the HTTP endpoint isn't
    /// enabled.
    /// 
    ///  
    /// <para>
    /// When enabled, this endpoint provides a connectionless web service API (RDS Data API)
    /// for running SQL queries on the Aurora DB cluster. You can also query your database
    /// from inside the RDS console with the RDS query editor.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/data-api.html">Using
    /// RDS Data API</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation applies only to Aurora Serverless v2 and provisioned DB clusters. To
    /// enable the HTTP endpoint for Aurora Serverless v1 DB clusters, use the <c>EnableHttpEndpoint</c>
    /// parameter of the <c>ModifyDBCluster</c> operation.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class EnableHttpEndpointRequest : AmazonRDSRequest
    {
        private string _resourceArn;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the DB cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

    }
}