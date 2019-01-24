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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Container for the parameters to the RemoveListenerCertificates operation.
    /// Removes the specified certificate from the specified HTTPS listener.
    /// 
    ///  
    /// <para>
    /// You can't remove the default certificate for a listener. To replace the default certificate,
    /// call <a>ModifyListener</a>.
    /// </para>
    ///  
    /// <para>
    /// To list the certificates for your listener, use <a>DescribeListenerCertificates</a>.
    /// </para>
    /// </summary>
    public partial class RemoveListenerCertificatesRequest : AmazonElasticLoadBalancingV2Request
    {
        private List<Certificate> _certificates = new List<Certificate>();
        private string _listenerArn;

        /// <summary>
        /// Gets and sets the property Certificates. 
        /// <para>
        /// The certificate to remove. You can specify one certificate per call. Set <code>CertificateArn</code>
        /// to the certificate ARN but do not set <code>IsDefault</code>.
        /// </para>
        /// </summary>
        public List<Certificate> Certificates
        {
            get { return this._certificates; }
            set { this._certificates = value; }
        }

        // Check to see if Certificates property is set
        internal bool IsSetCertificates()
        {
            return this._certificates != null && this._certificates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ListenerArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the listener.
        /// </para>
        /// </summary>
        public string ListenerArn
        {
            get { return this._listenerArn; }
            set { this._listenerArn = value; }
        }

        // Check to see if ListenerArn property is set
        internal bool IsSetListenerArn()
        {
            return this._listenerArn != null;
        }

    }
}