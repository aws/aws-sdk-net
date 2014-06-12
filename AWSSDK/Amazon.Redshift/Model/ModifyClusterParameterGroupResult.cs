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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Contains the output from the         <a>ModifyClusterParameterGroup</a> and <a>ResetClusterParameterGroup</a>
    /// actions and            indicate the parameter group involved and the status of the
    /// operation on the             parameter group.
    /// </summary>
    public partial class ModifyClusterParameterGroupResult
    {
        private string _parameterGroupName;
        private string _parameterGroupStatus;


        /// <summary>
        /// Gets and sets the property ParameterGroupName. 
        /// <para>
        ///         The name of the cluster parameter group.        
        /// </para>
        /// </summary>
        public string ParameterGroupName
        {
            get { return this._parameterGroupName; }
            set { this._parameterGroupName = value; }
        }


        /// <summary>
        /// Sets the ParameterGroupName property
        /// </summary>
        /// <param name="parameterGroupName">The value to set for the ParameterGroupName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterParameterGroupResult WithParameterGroupName(string parameterGroupName)
        {
            this._parameterGroupName = parameterGroupName;
            return this;
        }

        // Check to see if ParameterGroupName property is set
        internal bool IsSetParameterGroupName()
        {
            return this._parameterGroupName != null;
        }


        /// <summary>
        /// Gets and sets the property ParameterGroupStatus. 
        /// <para>
        ///         The status of the parameter group. For example, if you made        a change
        /// to a parameter group name-value pair, then the change could be pending        a reboot
        /// of an associated cluster.        
        /// </para>
        /// </summary>
        public string ParameterGroupStatus
        {
            get { return this._parameterGroupStatus; }
            set { this._parameterGroupStatus = value; }
        }


        /// <summary>
        /// Sets the ParameterGroupStatus property
        /// </summary>
        /// <param name="parameterGroupStatus">The value to set for the ParameterGroupStatus property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ModifyClusterParameterGroupResult WithParameterGroupStatus(string parameterGroupStatus)
        {
            this._parameterGroupStatus = parameterGroupStatus;
            return this;
        }

        // Check to see if ParameterGroupStatus property is set
        internal bool IsSetParameterGroupStatus()
        {
            return this._parameterGroupStatus != null;
        }

    }
}