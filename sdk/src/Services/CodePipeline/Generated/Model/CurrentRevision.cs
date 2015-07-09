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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Represents information about a current revision.
    /// </summary>
    public partial class CurrentRevision
    {
        private string _changeIdentifier;
        private string _revision;

        /// <summary>
        /// Gets and sets the property ChangeIdentifier. 
        /// <para>
        /// The change identifier for the current revision.
        /// </para>
        /// </summary>
        public string ChangeIdentifier
        {
            get { return this._changeIdentifier; }
            set { this._changeIdentifier = value; }
        }

        // Check to see if ChangeIdentifier property is set
        internal bool IsSetChangeIdentifier()
        {
            return this._changeIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision ID of the current version of an artifact.
        /// </para>
        /// </summary>
        public string Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision != null;
        }

    }
}