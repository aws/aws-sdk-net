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
 * Do not modify this file. This file is generated from the managedblockchain-2018-09-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ManagedBlockchain.Model
{
    /// <summary>
    /// The properties of the Accessor.
    /// </summary>
    public partial class Accessor
    {
        private string _arn;
        private string _billingToken;
        private DateTime? _creationDate;
        private string _id;
        private AccessorStatus _status;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private AccessorType _type;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the accessor. For more information about ARNs and
        /// their format, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property BillingToken. 
        /// <para>
        /// The billing token is a property of the accessor. Use this token to make Ethereum API
        /// calls to your Ethereum node. The billing token is used to track your accessor object
        /// for billing Ethereum API requests made to your Ethereum nodes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=42, Max=42)]
        public string BillingToken
        {
            get { return this._billingToken; }
            set { this._billingToken = value; }
        }

        // Check to see if BillingToken property is set
        internal bool IsSetBillingToken()
        {
            return this._billingToken != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The creation date and time of the accessor.
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the accessor.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the accessor.
        /// </para>
        /// </summary>
        public AccessorStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the Accessor.
        /// </para>
        ///  
        /// <para>
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/managed-blockchain/latest/ethereum-dev/tagging-resources.html">Tagging
        /// Resources</a> in the <i>Amazon Managed Blockchain Ethereum Developer Guide</i>, or
        /// <a href="https://docs.aws.amazon.com/managed-blockchain/latest/hyperledger-fabric-dev/tagging-resources.html">Tagging
        /// Resources</a> in the <i>Amazon Managed Blockchain Hyperledger Fabric Developer Guide</i>.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the accessor.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently accessor type is restricted to <code>BILLING_TOKEN</code>.
        /// </para>
        ///  </note>
        /// </summary>
        public AccessorType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}