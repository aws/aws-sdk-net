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
    /// Specifies the details for the EDI (electronic data interchange) transformation.
    /// </summary>
    public partial class EdiConfiguration
    {
        private CapabilityDirection _capabilityDirection;
        private S3Location _inputLocation;
        private S3Location _outputLocation;
        private string _transformerId;
        private EdiType _type;

        /// <summary>
        /// Gets and sets the property CapabilityDirection. 
        /// <para>
        /// Specifies whether this is capability is for inbound or outbound transformations.
        /// </para>
        /// </summary>
        public CapabilityDirection CapabilityDirection
        {
            get { return this._capabilityDirection; }
            set { this._capabilityDirection = value; }
        }

        // Check to see if CapabilityDirection property is set
        internal bool IsSetCapabilityDirection()
        {
            return this._capabilityDirection != null;
        }

        /// <summary>
        /// Gets and sets the property InputLocation. 
        /// <para>
        /// Contains the Amazon S3 bucket and prefix for the location of the input file, which
        /// is contained in an <c>S3Location</c> object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3Location InputLocation
        {
            get { return this._inputLocation; }
            set { this._inputLocation = value; }
        }

        // Check to see if InputLocation property is set
        internal bool IsSetInputLocation()
        {
            return this._inputLocation != null;
        }

        /// <summary>
        /// Gets and sets the property OutputLocation. 
        /// <para>
        /// Contains the Amazon S3 bucket and prefix for the location of the output file, which
        /// is contained in an <c>S3Location</c> object.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public S3Location OutputLocation
        {
            get { return this._outputLocation; }
            set { this._outputLocation = value; }
        }

        // Check to see if OutputLocation property is set
        internal bool IsSetOutputLocation()
        {
            return this._outputLocation != null;
        }

        /// <summary>
        /// Gets and sets the property TransformerId. 
        /// <para>
        /// Returns the system-assigned unique identifier for the transformer.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string TransformerId
        {
            get { return this._transformerId; }
            set { this._transformerId = value; }
        }

        // Check to see if TransformerId property is set
        internal bool IsSetTransformerId()
        {
            return this._transformerId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Returns the type of the capability. Currently, only <c>edi</c> is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public EdiType Type
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