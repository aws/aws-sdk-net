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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Container for the parameters to the CreateOrganization operation.
    /// Creates a new WorkMail organization. Optionally, you can choose to associate an existing
    /// AWS Directory Service directory with your organization. If an AWS Directory Service
    /// directory ID is specified, the organization alias must match the directory alias.
    /// If you choose not to associate an existing directory with your organization, then
    /// we create a new WorkMail directory for you. For more information, see <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/add_new_organization.html">Adding
    /// an organization</a> in the <i>WorkMail Administrator Guide</i>.
    /// 
    ///  
    /// <para>
    /// You can associate multiple email domains with an organization, then choose your default
    /// email domain from the WorkMail console. You can also associate a domain that is managed
    /// in an Amazon Route 53 public hosted zone. For more information, see <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/add_domain.html">Adding
    /// a domain</a> and <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/default_domain.html">Choosing
    /// the default domain</a> in the <i>WorkMail Administrator Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Optionally, you can use a customer managed key from AWS Key Management Service (AWS
    /// KMS) to encrypt email for your organization. If you don't associate an AWS KMS key,
    /// WorkMail creates a default, AWS managed key for you.
    /// </para>
    /// </summary>
    public partial class CreateOrganizationRequest : AmazonWorkMailRequest
    {
        private string _alias;
        private string _clientToken;
        private string _directoryId;
        private List<Domain> _domains = new List<Domain>();
        private bool? _enableInteroperability;
        private string _kmsKeyArn;

        /// <summary>
        /// Gets and sets the property Alias. 
        /// <para>
        /// The organization alias.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=62)]
        public string Alias
        {
            get { return this._alias; }
            set { this._alias = value; }
        }

        // Check to see if Alias property is set
        internal bool IsSetAlias()
        {
            return this._alias != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The idempotency token associated with the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The AWS Directory Service directory ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
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
        /// Gets and sets the property Domains. 
        /// <para>
        /// The email domains to associate with the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<Domain> Domains
        {
            get { return this._domains; }
            set { this._domains = value; }
        }

        // Check to see if Domains property is set
        internal bool IsSetDomains()
        {
            return this._domains != null && this._domains.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EnableInteroperability. 
        /// <para>
        /// When <code>true</code>, allows organization interoperability between WorkMail and
        /// Microsoft Exchange. If <code>true</code>, you must include a AD Connector directory
        /// ID in the request.
        /// </para>
        /// </summary>
        public bool EnableInteroperability
        {
            get { return this._enableInteroperability.GetValueOrDefault(); }
            set { this._enableInteroperability = value; }
        }

        // Check to see if EnableInteroperability property is set
        internal bool IsSetEnableInteroperability()
        {
            return this._enableInteroperability.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a customer managed key from AWS KMS.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

    }
}