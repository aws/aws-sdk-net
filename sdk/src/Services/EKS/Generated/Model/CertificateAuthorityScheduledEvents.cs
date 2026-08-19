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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// The scheduled events during which Amazon EKS may automatically activate a certificate
    /// authority, computed from its validity period. These events help ensure that a cluster's
    /// signing certificate authority is rotated before its certificate expires.
    /// </summary>
    public partial class CertificateAuthorityScheduledEvents
    {
        private DateTime? _finalAutoActivation;
        private DateTime? _firstAutoActivation;

        /// <summary>
        /// Gets and sets the property FinalAutoActivation. 
        /// <para>
        /// The Unix epoch timestamp in seconds by which Amazon EKS will automatically activate
        /// this certificate authority if you haven't already activated it.
        /// </para>
        /// </summary>
        public DateTime? FinalAutoActivation
        {
            get { return this._finalAutoActivation; }
            set { this._finalAutoActivation = value; }
        }

        // Check to see if FinalAutoActivation property is set
        internal bool IsSetFinalAutoActivation()
        {
            return this._finalAutoActivation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FirstAutoActivation. 
        /// <para>
        /// The earliest Unix epoch timestamp in seconds at which Amazon EKS may automatically
        /// activate this certificate authority.
        /// </para>
        /// </summary>
        public DateTime? FirstAutoActivation
        {
            get { return this._firstAutoActivation; }
            set { this._firstAutoActivation = value; }
        }

        // Check to see if FirstAutoActivation property is set
        internal bool IsSetFirstAutoActivation()
        {
            return this._firstAutoActivation.HasValue; 
        }

    }
}