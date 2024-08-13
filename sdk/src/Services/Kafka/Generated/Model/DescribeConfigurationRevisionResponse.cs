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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// This is the response object from the DescribeConfigurationRevision operation.
    /// </summary>
    public partial class DescribeConfigurationRevisionResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _creationTime;
        private string _description;
        private long? _revision;
        private MemoryStream _serverProperties;

        /// <summary>
        /// Gets and sets the property Arn.             
        /// <para>
        /// The Amazon Resource Name (ARN) of the configuration.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime.             
        /// <para>
        /// The time when the configuration was created.
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
        /// Gets and sets the property Description.             
        /// <para>
        /// The description of the configuration.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Revision.             
        /// <para>
        /// The revision number.
        /// </para>
        /// </summary>
        public long? Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServerProperties.             
        /// <para>
        /// Contents of the <filename>server.properties</filename> file. When using the API, you
        /// must ensure that the contents of the file are base64 encoded.                When
        /// using the AWS Management Console, the SDK, or the AWS CLI, the contents of <filename>server.properties</filename>
        /// can be in plaintext.
        /// </para>
        /// </summary>
        public MemoryStream ServerProperties
        {
            get { return this._serverProperties; }
            set { this._serverProperties = value; }
        }

        // Check to see if ServerProperties property is set
        internal bool IsSetServerProperties()
        {
            return this._serverProperties != null;
        }

    }
}