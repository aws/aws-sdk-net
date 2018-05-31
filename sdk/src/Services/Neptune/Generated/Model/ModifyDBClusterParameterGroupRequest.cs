/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the neptune-2018-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyDBClusterParameterGroup operation.
    /// Modifies the parameters of a DB cluster parameter group. To modify more than one
    /// parameter, submit a list of the following: <code>ParameterName</code>, <code>ParameterValue</code>,
    /// and <code>ApplyMethod</code>. A maximum of 20 parameters can be modified in a single
    /// request. 
    /// 
    ///  
    /// <para>
    /// For more information on Amazon Aurora, see <a href="http://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/CHAP_Aurora.html">Aurora
    /// on Amazon Neptune</a> in the <i>Amazon Neptune User Guide.</i> 
    /// </para>
    ///  <note> 
    /// <para>
    /// Changes to dynamic parameters are applied immediately. Changes to static parameters
    /// require a reboot without failover to the DB cluster associated with the parameter
    /// group before the change can take effect.
    /// </para>
    ///  </note> <important> 
    /// <para>
    /// After you create a DB cluster parameter group, you should wait at least 5 minutes
    /// before creating your first DB cluster that uses that DB cluster parameter group as
    /// the default parameter group. This allows Amazon Neptune to fully complete the create
    /// action before the parameter group is used as the default for a new DB cluster. This
    /// is especially important for parameters that are critical when creating the default
    /// database for a DB cluster, such as the character set for the default database defined
    /// by the <code>character_set_database</code> parameter. You can use the <i>Parameter
    /// Groups</i> option of the <a href="https://console.aws.amazon.com/rds/">Amazon Neptune
    /// console</a> or the <a>DescribeDBClusterParameters</a> command to verify that your
    /// DB cluster parameter group has been created or modified.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class ModifyDBClusterParameterGroupRequest : AmazonNeptuneRequest
    {
        private string _dbClusterParameterGroupName;
        private List<Parameter> _parameters = new List<Parameter>();

        /// <summary>
        /// Gets and sets the property DBClusterParameterGroupName. 
        /// <para>
        /// The name of the DB cluster parameter group to modify.
        /// </para>
        /// </summary>
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
        /// </summary>
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