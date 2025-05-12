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
 * Do not modify this file. This file is generated from the gameliftstreams-2018-05-10.normal.json service model.
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
namespace Amazon.GameLiftStreams.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateApplications operation.
    /// When you disassociate, or unlink, an application from a stream group, you can no
    /// longer stream this application by using that stream group's allocated compute resources.
    /// Any streams in process will continue until they terminate, which helps avoid interrupting
    /// an end-user's stream. Amazon GameLift Streams will not initiate new streams using
    /// this stream group. The disassociate action does not affect the stream capacity of
    /// a stream group. 
    /// 
    ///  
    /// <para>
    ///  You can only disassociate an application if it's not a default application of the
    /// stream group. Check <c>DefaultApplicationIdentifier</c> by calling <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_GetStreamGroup.html">GetStreamGroup</a>.
    /// 
    /// </para>
    /// </summary>
    public partial class DisassociateApplicationsRequest : AmazonGameLiftStreamsRequest
    {
        private List<string> _applicationIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _identifier;

        /// <summary>
        /// Gets and sets the property ApplicationIdentifiers. 
        /// <para>
        /// A set of applications that you want to disassociate from the stream group.
        /// </para>
        ///  
        /// <para>
        /// This value is a set of either <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Names (ARN)</a> or IDs that uniquely identify application resources. Format
        /// example: ARN-<c>arn:aws:gameliftstreams:us-west-2:123456789012:application/a-9ZY8X7Wv6</c>
        /// or ID-<c>a-9ZY8X7Wv6</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<string> ApplicationIdentifiers
        {
            get { return this._applicationIdentifiers; }
            set { this._applicationIdentifiers = value; }
        }

        // Check to see if ApplicationIdentifiers property is set
        internal bool IsSetApplicationIdentifiers()
        {
            return this._applicationIdentifiers != null && (this._applicationIdentifiers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// A stream group to disassociate these applications from.
        /// </para>
        ///  
        /// <para>
        /// This value is an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> or ID that uniquely identifies the stream group resource.
        /// Format example: ARN-<c>arn:aws:gameliftstreams:us-west-2:123456789012:streamgroup/sg-1AB2C3De4</c>
        /// or ID-<c>sg-1AB2C3De4</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

    }
}