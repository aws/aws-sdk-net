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
 * Do not modify this file. This file is generated from the dax-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DAX.Model
{
    /// <summary>
    /// The status of a parameter group.
    /// </summary>
    public partial class ParameterGroupStatus
    {
        private List<string> _nodeIdsToReboot = new List<string>();
        private string _parameterApplyStatus;
        private string _parameterGroupName;

        /// <summary>
        /// Gets and sets the property NodeIdsToReboot. 
        /// <para>
        /// The node IDs of one or more nodes to be rebooted.
        /// </para>
        /// </summary>
        public List<string> NodeIdsToReboot
        {
            get { return this._nodeIdsToReboot; }
            set { this._nodeIdsToReboot = value; }
        }

        // Check to see if NodeIdsToReboot property is set
        internal bool IsSetNodeIdsToReboot()
        {
            return this._nodeIdsToReboot != null && this._nodeIdsToReboot.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ParameterApplyStatus. 
        /// <para>
        /// The status of parameter updates. 
        /// </para>
        /// </summary>
        public string ParameterApplyStatus
        {
            get { return this._parameterApplyStatus; }
            set { this._parameterApplyStatus = value; }
        }

        // Check to see if ParameterApplyStatus property is set
        internal bool IsSetParameterApplyStatus()
        {
            return this._parameterApplyStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterGroupName. 
        /// <para>
        /// The name of the parameter group.
        /// </para>
        /// </summary>
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

    }
}