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
 * Do not modify this file. This file is generated from the cleanrooms-2022-02-17.normal.json service model.
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
namespace Amazon.CleanRooms.Model
{
    /// <summary>
    /// Represents a single change within a collaboration change request, containing the change
    /// identifier and specification.
    /// </summary>
    public partial class Change
    {
        private ChangeSpecification _specification;
        private ChangeSpecificationType _specificationType;
        private List<string> _types = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Specification. 
        /// <para>
        /// The specification details for this change.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChangeSpecification Specification
        {
            get { return this._specification; }
            set { this._specification = value; }
        }

        // Check to see if Specification property is set
        internal bool IsSetSpecification()
        {
            return this._specification != null;
        }

        /// <summary>
        /// Gets and sets the property SpecificationType. 
        /// <para>
        /// The type of specification for this change.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ChangeSpecificationType SpecificationType
        {
            get { return this._specificationType; }
            set { this._specificationType = value; }
        }

        // Check to see if SpecificationType property is set
        internal bool IsSetSpecificationType()
        {
            return this._specificationType != null;
        }

        /// <summary>
        /// Gets and sets the property Types. 
        /// <para>
        /// The list of change types that were applied.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public List<string> Types
        {
            get { return this._types; }
            set { this._types = value; }
        }

        // Check to see if Types property is set
        internal bool IsSetTypes()
        {
            return this._types != null && (this._types.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}