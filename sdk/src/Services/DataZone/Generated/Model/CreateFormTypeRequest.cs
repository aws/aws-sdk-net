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
    /// Container for the parameters to the CreateFormType operation.
    /// Creates a metadata form type.
    /// 
    ///  
    /// <para>
    /// Prerequisites:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The domain must exist and be in an <c>ENABLED</c> state. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The owning project must exist and be accessible.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The name must be unique within the domain.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For custom form types, to indicate that a field should be searchable, annotate it
    /// with <c>@amazon.datazone#searchable</c>. By default, searchable fields are indexed
    /// for semantic search, where related query terms will match the attribute value even
    /// if they are not stemmed or keyword matches. To indicate that a field should be indexed
    /// for lexical search (which disables semantic search but supports stemmed and partial
    /// matches), annotate it with <c>@amazon.datazone#searchable(modes:["LEXICAL"])</c>.
    /// To indicate that a field should be indexed for technical identifier search (for more
    /// information on technical identifier search, see: <a href="https://aws.amazon.com/blogs/big-data/streamline-data-discovery-with-precise-technical-identifier-search-in-amazon-sagemaker-unified-studio/">https://aws.amazon.com/blogs/big-data/streamline-data-discovery-with-precise-technical-identifier-search-in-amazon-sagemaker-unified-studio/</a>),
    /// annotate it with <c>@amazon.datazone#searchable(modes:["TECHNICAL"])</c>.
    /// </para>
    ///  
    /// <para>
    /// To denote that a field will store glossary term ids (which are filterable via the
    /// Search/SearchListings APIs), annotate it with <c>@amazon.datazone#glossaryterm("${GLOSSARY_ID}")</c>,
    /// where <c>${GLOSSARY_ID}</c> is the id of the glossary that the glossary terms stored
    /// in the field belong to. 
    /// </para>
    /// </summary>
    public partial class CreateFormTypeRequest : AmazonDataZoneRequest
    {
        private string _description;
        private string _domainIdentifier;
        private Model _model;
        private string _name;
        private string _owningProjectIdentifier;
        private FormTypeStatus _status;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of this Amazon DataZone metadata form type.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the Amazon DataZone domain in which this metadata form type is created.
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
        /// Gets and sets the property Model. 
        /// <para>
        /// The model of this Amazon DataZone metadata form type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public Model Model
        {
            get { return this._model; }
            set { this._model = value; }
        }

        // Check to see if Model property is set
        internal bool IsSetModel()
        {
            return this._model != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of this Amazon DataZone metadata form type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=128)]
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

        /// <summary>
        /// Gets and sets the property OwningProjectIdentifier. 
        /// <para>
        /// The ID of the Amazon DataZone project that owns this metadata form type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OwningProjectIdentifier
        {
            get { return this._owningProjectIdentifier; }
            set { this._owningProjectIdentifier = value; }
        }

        // Check to see if OwningProjectIdentifier property is set
        internal bool IsSetOwningProjectIdentifier()
        {
            return this._owningProjectIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of this Amazon DataZone metadata form type.
        /// </para>
        /// </summary>
        public FormTypeStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}