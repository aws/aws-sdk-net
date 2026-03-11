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
 * Do not modify this file. This file is generated from the datazone-2018-05-10.normal.json service model.
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
namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the GetFormType operation.
    /// Gets a metadata form type in Amazon DataZone.
    /// 
    ///  
    /// <para>
    /// Form types define the structure and validation rules for collecting metadata about
    /// assets in Amazon DataZone. They act as templates that ensure consistent metadata capture
    /// across similar types of assets, while allowing for customization to meet specific
    /// organizational needs. Form types can include required fields, validation rules, and
    /// dependencies, helping maintain high-quality metadata that makes data assets more discoverable
    /// and usable.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The form type with the specified identifier must exist in the given domain. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The domain must be valid and active.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// User must have permission on the form type.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The form type should not be deleted or in an invalid state.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// One use case for this API is to determine whether a form field is indexed for search.
    /// 
    /// </para>
    ///  
    /// <para>
    /// A searchable field will be annotated with <c>@amazon.datazone#searchable</c>. By default,
    /// searchable fields are indexed for semantic search, where related query terms will
    /// match the attribute value even if they are not stemmed or keyword matches. If a field
    /// is indexed technical identifier search, it will be annotated with <c>@amazon.datazone#searchable(modes:["TECHNICAL"])</c>.
    /// If a field is indexed for lexical search (supports stemmed and prefix matches but
    /// not semantic matches), it will be annotated with <c>@amazon.datazone#searchable(modes:["LEXICAL"])</c>.
    /// </para>
    ///  
    /// <para>
    /// A field storing glossary term IDs (which is filterable) will be annotated with <c>@amazon.datazone#glossaryterm("${glossaryId}")</c>.
    /// 
    /// </para>
    /// </summary>
    public partial class GetFormTypeRequest : AmazonDataZoneRequest
    {
        private string _domainIdentifier;
        private string _formTypeIdentifier;
        private string _revision;

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the Amazon DataZone domain in which this metadata form type exists.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DomainIdentifier
        {
            get { return this._domainIdentifier; }
            set { this._domainIdentifier = value; }
        }

        // Check to see if DomainIdentifier property is set
        internal bool IsSetDomainIdentifier()
        {
            return this._domainIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property FormTypeIdentifier. 
        /// <para>
        /// The ID of the metadata form type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=385)]
        public string FormTypeIdentifier
        {
            get { return this._formTypeIdentifier; }
            set { this._formTypeIdentifier = value; }
        }

        // Check to see if FormTypeIdentifier property is set
        internal bool IsSetFormTypeIdentifier()
        {
            return this._formTypeIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision of this metadata form type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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