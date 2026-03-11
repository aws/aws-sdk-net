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
 * Do not modify this file. This file is generated from the cloudfront-2020-05-31.normal.json service model.
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
namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A connection function summary.
    /// </summary>
    public partial class ConnectionFunctionSummary
    {
        private string _connectionFunctionArn;
        private FunctionConfig _connectionFunctionConfig;
        private DateTime? _createdTime;
        private string _id;
        private DateTime? _lastModifiedTime;
        private string _name;
        private FunctionStage _stage;
        private string _status;

        /// <summary>
        /// Gets and sets the property ConnectionFunctionArn. 
        /// <para>
        /// The connection function Amazon Resource Name (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ConnectionFunctionArn
        {
            get { return this._connectionFunctionArn; }
            set { this._connectionFunctionArn = value; }
        }

        // Check to see if ConnectionFunctionArn property is set
        internal bool IsSetConnectionFunctionArn()
        {
            return this._connectionFunctionArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionFunctionConfig.
        /// </summary>
        [AWSProperty(Required=true)]
        public FunctionConfig ConnectionFunctionConfig
        {
            get { return this._connectionFunctionConfig; }
            set { this._connectionFunctionConfig = value; }
        }

        // Check to see if ConnectionFunctionConfig property is set
        internal bool IsSetConnectionFunctionConfig()
        {
            return this._connectionFunctionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The connection function created time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The connection function ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The connection function last modified time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The connection function name.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property Stage. 
        /// <para>
        /// The connection function stage.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FunctionStage Stage
        {
            get { return this._stage; }
            set { this._stage = value; }
        }

        // Check to see if Stage property is set
        internal bool IsSetStage()
        {
            return this._stage != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The connection function status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}