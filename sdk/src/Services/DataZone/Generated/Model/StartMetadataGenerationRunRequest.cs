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
    /// Container for the parameters to the StartMetadataGenerationRun operation.
    /// Starts the metadata generation run.
    /// 
    ///  
    /// <para>
    /// Prerequisites:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Asset must be created and belong to the specified domain and project. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Asset type must be supported for metadata generation (e.g., Amazon Web Services Glue
    /// table).
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Asset must have a structured schema with valid rows and columns.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Valid values for --type: BUSINESS_DESCRIPTIONS, BUSINESS_NAMES.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The user must have permission to run metadata generation in the domain/project.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class StartMetadataGenerationRunRequest : AmazonDataZoneRequest
    {
        private string _clientToken;
        private string _domainIdentifier;
        private string _owningProjectIdentifier;
        private MetadataGenerationRunTarget _target;
        private MetadataGenerationRunType _type;

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
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The ID of the Amazon DataZone domain where you want to start a metadata generation
        /// run.
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
        /// Gets and sets the property OwningProjectIdentifier. 
        /// <para>
        /// The ID of the project that owns the asset for which you want to start a metadata generation
        /// run.
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
        /// Gets and sets the property Target. 
        /// <para>
        /// The asset for which you want to start a metadata generation run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetadataGenerationRunTarget Target
        {
            get { return this._target; }
            set { this._target = value; }
        }

        // Check to see if Target property is set
        internal bool IsSetTarget()
        {
            return this._target != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the metadata generation run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetadataGenerationRunType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}