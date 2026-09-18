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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// The description of the worker configuration revision.
    /// </summary>
    public partial class WorkerConfigurationRevisionDescription
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the worker configuration was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the worker configuration revision.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property PropertiesFileContent. 
        /// <para>
        /// Base64 encoded contents of the connect-distributed.properties file.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string PropertiesFileContent { get; set; }

        /// <summary>
        /// Checks to see if the PropertiesFileContent property is set.
        /// </summary>
        internal bool IsSetPropertiesFileContent() => this.PropertiesFileContent != null;

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The description of a revision of the worker configuration.
        /// </para>
        /// </summary>
        public long? Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision.HasValue;
    }
}
