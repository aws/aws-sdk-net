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
 * Do not modify this file. This file is generated from the resiliencehubv2-2026-02-17.normal.json service model.
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
namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Metadata for a service function deleted event.
    /// </summary>
    public partial class ServiceFunctionDeletedMetadata
    {
        private string _serviceFunctionId;
        private string _serviceFunctionName;

        /// <summary>
        /// Gets and sets the property ServiceFunctionId. 
        /// <para>
        /// The identifier of the deleted service function.
        /// </para>
        /// </summary>
        public string ServiceFunctionId
        {
            get { return this._serviceFunctionId; }
            set { this._serviceFunctionId = value; }
        }

        // Check to see if ServiceFunctionId property is set
        internal bool IsSetServiceFunctionId()
        {
            return this._serviceFunctionId != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceFunctionName. 
        /// <para>
        /// The name of the deleted service function.
        /// </para>
        /// </summary>
        public string ServiceFunctionName
        {
            get { return this._serviceFunctionName; }
            set { this._serviceFunctionName = value; }
        }

        // Check to see if ServiceFunctionName property is set
        internal bool IsSetServiceFunctionName()
        {
            return this._serviceFunctionName != null;
        }

    }
}