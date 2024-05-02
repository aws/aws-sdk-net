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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
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
namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Returns information about a set of differences for a commit specifier.
    /// </summary>
    public partial class Difference
    {
        private BlobMetadata _afterBlob;
        private BlobMetadata _beforeBlob;
        private ChangeTypeEnum _changeType;

        /// <summary>
        /// Gets and sets the property AfterBlob. 
        /// <para>
        /// Information about an <c>afterBlob</c> data type object, including the ID, the file
        /// mode permission code, and the path.
        /// </para>
        /// </summary>
        public BlobMetadata AfterBlob
        {
            get { return this._afterBlob; }
            set { this._afterBlob = value; }
        }

        // Check to see if AfterBlob property is set
        internal bool IsSetAfterBlob()
        {
            return this._afterBlob != null;
        }

        /// <summary>
        /// Gets and sets the property BeforeBlob. 
        /// <para>
        /// Information about a <c>beforeBlob</c> data type object, including the ID, the file
        /// mode permission code, and the path.
        /// </para>
        /// </summary>
        public BlobMetadata BeforeBlob
        {
            get { return this._beforeBlob; }
            set { this._beforeBlob = value; }
        }

        // Check to see if BeforeBlob property is set
        internal bool IsSetBeforeBlob()
        {
            return this._beforeBlob != null;
        }

        /// <summary>
        /// Gets and sets the property ChangeType. 
        /// <para>
        /// Whether the change type of the difference is an addition (A), deletion (D), or modification
        /// (M).
        /// </para>
        /// </summary>
        public ChangeTypeEnum ChangeType
        {
            get { return this._changeType; }
            set { this._changeType = value; }
        }

        // Check to see if ChangeType property is set
        internal bool IsSetChangeType()
        {
            return this._changeType != null;
        }

    }
}