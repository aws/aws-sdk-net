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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// The encryption-at-rest settings of the transform that apply to accessing user data.
    /// Machine learning transforms can access user data encrypted in Amazon S3 using KMS.
    /// 
    ///  
    /// <para>
    /// Additionally, imported labels and trained transforms can now be encrypted using a
    /// customer provided KMS key.
    /// </para>
    /// </summary>
    public partial class TransformEncryption
    {
        private MLUserDataEncryption _mlUserDataEncryption;
        private string _taskRunSecurityConfigurationName;

        /// <summary>
        /// Gets and sets the property MlUserDataEncryption. 
        /// <para>
        /// An <c>MLUserDataEncryption</c> object containing the encryption mode and customer-provided
        /// KMS key ID.
        /// </para>
        /// </summary>
        public MLUserDataEncryption MlUserDataEncryption
        {
            get { return this._mlUserDataEncryption; }
            set { this._mlUserDataEncryption = value; }
        }

        // Check to see if MlUserDataEncryption property is set
        internal bool IsSetMlUserDataEncryption()
        {
            return this._mlUserDataEncryption != null;
        }

        /// <summary>
        /// Gets and sets the property TaskRunSecurityConfigurationName. 
        /// <para>
        /// The name of the security configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string TaskRunSecurityConfigurationName
        {
            get { return this._taskRunSecurityConfigurationName; }
            set { this._taskRunSecurityConfigurationName = value; }
        }

        // Check to see if TaskRunSecurityConfigurationName property is set
        internal bool IsSetTaskRunSecurityConfigurationName()
        {
            return this._taskRunSecurityConfigurationName != null;
        }

    }
}