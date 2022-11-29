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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Information about the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/keystore-external.html#concept-external-key">external
    /// key </a>that is associated with a KMS key in an external key store. 
    /// 
    ///  
    /// <para>
    /// These fields appear in a <a>CreateKey</a> or <a>DescribeKey</a> response only for
    /// a KMS key in an external key store.
    /// </para>
    ///  
    /// <para>
    /// The <i>external key</i> is a symmetric encryption key that is hosted by an external
    /// key manager outside of Amazon Web Services. When you use the KMS key in an external
    /// key store in a cryptographic operation, the cryptographic operation is performed in
    /// the external key manager using the specified external key. For more information, see
    /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/keystore-external.html#concept-external-key">External
    /// key</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class XksKeyConfigurationType
    {
        private string _id;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the external key in its external key manager. This is the ID that the external
        /// key store proxy uses to identify the external key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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

    }
}