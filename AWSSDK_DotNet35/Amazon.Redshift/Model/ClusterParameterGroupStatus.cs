/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para> Describes the status of a parameter group. </para>
    /// </summary>
    public class ClusterParameterGroupStatus
    {
        
        private string parameterGroupName;
        private string parameterApplyStatus;


        /// <summary>
        /// The name of the cluster parameter group.
        ///  
        /// </summary>
        public string ParameterGroupName
        {
            get { return this.parameterGroupName; }
            set { this.parameterGroupName = value; }
        }

        // Check to see if ParameterGroupName property is set
        internal bool IsSetParameterGroupName()
        {
            return this.parameterGroupName != null;
        }

        /// <summary>
        /// The status of parameter updates.
        ///  
        /// </summary>
        public string ParameterApplyStatus
        {
            get { return this.parameterApplyStatus; }
            set { this.parameterApplyStatus = value; }
        }

        // Check to see if ParameterApplyStatus property is set
        internal bool IsSetParameterApplyStatus()
        {
            return this.parameterApplyStatus != null;
        }
    }
}
