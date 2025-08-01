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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
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
namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePersistentAppUI operation.
    /// Creates a persistent application user interface.
    /// </summary>
    public partial class CreatePersistentAppUIRequest : AmazonElasticMapReduceRequest
    {
        private EMRContainersConfig _emrContainersConfig;
        private ProfilerType _profilerType;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _targetResourceArn;
        private string _xReferer;

        /// <summary>
        /// Gets and sets the property EMRContainersConfig. 
        /// <para>
        /// The EMR containers configuration.
        /// </para>
        /// </summary>
        public EMRContainersConfig EMRContainersConfig
        {
            get { return this._emrContainersConfig; }
            set { this._emrContainersConfig = value; }
        }

        // Check to see if EMRContainersConfig property is set
        internal bool IsSetEMRContainersConfig()
        {
            return this._emrContainersConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ProfilerType. 
        /// <para>
        /// The profiler type for the persistent application user interface.
        /// </para>
        /// </summary>
        public ProfilerType ProfilerType
        {
            get { return this._profilerType; }
            set { this._profilerType = value; }
        }

        // Check to see if ProfilerType property is set
        internal bool IsSetProfilerType()
        {
            return this._profilerType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags for the persistent application user interface.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetResourceArn. 
        /// <para>
        /// The unique Amazon Resource Name (ARN) of the target resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string TargetResourceArn
        {
            get { return this._targetResourceArn; }
            set { this._targetResourceArn = value; }
        }

        // Check to see if TargetResourceArn property is set
        internal bool IsSetTargetResourceArn()
        {
            return this._targetResourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property XReferer. 
        /// <para>
        /// The cross reference for the persistent application user interface.
        /// </para>
        /// </summary>
        public string XReferer
        {
            get { return this._xReferer; }
            set { this._xReferer = value; }
        }

        // Check to see if XReferer property is set
        internal bool IsSetXReferer()
        {
            return this._xReferer != null;
        }

    }
}