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
    /// Container for the parameters to the UpdateDocumentMetadata operation.
    /// Updates information related to approval reviews for a specific version of a change
    /// template in Change Manager.
    /// </summary>
    public partial class UpdateDocumentMetadataRequest : AmazonSimpleSystemsManagementRequest
    {
        private DocumentReviews _documentReviews;
        private string _documentVersion;
        private string _name;

        /// <summary>
        /// Gets and sets the property DocumentReviews. 
        /// <para>
        /// The change template review details to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DocumentReviews DocumentReviews
        {
            get { return this._documentReviews; }
            set { this._documentReviews = value; }
        }

        // Check to see if DocumentReviews property is set
        internal bool IsSetDocumentReviews()
        {
            return this._documentReviews != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentVersion. 
        /// <para>
        /// The version of a change template in which to update approval metadata.
        /// </para>
        /// </summary>
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
        /// The name of the change template for which a version's metadata is to be updated.
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