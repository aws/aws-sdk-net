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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GroundStation.Model
{
    /// <summary>
    /// AWS Key Management Service (KMS) Key.
    /// </summary>
    public partial class KmsKey
    {
        private string _kmsAliasArn;
        private string _kmsKeyArn;

        /// <summary>
        /// Gets and sets the property KmsAliasArn. 
        /// <para>
        /// KMS Alias Arn.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string KmsAliasArn
        {
            get { return this._kmsAliasArn; }
            set { this._kmsAliasArn = value; }
        }

        // Check to see if KmsAliasArn property is set
        internal bool IsSetKmsAliasArn()
        {
            return this._kmsAliasArn != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// KMS Key Arn.
        /// </para>
        /// </summary>
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