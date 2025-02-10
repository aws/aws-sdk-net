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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the PurchaseCapacityBlockExtension operation.
    /// </summary>
    public partial class PurchaseCapacityBlockExtensionResponse : AmazonWebServiceResponse
    {
        private List<CapacityBlockExtension> _capacityBlockExtensions = AWSConfigs.InitializeCollections ? new List<CapacityBlockExtension>() : null;

        /// <summary>
        /// Gets and sets the property CapacityBlockExtensions. 
        /// <para>
        /// The purchased Capacity Block extensions. 
        /// </para>
        /// </summary>
        public List<CapacityBlockExtension> CapacityBlockExtensions
        {
            get { return this._capacityBlockExtensions; }
            set { this._capacityBlockExtensions = value; }
        }

        // Check to see if CapacityBlockExtensions property is set
        internal bool IsSetCapacityBlockExtensions()
        {
            return this._capacityBlockExtensions != null && (this._capacityBlockExtensions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}