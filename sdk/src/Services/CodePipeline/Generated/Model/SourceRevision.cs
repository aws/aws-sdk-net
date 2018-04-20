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
    /// 
    /// </summary>
    public partial class SourceRevision
    {
        private string _actionName;
        private string _revisionId;
        private string _revisionSummary;
        private string _revisionUrl;

        /// <summary>
        /// Gets and sets the property ActionName.
        /// </summary>
        public string ActionName
        {
            get { return this._actionName; }
            set { this._actionName = value; }
        }

        // Check to see if ActionName property is set
        internal bool IsSetActionName()
        {
            return this._actionName != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionId.
        /// </summary>
        public string RevisionId
        {
            get { return this._revisionId; }
            set { this._revisionId = value; }
        }

        // Check to see if RevisionId property is set
        internal bool IsSetRevisionId()
        {
            return this._revisionId != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionSummary.
        /// </summary>
        public string RevisionSummary
        {
            get { return this._revisionSummary; }
            set { this._revisionSummary = value; }
        }

        // Check to see if RevisionSummary property is set
        internal bool IsSetRevisionSummary()
        {
            return this._revisionSummary != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionUrl.
        /// </summary>
        public string RevisionUrl
        {
            get { return this._revisionUrl; }
            set { this._revisionUrl = value; }
        }

        // Check to see if RevisionUrl property is set
        internal bool IsSetRevisionUrl()
        {
            return this._revisionUrl != null;
        }

    }
}