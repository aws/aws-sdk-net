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
 * Do not modify this file. This file is generated from the cloudhsm-2014-05-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudHSM.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyLunaClient operation.
    /// Modifies the certificate used by the client.
    /// 
    ///  
    /// <para>
    /// This action can potentially start a workflow to install the new certificate on the
    /// client's HSMs.
    /// </para>
    /// </summary>
    public partial class ModifyLunaClientRequest : AmazonCloudHSMRequest
    {
        private string _certificate;
        private string _clientArn;

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The new certificate for the client. 
        /// </para>
        /// </summary>
        public string Certificate
        {
            get { return this._certificate; }
            set { this._certificate = value; }
        }

        // Check to see if Certificate property is set
        internal bool IsSetCertificate()
        {
            return this._certificate != null;
        }

        /// <summary>
        /// Gets and sets the property ClientArn. 
        /// <para>
        /// The ARN of the client.
        /// </para>
        /// </summary>
        public string ClientArn
        {
            get { return this._clientArn; }
            set { this._clientArn = value; }
        }

        // Check to see if ClientArn property is set
        internal bool IsSetClientArn()
        {
            return this._clientArn != null;
        }

    }
}