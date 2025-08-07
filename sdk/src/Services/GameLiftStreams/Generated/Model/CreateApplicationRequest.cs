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
    /// Container for the parameters to the CreateApplication operation.
    /// Creates an application resource in Amazon GameLift Streams, which specifies the application
    /// content you want to stream, such as a game build or other software, and configures
    /// the settings to run it.
    /// 
    ///  
    /// <para>
    ///  Before you create an application, upload your application content files to an Amazon
    /// Simple Storage Service (Amazon S3) bucket. For more information, see <b>Getting Started</b>
    /// in the Amazon GameLift Streams Developer Guide. 
    /// </para>
    ///  <important> 
    /// <para>
    ///  Make sure that your files in the Amazon S3 bucket are the correct version you want
    /// to use. If you change the files at a later time, you will need to create a new Amazon
    /// GameLift Streams application. 
    /// </para>
    ///  </important> 
    /// <para>
    ///  If the request is successful, Amazon GameLift Streams begins to create an application
    /// and sets the status to <c>INITIALIZED</c>. When an application reaches <c>READY</c>
    /// status, you can use the application to set up stream groups and start streams. To
    /// track application status, call <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_GetApplication.html">GetApplication</a>.
    /// 
    /// </para>
    /// </summary>
    public partial class CreateApplicationRequest : AmazonGameLiftStreamsRequest
    {
        private string _applicationLogOutputUri;
        private List<string> _applicationLogPaths = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _applicationSourceUri;
        private string _clientToken;
        private string _description;
        private string _executablePath;
        private RuntimeEnvironment _runtimeEnvironment;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

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
        /// Gets and sets the property ApplicationSourceUri. 
        /// <para>
        /// The location of the content that you want to stream. Enter an Amazon S3 URI to a bucket
        /// that contains your game or other application. The location can have a multi-level
        /// prefix structure, but it must include all the files needed to run the content. Amazon
        /// GameLift Streams copies everything under the specified location.
        /// </para>
        ///  
        /// <para>
        /// This value is immutable. To designate a different content location, create a new application.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Amazon S3 bucket and the Amazon GameLift Streams application must be in the same
        /// Amazon Web Services Region.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ApplicationSourceUri
        {
            get { return this._applicationSourceUri; }
            set { this._applicationSourceUri = value; }
        }

        // Check to see if ApplicationSourceUri property is set
        internal bool IsSetApplicationSourceUri()
        {
            return this._applicationSourceUri != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  A unique identifier that represents a client request. The request is idempotent,
        /// which ensures that an API request completes only once. When users send a request,
        /// Amazon GameLift Streams automatically populates this field. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=128)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable label for the application. You can update this value later.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=80)]
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
        /// Gets and sets the property ExecutablePath. 
        /// <para>
        /// The path and file name of the executable file that launches the content for streaming.
        /// Enter a path value that is relative to the location set in <c>ApplicationSourceUri</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ExecutablePath
        {
            get { return this._executablePath; }
            set { this._executablePath = value; }
        }

        // Check to see if ExecutablePath property is set
        internal bool IsSetExecutablePath()
        {
            return this._executablePath != null;
        }

        /// <summary>
        /// Gets and sets the property RuntimeEnvironment. 
        /// <para>
        /// Configuration settings that identify the operating system for an application resource.
        /// This can also include a compatibility layer and other drivers.
        /// </para>
        ///  
        /// <para>
        /// A runtime environment can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  For Linux applications 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Ubuntu 22.04 LTS (<c>Type=UBUNTU, Version=22_04_LTS</c>) 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  For Windows applications 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Microsoft Windows Server 2022 Base (<c>Type=WINDOWS, Version=2022</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Proton 9.0-2 (<c>Type=PROTON, Version=20250516</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Proton 8.0-5 (<c>Type=PROTON, Version=20241007</c>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Proton 8.0-2c (<c>Type=PROTON, Version=20230704</c>)
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuntimeEnvironment RuntimeEnvironment
        {
            get { return this._runtimeEnvironment; }
            set { this._runtimeEnvironment = value; }
        }

        // Check to see if RuntimeEnvironment property is set
        internal bool IsSetRuntimeEnvironment()
        {
            return this._runtimeEnvironment != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of labels to assign to the new application resource. Tags are developer-defined
        /// key-value pairs. Tagging Amazon Web Services resources is useful for resource management,
        /// access management and cost allocation. See <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">
        /// Tagging Amazon Web Services Resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// You can use <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_TagResource.html">TagResource</a>
        /// to add tags, <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_UntagResource.html">UntagResource</a>
        /// to remove tags, and <a href="https://docs.aws.amazon.com/gameliftstreams/latest/apireference/API_ListTagsForResource.html">ListTagsForResource</a>
        /// to view tags on existing resources.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}