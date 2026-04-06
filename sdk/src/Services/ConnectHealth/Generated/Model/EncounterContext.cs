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
 * Do not modify this file. This file is generated from the connecthealth-2025-01-29.normal.json service model.
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
namespace Amazon.ConnectHealth.Model
{
    /// <summary>
    /// Context information about the clinical encounter
    /// </summary>
    public partial class EncounterContext
    {
        private string _unstructuredContext;

        /// <summary>
        /// Gets and sets the property UnstructuredContext. 
        /// <para>
        /// Unstructured context information in markdown format
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string UnstructuredContext
        {
            get { return this._unstructuredContext; }
            set { this._unstructuredContext = value; }
        }

        // Check to see if UnstructuredContext property is set
        internal bool IsSetUnstructuredContext()
        {
            return this._unstructuredContext != null;
        }

    }
}