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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateStorageVirtualMachine operation.
    /// Updates an Amazon FSx for ONTAP storage virtual machine (SVM).
    /// </summary>
    public partial class UpdateStorageVirtualMachineRequest : AmazonFSxRequest
    {
        private UpdateSvmActiveDirectoryConfiguration _activeDirectoryConfiguration;
        private string _clientRequestToken;
        private string _storageVirtualMachineId;
        private string _svmAdminPassword;

        /// <summary>
        /// Gets and sets the property ActiveDirectoryConfiguration. 
        /// <para>
        /// Updates the Microsoft Active Directory (AD) configuration for an SVM that is joined
        /// to an AD.
        /// </para>
        /// </summary>
        public UpdateSvmActiveDirectoryConfiguration ActiveDirectoryConfiguration
        {
            get { return this._activeDirectoryConfiguration; }
            set { this._activeDirectoryConfiguration = value; }
        }

        // Check to see if ActiveDirectoryConfiguration property is set
        internal bool IsSetActiveDirectoryConfiguration()
        {
            return this._activeDirectoryConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property StorageVirtualMachineId. 
        /// <para>
        /// The ID of the SVM that you want to update, in the format <code>svm-0123456789abcdef0</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=21, Max=21)]
        public string StorageVirtualMachineId
        {
            get { return this._storageVirtualMachineId; }
            set { this._storageVirtualMachineId = value; }
        }

        // Check to see if StorageVirtualMachineId property is set
        internal bool IsSetStorageVirtualMachineId()
        {
            return this._storageVirtualMachineId != null;
        }

        /// <summary>
        /// Gets and sets the property SvmAdminPassword. 
        /// <para>
        /// Enter a new SvmAdminPassword if you are updating it.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=8, Max=50)]
        public string SvmAdminPassword
        {
            get { return this._svmAdminPassword; }
            set { this._svmAdminPassword = value; }
        }

        // Check to see if SvmAdminPassword property is set
        internal bool IsSetSvmAdminPassword()
        {
            return this._svmAdminPassword != null;
        }

    }
}