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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
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
namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// A list of failures when performing a batch grant or batch revoke operation.
    /// </summary>
    public partial class BatchPermissionsFailureEntry
    {
        private ErrorDetail _error;
        private BatchPermissionsRequestEntry _requestEntry;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// An error message that applies to the failure of the entry.
        /// </para>
        /// </summary>
        public ErrorDetail Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property RequestEntry. 
        /// <para>
        /// An identifier for an entry of the batch request.
        /// </para>
        /// </summary>
        public BatchPermissionsRequestEntry RequestEntry
        {
            get { return this._requestEntry; }
            set { this._requestEntry = value; }
        }

        // Check to see if RequestEntry property is set
        internal bool IsSetRequestEntry()
        {
            return this._requestEntry != null;
        }

    }
}