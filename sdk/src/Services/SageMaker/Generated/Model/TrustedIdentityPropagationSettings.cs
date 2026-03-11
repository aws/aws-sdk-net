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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The Trusted Identity Propagation (TIP) settings for the SageMaker domain. These settings
    /// determine how user identities from IAM Identity Center are propagated through the
    /// domain to TIP enabled Amazon Web Services services.
    /// </summary>
    public partial class TrustedIdentityPropagationSettings
    {
        private FeatureStatus _status;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of Trusted Identity Propagation (TIP) at the SageMaker domain level. 
        /// </para>
        ///  
        /// <para>
        /// When disabled, standard IAM role-based access is used. 
        /// </para>
        ///  
        /// <para>
        /// When enabled:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// User identities from IAM Identity Center are propagated through the application to
        /// TIP enabled Amazon Web Services services.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// New applications or existing applications that are automatically patched, will use
        /// the domain level configuration.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public FeatureStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}