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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Verified Access provides server side encryption by default to data at rest using
    /// Amazon Web Services-owned KMS keys. You also have the option of using customer managed
    /// KMS keys, which can be specified using the options below.
    /// </summary>
    public partial class VerifiedAccessSseSpecificationRequest
    {
        private bool? _customerManagedKeyEnabled;
        private string _kmsKeyArn;

        /// <summary>
        /// Gets and sets the property CustomerManagedKeyEnabled. 
        /// <para>
        ///  Enable or disable the use of customer managed KMS keys for server side encryption.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>True</c> | <c>False</c> 
        /// </para>
        /// </summary>
        public bool? CustomerManagedKeyEnabled
        {
            get { return this._customerManagedKeyEnabled; }
            set { this._customerManagedKeyEnabled = value; }
        }

        // Check to see if CustomerManagedKeyEnabled property is set
        internal bool IsSetCustomerManagedKeyEnabled()
        {
            return this._customerManagedKeyEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        ///  The ARN of the KMS key. 
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