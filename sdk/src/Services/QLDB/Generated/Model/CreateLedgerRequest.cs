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
 * Do not modify this file. This file is generated from the qldb-2019-01-02.normal.json service model.
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
namespace Amazon.QLDB.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLedger operation.
    /// Creates a new ledger in your Amazon Web Services account in the current Region.
    /// </summary>
    public partial class CreateLedgerRequest : AmazonQLDBRequest
    {
        private bool? _deletionProtection;
        private string _kmsKey;
        private string _name;
        private PermissionsMode _permissionsMode;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property DeletionProtection. 
        /// <para>
        /// Specifies whether the ledger is protected from being deleted by any user. If not defined
        /// during ledger creation, this feature is enabled (<c>true</c>) by default.
        /// </para>
        ///  
        /// <para>
        /// If deletion protection is enabled, you must first disable it before you can delete
        /// the ledger. You can disable it by calling the <c>UpdateLedger</c> operation to set
        /// this parameter to <c>false</c>.
        /// </para>
        /// </summary>
        public bool? DeletionProtection
        {
            get { return this._deletionProtection; }
            set { this._deletionProtection = value; }
        }

        // Check to see if DeletionProtection property is set
        internal bool IsSetDeletionProtection()
        {
            return this._deletionProtection.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKey. 
        /// <para>
        /// The key in Key Management Service (KMS) to use for encryption of data at rest in the
        /// ledger. For more information, see <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/encryption-at-rest.html">Encryption
        /// at rest</a> in the <i>Amazon QLDB Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Use one of the following options to specify this parameter:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AWS_OWNED_KMS_KEY</c>: Use an KMS key that is owned and managed by Amazon Web
        /// Services on your behalf.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Undefined</b>: By default, use an Amazon Web Services owned KMS key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>A valid symmetric customer managed KMS key</b>: Use the specified symmetric encryption
        /// KMS key in your account that you create, own, and manage.
        /// </para>
        ///  
        /// <para>
        /// Amazon QLDB does not support asymmetric keys. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
        /// symmetric and asymmetric keys</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To specify a customer managed KMS key, you can use its key ID, Amazon Resource Name
        /// (ARN), alias name, or alias ARN. When using an alias name, prefix it with <c>"alias/"</c>.
        /// To specify a key in a different Amazon Web Services account, you must use the key
        /// ARN or alias ARN.
        /// </para>
        ///  
        /// <para>
        /// For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID: <c>1234abcd-12ab-34cd-56ef-1234567890ab</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <c>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name: <c>alias/ExampleAlias</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias ARN: <c>arn:aws:kms:us-east-2:111122223333:alias/ExampleAlias</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#key-id">Key
        /// identifiers (KeyId)</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1600)]
        public string KmsKey
        {
            get { return this._kmsKey; }
            set { this._kmsKey = value; }
        }

        // Check to see if KmsKey property is set
        internal bool IsSetKmsKey()
        {
            return this._kmsKey != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the ledger that you want to create. The name must be unique among all
        /// of the ledgers in your Amazon Web Services account in the current Region.
        /// </para>
        ///  
        /// <para>
        /// Naming constraints for ledger names are defined in <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/limits.html#limits.naming">Quotas
        /// in Amazon QLDB</a> in the <i>Amazon QLDB Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
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
        /// Gets and sets the property PermissionsMode. 
        /// <para>
        /// The permissions mode to assign to the ledger that you want to create. This parameter
        /// can have one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALLOW_ALL</c>: A legacy permissions mode that enables access control with API-level
        /// granularity for ledgers.
        /// </para>
        ///  
        /// <para>
        /// This mode allows users who have the <c>SendCommand</c> API permission for this ledger
        /// to run all PartiQL commands (hence, <c>ALLOW_ALL</c>) on any tables in the specified
        /// ledger. This mode disregards any table-level or command-level IAM permissions policies
        /// that you create for the ledger.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STANDARD</c>: (<i>Recommended</i>) A permissions mode that enables access control
        /// with finer granularity for ledgers, tables, and PartiQL commands.
        /// </para>
        ///  
        /// <para>
        /// By default, this mode denies all user requests to run any PartiQL commands on any
        /// tables in this ledger. To allow PartiQL commands to run, you must create IAM permissions
        /// policies for specific table resources and PartiQL actions, in addition to the <c>SendCommand</c>
        /// API permission for the ledger. For information, see <a href="https://docs.aws.amazon.com/qldb/latest/developerguide/getting-started-standard-mode.html">Getting
        /// started with the standard permissions mode</a> in the <i>Amazon QLDB Developer Guide</i>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// We strongly recommend using the <c>STANDARD</c> permissions mode to maximize the security
        /// of your ledger data.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public PermissionsMode PermissionsMode
        {
            get { return this._permissionsMode; }
            set { this._permissionsMode = value; }
        }

        // Check to see if PermissionsMode property is set
        internal bool IsSetPermissionsMode()
        {
            return this._permissionsMode != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value pairs to add as tags to the ledger that you want to create. Tag keys
        /// are case sensitive. Tag values are case sensitive and can be null.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}