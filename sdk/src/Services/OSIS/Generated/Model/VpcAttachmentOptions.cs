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
 * Do not modify this file. This file is generated from the osis-2022-01-01.normal.json service model.
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
namespace Amazon.OSIS.Model
{
    /// <summary>
    /// Options for attaching a VPC to pipeline.
    /// </summary>
    public partial class VpcAttachmentOptions
    {
        private bool? _attachToVpc;
        private string _cidrBlock;

        /// <summary>
        /// Gets and sets the property AttachToVpc. 
        /// <para>
        /// Whether a VPC is attached to the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? AttachToVpc
        {
            get { return this._attachToVpc; }
            set { this._attachToVpc = value; }
        }

        // Check to see if AttachToVpc property is set
        internal bool IsSetAttachToVpc()
        {
            return this._attachToVpc.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CidrBlock. 
        /// <para>
        /// The CIDR block to be reserved for OpenSearch Ingestion to create elastic network interfaces
        /// (ENIs).
        /// </para>
        /// </summary>
        public string CidrBlock
        {
            get { return this._cidrBlock; }
            set { this._cidrBlock = value; }
        }

        // Check to see if CidrBlock property is set
        internal bool IsSetCidrBlock()
        {
            return this._cidrBlock != null;
        }

    }
}