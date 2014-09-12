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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
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
    /// Returns information about an HSM configuration, which is an object that describes
    /// to Amazon Redshift            clusters the information they require to connect to
    /// an HSM where they can store database            encryption keys.
    /// </summary>
    public partial class HsmConfiguration
    {
        private string _description;
        private string _hsmConfigurationIdentifier;
        private string _hsmIpAddress;
        private string _hsmPartitionName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A text description of the HSM configuration.
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
        /// Gets and sets the property HsmConfigurationIdentifier. 
        /// <para>
        /// The name of the Amazon Redshift HSM configuration.
        /// </para>
        /// </summary>
        public string HsmConfigurationIdentifier
        {
            get { return this._hsmConfigurationIdentifier; }
            set { this._hsmConfigurationIdentifier = value; }
        }

        // Check to see if HsmConfigurationIdentifier property is set
        internal bool IsSetHsmConfigurationIdentifier()
        {
            return this._hsmConfigurationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property HsmIpAddress. 
        /// <para>
        /// The IP address that the Amazon Redshift cluster must use to access the HSM.
        /// </para>
        /// </summary>
        public string HsmIpAddress
        {
            get { return this._hsmIpAddress; }
            set { this._hsmIpAddress = value; }
        }

        // Check to see if HsmIpAddress property is set
        internal bool IsSetHsmIpAddress()
        {
            return this._hsmIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property HsmPartitionName. 
        /// <para>
        /// The name of the partition in the HSM where the Amazon Redshift clusters will store
        ///            their database encryption keys.
        /// </para>
        /// </summary>
        public string HsmPartitionName
        {
            get { return this._hsmPartitionName; }
            set { this._hsmPartitionName = value; }
        }

        // Check to see if HsmPartitionName property is set
        internal bool IsSetHsmPartitionName()
        {
            return this._hsmPartitionName != null;
        }

    }
}