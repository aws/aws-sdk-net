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

/*
 * Do not modify this file. This file is generated from the ec2-2015-03-01.normal.json service model.
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
    /// 
    /// </summary>
    public partial class ImportImageTask
    {
        private string _architecture;
        private string _description;
        private string _hypervisor;
        private string _imageId;
        private string _importTaskId;
        private string _licenseType;
        private string _platform;
        private string _progress;
        private List<SnapshotDetail> _snapshotDetails = new List<SnapshotDetail>();
        private string _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// Architecture of the VM being imported.
        /// </para>
        /// </summary>
        public string Architecture
        {
            get { return this._architecture; }
            set { this._architecture = value; }
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this._architecture != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the import task.
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
        /// Gets and sets the property Hypervisor. 
        /// <para>
        /// Target hypervisor for the import task.
        /// </para>
        /// </summary>
        public string Hypervisor
        {
            get { return this._hypervisor; }
            set { this._hypervisor = value; }
        }

        // Check to see if Hypervisor property is set
        internal bool IsSetHypervisor()
        {
            return this._hypervisor != null;
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The Amazon Machine Image (AMI) ID of the imported virtual machine.
        /// </para>
        /// </summary>
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property ImportTaskId. 
        /// <para>
        /// The ID of the import task.
        /// </para>
        /// </summary>
        public string ImportTaskId
        {
            get { return this._importTaskId; }
            set { this._importTaskId = value; }
        }

        // Check to see if ImportTaskId property is set
        internal bool IsSetImportTaskId()
        {
            return this._importTaskId != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseType. 
        /// <para>
        /// License type of the VM being imported.
        /// </para>
        /// </summary>
        public string LicenseType
        {
            get { return this._licenseType; }
            set { this._licenseType = value; }
        }

        // Check to see if LicenseType property is set
        internal bool IsSetLicenseType()
        {
            return this._licenseType != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The description string for the import image task.
        /// </para>
        /// </summary>
        public string Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property Progress. 
        /// <para>
        /// The percentage of progress of the ImportImage task.
        /// </para>
        /// </summary>
        public string Progress
        {
            get { return this._progress; }
            set { this._progress = value; }
        }

        // Check to see if Progress property is set
        internal bool IsSetProgress()
        {
            return this._progress != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotDetails.
        /// </summary>
        public List<SnapshotDetail> SnapshotDetails
        {
            get { return this._snapshotDetails; }
            set { this._snapshotDetails = value; }
        }

        // Check to see if SnapshotDetails property is set
        internal bool IsSetSnapshotDetails()
        {
            return this._snapshotDetails != null && this._snapshotDetails.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// A brief status for the ImportImage task.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A descriptive status message for the ImportImage task.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}