/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the codestar-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeStar.Model
{
    /// <summary>
    /// Location and destination information about the source code files provided with the
    /// project request. The source code is uploaded to the new project source repository
    /// after project creation.
    /// </summary>
    public partial class Code
    {
        private CodeDestination _destination;
        private CodeSource _source;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The repository to be created in AWS CodeStar. Valid values are AWS CodeCommit or GitHub.
        /// After AWS CodeStar provisions the new repository, the source code files provided with
        /// the project request are placed in the repository.
        /// </para>
        /// </summary>
        public CodeDestination Destination
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
        /// The location where the source code files provided with the project request are stored.
        /// AWS CodeStar retrieves the files during project creation.
        /// </para>
        /// </summary>
        public CodeSource Source
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