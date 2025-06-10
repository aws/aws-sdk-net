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
    /// Container for the parameters to the DeleteApplication operation.
    /// Permanently deletes an Amazon GameLift Streams application resource. This also deletes
    /// the application content files stored with Amazon GameLift Streams. However, this does
    /// not delete the original files that you uploaded to your Amazon S3 bucket; you can
    /// delete these any time after Amazon GameLift Streams creates an application, which
    /// is the only time Amazon GameLift Streams accesses your Amazon S3 bucket.
    /// 
    ///  
    /// <para>
    ///  You can only delete an application that meets the following conditions: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The application is in <c>READY</c> or <c>ERROR</c> status. You cannot delete an application
    /// that's in <c>PROCESSING</c> or <c>INITIALIZED</c> status.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The application is not the default application of any stream groups. You must first
    /// delete the stream group by using <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_DeleteStreamGroup.html">DeleteStreamGroup</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The application is not linked to any stream groups. You must first unlink the stream
    /// group by using <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_DisassociateApplications.html">DisassociateApplications</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  An application is not streaming in any ongoing stream session. You must wait until
    /// the client ends the stream session or call <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_TerminateStreamSession.html">TerminateStreamSession</a>
    /// to end the stream. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If any active stream groups exist for this application, this request returns a <c>ValidationException</c>.
    /// 
    /// </para>
    /// </summary>
    public partial class DeleteApplicationRequest : AmazonGameLiftStreamsRequest
    {
        private string _identifier;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// An <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference-arns.html">Amazon
        /// Resource Name (ARN)</a> or ID that uniquely identifies the application resource. Example
        /// ARN: <c>arn:aws:gameliftstreams:us-west-2:111122223333:application/a-9ZY8X7Wv6</c>.
        /// Example ID: <c>a-9ZY8X7Wv6</c>. 
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