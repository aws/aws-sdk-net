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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// An Key Management Service (KMS) key and an Identity and Access Management (IAM) role
    /// that Amazon Forecast can assume to access the key. You can specify this optional object
    /// in the <a>CreateDataset</a> and <a>CreatePredictor</a> requests.
    /// </summary>
    public partial class EncryptionConfig
    {
        private string _kmsKeyArn;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property KMSKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string KMSKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KMSKeyArn property is set
        internal bool IsSetKMSKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that Amazon Forecast can assume to access the KMS key.
        /// </para>
        ///  
        /// <para>
        /// Passing a role across Amazon Web Services accounts is not allowed. If you pass a role
        /// that isn't in your account, you get an <code>InvalidInputException</code> error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

    }
}