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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateInstanceExportTask operation.
    /// Exports a running or stopped instance to an Amazon S3 bucket.
    /// 
    ///  
    /// <para>
    /// For information about the prerequisites for your Amazon S3 bucket, supported operating
    /// systems, image formats, and known limitations for the types of instances you can export,
    /// see <a href="https://docs.aws.amazon.com/vm-import/latest/userguide/vmexport.html">Exporting
    /// an instance as a VM Using VM Import/Export</a> in the <i>VM Import/Export User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateInstanceExportTaskRequest : AmazonEC2Request
    {
        private string _description;
        private ExportToS3TaskSpecification _exportToS3Task;
        private string _instanceId;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;
        private ExportEnvironment _targetEnvironment;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the conversion task or the resource being exported. The maximum
        /// length is 255 characters.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ExportToS3Task. 
        /// <para>
        /// The format and location for an export instance task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExportToS3TaskSpecification ExportToS3Task
        {
            get { return this._exportToS3Task; }
            set { this._exportToS3Task = value; }
        }

        // Check to see if ExportToS3Task property is set
        internal bool IsSetExportToS3Task()
        {
            return this._exportToS3Task != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the export instance task during creation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetEnvironment. 
        /// <para>
        /// The target virtualization environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ExportEnvironment TargetEnvironment
        {
            get { return this._targetEnvironment; }
            set { this._targetEnvironment = value; }
        }

        // Check to see if TargetEnvironment property is set
        internal bool IsSetTargetEnvironment()
        {
            return this._targetEnvironment != null;
        }

    }
}