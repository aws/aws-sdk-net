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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The instance requirement details for a flexible instance group, including the current
    /// and desired instance types.
    /// </summary>
    public partial class ClusterInstanceRequirementDetails
    {
        private List<string> _currentInstanceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _desiredInstanceTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CurrentInstanceTypes. 
        /// <para>
        /// The instance types currently in use by the instance group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<string> CurrentInstanceTypes
        {
            get { return this._currentInstanceTypes; }
            set { this._currentInstanceTypes = value; }
        }

        // Check to see if CurrentInstanceTypes property is set
        internal bool IsSetCurrentInstanceTypes()
        {
            return this._currentInstanceTypes != null && (this._currentInstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DesiredInstanceTypes. 
        /// <para>
        /// The desired instance types for the instance group, as specified in the most recent
        /// update request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<string> DesiredInstanceTypes
        {
            get { return this._desiredInstanceTypes; }
            set { this._desiredInstanceTypes = value; }
        }

        // Check to see if DesiredInstanceTypes property is set
        internal bool IsSetDesiredInstanceTypes()
        {
            return this._desiredInstanceTypes != null && (this._desiredInstanceTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}