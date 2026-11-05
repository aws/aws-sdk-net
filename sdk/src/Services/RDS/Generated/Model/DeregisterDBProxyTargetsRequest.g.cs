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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the DeregisterDBProxyTargets operation. Remove the
    /// association between one or more <c>DBProxyTarget</c> data structures and a <c>DBProxyTargetGroup</c>.
    /// </summary>
    public partial class DeregisterDBProxyTargetsRequest : AmazonRDSRequest
    {
        /// <summary>
        /// Gets and sets the property DBClusterIdentifiers. 
        /// <para>
        /// One or more DB cluster identifiers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DBClusterIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DBClusterIdentifiers property is set.
        /// </summary>
        internal bool IsSetDBClusterIdentifiers() => this.DBClusterIdentifiers != null && (this.DBClusterIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DBInstanceIdentifiers. 
        /// <para>
        /// One or more DB instance identifiers.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DBInstanceIdentifiers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DBInstanceIdentifiers property is set.
        /// </summary>
        internal bool IsSetDBInstanceIdentifiers() => this.DBInstanceIdentifiers != null && (this.DBInstanceIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DBProxyName. 
        /// <para>
        /// The identifier of the <c>DBProxy</c> that is associated with the <c>DBProxyTargetGroup</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string DBProxyName { get; set; }

        /// <summary>
        /// Checks to see if the DBProxyName property is set.
        /// </summary>
        internal bool IsSetDBProxyName() => this.DBProxyName != null;

        /// <summary>
        /// Gets and sets the property TargetGroupName. 
        /// <para>
        /// The identifier of the <c>DBProxyTargetGroup</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string TargetGroupName { get; set; }

        /// <summary>
        /// Checks to see if the TargetGroupName property is set.
        /// </summary>
        internal bool IsSetTargetGroupName() => this.TargetGroupName != null;
    }
}
