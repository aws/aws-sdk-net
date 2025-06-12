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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
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
namespace Amazon.ECS.Model
{
    /// <summary>
    /// The FireLens configuration for the container. This is used to specify and configure
    /// a log router for container logs. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using_firelens.html">Custom
    /// log routing</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </summary>
    public partial class FirelensConfiguration
    {
        private Dictionary<string, string> _options = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private FirelensConfigurationType _type;

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The options to use when configuring the log router. This field is optional and can
        /// be used to specify a custom configuration file or to add additional metadata, such
        /// as the task, task definition, cluster, and container instance details to the log event.
        /// If specified, the syntax to use is <c>"options":{"enable-ecs-log-metadata":"true|false","config-file-type:"s3|file","config-file-value":"arn:aws:s3:::mybucket/fluent.conf|filepath"}</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using_firelens.html#firelens-taskdef">Creating
        /// a task definition that uses a FireLens configuration</a> in the <i>Amazon Elastic
        /// Container Service Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Tasks hosted on Fargate only support the <c>file</c> configuration file type.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null && (this._options.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The log router to use. The valid values are <c>fluentd</c> or <c>fluentbit</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FirelensConfigurationType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}