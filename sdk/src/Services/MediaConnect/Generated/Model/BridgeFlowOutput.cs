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
    /// The output of the bridge. A flow output is delivered to the Amazon Web Services cloud.
    /// </summary>
    public partial class BridgeFlowOutput
    {
        private string _flowArn;
        private string _flowSourceArn;
        private string _name;

        /// <summary>
        /// Gets and sets the property FlowArn. 
        /// <para>
        ///  The Amazon Resource Number (ARN) of the cloud flow.
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
        /// Gets and sets the property FlowSourceArn. 
        /// <para>
        ///  The Amazon Resource Number (ARN) of the flow source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FlowSourceArn
        {
            get { return this._flowSourceArn; }
            set { this._flowSourceArn = value; }
        }

        // Check to see if FlowSourceArn property is set
        internal bool IsSetFlowSourceArn()
        {
            return this._flowSourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the bridge's output.
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

    }
}