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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Proton.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRepository operation.
    /// Create and register a link to a repository that can be used with self-managed provisioning
    /// (infrastructure or pipelines) or for template sync configurations. When you create
    /// a repository link, Proton creates a <a href="https://docs.aws.amazon.com/proton/latest/adminguide/using-service-linked-roles.html">service-linked
    /// role</a> for you.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/proton/latest/adminguide/ag-works-prov-methods.html#ag-works-prov-methods-self">Self-managed
    /// provisioning</a>, <a href="https://docs.aws.amazon.com/proton/latest/adminguide/ag-template-bundles.html">Template
    /// bundles</a>, and <a href="https://docs.aws.amazon.com/proton/latest/adminguide/ag-template-sync-configs.html">Template
    /// sync configurations</a> in the <i>Proton Administrator Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateRepositoryRequest : AmazonProtonRequest
    {
        private string _connectionArn;
        private string _encryptionKey;
        private string _name;
        private RepositoryProvider _provider;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ConnectionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of your Amazon Web Services CodeStar connection. For
        /// more information, see <a href="https://docs.aws.amazon.com/proton/latest/adminguide/setting-up-for-service.html">Setting
        /// up for Proton</a> in the <i>Proton Administrator Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string ConnectionArn
        {
            get { return this._connectionArn; }
            set { this._connectionArn = value; }
        }

        // Check to see if ConnectionArn property is set
        internal bool IsSetConnectionArn()
        {
            return this._connectionArn != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKey. 
        /// <para>
        /// The ARN of your customer Amazon Web Services Key Management Service (Amazon Web Services
        /// KMS) key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string EncryptionKey
        {
            get { return this._encryptionKey; }
            set { this._encryptionKey = value; }
        }

        // Check to see if EncryptionKey property is set
        internal bool IsSetEncryptionKey()
        {
            return this._encryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The repository name (for example, <code>myrepos/myrepo</code>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Provider. 
        /// <para>
        /// The repository provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RepositoryProvider Provider
        {
            get { return this._provider; }
            set { this._provider = value; }
        }

        // Check to see if Provider property is set
        internal bool IsSetProvider()
        {
            return this._provider != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional list of metadata items that you can associate with the Proton repository.
        /// A tag is a key-value pair.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <i>Proton resources and tagging</i> in the <a href="https://docs.aws.amazon.com/proton/latest/adminguide/resources.html">Proton
        /// Administrator Guide</a> or <a href="https://docs.aws.amazon.com/proton/latest/userguide/resources.html">Proton
        /// User Guide</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}