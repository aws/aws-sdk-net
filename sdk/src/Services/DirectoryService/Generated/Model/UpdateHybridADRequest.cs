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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
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
namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateHybridAD operation.
    /// Updates the configuration of an existing hybrid directory. You can recover hybrid
    /// directory administrator account or modify self-managed instance settings.
    /// 
    ///  
    /// <para>
    /// Updates are applied asynchronously. Use <a>DescribeHybridADUpdate</a> to monitor the
    /// progress of configuration changes.
    /// </para>
    ///  
    /// <para>
    /// The <c>InstanceIds</c> must have a one-to-one correspondence with <c>CustomerDnsIps</c>,
    /// meaning that if the IP address for instance i-10243410 is 10.24.34.100 and the IP
    /// address for instance i-10243420 is 10.24.34.200, then the input arrays must maintain
    /// the same order relationship, either [10.24.34.100, 10.24.34.200] paired with [i-10243410,
    /// i-10243420] or [10.24.34.200, 10.24.34.100] paired with [i-10243420, i-10243410].
    /// </para>
    ///  <note> 
    /// <para>
    /// You must provide at least one update to <a>UpdateHybridADRequest$HybridAdministratorAccountUpdate</a>
    /// or <a>UpdateHybridADRequest$SelfManagedInstancesSettings</a>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateHybridADRequest : AmazonDirectoryServiceRequest
    {
        private string _directoryId;
        private HybridAdministratorAccountUpdate _hybridAdministratorAccountUpdate;
        private HybridCustomerInstancesSettings _selfManagedInstancesSettings;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the hybrid directory to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property HybridAdministratorAccountUpdate. 
        /// <para>
        /// We create a hybrid directory administrator account when we create a hybrid directory.
        /// Use <c>HybridAdministratorAccountUpdate</c> to recover the hybrid directory administrator
        /// account if you have deleted it.
        /// </para>
        ///  
        /// <para>
        /// To recover your hybrid directory administrator account, we need temporary access to
        /// a user in your self-managed AD with administrator permissions in the form of a secret
        /// from Amazon Web Services Secrets Manager. We use these credentials once during recovery
        /// and don't store them.
        /// </para>
        ///  
        /// <para>
        /// If your hybrid directory administrator account exists, then you don’t need to use
        /// <c>HybridAdministratorAccountUpdate</c>, even if you have updated your self-managed
        /// AD administrator user.
        /// </para>
        /// </summary>
        public HybridAdministratorAccountUpdate HybridAdministratorAccountUpdate
        {
            get { return this._hybridAdministratorAccountUpdate; }
            set { this._hybridAdministratorAccountUpdate = value; }
        }

        // Check to see if HybridAdministratorAccountUpdate property is set
        internal bool IsSetHybridAdministratorAccountUpdate()
        {
            return this._hybridAdministratorAccountUpdate != null;
        }

        /// <summary>
        /// Gets and sets the property SelfManagedInstancesSettings. 
        /// <para>
        /// Updates to the self-managed AD configuration, including DNS server IP addresses and
        /// Amazon Web Services System Manager managed node identifiers.
        /// </para>
        /// </summary>
        public HybridCustomerInstancesSettings SelfManagedInstancesSettings
        {
            get { return this._selfManagedInstancesSettings; }
            set { this._selfManagedInstancesSettings = value; }
        }

        // Check to see if SelfManagedInstancesSettings property is set
        internal bool IsSetSelfManagedInstancesSettings()
        {
            return this._selfManagedInstancesSettings != null;
        }

    }
}