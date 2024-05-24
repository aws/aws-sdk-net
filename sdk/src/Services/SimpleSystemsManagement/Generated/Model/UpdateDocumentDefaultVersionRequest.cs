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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateDocumentDefaultVersion operation.
    /// Set the default version of a document. 
    /// 
    ///  <note> 
    /// <para>
    /// If you change a document version for a State Manager association, Systems Manager
    /// immediately runs the association unless you previously specifed the <c>apply-only-at-cron-interval</c>
    /// parameter.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateDocumentDefaultVersionRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _documentVersion;
        private string _name;

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The version of a custom document that you want to set as the default version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DocumentVersion
        {
            get { return this._documentVersion; }
            set { this._documentVersion = value; }
        }

        // Check to see if DocumentVersion property is set
        internal bool IsSetDocumentVersion()
        {
            return this._documentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of a custom document that you want to set as the default version.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}