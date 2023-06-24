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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyDBClusterParameterGroup operation.
    /// Modifies the parameters of a DB cluster parameter group. To modify more than one parameter,
    /// submit a list of the following: <code>ParameterName</code>, <code>ParameterValue</code>,
    /// and <code>ApplyMethod</code>. A maximum of 20 parameters can be modified in a single
    /// request.
    /// 
    ///  <important> 
    /// <para>
    /// After you create a DB cluster parameter group, you should wait at least 5 minutes
    /// before creating your first DB cluster that uses that DB cluster parameter group as
    /// the default parameter group. This allows Amazon RDS to fully complete the create action
    /// before the parameter group is used as the default for a new DB cluster. This is especially
    /// important for parameters that are critical when creating the default database for
    /// a DB cluster, such as the character set for the default database defined by the <code>character_set_database</code>
    /// parameter. You can use the <i>Parameter Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon
    /// RDS console</a> or the <code>DescribeDBClusterParameters</code> operation to verify
    /// that your DB cluster parameter group has been created or modified.
    /// </para>
    ///  
    /// <para>
    /// If the modified DB cluster parameter group is used by an Aurora Serverless v1 cluster,
    /// Aurora applies the update immediately. The cluster restart might interrupt your workload.
    /// In that case, your application must reopen any connections and retry any transactions
    /// that were active when the parameter changes took effect.
    /// </para>
    ///  </important> 
    /// <para>
    /// For more information on Amazon Aurora DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/CHAP_AuroraOverview.html">
    /// What is Amazon Aurora?</a> in the <i>Amazon Aurora User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information on Multi-AZ DB clusters, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/multi-az-db-clusters-concepts.html">
    /// Multi-AZ DB cluster deployments</a> in the <i>Amazon RDS User Guide.</i> 
    /// </para>
    /// </summary>
    public partial class ModifyDBClusterParameterGroupRequest : AmazonRDSRequest
    {
        private string _dbClusterParameterGroupName;
        private List<Parameter> _parameters = new List<Parameter>();

        /// <summary>
        /// Gets and sets the property DBClusterParameterGroupName. 
        /// <para>
        /// The name of the DB cluster parameter group to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBClusterParameterGroupName
        {
            get { return this._dbClusterParameterGroupName; }
            set { this._dbClusterParameterGroupName = value; }
        }

        // Check to see if DBClusterParameterGroupName property is set
        internal bool IsSetDBClusterParameterGroupName()
        {
            return this._dbClusterParameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// A list of parameters in the DB cluster parameter group to modify.
        /// </para>
        ///  
        /// <para>
        /// Valid Values (for the application method): <code>immediate | pending-reboot</code>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// You can use the <code>immediate</code> value with dynamic parameters only. You can
        /// use the <code>pending-reboot</code> value for both dynamic and static parameters.
        /// </para>
        ///  
        /// <para>
        /// When the application method is <code>immediate</code>, changes to dynamic parameters
        /// are applied immediately to the DB clusters associated with the parameter group. When
        /// the application method is <code>pending-reboot</code>, changes to dynamic and static
        /// parameters are applied after a reboot without failover to the DB clusters associated
        /// with the parameter group.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<Parameter> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

    }
}