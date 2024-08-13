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
 * Do not modify this file. This file is generated from the workspaces-web-2020-07-08.normal.json service model.
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
namespace Amazon.WorkSpacesWeb.Model
{
    /// <summary>
    /// The summary of the certificate.
    /// </summary>
    public partial class CertificateSummary
    {
        private string _issuer;
        private DateTime? _notValidAfter;
        private DateTime? _notValidBefore;
        private string _subject;
        private string _thumbprint;

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The entity that issued the certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Issuer
        {
            get { return this._issuer; }
            set { this._issuer = value; }
        }

        // Check to see if Issuer property is set
        internal bool IsSetIssuer()
        {
            return this._issuer != null;
        }

        /// <summary>
        /// Gets and sets the property NotValidAfter. 
        /// <para>
        /// The certificate is not valid after this date.
        /// </para>
        /// </summary>
        public DateTime? NotValidAfter
        {
            get { return this._notValidAfter; }
            set { this._notValidAfter = value; }
        }

        // Check to see if NotValidAfter property is set
        internal bool IsSetNotValidAfter()
        {
            return this._notValidAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotValidBefore. 
        /// <para>
        /// The certificate is not valid before this date.
        /// </para>
        /// </summary>
        public DateTime? NotValidBefore
        {
            get { return this._notValidBefore; }
            set { this._notValidBefore = value; }
        }

        // Check to see if NotValidBefore property is set
        internal bool IsSetNotValidBefore()
        {
            return this._notValidBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Subject. 
        /// <para>
        /// The entity the certificate belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Subject
        {
            get { return this._subject; }
            set { this._subject = value; }
        }

        // Check to see if Subject property is set
        internal bool IsSetSubject()
        {
            return this._subject != null;
        }

        /// <summary>
        /// Gets and sets the property Thumbprint. 
        /// <para>
        /// A hexadecimal identifier for the certificate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=64, Max=64)]
        public string Thumbprint
        {
            get { return this._thumbprint; }
            set { this._thumbprint = value; }
        }

        // Check to see if Thumbprint property is set
        internal bool IsSetThumbprint()
        {
            return this._thumbprint != null;
        }

    }
}