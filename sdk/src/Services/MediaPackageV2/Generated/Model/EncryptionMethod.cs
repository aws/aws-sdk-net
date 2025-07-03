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
 * Do not modify this file. This file is generated from the mediapackagev2-2022-12-25.normal.json service model.
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
        private CmafEncryptionMethod _cmafEncryptionMethod;
        private IsmEncryptionMethod _ismEncryptionMethod;
        private TsEncryptionMethod _tsEncryptionMethod;

        /// <summary>
        /// Gets and sets the property CmafEncryptionMethod. 
        /// <para>
        /// The encryption method to use.
        /// </para>
        /// </summary>
        public CmafEncryptionMethod CmafEncryptionMethod
        {
            get { return this._cmafEncryptionMethod; }
            set { this._cmafEncryptionMethod = value; }
        }

        // Check to see if CmafEncryptionMethod property is set
        internal bool IsSetCmafEncryptionMethod()
        {
            return this._cmafEncryptionMethod != null;
        }

        /// <summary>
        /// Gets and sets the property IsmEncryptionMethod. 
        /// <para>
        /// The encryption method used for Microsoft Smooth Streaming (MSS) content. This specifies
        /// how the MSS segments are encrypted to protect the content during delivery to client
        /// players.
        /// </para>
        /// </summary>
        public IsmEncryptionMethod IsmEncryptionMethod
        {
            get { return this._ismEncryptionMethod; }
            set { this._ismEncryptionMethod = value; }
        }

        // Check to see if IsmEncryptionMethod property is set
        internal bool IsSetIsmEncryptionMethod()
        {
            return this._ismEncryptionMethod != null;
        }

        /// <summary>
        /// Gets and sets the property TsEncryptionMethod. 
        /// <para>
        /// The encryption method to use.
        /// </para>
        /// </summary>
        public TsEncryptionMethod TsEncryptionMethod
        {
            get { return this._tsEncryptionMethod; }
            set { this._tsEncryptionMethod = value; }
        }

        // Check to see if TsEncryptionMethod property is set
        internal bool IsSetTsEncryptionMethod()
        {
            return this._tsEncryptionMethod != null;
        }

    }
}