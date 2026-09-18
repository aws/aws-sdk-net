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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.MediaPackageV2.Model
{
    /// <summary>
    /// The encryption type.
    /// </summary>
    public partial class EncryptionMethod
    {
        /// <summary>
        /// Gets and sets the property CmafEncryptionMethod. 
        /// <para>
        /// The encryption method to use.
        /// </para>
        /// </summary>
        public CmafEncryptionMethod CmafEncryptionMethod { get; set; }

        /// <summary>
        /// Checks to see if the CmafEncryptionMethod property is set.
        /// </summary>
        internal bool IsSetCmafEncryptionMethod() => this.CmafEncryptionMethod != null;

        /// <summary>
        /// Gets and sets the property IsmEncryptionMethod. 
        /// <para>
        /// The encryption method used for Microsoft Smooth Streaming (MSS) content. This specifies
        /// how the MSS segments are encrypted to protect the content during delivery to client
        /// players.
        /// </para>
        /// </summary>
        public IsmEncryptionMethod IsmEncryptionMethod { get; set; }

        /// <summary>
        /// Checks to see if the IsmEncryptionMethod property is set.
        /// </summary>
        internal bool IsSetIsmEncryptionMethod() => this.IsmEncryptionMethod != null;

        /// <summary>
        /// Gets and sets the property TsEncryptionMethod. 
        /// <para>
        /// The encryption method to use.
        /// </para>
        /// </summary>
        public TsEncryptionMethod TsEncryptionMethod { get; set; }

        /// <summary>
        /// Checks to see if the TsEncryptionMethod property is set.
        /// </summary>
        internal bool IsSetTsEncryptionMethod() => this.TsEncryptionMethod != null;
    }
}
