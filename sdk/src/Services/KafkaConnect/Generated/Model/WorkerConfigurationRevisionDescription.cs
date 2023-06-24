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
 * Do not modify this file. This file is generated from the kafkaconnect-2021-09-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// The description of the worker configuration revision.
    /// </summary>
    public partial class WorkerConfigurationRevisionDescription
    {
        private DateTime? _creationTime;
        private string _description;
        private string _propertiesFileContent;
        private long? _revision;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the worker configuration was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
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
        /// The description of the worker configuration revision.
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
        /// Gets and sets the property PropertiesFileContent. 
        /// <para>
        /// Base64 encoded contents of the connect-distributed.properties file.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string PropertiesFileContent
        {
            get { return this._propertiesFileContent; }
            set { this._propertiesFileContent = value; }
        }

        // Check to see if PropertiesFileContent property is set
        internal bool IsSetPropertiesFileContent()
        {
            return this._propertiesFileContent != null;
        }

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The description of a revision of the worker configuration.
        /// </para>
        /// </summary>
        public long Revision
        {
            get { return this._revision.GetValueOrDefault(); }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision.HasValue; 
        }

    }
}