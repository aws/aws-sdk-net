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

namespace Amazon.CloudSearch.Model
{
    /// <summary>
    /// <para>The status and configuration of a search domain's scaling parameters. </para>
    /// </summary>
    public partial class ScalingParametersStatus
    {
        
        private ScalingParameters options;
        private OptionStatus status;


        /// <summary>
        /// The desired instance type and desired number of replicas of each index partition.
        ///  
        /// </summary>
        public ScalingParameters Options
        {
            get { return this.options; }
            set { this.options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this.options != null;
        }

        /// <summary>
        /// The status of domain configuration option.
        ///  
        /// </summary>
        public OptionStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }
    }
}
