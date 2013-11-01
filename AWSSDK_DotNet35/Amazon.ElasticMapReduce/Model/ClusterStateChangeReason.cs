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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// <para>The reason that the cluster changed to its current state.</para>
    /// </summary>
    public class ClusterStateChangeReason
    {
        
        private ClusterStateChangeReasonCode code;
        private string message;


        /// <summary>
        /// The programmatic code for the state change reason.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>INTERNAL_ERROR, VALIDATION_ERROR, INSTANCE_FAILURE, BOOTSTRAP_FAILURE, USER_REQUEST, STEP_FAILURE, ALL_STEPS_COMPLETED</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ClusterStateChangeReasonCode Code
        {
            get { return this.code; }
            set { this.code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this.code != null;
        }

        /// <summary>
        /// The descriptive message for the state change reason.
        ///  
        /// </summary>
        public string Message
        {
            get { return this.message; }
            set { this.message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this.message != null;
        }
    }
}
