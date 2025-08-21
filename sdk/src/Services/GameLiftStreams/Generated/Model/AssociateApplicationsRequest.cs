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
    /// Container for the parameters to the AssociateApplications operation.
    /// When you associate, or link, an application with a stream group, then Amazon GameLift
    /// Streams can launch the application using the stream group's allocated compute resources.
    /// The stream group must be in <c>ACTIVE</c> status. You can reverse this action by using
    /// <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_DisassociateApplications.html">DisassociateApplications</a>.
    /// 
    ///  
    /// <para>
    /// If a stream group does not already have a linked application, Amazon GameLift Streams
    /// will automatically assign the first application provided in <c>ApplicationIdentifiers</c>
    /// as the default.
    /// </para>
    /// </summary>
    public partial class AssociateApplicationsRequest : AmazonGameLiftStreamsRequest
    {
        private List<string> _applicationIdentifiers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _identifier;

        /// <summary>
        /// Gets and sets the property ApplicationIdentifiers. 
        /// <para>
        /// A set of applications to associate with the stream group.
        /// </para>
        ///  
        /// <para>
        /// This value is a set of either <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Names (ARN)</a> or IDs that uniquely identify application resources. Example
        /// ARN: <c>arn:aws:gameliftstreams:us-west-2:111122223333:application/a-9ZY8X7Wv6</c>.
        /// Example ID: <c>a-9ZY8X7Wv6</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
        /// A stream group to associate to the applications.
        /// </para>
        ///  
        /// <para>
        /// This value is an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> or ID that uniquely identifies the stream group resource.
        /// Example ARN: <c>arn:aws:gameliftstreams:us-west-2:111122223333:streamgroup/sg-1AB2C3De4</c>.
        /// Example ID: <c>sg-1AB2C3De4</c>. 
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