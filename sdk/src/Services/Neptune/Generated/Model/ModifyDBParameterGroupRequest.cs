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
    /// Container for the parameters to the ModifyDBParameterGroup operation.
    /// Modifies the parameters of a DB parameter group. To modify more than one parameter,
    /// submit a list of the following: <c>ParameterName</c>, <c>ParameterValue</c>, and <c>ApplyMethod</c>.
    /// A maximum of 20 parameters can be modified in a single request.
    /// 
    ///  <note> 
    /// <para>
    /// Changes to dynamic parameters are applied immediately. Changes to static parameters
    /// require a reboot without failover to the DB instance associated with the parameter
    /// group before the change can take effect.
    /// </para>
    ///  </note> <important> 
    /// <para>
    /// After you modify a DB parameter group, you should wait at least 5 minutes before creating
    /// your first DB instance that uses that DB parameter group as the default parameter
    /// group. This allows Amazon Neptune to fully complete the modify action before the parameter
    /// group is used as the default for a new DB instance. This is especially important for
    /// parameters that are critical when creating the default database for a DB instance,
    /// such as the character set for the default database defined by the <c>character_set_database</c>
    /// parameter. You can use the <i>Parameter Groups</i> option of the Amazon Neptune console
    /// or the <i>DescribeDBParameters</i> command to verify that your DB parameter group
    /// has been created or modified.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class ModifyDBParameterGroupRequest : AmazonNeptuneRequest
    {
        private string _dbParameterGroupName;
        private List<Parameter> _parameters = AWSConfigs.InitializeCollections ? new List<Parameter>() : null;

        /// <summary>
        /// Gets and sets the property DBParameterGroupName. 
        /// <para>
        /// The name of the DB parameter group.
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If supplied, must match the name of an existing DBParameterGroup.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DBParameterGroupName
        {
            get { return this._dbParameterGroupName; }
            set { this._dbParameterGroupName = value; }
        }

        // Check to see if DBParameterGroupName property is set
        internal bool IsSetDBParameterGroupName()
        {
            return this._dbParameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// An array of parameter names, values, and the apply method for the parameter update.
        /// At least one parameter name, value, and apply method must be supplied; subsequent
        /// arguments are optional. A maximum of 20 parameters can be modified in a single request.
        /// </para>
        ///  
        /// <para>
        /// Valid Values (for the application method): <c>immediate | pending-reboot</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// You can use the immediate value with dynamic parameters only. You can use the pending-reboot
        /// value for both dynamic and static parameters, and changes are applied when you reboot
        /// the DB instance without failover.
        /// </para>
        ///  </note>
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