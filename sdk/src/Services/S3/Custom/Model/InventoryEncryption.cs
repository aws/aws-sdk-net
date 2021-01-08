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

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.S3.Model
{
    /// <summary>
    /// InventoryEncryption class
    /// </summary>
    public class InventoryEncryption
    {
        private SSES3 sSES3;
        private SSEKMS sSEKms;

        /// <summary>
        /// Specifies the use of SSE-S3 to encrypt delievered Inventory reports.
        /// </summary>
        public SSES3 SSES3
        {
            get { return this.sSES3; }
            set { this.sSES3 = value; }
        }

        // Check to see if SSES3 property is set
        internal bool IsSetSSES3()
        {
            return this.sSES3 != null;
        }

        /// <summary>
        /// Specifies the use of SSE-KMS to encrypt delievered Inventory reports.
        /// </summary>
        public SSEKMS SSEKMS
        {
            get { return this.sSEKms; }
            set { this.sSEKms = value; }
        }

        // Check to see if SSEKMS property is set
        internal bool IsSetSSEKMS()
        {
            return this.sSEKms != null;
        }


    }
}