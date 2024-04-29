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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateConfiguration operation.
    /// Updates setting configurations for your Amazon Inspector account. When you use this
    /// API as an Amazon Inspector delegated administrator this updates the setting for all
    /// accounts you manage. Member accounts in an organization cannot update this setting.
    /// </summary>
    public partial class UpdateConfigurationRequest : AmazonInspector2Request
    {
        private Ec2Configuration _ec2Configuration;
        private EcrConfiguration _ecrConfiguration;

        /// <summary>
        /// Gets and sets the property Ec2Configuration. 
        /// <para>
        /// Specifies how the Amazon EC2 automated scan will be updated for your environment.
        /// </para>
        /// </summary>
        public Ec2Configuration Ec2Configuration
        {
            get { return this._ec2Configuration; }
            set { this._ec2Configuration = value; }
        }

        // Check to see if Ec2Configuration property is set
        internal bool IsSetEc2Configuration()
        {
            return this._ec2Configuration != null;
        }

        /// <summary>
        /// Gets and sets the property EcrConfiguration. 
        /// <para>
        /// Specifies how the ECR automated re-scan will be updated for your environment.
        /// </para>
        /// </summary>
        public EcrConfiguration EcrConfiguration
        {
            get { return this._ecrConfiguration; }
            set { this._ecrConfiguration = value; }
        }

        // Check to see if EcrConfiguration property is set
        internal bool IsSetEcrConfiguration()
        {
            return this._ecrConfiguration != null;
        }

    }
}