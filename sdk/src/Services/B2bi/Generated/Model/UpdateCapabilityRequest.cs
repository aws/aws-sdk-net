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
 * Do not modify this file. This file is generated from the b2bi-2022-06-23.normal.json service model.
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
namespace Amazon.B2bi.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCapability operation.
    /// Updates some of the parameters for a capability, based on the specified parameters.
    /// A trading capability contains the information required to transform incoming EDI documents
    /// into JSON or XML outputs.
    /// </summary>
    public partial class UpdateCapabilityRequest : AmazonB2biRequest
    {
        private string _capabilityId;
        private CapabilityConfiguration _configuration;
        private List<S3Location> _instructionsDocuments = AWSConfigs.InitializeCollections ? new List<S3Location>() : null;
        private string _name;

        /// <summary>
        /// Gets and sets the property CapabilityId. 
        /// <para>
        /// Specifies a system-assigned unique identifier for the capability.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string CapabilityId
        {
            get { return this._capabilityId; }
            set { this._capabilityId = value; }
        }

        // Check to see if CapabilityId property is set
        internal bool IsSetCapabilityId()
        {
            return this._capabilityId != null;
        }

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// Specifies a structure that contains the details for a capability.
        /// </para>
        /// </summary>
        public CapabilityConfiguration Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null;
        }

        /// <summary>
        /// Gets and sets the property InstructionsDocuments. 
        /// <para>
        /// Specifies one or more locations in Amazon S3, each specifying an EDI document that
        /// can be used with this capability. Each item contains the name of the bucket and the
        /// key, to identify the document's location.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<S3Location> InstructionsDocuments
        {
            get { return this._instructionsDocuments; }
            set { this._instructionsDocuments = value; }
        }

        // Check to see if InstructionsDocuments property is set
        internal bool IsSetInstructionsDocuments()
        {
            return this._instructionsDocuments != null && (this._instructionsDocuments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies a new name for the capability, to replace the existing name.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=254)]
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