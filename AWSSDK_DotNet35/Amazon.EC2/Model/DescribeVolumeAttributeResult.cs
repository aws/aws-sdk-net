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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DescribeVolumeAttributeResult : AmazonWebServiceResponse
    {
        private bool? _autoEnableIO;
        private List<ProductCode> _productCodes = new List<ProductCode>();
        private string _volumeId;

        /// <summary>
        /// Gets and sets the property AutoEnableIO. 
        /// <para>
        /// The state of <code>autoEnableIO</code> attribute.
        /// </para>
        /// </summary>
        public bool AutoEnableIO
        {
            get { return this._autoEnableIO.GetValueOrDefault(); }
            set { this._autoEnableIO = value; }
        }

        // Check to see if AutoEnableIO property is set
        internal bool IsSetAutoEnableIO()
        {
            return this._autoEnableIO.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProductCodes. 
        /// <para>
        /// A list of product codes.
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
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the volume.
        /// </para>
        /// </summary>
        public string VolumeId
        {
            get { return this._volumeId; }
            set { this._volumeId = value; }
        }

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this._volumeId != null;
        }

    }
}