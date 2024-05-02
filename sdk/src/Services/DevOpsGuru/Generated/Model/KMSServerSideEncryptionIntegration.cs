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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
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
namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// Information about the KMS encryption used with DevOps Guru.
    /// </summary>
    public partial class KMSServerSideEncryptionIntegration
    {
        private string _kmsKeyId;
        private OptInStatus _optInStatus;
        private ServerSideEncryptionType _type;

        /// <summary>
        /// Gets and sets the property KMSKeyId. 
        /// <para>
        ///  Describes the specified KMS key. 
        /// </para>
        ///  
        /// <para>
        /// To specify a KMS key, use its key ID, key ARN, alias name, or alias ARN. When using
        /// an alias name, prefix it with "alias/". If you specify a predefined Amazon Web Services
        /// alias (an Amazon Web Services alias with no key ID), Amazon Web Services KMS associates
        /// the alias with an Amazon Web Services managed key and returns its KeyId and Arn in
        /// the response. To specify a KMS key in a different Amazon Web Services account, you
        /// must use the key ARN or alias ARN.
        /// </para>
        ///  
        /// <para>
        /// For example: 
        /// </para>
        ///  
        /// <para>
        /// Key ID: 1234abcd-12ab-34cd-56ef-1234567890ab
        /// </para>
        ///  
        /// <para>
        /// Key ARN: arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab
        /// </para>
        ///  
        /// <para>
        /// Alias name: alias/ExampleAlias
        /// </para>
        ///  
        /// <para>
        /// Alias ARN: arn:aws:kms:us-east-2:111122223333:alias/ExampleAlias
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string KMSKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KMSKeyId property is set
        internal bool IsSetKMSKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property OptInStatus. 
        /// <para>
        ///  Specifies if DevOps Guru is enabled for customer managed keys. 
        /// </para>
        /// </summary>
        public OptInStatus OptInStatus
        {
            get { return this._optInStatus; }
            set { this._optInStatus = value; }
        }

        // Check to see if OptInStatus property is set
        internal bool IsSetOptInStatus()
        {
            return this._optInStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  The type of KMS key used. Customer managed keys are the KMS keys that you create.
        /// Amazon Web Services owned keys are keys that are owned and managed by DevOps Guru.
        /// 
        /// </para>
        /// </summary>
        public ServerSideEncryptionType Type
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