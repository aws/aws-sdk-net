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
    /// A structure containing an error related to a <c>TagResource</c> or <c>UnTagResource</c>
    /// operation.
    /// </summary>
    public partial class LFTagError
    {
        private ErrorDetail _error;
        private LFTagPair _lfTag;

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// An error that occurred with the attachment or detachment of the LF-tag.
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
        /// Gets and sets the property LFTag. 
        /// <para>
        /// The key-name of the LF-tag.
        /// </para>
        /// </summary>
        public LFTagPair LFTag
        {
            get { return this._lfTag; }
            set { this._lfTag = value; }
        }

        // Check to see if LFTag property is set
        internal bool IsSetLFTag()
        {
            return this._lfTag != null;
        }

    }
}