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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Provides information on how the retriever used for your Amazon Q Business application
    /// is configured.
    /// </summary>
    public partial class RetrieverConfiguration
    {
        private KendraIndexConfiguration _kendraIndexConfiguration;
        private NativeIndexConfiguration _nativeIndexConfiguration;

        /// <summary>
        /// Gets and sets the property KendraIndexConfiguration. 
        /// <para>
        /// Provides information on how the Amazon Kendra index used as a retriever for your Amazon
        /// Q Business application is configured.
        /// </para>
        /// </summary>
        public KendraIndexConfiguration KendraIndexConfiguration
        {
            get { return this._kendraIndexConfiguration; }
            set { this._kendraIndexConfiguration = value; }
        }

        // Check to see if KendraIndexConfiguration property is set
        internal bool IsSetKendraIndexConfiguration()
        {
            return this._kendraIndexConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property NativeIndexConfiguration. 
        /// <para>
        /// Provides information on how a Amazon Q Business index used as a retriever for your
        /// Amazon Q Business application is configured.
        /// </para>
        /// </summary>
        public NativeIndexConfiguration NativeIndexConfiguration
        {
            get { return this._nativeIndexConfiguration; }
            set { this._nativeIndexConfiguration = value; }
        }

        // Check to see if NativeIndexConfiguration property is set
        internal bool IsSetNativeIndexConfiguration()
        {
            return this._nativeIndexConfiguration != null;
        }

    }
}