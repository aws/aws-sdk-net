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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
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
namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// The source of the bridge. A flow source originates in MediaConnect as an existing
    /// cloud flow.
    /// </summary>
    public partial class BridgeFlowSource
    {
        private string _flowArn;
        private VpcInterfaceAttachment _flowVpcInterfaceAttachment;
        private string _name;
        private string _outputArn;

        /// <summary>
        /// Gets and sets the property FlowArn. 
        /// <para>
        ///  The ARN of the cloud flow used as a source of this bridge.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FlowArn
        {
            get { return this._flowArn; }
            set { this._flowArn = value; }
        }

        // Check to see if FlowArn property is set
        internal bool IsSetFlowArn()
        {
            return this._flowArn != null;
        }

        /// <summary>
        /// Gets and sets the property FlowVpcInterfaceAttachment. 
        /// <para>
        ///  The name of the VPC interface attachment to use for this source.
        /// </para>
        /// </summary>
        public VpcInterfaceAttachment FlowVpcInterfaceAttachment
        {
            get { return this._flowVpcInterfaceAttachment; }
            set { this._flowVpcInterfaceAttachment = value; }
        }

        // Check to see if FlowVpcInterfaceAttachment property is set
        internal bool IsSetFlowVpcInterfaceAttachment()
        {
            return this._flowVpcInterfaceAttachment != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the flow source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property OutputArn. 
        /// <para>
        ///  The Amazon Resource Number (ARN) of the output.
        /// </para>
        /// </summary>
        public string OutputArn
        {
            get { return this._outputArn; }
            set { this._outputArn = value; }
        }

        // Check to see if OutputArn property is set
        internal bool IsSetOutputArn()
        {
            return this._outputArn != null;
        }

    }
}