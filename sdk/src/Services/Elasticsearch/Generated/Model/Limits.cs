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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Limits for given InstanceType and for each of it's role. <br/> Limits contains following
    /// <code> <a>StorageTypes,</a> </code> <code> <a>InstanceLimits</a> </code> and <code>
    /// <a>AdditionalLimits</a> </code>
    /// </summary>
    public partial class Limits
    {
        private List<AdditionalLimit> _additionalLimits = new List<AdditionalLimit>();
        private InstanceLimits _instanceLimits;
        private List<StorageType> _storageTypes = new List<StorageType>();

        /// <summary>
        /// Gets and sets the property AdditionalLimits. 
        /// <para>
        ///  List of additional limits that are specific to a given InstanceType and for each
        /// of it's <code> <a>InstanceRole</a> </code> . 
        /// </para>
        /// </summary>
        public List<AdditionalLimit> AdditionalLimits
        {
            get { return this._additionalLimits; }
            set { this._additionalLimits = value; }
        }

        // Check to see if AdditionalLimits property is set
        internal bool IsSetAdditionalLimits()
        {
            return this._additionalLimits != null && this._additionalLimits.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InstanceLimits.
        /// </summary>
        public InstanceLimits InstanceLimits
        {
            get { return this._instanceLimits; }
            set { this._instanceLimits = value; }
        }

        // Check to see if InstanceLimits property is set
        internal bool IsSetInstanceLimits()
        {
            return this._instanceLimits != null;
        }

        /// <summary>
        /// Gets and sets the property StorageTypes. 
        /// <para>
        /// StorageType represents the list of storage related types and attributes that are available
        /// for given InstanceType. 
        /// </para>
        /// </summary>
        public List<StorageType> StorageTypes
        {
            get { return this._storageTypes; }
            set { this._storageTypes = value; }
        }

        // Check to see if StorageTypes property is set
        internal bool IsSetStorageTypes()
        {
            return this._storageTypes != null && this._storageTypes.Count > 0; 
        }

    }
}