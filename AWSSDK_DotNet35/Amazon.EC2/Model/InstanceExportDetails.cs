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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes an instance export task.</para>
    /// </summary>
    public class InstanceExportDetails
    {
        
        private string instanceId;
        private ExportEnvironment targetEnvironment;


        /// <summary>
        /// The ID of the resource being exported.
        ///  
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

        /// <summary>
        /// The target virtualization environment.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>citrix, vmware, microsoft</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ExportEnvironment TargetEnvironment
        {
            get { return this.targetEnvironment; }
            set { this.targetEnvironment = value; }
        }

        // Check to see if TargetEnvironment property is set
        internal bool IsSetTargetEnvironment()
        {
            return this.targetEnvironment != null;
        }
    }
}
