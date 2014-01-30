/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using Amazon.Runtime;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class DescribeVolumeAttributeResult : AmazonWebServiceResponse
    {
        
        private string volumeId;
        private bool? autoEnableIO;
        private List<ProductCode> productCodes = new List<ProductCode>();


        /// <summary>
        /// The ID of the volume.
        ///  
        /// </summary>
        public string VolumeId
        {
            get { return this.volumeId; }
            set { this.volumeId = value; }
        }

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this.volumeId != null;
        }

        /// <summary>
        /// The state of <c>autoEnableIO</c> attribute.
        ///  
        /// </summary>
        public bool AutoEnableIO
        {
            get { return this.autoEnableIO ?? default(bool); }
            set { this.autoEnableIO = value; }
        }

        // Check to see if AutoEnableIO property is set
        internal bool IsSetAutoEnableIO()
        {
            return this.autoEnableIO.HasValue;
        }

        /// <summary>
        /// A list of product codes.
        ///  
        /// </summary>
        public List<ProductCode> ProductCodes
        {
            get { return this.productCodes; }
            set { this.productCodes = value; }
        }

        // Check to see if ProductCodes property is set
        internal bool IsSetProductCodes()
        {
            return this.productCodes.Count > 0;
        }
    }
}
