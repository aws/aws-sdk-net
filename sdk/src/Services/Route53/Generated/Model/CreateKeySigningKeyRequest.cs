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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the CreateKeySigningKey operation.
    /// Creates a new key-signing key (KSK) associated with a hosted zone. You can only have
    /// two KSKs per hosted zone.
    /// </summary>
    public partial class CreateKeySigningKeyRequest : AmazonRoute53Request
    {
        private string _callerReference;
        private string _hostedZoneId;
        private string _keyManagementServiceArn;
        private string _name;
        private string _status;

        /// <summary>
        /// Gets and sets the property CallerReference. 
        /// <para>
        /// A unique string that identifies the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string CallerReference
        {
            get { return this._callerReference; }
            set { this._callerReference = value; }
        }

        // Check to see if CallerReference property is set
        internal bool IsSetCallerReference()
        {
            return this._callerReference != null;
        }

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The unique string (ID) used to identify a hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=32)]
        public string HostedZoneId
        {
            get { return this._hostedZoneId; }
            set { this._hostedZoneId = value; }
        }

        // Check to see if HostedZoneId property is set
        internal bool IsSetHostedZoneId()
        {
            return this._hostedZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property KeyManagementServiceArn. 
        /// <para>
        /// The Amazon resource name (ARN) for a customer managed key in Key Management Service
        /// (KMS). The <c>KeyManagementServiceArn</c> must be unique for each key-signing key
        /// (KSK) in a single hosted zone. To see an example of <c>KeyManagementServiceArn</c>
        /// that grants the correct permissions for DNSSEC, scroll down to <b>Example</b>. 
        /// </para>
        ///  
        /// <para>
        /// You must configure the customer managed customer managed key as follows:
        /// </para>
        ///  <dl> <dt>Status</dt> <dd> 
        /// <para>
        /// Enabled
        /// </para>
        ///  </dd> <dt>Key spec</dt> <dd> 
        /// <para>
        /// ECC_NIST_P256
        /// </para>
        ///  </dd> <dt>Key usage</dt> <dd> 
        /// <para>
        /// Sign and verify
        /// </para>
        ///  </dd> <dt>Key policy</dt> <dd> 
        /// <para>
        /// The key policy must give permission for the following actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// DescribeKey
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GetPublicKey
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Sign
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The key policy must also include the Amazon Route 53 service in the principal for
        /// your account. Specify the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"Service": "dnssec-route53.amazonaws.com"</c> 
        /// </para>
        ///  </li> </ul> </dd> </dl> 
        /// <para>
        /// For more information about working with a customer managed key in KMS, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html">Key
        /// Management Service concepts</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string KeyManagementServiceArn
        {
            get { return this._keyManagementServiceArn; }
            set { this._keyManagementServiceArn = value; }
        }

        // Check to see if KeyManagementServiceArn property is set
        internal bool IsSetKeyManagementServiceArn()
        {
            return this._keyManagementServiceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A string used to identify a key-signing key (KSK). <c>Name</c> can include numbers,
        /// letters, and underscores (_). <c>Name</c> must be unique for each key-signing key
        /// in the same hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=128)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// A string specifying the initial status of the key-signing key (KSK). You can set the
        /// value to <c>ACTIVE</c> or <c>INACTIVE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=5, Max=150)]
        public string Status
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