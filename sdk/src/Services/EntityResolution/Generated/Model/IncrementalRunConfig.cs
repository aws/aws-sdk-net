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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// An object which defines an incremental run type and has only <c>incrementalRunType</c>
    /// as a field.
    /// </summary>
    public partial class IncrementalRunConfig
    {
        private IncrementalRunType _incrementalRunType;

        /// <summary>
        /// Gets and sets the property IncrementalRunType. 
        /// <para>
        /// The type of incremental run. It takes only one value: <c>IMMEDIATE</c>.
        /// </para>
        /// </summary>
        public IncrementalRunType IncrementalRunType
        {
            get { return this._incrementalRunType; }
            set { this._incrementalRunType = value; }
        }

        // Check to see if IncrementalRunType property is set
        internal bool IsSetIncrementalRunType()
        {
            return this._incrementalRunType != null;
        }

    }
}