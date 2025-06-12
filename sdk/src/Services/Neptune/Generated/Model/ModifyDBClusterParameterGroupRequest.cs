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
 * Do not modify this file. This file is generated from the neptune-2014-10-31.normal.json service model.
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
namespace Amazon.Neptune.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyDBClusterParameterGroup operation.
    /// Modifies the parameters of a DB cluster parameter group. To modify more than one
    /// parameter, submit a list of the following: <c>ParameterName</c>, <c>ParameterValue</c>,
    /// and <c>ApplyMethod</c>. A maximum of 20 parameters can be modified in a single request.
    /// 
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
    /// by the <c>character_set_database</c> parameter. You can use the <i>Parameter Groups</i>
    /// option of the Amazon Neptune console or the <a>DescribeDBClusterParameters</a> command
    /// to verify that your DB cluster parameter group has been created or modified.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class ModifyDBClusterParameterGroupRequest : AmazonNeptuneRequest
    {
        private string _dbClusterParameterGroupName;
        private List<Parameter> _parameters = AWSConfigs.InitializeCollections ? new List<Parameter>() : null;

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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}