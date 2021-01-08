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

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Information about file modes in a merge or pull request.
    /// </summary>
    public partial class FileModes
    {
        private FileModeTypeEnum _base;
        private FileModeTypeEnum _destination;
        private FileModeTypeEnum _source;

        /// <summary>
        /// Gets and sets the property Base. 
        /// <para>
        /// The file mode of a file in the base of a merge or pull request.
        /// </para>
        /// </summary>
        public FileModeTypeEnum Base
        {
            get { return this._base; }
            set { this._base = value; }
        }

        // Check to see if Base property is set
        internal bool IsSetBase()
        {
            return this._base != null;
        }

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The file mode of a file in the destination of a merge or pull request.
        /// </para>
        /// </summary>
        public FileModeTypeEnum Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The file mode of a file in the source of a merge or pull request.
        /// </para>
        /// </summary>
        public FileModeTypeEnum Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}