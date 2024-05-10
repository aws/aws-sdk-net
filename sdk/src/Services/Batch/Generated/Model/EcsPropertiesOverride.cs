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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
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
namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that contains overrides for the Amazon ECS task definition of a job.
    /// </summary>
    public partial class EcsPropertiesOverride
    {
        private List<TaskPropertiesOverride> _taskProperties = AWSConfigs.InitializeCollections ? new List<TaskPropertiesOverride>() : null;

        /// <summary>
        /// Gets and sets the property TaskProperties. 
        /// <para>
        /// The overrides for the Amazon ECS task definition of a job.
        /// </para>
        ///  <note> 
        /// <para>
        /// This object is currently limited to one element.
        /// </para>
        ///  </note>
        /// </summary>
        public List<TaskPropertiesOverride> TaskProperties
        {
            get { return this._taskProperties; }
            set { this._taskProperties = value; }
        }

        // Check to see if TaskProperties property is set
        internal bool IsSetTaskProperties()
        {
            return this._taskProperties != null && (this._taskProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}