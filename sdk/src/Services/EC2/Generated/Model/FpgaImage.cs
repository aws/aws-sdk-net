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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes an Amazon FPGA image (AFI).
    /// </summary>
    public partial class FpgaImage
    {
        private DateTime? _createTime;
        private bool? _dataRetentionSupport;
        private string _description;
        private string _fpgaImageGlobalId;
        private string _fpgaImageId;
        private List<string> _instanceTypes = new List<string>();
        private string _name;
        private string _ownerAlias;
        private string _ownerId;
        private PciId _pciId;
        private List<ProductCode> _productCodes = new List<ProductCode>();
        private bool? _public;
        private string _shellVersion;
        private FpgaImageState _state;
        private List<Tag> _tags = new List<Tag>();
        private DateTime? _updateTime;

        /// <summary>
        /// Gets and sets the property CreateTime. 
        /// <para>
        /// The date and time the AFI was created.
        /// </para>
        /// </summary>
        public DateTime CreateTime
        {
            get { return this._createTime.GetValueOrDefault(); }
            set { this._createTime = value; }
        }

        // Check to see if CreateTime property is set
        internal bool IsSetCreateTime()
        {
            return this._createTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataRetentionSupport. 
        /// <para>
        /// Indicates whether data retention support is enabled for the AFI.
        /// </para>
        /// </summary>
        public bool DataRetentionSupport
        {
            get { return this._dataRetentionSupport.GetValueOrDefault(); }
            set { this._dataRetentionSupport = value; }
        }

        // Check to see if DataRetentionSupport property is set
        internal bool IsSetDataRetentionSupport()
        {
            return this._dataRetentionSupport.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the AFI.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property FpgaImageGlobalId. 
        /// <para>
        /// The global FPGA image identifier (AGFI ID).
        /// </para>
        /// </summary>
        public string FpgaImageGlobalId
        {
            get { return this._fpgaImageGlobalId; }
            set { this._fpgaImageGlobalId = value; }
        }

        // Check to see if FpgaImageGlobalId property is set
        internal bool IsSetFpgaImageGlobalId()
        {
            return this._fpgaImageGlobalId != null;
        }

        /// <summary>
        /// Gets and sets the property FpgaImageId. 
        /// <para>
        /// The FPGA image identifier (AFI ID).
        /// </para>
        /// </summary>
        public string FpgaImageId
        {
            get { return this._fpgaImageId; }
            set { this._fpgaImageId = value; }
        }

        // Check to see if FpgaImageId property is set
        internal bool IsSetFpgaImageId()
        {
            return this._fpgaImageId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceTypes. 
        /// <para>
        /// The instance types supported by the AFI.
        /// </para>
        /// </summary>
        public List<string> InstanceTypes
        {
            get { return this._instanceTypes; }
            set { this._instanceTypes = value; }
        }

        // Check to see if InstanceTypes property is set
        internal bool IsSetInstanceTypes()
        {
            return this._instanceTypes != null && this._instanceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the AFI.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property OwnerAlias. 
        /// <para>
        /// The alias of the AFI owner. Possible values include <code>self</code>, <code>amazon</code>,
        /// and <code>aws-marketplace</code>.
        /// </para>
        /// </summary>
        public string OwnerAlias
        {
            get { return this._ownerAlias; }
            set { this._ownerAlias = value; }
        }

        // Check to see if OwnerAlias property is set
        internal bool IsSetOwnerAlias()
        {
            return this._ownerAlias != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the AFI.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property PciId. 
        /// <para>
        /// Information about the PCI bus.
        /// </para>
        /// </summary>
        public PciId PciId
        {
            get { return this._pciId; }
            set { this._pciId = value; }
        }

        // Check to see if PciId property is set
        internal bool IsSetPciId()
        {
            return this._pciId != null;
        }

        /// <summary>
        /// Gets and sets the property ProductCodes. 
        /// <para>
        /// The product codes for the AFI.
        /// </para>
        /// </summary>
        public List<ProductCode> ProductCodes
        {
            get { return this._productCodes; }
            set { this._productCodes = value; }
        }

        // Check to see if ProductCodes property is set
        internal bool IsSetProductCodes()
        {
            return this._productCodes != null && this._productCodes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Public. 
        /// <para>
        /// Indicates whether the AFI is public.
        /// </para>
        /// </summary>
        public bool Public
        {
            get { return this._public.GetValueOrDefault(); }
            set { this._public = value; }
        }

        // Check to see if Public property is set
        internal bool IsSetPublic()
        {
            return this._public.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ShellVersion. 
        /// <para>
        /// The version of the Amazon Web Services Shell that was used to create the bitstream.
        /// </para>
        /// </summary>
        public string ShellVersion
        {
            get { return this._shellVersion; }
            set { this._shellVersion = value; }
        }

        // Check to see if ShellVersion property is set
        internal bool IsSetShellVersion()
        {
            return this._shellVersion != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Information about the state of the AFI.
        /// </para>
        /// </summary>
        public FpgaImageState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the AFI.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UpdateTime. 
        /// <para>
        /// The time of the most recent update to the AFI.
        /// </para>
        /// </summary>
        public DateTime UpdateTime
        {
            get { return this._updateTime.GetValueOrDefault(); }
            set { this._updateTime = value; }
        }

        // Check to see if UpdateTime property is set
        internal bool IsSetUpdateTime()
        {
            return this._updateTime.HasValue; 
        }

    }
}