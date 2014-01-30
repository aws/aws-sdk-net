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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateInstanceExportTask operation.
    /// <para>Exports a running or stopped instance to an Amazon S3 bucket.</para> <para>For information about the supported operating systems,
    /// image formats, and known limitations for the types of instances you can export, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ExportingEC2Instances.html" >Exporting EC2 Instances</a> in the <i>Amazon Elastic
    /// Compute Cloud User Guide</i> .</para>
    /// </summary>
    public partial class CreateInstanceExportTaskRequest : AmazonEC2Request
    {
        private string description;
        private string instanceId;
        private ExportEnvironment targetEnvironment;
        private ExportToS3TaskSpecification exportToS3Task;


        /// <summary>
        /// A description for the conversion task or the resource being exported. The maximum length is 255 bytes.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// The ID of the instance.
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

        /// <summary>
        /// 
        ///  
        /// </summary>
        public ExportToS3TaskSpecification ExportToS3Task
        {
            get { return this.exportToS3Task; }
            set { this.exportToS3Task = value; }
        }

        // Check to see if ExportToS3Task property is set
        internal bool IsSetExportToS3Task()
        {
            return this.exportToS3Task != null;
        }

    }
}
    
