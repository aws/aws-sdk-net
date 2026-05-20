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
    /// Container for the parameters to the StartNotebookImport operation.
    /// Starts a notebook import in Amazon SageMaker Unified Studio. This operation imports
    /// a notebook from an Amazon Simple Storage Service location into a project.
    /// </summary>
    public partial class StartNotebookImportRequest : AmazonDataZoneRequest
    {
        private string _clientToken;
        private string _description;
        private string _domainIdentifier;
        private string _name;
        private string _owningProjectIdentifier;
        private SourceLocation _sourceLocation;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency of the request. This field
        /// is automatically populated if not provided.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the imported notebook.
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
        /// The identifier of the Amazon SageMaker Unified Studio domain in which to import the
        /// notebook.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the imported notebook. The name must be between 1 and 256 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=256)]
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
        /// The identifier of the project that will own the imported notebook.
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
        /// Gets and sets the property SourceLocation. 
        /// <para>
        /// The source location of the notebook to import. This specifies the Amazon Simple Storage
        /// Service URI of the notebook file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SourceLocation SourceLocation
        {
            get { return this._sourceLocation; }
            set { this._sourceLocation = value; }
        }

        // Check to see if SourceLocation property is set
        internal bool IsSetSourceLocation()
        {
            return this._sourceLocation != null;
        }

    }
}