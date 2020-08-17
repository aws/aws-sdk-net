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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateWorkforce operation.
    /// Restricts access to tasks assigned to workers in the specified workforce to those
    /// within specific ranges of IP addresses. You specify allowed IP addresses by creating
    /// a list of up to ten <a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Subnets.html">CIDRs</a>.
    /// 
    ///  
    /// <para>
    /// By default, a workforce isn't restricted to specific IP addresses. If you specify
    /// a range of IP addresses, workers who attempt to access tasks using any IP address
    /// outside the specified range are denied access and get a <code>Not Found</code> error
    /// message on the worker portal. After restricting access with this operation, you can
    /// see the allowed IP values for a private workforce with the operation.
    /// </para>
    ///  <important> 
    /// <para>
    /// This operation applies only to private workforces.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateWorkforceRequest : AmazonSageMakerRequest
    {
        private OidcConfig _oidcConfig;
        private SourceIpConfig _sourceIpConfig;
        private string _workforceName;

        /// <summary>
        /// Gets and sets the property OidcConfig. 
        /// <para>
        /// Use this parameter to update your OIDC Identity Provider (IdP) configuration for a
        /// workforce made using your own IdP.
        /// </para>
        /// </summary>
        public OidcConfig OidcConfig
        {
            get { return this._oidcConfig; }
            set { this._oidcConfig = value; }
        }

        // Check to see if OidcConfig property is set
        internal bool IsSetOidcConfig()
        {
            return this._oidcConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SourceIpConfig. 
        /// <para>
        /// A list of one to ten worker IP address ranges (<a href="https://docs.aws.amazon.com/vpc/latest/userguide/VPC_Subnets.html">CIDRs</a>)
        /// that can be used to access tasks assigned to this workforce.
        /// </para>
        ///  
        /// <para>
        /// Maximum: Ten CIDR values
        /// </para>
        /// </summary>
        public SourceIpConfig SourceIpConfig
        {
            get { return this._sourceIpConfig; }
            set { this._sourceIpConfig = value; }
        }

        // Check to see if SourceIpConfig property is set
        internal bool IsSetSourceIpConfig()
        {
            return this._sourceIpConfig != null;
        }

        /// <summary>
        /// Gets and sets the property WorkforceName. 
        /// <para>
        /// The name of the private workforce whose access you want to restrict. <code>WorkforceName</code>
        /// is automatically set to <code>default</code> when a workforce is created and cannot
        /// be modified. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string WorkforceName
        {
            get { return this._workforceName; }
            set { this._workforceName = value; }
        }

        // Check to see if WorkforceName property is set
        internal bool IsSetWorkforceName()
        {
            return this._workforceName != null;
        }

    }
}