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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// A single result from a content retrieval operation.
    /// </summary>
    public partial class RetrieveResult
    {
        private string _associationId;
        private string _contentText;
        private ReferenceType _referenceType;
        private string _sourceId;

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// The identifier of the assistant association for the retrieved result.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AssociationId
        {
            get { return this._associationId; }
            set { this._associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this._associationId != null;
        }

        /// <summary>
        /// Gets and sets the property ContentText. 
        /// <para>
        /// The text content of the retrieved result.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string ContentText
        {
            get { return this._contentText; }
            set { this._contentText = value; }
        }

        // Check to see if ContentText property is set
        internal bool IsSetContentText()
        {
            return this._contentText != null;
        }

        /// <summary>
        /// Gets and sets the property ReferenceType. 
        /// <para>
        /// A type to define the KB origin of a retrieved content.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReferenceType ReferenceType
        {
            get { return this._referenceType; }
            set { this._referenceType = value; }
        }

        // Check to see if ReferenceType property is set
        internal bool IsSetReferenceType()
        {
            return this._referenceType != null;
        }

        /// <summary>
        /// Gets and sets the property SourceId. 
        /// <para>
        /// The URL, URI, or ID of the retrieved content when available, or a UUID when unavailable.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string SourceId
        {
            get { return this._sourceId; }
            set { this._sourceId = value; }
        }

        // Check to see if SourceId property is set
        internal bool IsSetSourceId()
        {
            return this._sourceId != null;
        }

    }
}