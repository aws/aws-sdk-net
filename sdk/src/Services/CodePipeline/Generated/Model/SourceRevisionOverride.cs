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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// A list that allows you to specify, or override, the source revision for a pipeline
    /// execution that's being started. A source revision is the version with all the changes
    /// to your application code, or source artifact, for the pipeline execution.
    /// 
    ///  <note> 
    /// <para>
    /// For the <c>S3_OBJECT_VERSION_ID</c> and <c>S3_OBJECT_KEY</c> types of source revisions,
    /// either of the types can be used independently, or they can be used together to override
    /// the source with a specific ObjectKey and VersionID.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SourceRevisionOverride
    {
        private string _actionName;
        private SourceRevisionType _revisionType;
        private string _revisionValue;

        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        /// The name of the action where the override will be applied.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property RevisionType. 
        /// <para>
        /// The type of source revision, based on the source provider. For example, the revision
        /// type for the CodeCommit action provider is the commit ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SourceRevisionType RevisionType
        {
            get { return this._revisionType; }
            set { this._revisionType = value; }
        }

        // Check to see if RevisionType property is set
        internal bool IsSetRevisionType()
        {
            return this._revisionType != null;
        }

        /// <summary>
        /// Gets and sets the property RevisionValue. 
        /// <para>
        /// The source revision, or version of your source artifact, with the changes that you
        /// want to run in the pipeline execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1500)]
        public string RevisionValue
        {
            get { return this._revisionValue; }
            set { this._revisionValue = value; }
        }

        // Check to see if RevisionValue property is set
        internal bool IsSetRevisionValue()
        {
            return this._revisionValue != null;
        }

    }
}