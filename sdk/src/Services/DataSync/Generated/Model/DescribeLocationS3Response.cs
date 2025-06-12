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
 * Do not modify this file. This file is generated from the datasync-2018-11-09.normal.json service model.
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
namespace Amazon.DataSync.Model
{
    /// <summary>
    /// DescribeLocationS3Response
    /// </summary>
    public partial class DescribeLocationS3Response : AmazonWebServiceResponse
    {
        private List<string> _agentArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _creationTime;
        private string _locationArn;
        private string _locationUri;
        private S3Config _s3Config;
        private S3StorageClass _s3StorageClass;

        /// <summary>
        /// Gets and sets the property AgentArns. 
        /// <para>
        /// The ARNs of the DataSync agents deployed on your Outpost when using working with Amazon
        /// S3 on Outposts.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/deploy-agents.html#outposts-agent">Deploy
        /// your DataSync agent on Outposts</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=4)]
        public List<string> AgentArns
        {
            get { return this._agentArns; }
            set { this._agentArns = value; }
        }

        // Check to see if AgentArns property is set
        internal bool IsSetAgentArns()
        {
            return this._agentArns != null && (this._agentArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the Amazon S3 location was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocationArn. 
        /// <para>
        /// The ARN of the Amazon S3 location.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string LocationArn
        {
            get { return this._locationArn; }
            set { this._locationArn = value; }
        }

        // Check to see if LocationArn property is set
        internal bool IsSetLocationArn()
        {
            return this._locationArn != null;
        }

        /// <summary>
        /// Gets and sets the property LocationUri. 
        /// <para>
        /// The URL of the Amazon S3 location that was described.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4360)]
        public string LocationUri
        {
            get { return this._locationUri; }
            set { this._locationUri = value; }
        }

        // Check to see if LocationUri property is set
        internal bool IsSetLocationUri()
        {
            return this._locationUri != null;
        }

        /// <summary>
        /// Gets and sets the property S3Config.
        /// </summary>
        public S3Config S3Config
        {
            get { return this._s3Config; }
            set { this._s3Config = value; }
        }

        // Check to see if S3Config property is set
        internal bool IsSetS3Config()
        {
            return this._s3Config != null;
        }

        /// <summary>
        /// Gets and sets the property S3StorageClass. 
        /// <para>
        /// When Amazon S3 is a destination location, this is the storage class that you chose
        /// for your objects.
        /// </para>
        ///  
        /// <para>
        /// Some storage classes have behaviors that can affect your Amazon S3 storage costs.
        /// For more information, see <a href="https://docs.aws.amazon.com/datasync/latest/userguide/create-s3-location.html#using-storage-classes">Storage
        /// class considerations with Amazon S3 transfers</a>.
        /// </para>
        /// </summary>
        public S3StorageClass S3StorageClass
        {
            get { return this._s3StorageClass; }
            set { this._s3StorageClass = value; }
        }

        // Check to see if S3StorageClass property is set
        internal bool IsSetS3StorageClass()
        {
            return this._s3StorageClass != null;
        }

    }
}