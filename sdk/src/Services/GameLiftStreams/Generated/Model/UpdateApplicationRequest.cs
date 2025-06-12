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
    /// Container for the parameters to the UpdateApplication operation.
    /// Updates the mutable configuration settings for a Amazon GameLift Streams application
    /// resource. You can change the <c>Description</c>, <c>ApplicationLogOutputUri</c>, and
    /// <c>ApplicationLogPaths</c>. 
    /// 
    ///  
    /// <para>
    /// To update application settings, specify the application ID and provide the new values.
    /// If the operation is successful, it returns the complete updated set of settings for
    /// the application.
    /// </para>
    /// </summary>
    public partial class UpdateApplicationRequest : AmazonGameLiftStreamsRequest
    {
        private string _applicationLogOutputUri;
        private List<string> _applicationLogPaths = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _description;
        private string _identifier;

        /// <summary>
        /// Gets and sets the property ApplicationLogOutputUri. 
        /// <para>
        /// An Amazon S3 URI to a bucket where you would like Amazon GameLift Streams to save
        /// application logs. Required if you specify one or more <c>ApplicationLogPaths</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The log bucket must have permissions that give Amazon GameLift Streams access to write
        /// the log files. For more information, see <a href="https://docs.aws.amazon.com/gameliftstreams/latest/developerguide/applications.html#application-bucket-permission-template">Application
        /// log bucket permission policy</a> in the <i>Amazon GameLift Streams Developer Guide</i>.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string ApplicationLogOutputUri
        {
            get { return this._applicationLogOutputUri; }
            set { this._applicationLogOutputUri = value; }
        }

        // Check to see if ApplicationLogOutputUri property is set
        internal bool IsSetApplicationLogOutputUri()
        {
            return this._applicationLogOutputUri != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationLogPaths. 
        /// <para>
        /// Locations of log files that your content generates during a stream session. Enter
        /// path values that are relative to the <c>ApplicationSourceUri</c> location. You can
        /// specify up to 10 log paths. Amazon GameLift Streams uploads designated log files to
        /// the Amazon S3 bucket that you specify in <c>ApplicationLogOutputUri</c> at the end
        /// of a stream session. To retrieve stored log files, call <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_GetStreamSession.html">GetStreamSession</a>
        /// and get the <c>LogFileLocationUri</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> ApplicationLogPaths
        {
            get { return this._applicationLogPaths; }
            set { this._applicationLogPaths = value; }
        }

        // Check to see if ApplicationLogPaths property is set
        internal bool IsSetApplicationLogPaths()
        {
            return this._applicationLogPaths != null && (this._applicationLogPaths.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable label for the application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=80)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

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