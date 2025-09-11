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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// A customer managed key structure that contains the information listed below: 
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>KeyArn</c> - The ARN of a KMS key that is registered to a QuickSight account for
    /// encryption and decryption use.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DefaultKey</c> - Indicates whether the current key is set as the default key for
    /// encryption and decryption use.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RegisteredCustomerManagedKey
    {
        private bool? _defaultKey;
        private string _keyArn;

        /// <summary>
        /// Gets and sets the property DefaultKey. 
        /// <para>
        /// Indicates whether a <c>RegisteredCustomerManagedKey</c> is set as the default key
        /// for encryption and decryption use.
        /// </para>
        /// </summary>
        public bool? DefaultKey
        {
            get { return this._defaultKey; }
            set { this._defaultKey = value; }
        }

        // Check to see if DefaultKey property is set
        internal bool IsSetDefaultKey()
        {
            return this._defaultKey.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeyArn. 
        /// <para>
        /// The ARN of the KMS key that is registered to a QuickSight account for encryption and
        /// decryption use.
        /// </para>
        /// </summary>
        public string KeyArn
        {
            get { return this._keyArn; }
            set { this._keyArn = value; }
        }

        // Check to see if KeyArn property is set
        internal bool IsSetKeyArn()
        {
            return this._keyArn != null;
        }

    }
}