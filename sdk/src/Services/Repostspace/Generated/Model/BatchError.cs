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
 * Do not modify this file. This file is generated from the repostspace-2022-05-13.normal.json service model.
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
namespace Amazon.Repostspace.Model
{
    /// <summary>
    /// An error that occurred during a batch operation.
    /// </summary>
    public partial class BatchError
    {
        private string _accessorId;
        private int? _error;
        private string _message;

        /// <summary>
        /// Gets and sets the property AccessorId. 
        /// <para>
        /// The accessor identifier that's related to the error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AccessorId
        {
            get { return this._accessorId; }
            set { this._accessorId = value; }
        }

        // Check to see if AccessorId property is set
        internal bool IsSetAccessorId()
        {
            return this._accessorId != null;
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The error code.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Description of the error.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

    }
}