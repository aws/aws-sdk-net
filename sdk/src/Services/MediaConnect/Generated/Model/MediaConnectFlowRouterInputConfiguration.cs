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
    /// Configuration settings for connecting a router input to a flow output.
    /// </summary>
    public partial class MediaConnectFlowRouterInputConfiguration
    {
        private string _flowArn;
        private string _flowOutputArn;
        private FlowTransitEncryption _sourceTransitDecryption;

        /// <summary>
        /// Gets and sets the property FlowArn. 
        /// <para>
        /// The ARN of the flow to connect to.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property FlowOutputArn. 
        /// <para>
        /// The ARN of the flow output to connect to this router input.
        /// </para>
        /// </summary>
        public string FlowOutputArn
        {
            get { return this._flowOutputArn; }
            set { this._flowOutputArn = value; }
        }

        // Check to see if FlowOutputArn property is set
        internal bool IsSetFlowOutputArn()
        {
            return this._flowOutputArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceTransitDecryption. 
        /// <para>
        /// The decryption configuration for the flow source when connected to this router input.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FlowTransitEncryption SourceTransitDecryption
        {
            get { return this._sourceTransitDecryption; }
            set { this._sourceTransitDecryption = value; }
        }

        // Check to see if SourceTransitDecryption property is set
        internal bool IsSetSourceTransitDecryption()
        {
            return this._sourceTransitDecryption != null;
        }

    }
}