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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
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
namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateResourceTypes operation.
    /// Adds all resource types specified in the <c>ResourceTypes</c> list to the <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_RecordingGroup.html">RecordingGroup</a>
    /// of specified configuration recorder and includes those resource types when recording.
    /// 
    ///  
    /// <para>
    /// For this operation, the specified configuration recorder must use a <a href="https://docs.aws.amazon.com/config/latest/APIReference/API_RecordingStrategy.html">RecordingStrategy</a>
    /// that is either <c>INCLUSION_BY_RESOURCE_TYPES</c> or <c>EXCLUSION_BY_RESOURCE_TYPES</c>.
    /// </para>
    /// </summary>
    public partial class AssociateResourceTypesRequest : AmazonConfigServiceRequest
    {
        private string _configurationRecorderArn;
        private List<string> _resourceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ConfigurationRecorderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the specified configuration recorder.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public string ConfigurationRecorderArn
        {
            get { return this._configurationRecorderArn; }
            set { this._configurationRecorderArn = value; }
        }

        // Check to see if ConfigurationRecorderArn property is set
        internal bool IsSetConfigurationRecorderArn()
        {
            return this._configurationRecorderArn != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceTypes. 
        /// <para>
        /// The list of resource types you want to add to the recording group of the specified
        /// configuration recorder.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ResourceTypes
        {
            get { return this._resourceTypes; }
            set { this._resourceTypes = value; }
        }

        // Check to see if ResourceTypes property is set
        internal bool IsSetResourceTypes()
        {
            return this._resourceTypes != null && (this._resourceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}