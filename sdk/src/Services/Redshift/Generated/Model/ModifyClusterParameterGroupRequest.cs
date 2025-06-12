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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyClusterParameterGroup operation.
    /// Modifies the parameters of a parameter group. For the parameters parameter, it can't
    /// contain ASCII characters.
    /// 
    ///  
    /// <para>
    ///  For more information about parameters and parameter groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
    /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
    /// </para>
    /// </summary>
    public partial class ModifyClusterParameterGroupRequest : AmazonRedshiftRequest
    {
        private string _parameterGroupName;
        private List<Parameter> _parameters = AWSConfigs.InitializeCollections ? new List<Parameter>() : null;

        /// <summary>
        /// Gets and sets the property ParameterGroupName. 
        /// <para>
        /// The name of the parameter group to be modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=2147483647)]
        public string ParameterGroupName
        {
            get { return this._parameterGroupName; }
            set { this._parameterGroupName = value; }
        }

        // Check to see if ParameterGroupName property is set
        internal bool IsSetParameterGroupName()
        {
            return this._parameterGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// An array of parameters to be modified. A maximum of 20 parameters can be modified
        /// in a single request.
        /// </para>
        ///  
        /// <para>
        /// For each parameter to be modified, you must supply at least the parameter name and
        /// parameter value; other name-value pairs of the parameter are optional.
        /// </para>
        ///  
        /// <para>
        /// For the workload management (WLM) configuration, you must supply all the name-value
        /// pairs in the wlm_json_configuration parameter.
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