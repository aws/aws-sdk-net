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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
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
namespace Amazon.AppSync.Model
{
    /// <summary>
    /// The configuration for a Lambda data source.
    /// </summary>
    public partial class LambdaConfig
    {
        private InvokeType _invokeType;

        /// <summary>
        /// Gets and sets the property InvokeType. 
        /// <para>
        /// The invocation type for a Lambda data source.
        /// </para>
        /// </summary>
        public InvokeType InvokeType
        {
            get { return this._invokeType; }
            set { this._invokeType = value; }
        }

        // Check to see if InvokeType property is set
        internal bool IsSetInvokeType()
        {
            return this._invokeType != null;
        }

    }
}